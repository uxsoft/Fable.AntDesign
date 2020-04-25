namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.Core.JsInterop
open Fable.React.Props

[<StringEnum; RequireQualifiedAccess>]
type Size = Large | Default | Small

[<StringEnum; RequireQualifiedAccess>]
type Theme = Dark | Light

type AntElement(partialImport: obj -> ReactElement seq -> ReactElement) =
    let mutable props = []

    member x.Props = createObj props
    member internal x.Attribute name value = props <- props @ [name ==> value]
    
    member x.Item
        with get(children: ReactElement list) = partialImport x.Props children
    
    member x.With (children: ReactElement list) =
        partialImport x.Props children
        
    member x.Empty =
        partialImport x.Props []
        
    // Common Attributes
    member x.Custom with set (v: string * obj) = match v with (name, value) -> x.Attribute name value
    member x.Style with set (css: CSSProp list) = x.Attribute "style" (keyValueList CaseRules.LowerFirst css)
    member x.Id with set (v: string) = x.Attribute "id" v
    member x.Key with set (v: string) = x.Attribute "key" v