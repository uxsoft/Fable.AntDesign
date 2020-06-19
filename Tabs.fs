namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

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
    inherit AntElement(ofImport "Tabs" "antd")
    member x.ActiveKey
        (v: string) = x.attribute "activeKey" v
    member x.Animated
        (v: bool) = x.attribute "animated" v

    member x.RenderTabBar
        (v: obj -> obj -> ReactElement) =
            let uncurried = System.Func<obj, obj, ReactElement> v
            x.attribute "renderTabBar" uncurried

    member x.DefaultActiveKey
        (v: string) = x.attribute "defaultActiveKey" v
    member x.HideAdd
        (v: bool) = x.attribute "hideAdd" v
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.TabBarExtraContent
        (v: ReactElement) = x.attribute "tabBarExtraContent" v
    member x.TabBarGutter
        (v: float) = x.attribute "tabBarGutter" v
    member x.TabPosition
        (v: TabsPosition) = x.attribute "tabPosition" v
    member x.Type
        (v: TabsType) = x.attribute "type" v
    member x.OnChange
        (v: string -> unit) = x.attribute "onChange" v

    member x.OnEdit
        (v: string -> string -> unit) =
            let uncurried = System.Func<string, string, unit> v
            x.attribute "onEdit" uncurried

    member x.OnNextClick
        (v: unit -> unit) = x.attribute "onNextClick" v
    member x.OnPrevClick
        (v: unit -> unit) = x.attribute "onPrevClick" v

    member x.OnTabClick
        (v: string -> Event -> unit) =
            let uncurried = System.Func<string, Event, unit> v
            x.attribute "onTabClick" uncurried

    member x.TabBarStyle(css: Props.CSSProp list) =
        x.attribute "tabBarStyle" (keyValueList CaseRules.LowerFirst css)

type AntTabsPane() =
    inherit AntElement(ofImport "Tabs.TabPane" "antd")
    member x.ForceRender
        (v: bool) = x.attribute "forceRender" v
    member x.Key
        (v: string) = x.attribute "key" v
    member x.Tab
        (v: ReactElement) = x.attribute "tab" v
