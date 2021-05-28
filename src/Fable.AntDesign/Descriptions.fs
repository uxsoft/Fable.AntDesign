module Fable.AntDesign.Descriptions

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type DescriptionsLayout = Horizontal | Vertical

type DescriptionsBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Descriptions" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
    [<CustomOperation("colon")>] member inline _.colon (x: DSLElement, v: bool) = x.attr "colon" v
    [<CustomOperation("column")>] member inline _.column (x: DSLElement, v: int) = x.attr "column" v 
    [<CustomOperation("extra")>] member inline _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
    [<CustomOperation("layout")>] member inline _.layout (x: DSLElement, v: DescriptionsLayout) = x.attr "layout" v 
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    
type DescriptionBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Descriptions.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("contentStyle")>] member inline _.contentStyle (x: DSLElement, css: CSSProp list) = x.attr "contentStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("label")>] member inline _.label (x: DSLElement, v: ReactElement) = x.attr "label" v 
    [<CustomOperation("labelStyle")>] member inline _.labelStyle (x: DSLElement, css: CSSProp list) = x.attr "labelStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("span")>] member inline _.span (x: DSLElement, v: int) = x.attr "span" v 
