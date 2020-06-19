namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntLayout() =
    inherit AntElement(ofImport "Layout" "antd")
    member x.ClassName
        (v: string) = x.attribute "className" v
    member x.HasSider
        (v: bool) = x.attribute "hasSider" v

type AntHeader() =
    inherit AntElement(ofImport "Layout.Header" "antd")

type AntContent() =
    inherit AntElement(ofImport "Layout.Content" "antd")

type AntFooter() =
    inherit AntElement(ofImport "Layout.Footer" "antd")

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
    inherit AntElement(ofImport "Layout.Sider" "antd")
    member x.Breakpoint
        (v: SiderBreakpoint) = x.attribute "breakpoint" v
    member x.ClassName
        (v: string) = x.attribute "className" v
    member x.Collapsed
        (v: bool) = x.attribute "collapsed" v
    member x.CollapsedWidth
        (v: int) = x.attribute "collapsedWidth" v
    member x.Collapsible
        (v: bool) = x.attribute "collapsible" v
    member x.DefaultCollapsed
        (v: bool) = x.attribute "defaultCollapsed" v
    member x.ReverseArrow
        (v: bool) = x.attribute "reverseArrow" v
    member x.Theme
        (v: Theme) = x.attribute "theme" v
    member x.Trigger
        (v: ReactElement) = x.attribute "trigger" v
    member x.Width
        (v: string) = x.attribute "width" v

    member x.OnCollapse
        (v: bool -> CollapseType -> unit) =
            let uncurried = System.Func<bool, CollapseType, unit> v
            x.attribute "onCollapse" uncurried

    member x.OnBreakpoint
        (v: bool -> unit) = x.attribute "onBreakpoint" v
    member x.ZeroWidthTriggerStyle(css: Props.CSSProp list) =
        x.attribute "zeroWidthTriggerStyle" (keyValueList CaseRules.LowerFirst css)
