module Fable.AntDesign.Tabs

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types
open System

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
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Tabs" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("activeKey")>] member _.activeKey (x: DSLElement, v: string) = x.attr "activeKey" v
    [<CustomOperation("animated")>] member _.animated (x: DSLElement, v: bool) = x.attr "animated" v
    [<CustomOperation("renderTabBar")>] member _.renderTabBar (x: DSLElement, v: Func<obj, obj, ReactElement>) = x.attr "renderTabBar" v
    [<CustomOperation("defaultActiveKey")>] member _.defaultActiveKey (x: DSLElement, v: string) = x.attr "defaultActiveKey" v
    [<CustomOperation("hideAdd")>] member _.hideAdd (x: DSLElement, v: bool) = x.attr "hideAdd" v
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("tabBarExtraContent")>] member _.tabBarExtraContent (x: DSLElement, v: ReactElement) = x.attr "tabBarExtraContent" v
    [<CustomOperation("tabBarGutter")>] member _.tabBarGutter (x: DSLElement, v: float) = x.attr "tabBarGutter" v
    [<CustomOperation("tabBarStyle")>] member _.tabBarStyle(x: DSLElement, v: Props.CSSProp list) = x.attr "tabBarStyle" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("tabPosition")>] member _.tabPosition (x: DSLElement, v: TabsPosition) = x.attr "tabPosition" v
    [<CustomOperation("tabsType")>] member _.tabsType (x: DSLElement, v: TabsType) = x.attr "type" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
    [<CustomOperation("onEdit")>] member _.onEdit (x: DSLElement, v: Func<string, string, unit>) = x.attr "onEdit" v
    [<CustomOperation("onNextClick")>] member _.onNextClick (x: DSLElement, v: unit -> unit) = x.attr "onNextClick" v
    [<CustomOperation("onPrevClick")>] member _.onPrevClick (x: DSLElement, v: unit -> unit) = x.attr "onPrevClick" v
    [<CustomOperation("onTabClick")>] member _.onTabClick (x: DSLElement, v: Func<string, Event, unit>) = x.attr "onTabClick" v
    [<CustomOperation("keyboard")>] member _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v

type TabPaneBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Tabs.TabPane" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("forceRender")>] member _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v
    [<CustomOperation("tab")>] member _.tab (x: DSLElement, v: ReactElement) = x.attr "tab" v
    [<CustomOperation("closeIcon")>] member _.closeIcon (x: DSLElement, v: ReactElement) = x.attr "closeIcon" v
