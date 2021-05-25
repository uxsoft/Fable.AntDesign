module Fable.AntD.Builders.Collapse

open Fable.AntD.Builders.Common
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

    [<CustomOperation("accordion")>] member _.accordion (x: DSLElement) = x.attr "accordion" true 
    [<CustomOperation("activeKey")>] member _.activeKey (x: DSLElement, v: string array) = x.attr "activeKey" v 
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true 
    [<CustomOperation("collapsible")>] member _.collapsible (x: DSLElement, v: CollapseCollapsible) = x.attr "collapsible" v
    [<CustomOperation("defaultActiveKey")>] member _.defaultActiveKey (x: DSLElement, v: string array) = x.attr "defaultActiveKey" v 
    [<CustomOperation("destroyInactivePanel")>] member _.destroyInactivePanel (x: DSLElement) = x.attr "destroyInactivePanel" true
    [<CustomOperation("expandIcon")>] member _.expandIcon (x: DSLElement, v: obj -> ReactElement) = x.attr "expandIcon" v 
    [<CustomOperation("expandIconPosition")>] member _.expandIconPosition (x: DSLElement, v: CollapseExpandIconPosition) = x.attr "expandIconPosition" v 
    [<CustomOperation("ghost")>] member _.ghost (x: DSLElement) = x.attr "ghost" true        
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: unit -> unit) = x.attr "onChange" v
    

type CollapsePanelBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Collapse.Panel" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("collapsible")>] member _.collapsible (x: DSLElement, v: CollapseCollapsible) = x.attr "collapsible" v
    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
    [<CustomOperation("forceRender")>] member _.forceRender (x: DSLElement) = x.attr "forceRender" true 
    [<CustomOperation("header")>] member _.header (x: DSLElement, v: ReactElement) = x.attr "header" v
    [<CustomOperation("showArrow")>] member _.showArrow (x: DSLElement) = x.attr "showArrow" true
