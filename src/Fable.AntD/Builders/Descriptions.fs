module Fable.AntD.Builders.Descriptions

open Fable.AntD.Builders.Common
open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type DescriptionsLayout = Horizontal | Vertical

type DescriptionsBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Descriptions" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true 
    [<CustomOperation("colon")>] member _.colon (x: DSLElement) = x.attr "colon" true
    [<CustomOperation("column")>] member _.column (x: DSLElement, v: int) = x.attr "column" v 
    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
    [<CustomOperation("layout")>] member _.layout (x: DSLElement, v: DescriptionsLayout) = x.attr "layout" v 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    
type DescriptionBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Descriptions.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("contentStyle")>] member _.contentStyle (x: DSLElement, css: CSSProp list) = x.attr "contentStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("label")>] member _.label (x: DSLElement, v: ReactElement) = x.attr "label" v 
    [<CustomOperation("labelStyle")>] member _.labelStyle (x: DSLElement, css: CSSProp list) = x.attr "labelStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("span")>] member _.span (x: DSLElement, v: int) = x.attr "span" v 
