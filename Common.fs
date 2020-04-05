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
    let props = System.Collections.Generic.List<string * obj>()

    member x.Props = createObj props
    member internal x.Attribute name value = props.Add((name, unbox value))
    
    member x.With (children: ReactElement list) =
        partialImport x.Props children
        
    member x.Empty =
        partialImport x.Props []
        
    // Common Attributes
    member x.Custom with set (t: string * obj) = props.Add(t)
    member x.Style with set (css: CSSProp list) = props.Add(("style", keyValueList CaseRules.LowerFirst css))
    member x.Id with set (v: string) = x.Attribute "id" v
    member x.Key with set (v: string) = x.Attribute "key" v