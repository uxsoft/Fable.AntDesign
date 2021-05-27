module Fable.AntDesign.Collapse

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type CollapseCollapsible = Header | Disabled

[<StringEnum; RequireQualifiedAccess>]
type CollapseExpandIconPosition = Left | Right

type CollapseBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Collapse" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("accordion")>] member _.accordion (x: DSLElement, v: bool) = x.attr "accordion" v 
    [<CustomOperation("activeKey")>] member _.activeKey (x: DSLElement, v: string array) = x.attr "activeKey" v 
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
    [<CustomOperation("collapsible")>] member _.collapsible (x: DSLElement, v: CollapseCollapsible) = x.attr "collapsible" v
    [<CustomOperation("defaultActiveKey")>] member _.defaultActiveKey (x: DSLElement, v: string array) = x.attr "defaultActiveKey" v 
    [<CustomOperation("destroyInactivePanel")>] member _.destroyInactivePanel (x: DSLElement, v: bool) = x.attr "destroyInactivePanel" v
    [<CustomOperation("expandIcon")>] member _.expandIcon (x: DSLElement, v: obj -> ReactElement) = x.attr "expandIcon" v 
    [<CustomOperation("expandIconPosition")>] member _.expandIconPosition (x: DSLElement, v: CollapseExpandIconPosition) = x.attr "expandIconPosition" v 
    [<CustomOperation("ghost")>] member _.ghost (x: DSLElement, v: bool) = x.attr "ghost" v        
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: unit -> unit) = x.attr "onChange" v
    

type CollapsePanelBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Collapse.Panel" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("collapsible")>] member _.collapsible (x: DSLElement, v: CollapseCollapsible) = x.attr "collapsible" v
    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
    [<CustomOperation("forceRender")>] member _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v 
    [<CustomOperation("header")>] member _.header (x: DSLElement, v: ReactElement) = x.attr "header" v
    [<CustomOperation("showArrow")>] member _.showArrow (x: DSLElement, v: bool) = x.attr "showArrow" v
