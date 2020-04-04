namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<AutoOpen>]
module Tabs =
    
    [<StringEnum; RequireQualifiedAccess>] type AntTabsPosition = Top | Right | Bottom | Left

    [<StringEnum; RequireQualifiedAccess>] type AntTabsType = Line | Card | [<CompiledName("editable-card")>] EditableCard

    [<RequireQualifiedAccess>]
    type AntTabs  =
        | ActiveKey of string
        | Animated of bool
        | RenderTabBar of (obj -> obj -> ReactElement)
        | DefaultActiveKey of string
        | HideAdd of bool
        | Size of Size
        | TabBarExtraContent of ReactElement
        | TabBarGutter of float
        | TabPosition of AntTabsPosition
        | Type of AntTabsType
        | OnChange of (string -> unit)
        | OnEdit of (string -> string -> unit)
        | OnNextClick of (unit -> unit)
        | OnPrevClick of (unit -> unit)
        | OnTabClick of (string -> Event -> unit)
        static member Custom (key: string, value: obj): AntTabs = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTabs = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member TabBarStyle (css: Props.CSSProp list): AntTabs = unbox ("tabBarStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntTabsPane  =
        | ForceRender of bool
        | Key of string
        | Tab of ReactElement
        static member Custom (key: string, value: obj): AntTabsPane = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTabsPane = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antTabs (props: AntTabs list) (children: ReactElement list): ReactElement =
       ofImport "Tabs" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antTabsPane (props: AntTabsPane list) (children: ReactElement list): ReactElement =
       ofImport "Tabs.TabPane" "antd" (keyValueList CaseRules.LowerFirst props) children
    