module Fable.AntDesign.Layout

open System
open Fable.Core
open Fable.React
open Fable.Core.JsInterop
open Fable.AntDesign.Common
open Fable.React.Props

type LayoutBuilder() =
    inherit ReactBuilder()

    member _.Run(s: DSLElement) =
        ofImport "Layout" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("hasSider")>] member inline _.hasSider(s: DSLElement, v: bool) = s.attr "hasSider" v

type HeaderBuilder() =
    inherit ReactBuilder()

    member _.Run(s: DSLElement) =
        ofImport "Layout.Header" "antd" (createObj s.Attributes) s.Children
    

type ContentBuilder() =
    inherit ReactBuilder()
    member _.Run(s: DSLElement) =
        ofImport "Layout.Content" "antd" (createObj s.Attributes) s.Children

type FooterBuilder() =
    inherit ReactBuilder()
    member _.Run(s: DSLElement) =
        ofImport "Layout.Footer" "antd" (createObj s.Attributes) s.Children

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

type SiderBuilder() =
    inherit ReactBuilder()
    member _.Run(s: DSLElement) =
        ofImport "Layout.Sider" "antd" (createObj s.Attributes) s.Children
    
    [<CustomOperation("breakpoint")>] member inline _.breakpoint(x: DSLElement, v: SiderBreakpoint) = x.attr "breakpoint" v
    [<CustomOperation("collapsed")>] member inline _.collapsed (x: DSLElement, v: bool) = x.attr "collapsed" v
    [<CustomOperation("collapsedWidth")>] member inline _.collapsedWidth (x: DSLElement, v: int) = x.attr "collapsedWidth" v
    [<CustomOperation("collapsible")>] member inline _.collapsible (x: DSLElement, v: bool) = x.attr "collapsible" v
    [<CustomOperation("defaultCollapsed")>] member inline _.defaultCollapsed (x: DSLElement, v: bool) = x.attr "defaultCollapsed" v
    [<CustomOperation("reverseArrow")>] member inline _.reverseArrow (x: DSLElement, v: bool) = x.attr "reverseArrow" v
    [<CustomOperation("theme")>] member inline _.theme (x: DSLElement, v: Theme) = x.attr "theme" v
    [<CustomOperation("trigger")>] member inline _.trigger (x: DSLElement, v: ReactElement) = x.attr "trigger" v
    [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: string) = x.attr "width" v
    [<CustomOperation("onCollapse")>] member inline _.onCollapse (x: DSLElement, v: Func<bool, CollapseType, unit>) = x.attr "onCollapse" v
    [<CustomOperation("onBreakpoint")>] member inline _.onBreakpoint (x: DSLElement, v: bool -> unit) = x.attr "onBreakpoint" v
    [<CustomOperation("zeroWidthTriggerStyle")>] member inline _.zeroWidthTriggerStyle(x: DSLElement, css: CSSProp list) = x.attr "zeroWidthTriggerStyle" (keyValueList CaseRules.LowerFirst css)