namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Collapse =

    [<StringEnum; RequireQualifiedAccess>]
    type CollapseCollapsible = Header | Disabled
    
    [<StringEnum; RequireQualifiedAccess>]
    type CollapseExpandIconPosition = Left | Right
    
    type CollapseBuilder() =
        inherit ReactBuilder(import "Collapse" "antd")
    
        [<CustomOperation("accordion")>] member inline _.accordion (x: DSLElement, v: bool) = x.attr "accordion" v 
        [<CustomOperation("activeKey")>] member inline _.activeKey (x: DSLElement, v: string array) = x.attr "activeKey" v 
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
        [<CustomOperation("collapsible")>] member inline _.collapsible (x: DSLElement, v: CollapseCollapsible) = x.attr "collapsible" v
        [<CustomOperation("defaultActiveKey")>] member inline _.defaultActiveKey (x: DSLElement, v: string array) = x.attr "defaultActiveKey" v 
        [<CustomOperation("destroyInactivePanel")>] member inline _.destroyInactivePanel (x: DSLElement, v: bool) = x.attr "destroyInactivePanel" v
        [<CustomOperation("expandIcon")>] member inline _.expandIcon (x: DSLElement, v: obj -> ReactElement) = x.attr "expandIcon" v 
        [<CustomOperation("expandIconPosition")>] member inline _.expandIconPosition (x: DSLElement, v: CollapseExpandIconPosition) = x.attr "expandIconPosition" v 
        [<CustomOperation("ghost")>] member inline _.ghost (x: DSLElement, v: bool) = x.attr "ghost" v        
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
        
    
    type CollapsePanelBuilder() =
        inherit ReactBuilder(import "Collapse.Panel" "antd")
    
        [<CustomOperation("collapsible")>] member inline _.collapsible (x: DSLElement, v: CollapseCollapsible) = x.attr "collapsible" v
        [<CustomOperation("extra")>] member inline _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
        [<CustomOperation("forceRender")>] member inline _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v 
        [<CustomOperation("header")>] member inline _.header (x: DSLElement, v: ReactElement) = x.attr "header" v
        [<CustomOperation("showArrow")>] member inline _.showArrow (x: DSLElement, v: bool) = x.attr "showArrow" v
    