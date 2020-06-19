namespace Fable.AntD

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

type AntTabs() =
    inherit AntElement<AntTabs>(ofImport "Tabs" "antd")
    member x.activeKey (v: string) = x.attribute "activeKey" v
    member x.animated (v: bool) = x.attribute "animated" v
    member x.renderTabBar (v: Func<obj, obj, ReactElement>) = x.attribute "renderTabBar" v
    member x.defaultActiveKey (v: string) = x.attribute "defaultActiveKey" v
    member x.hideAdd (v: bool) = x.attribute "hideAdd" v
    member x.size (v: Size) = x.attribute "size" v
    member x.tabBarExtraContent (v: ReactElement) = x.attribute "tabBarExtraContent" v
    member x.tabBarGutter (v: float) = x.attribute "tabBarGutter" v
    member x.tabPosition (v: TabsPosition) = x.attribute "tabPosition" v
    member x.tabsType (v: TabsType) = x.attribute "type" v
    member x.onChange (v: string -> unit) = x.attribute "onChange" v
    member x.onEdit (v: Func<string, string, unit>) = x.attribute "onEdit" v
    member x.onNextClick (v: unit -> unit) = x.attribute "onNextClick" v
    member x.onPrevClick (v: unit -> unit) = x.attribute "onPrevClick" v
    member x.onTabClick (v: Func<string, Event, unit>) = x.attribute "onTabClick" v
    member x.tabBarStyle(css: Props.CSSProp list) = x.attribute "tabBarStyle" (keyValueList CaseRules.LowerFirst css)

type AntTabsPane() =
    inherit AntElement<AntTabsPane>(ofImport "Tabs.TabPane" "antd")
    member x.forceRender (v: bool) = x.attribute "forceRender" v
    member x.tab (v: ReactElement) = x.attribute "tab" v
