module Fable.AntDesign.Common

open Fable.Core
open Fable.React
open Fable.React.Props
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
    
    member x.attr (name: string) (value) =
        { x with Attributes = x.Attributes @ [ name, value ] }
        
    member x.get<'t> (name: string) =
        x.Attributes
        |> List.tryFind (fun (k, _) -> k = name)
        |> Option.map (fun (_, v) -> v :?> 't)
        
    member x.getOrDefault<'t> (name: string) (fallback: 't) =
        x.get<'t> name |> Option.defaultValue fallback

type DSLAttribute =
    { Name: string; Value: obj }

type ReactBuilder() =
    member _.Zero() = { Attributes = []; Children = [] }
    member _.Delay(f) = f ()

    member x.Yield() = x.Zero()

    member _.Yield(attr: DSLAttribute) =
        Browser.Dom.console.log attr
        { Attributes = [attr.Name, attr.Value]; Children = [ ] }
    
    member _.Yield(child: ReactElement) =
        { Attributes = []; Children = [ child ] }
        
    member _.Yield(children: ReactElement list) =
        { Attributes = []; Children = children }

    member x.Yield(_) = x.Zero()

    member _.Combine(a: DSLElement, b: DSLElement) =
        { Attributes = a.Attributes @ b.Attributes
          Children = a.Children @ b.Children }

    member x.For(s: DSLElement, f) =
        x.Combine(s, f ())
        
    member x.For(list: 'a seq, f: 'a -> DSLElement) =
        let elements = Seq.map f list
        { Attributes = elements |> Seq.map (fun i -> i.Attributes) |> List.concat
          Children =  elements |> Seq.map (fun i -> i.Children) |> List.concat }

    
    
    // Common Attributes
    [<CustomOperation("attr")>]
    member _.attr(s: DSLElement, n: string, v) = s.attr n v

    [<CustomOperation("style")>]
    member _.style(s: DSLElement, css: CSSProp list) =
        s.attr "style" (keyValueList CaseRules.LowerFirst css)

    [<CustomOperation("id")>]
    member _.id(s: DSLElement, v: string) = s.attr "id" v

    [<CustomOperation("key")>]
    member _.key(s: DSLElement, v: string) = s.attr "key" v

    [<CustomOperation("className")>]
    member _.className(s: DSLElement, v: string) = s.attr "className" v
