module Fable.AntD.Builders.Layout

open System
open Fable.Core
open Fable.React
open Fable.Core.JsInterop
open Fable.AntD.Builders.Common

type LayoutBuilder() =
    inherit ReactBuilder()

    member _.Run(s: DSLElement) =
        ofImport "Layout" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("hasSider")>] member _.hasSider(s: DSLElement, v: bool) = s.attr "hasSider" v

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
    
    [<CustomOperation("breakpoint")>] member _.breakpoint(x: DSLElement, v: SiderBreakpoint) = x.attr "breakpoint" v
    [<CustomOperation("collapsed")>] member _.collapsed (x: DSLElement) = x.attr "collapsed" true
    [<CustomOperation("collapsedWidth")>] member _.collapsedWidth (x: DSLElement, v: int) = x.attr "collapsedWidth" v
    [<CustomOperation("collapsible")>] member _.collapsible (x: DSLElement) = x.attr "collapsible" true
    [<CustomOperation("defaultCollapsed")>] member _.defaultCollapsed (x: DSLElement) = x.attr "defaultCollapsed" true
    [<CustomOperation("reverseArrow")>] member _.reverseArrow (x: DSLElement) = x.attr "reverseArrow" true
    [<CustomOperation("theme")>] member _.theme (x: DSLElement, v: Theme) = x.attr "theme" v
    [<CustomOperation("trigger")>] member _.trigger (x: DSLElement, v: ReactElement) = x.attr "trigger" v
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v
    [<CustomOperation("onCollapse")>] member _.onCollapse (x: DSLElement, v: Func<bool, CollapseType, unit>) = x.attr "onCollapse" v
    [<CustomOperation("onBreakpoint")>] member _.onBreakpoint (x: DSLElement, v: bool -> unit) = x.attr "onBreakpoint" v
    [<CustomOperation("zeroWidthTriggerStyle")>] member _.zeroWidthTriggerStyle(x: DSLElement, css: Props.CSSProp list) = x.attr "zeroWidthTriggerStyle" (keyValueList CaseRules.LowerFirst css)