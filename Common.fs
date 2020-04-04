namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.Core.JsInterop
open Fable.React.Props

[<StringEnum; RequireQualifiedAccess>]
type Size = Large | Default | Small

[<StringEnum; RequireQualifiedAccess>]
type Theme = Dark | Light

type AntElement(elementName: string, ?package: string) =
    let props = System.Collections.Generic.List<string * obj>()

    member x.Props = createObj props
    
    member x.Attribute name value = props.Add((name, unbox value))
    member x.Style with set (css: CSSProp list) = props.Add(("style", keyValueList CaseRules.LowerFirst css))
    
    member x.With (children: ReactElement list) =
        ofImport elementName (defaultArg package "antd") x.Props children
        
    member x.Empty =
        ofImport elementName (defaultArg package "antd") x.Props []