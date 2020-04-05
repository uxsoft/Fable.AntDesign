namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type Layout() =
    inherit AntElement(ofImport "Layout" "antd")
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.HasSider with set (v: bool) = x.Attribute "hasSider" v 

type Header() =
    inherit AntElement(ofImport "Layout.Header" "antd")
    
type Content() =
    inherit AntElement(ofImport "Layout.Content" "antd")

type Footer() =
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
    
type Sider() =
    inherit AntElement(ofImport "Layout.Sider" "antd")
    member x.Breakpoint with set (v: SiderBreakpoint) = x.Attribute "breakpoint" v 
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.Collapsed with set (v: bool) = x.Attribute "collapsed" v 
    member x.CollapsedWidth with set (v: int) = x.Attribute "collapsedWidth" v 
    member x.Collapsible with set (v: bool) = x.Attribute "collapsible" v 
    member x.DefaultCollapsed with set (v: bool) = x.Attribute "defaultCollapsed" v 
    member x.ReverseArrow with set (v: bool) = x.Attribute "reverseArrow" v 
    member x.Theme with set (v: Theme) = x.Attribute "theme" v 
    member x.Trigger with set (v: ReactElement) = x.Attribute "trigger" v 
    member x.Width with set (v: string) = x.Attribute "width" v 
    member x.OnCollapse with set (v: (bool -> CollapseType -> unit)) = x.Attribute "onCollapse" v 
    member x.OnBreakpoint with set (v: (bool -> unit)) = x.Attribute "onBreakpoint" v 
    member x.ZeroWidthTriggerStyle (css: Props.CSSProp list) = x.Attribute "zeroWidthTriggerStyle" (keyValueList CaseRules.LowerFirst css)