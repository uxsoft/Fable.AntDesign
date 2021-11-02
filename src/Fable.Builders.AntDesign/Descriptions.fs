namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Feliz
open Fable.Core.JsInterop

[<AutoOpen>]
module Descriptions =

    [<StringEnum; RequireQualifiedAccess>]
    type DescriptionsLayout = Horizontal | Vertical
    
    type DescriptionsBuilder() =
        inherit ReactBuilder(import "Descriptions" "antd")
    
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
        [<CustomOperation("colon")>] member inline _.colon (x: DSLElement, v: bool) = x.attr "colon" v
        [<CustomOperation("column")>] member inline _.column (x: DSLElement, v: int) = x.attr "column" v 
        [<CustomOperation("extra")>] member inline _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
        [<CustomOperation("layout")>] member inline _.layout (x: DSLElement, v: DescriptionsLayout) = x.attr "layout" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
        
    type DescriptionBuilder() =
        inherit ReactBuilder(import "Descriptions.Item" "antd")
    
        [<CustomOperation("contentStyle")>] member inline _.contentStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "contentStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("label")>] member inline _.label (x: DSLElement, v: ReactElement) = x.attr "label" v 
        [<CustomOperation("labelStyle")>] member inline _.labelStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "labelStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("span")>] member inline _.span (x: DSLElement, v: int) = x.attr "span" v 
    