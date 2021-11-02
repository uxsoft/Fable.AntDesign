namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser.Types
open System

[<AutoOpen>]
module Tabs =

    [<StringEnum; RequireQualifiedAccess>]
    type TabsPosition =
        | Top
        | Right
        | Bottom
        | Left
    
    [<StringEnum; RequireQualifiedAccess>]
    type TabsType =
        | Line
        | Card
        | [<CompiledName("editable-card")>] EditableCard
    
    type TabsBuilder() =
        inherit ReactBuilder(import "Tabs" "antd")
    
        [<CustomOperation("activeKey")>] member inline _.activeKey (x: DSLElement, v: string) = x.attr "activeKey" v
        [<CustomOperation("animated")>] member inline _.animated (x: DSLElement, v: bool) = x.attr "animated" v
        [<CustomOperation("renderTabBar")>] member inline _.renderTabBar (x: DSLElement, v: Func<obj, obj, ReactElement>) = x.attr "renderTabBar" v
        [<CustomOperation("defaultActiveKey")>] member inline _.defaultActiveKey (x: DSLElement, v: string) = x.attr "defaultActiveKey" v
        [<CustomOperation("hideAdd")>] member inline _.hideAdd (x: DSLElement, v: bool) = x.attr "hideAdd" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("tabBarExtraContent")>] member inline _.tabBarExtraContent (x: DSLElement, v: ReactElement) = x.attr "tabBarExtraContent" v
        [<CustomOperation("tabBarGutter")>] member inline _.tabBarGutter (x: DSLElement, v: float) = x.attr "tabBarGutter" v
        [<CustomOperation("tabBarStyle")>] member inline _.tabBarStyle(x: DSLElement, v: IStyleAttribute list) = x.attr "tabBarStyle" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("tabPosition")>] member inline _.tabPosition (x: DSLElement, v: TabsPosition) = x.attr "tabPosition" v
        [<CustomOperation("tabsType")>] member inline _.tabsType (x: DSLElement, v: TabsType) = x.attr "type" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
        [<CustomOperation("onEdit")>] member inline _.onEdit (x: DSLElement, v: Func<string, string, unit>) = x.attr "onEdit" v
        [<CustomOperation("onNextClick")>] member inline _.onNextClick (x: DSLElement, v: unit -> unit) = x.attr "onNextClick" v
        [<CustomOperation("onPrevClick")>] member inline _.onPrevClick (x: DSLElement, v: unit -> unit) = x.attr "onPrevClick" v
        [<CustomOperation("onTabClick")>] member inline _.onTabClick (x: DSLElement, v: Func<string, Event, unit>) = x.attr "onTabClick" v
        [<CustomOperation("keyboard")>] member inline _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v
    
    type TabPaneBuilder() =
        inherit ReactBuilder(import "Tabs.TabPane" "antd")
    
        [<CustomOperation("forceRender")>] member inline _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v
        [<CustomOperation("tab")>] member inline _.tab (x: DSLElement, v: ReactElement) = x.attr "tab" v
        [<CustomOperation("closeIcon")>] member inline _.closeIcon (x: DSLElement, v: ReactElement) = x.attr "closeIcon" v
    