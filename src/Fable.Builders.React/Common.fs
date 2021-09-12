module Fable.Builders.Common

open Fable.Core
open Feliz
open JsInterop

[<StringEnum; RequireQualifiedAccess>]
type Size =
    | Large
    | Default
    | Small

[<StringEnum; RequireQualifiedAccess>]
type Theme =
    | Dark
    | Light

type DSLElement =
    { Attributes: (string * obj) list
      Children: ReactElement list }
    
    member inline x.attr (name: string) (value) =
        { x with Attributes = x.Attributes @ [ name, value ] }
        
    member inline x.get<'t> (name: string) =
        x.Attributes
        |> List.tryFind (fun (k, _) -> k = name)
        |> Option.map (fun (_, v) -> v :?> 't)
        
    member inline x.getOrDefault<'t> (name: string) (fallback: 't) =
        x.get<'t> name |> Option.defaultValue fallback

type DSLAttribute =
    { Name: string; Value: obj }

type ReactBuilder(import: obj) =
    member inline _.Zero() = { Attributes = []; Children = [] }
    member inline _.Delay(f) = f ()

    member inline x.Yield() = x.Zero()

    member inline _.Yield(attr: DSLAttribute) =
        { Attributes = [attr.Name, attr.Value]; Children = [ ] }

    member inline _.Yield(child: string) =
        { Attributes = []; Children = [ Html.text child ] }
    
    member inline _.Yield(child: ReactElement) =
        { Attributes = []; Children = [ child ] }
        
    member inline _.Yield(children: ReactElement list) =
        { Attributes = []; Children = children }

    member inline x.Yield _ = x.Zero()

    member inline _.Combine(a: DSLElement, b: DSLElement) =
        { Attributes = a.Attributes @ b.Attributes
          Children = a.Children @ b.Children }

    member inline x.For(s: DSLElement, f) =
        x.Combine(s, f ())
        
    member inline x.For(list: 'a seq, f: 'a -> DSLElement) =
        let elements = Seq.map f list
        { Attributes = elements |> Seq.map (fun i -> i.Attributes) |> List.concat
          Children =  elements |> Seq.map (fun i -> i.Children) |> List.concat }

    
    
    // Common Attributes
    [<CustomOperation("attr")>]
    member inline _.attr(s: DSLElement, n: string, v) = s.attr n v

    [<CustomOperation("style")>]
    member inline _.style(s: DSLElement, css: IStyleAttribute list) =
        s.attr "style" (keyValueList CaseRules.LowerFirst css)

    [<CustomOperation("id")>]
    member inline _.id(s: DSLElement, v: string) = s.attr "id" v

    [<CustomOperation("key")>]
    member inline _.key(s: DSLElement, v: string) = s.attr "key" v

    [<CustomOperation("className")>]
    member inline _.className(s: DSLElement, v: string) = s.attr "className" v

    member _.Run(s: DSLElement) =
        Interop.reactApi.createElement(import, createObj s.Attributes, s.Children)