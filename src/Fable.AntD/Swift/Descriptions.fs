namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type DescriptionsLayout = Horizontal | Vertical

type AntDescriptions() =
    inherit AntElement<AntDescriptions>(ofImport "Descriptions" "antd")
    member x.bordered (?v: bool) = x.attribute "bordered" (Option.defaultValue true v) 
    member x.colon (v: bool) = x.attribute "colon" v 
    member x.column (v: int) = x.attribute "column" v 
    member x.extra (v: ReactElement) = x.attribute "extra" v
    member x.layout (v: DescriptionsLayout) = x.attribute "layout" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.title (v: ReactElement) = x.attribute "title" v 
    
type AntDescriptionsItem() =
    inherit AntElement<AntDescriptionsItem>(ofImport "Descriptions.Item" "antd")
    member x.contentStyle (css: CSSProp list) = x.attribute "contentStyle" (keyValueList CaseRules.LowerFirst css)
    member x.label (v: ReactElement) = x.attribute "label" v 
    member x.labelStyle (css: CSSProp list) = x.attribute "labelStyle" (keyValueList CaseRules.LowerFirst css)
    member x.span (v: int) = x.attribute "span" v 
