namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System

type AntLayout() =
    inherit AntElement<AntLayout>(ofImport "Layout" "antd")
    member x.className (v: string) = x.attribute "className" v
    member x.hasSider (v: bool) = x.attribute "hasSider" v

type AntHeader() =
    inherit AntElement<AntHeader>(ofImport "Layout.Header" "antd")

type AntContent() =
    inherit AntElement<AntContent>(ofImport "Layout.Content" "antd")

type AntFooter() =
    inherit AntElement<AntFooter>(ofImport "Layout.Footer" "antd")

[<StringEnum; RequireQualifiedAccess>]
type SiderBreakpoint =
    | [<CompiledName("xs")>] XS
    | [<CompiledName("sm")>] SM
    | [<CompiledName("md")>] MD
    | [<CompiledName("lg")>] LG
    | [<CompiledName("xl")>] XL
    | [<CompiledName("xxl")>] XXL

[<StringEnum; RequireQualifiedAccess>]
type CollapseType =
    | [<CompiledName("clickTrigger")>] ClickTrigger
    | [<CompiledName("responsive")>] Responsive

type AntSider() =
    inherit AntElement<AntSider>(ofImport "Layout.Sider" "antd")
    member x.breakpoint (v: SiderBreakpoint) = x.attribute "breakpoint" v
    member x.className (v: string) = x.attribute "className" v
    member x.collapsed (?v: bool) = x.attribute "collapsed" (Option.defaultValue true v)
    member x.collapsedWidth (v: int) = x.attribute "collapsedWidth" v
    member x.collapsible (?v: bool) = x.attribute "collapsible" (Option.defaultValue true v)
    member x.defaultCollapsed (?v: bool) = x.attribute "defaultCollapsed" (Option.defaultValue true v)
    member x.reverseArrow (?v: bool) = x.attribute "reverseArrow" (Option.defaultValue true v)
    member x.theme (v: Theme) = x.attribute "theme" v
    member x.trigger (v: ReactElement) = x.attribute "trigger" v
    member x.width (v: string) = x.attribute "width" v
    member x.onCollapse (v: Func<bool, CollapseType, unit>) = x.attribute "onCollapse" v
    member x.onBreakpoint (v: bool -> unit) = x.attribute "onBreakpoint" v
    member x.zeroWidthTriggerStyle(css: Props.CSSProp list) = x.attribute "zeroWidthTriggerStyle" (keyValueList CaseRules.LowerFirst css)