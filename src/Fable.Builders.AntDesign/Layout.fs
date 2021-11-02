namespace Fable.Builders.AntDesign

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Builders.Common
open Feliz

[<AutoOpen>]
module Layout =

    type LayoutBuilder() =
        inherit ReactBuilder(import "Layout" "antd")
    
        [<CustomOperation("hasSider")>] member inline _.hasSider(s: DSLElement, v: bool) = s.attr "hasSider" v
    
    type HeaderBuilder() =
        inherit ReactBuilder(import "Layout.Header" "antd")
        
    
    type ContentBuilder() =
        inherit ReactBuilder(import "Layout.Content" "antd")
    
    type FooterBuilder() =
        inherit ReactBuilder(import "Layout.Footer" "antd")
    
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
        inherit ReactBuilder(import "Layout.Sider" "antd")
        
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
        [<CustomOperation("zeroWidthTriggerStyle")>] member inline _.zeroWidthTriggerStyle(x: DSLElement, css: IStyleAttribute list) = x.attr "zeroWidthTriggerStyle" (keyValueList CaseRules.LowerFirst css)