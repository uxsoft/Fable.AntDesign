namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Layout =

    [<RequireQualifiedAccess>]
    type AntLayout =
        | ClassName of string
        | HasSider of bool
        static member Custom (key: string, value: obj): AntLayout = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntLayout = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntHeader =
        static member Custom (key: string, value: obj): AntHeader = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntHeader = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntContent =
        static member Custom (key: string, value: obj): AntContent = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntContent = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    [<RequireQualifiedAccess>]
    type AntFooter =
        static member Custom (key: string, value: obj): AntFooter = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntFooter = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type SiderBreakpoint =
        | [<CompiledName("xs")>] XS
        | [<CompiledName("sm")>] SM
        | [<CompiledName("md")>] MD
        | [<CompiledName("lg")>] LG
        | [<CompiledName("xl")>] XL
        | [<CompiledName("xxl")>] XXL

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type CollapseType = 
        | [<CompiledName("clickTrigger")>] ClickTrigger
        | [<CompiledName("responsive")>] Responsive
        
    [<RequireQualifiedAccess>]
    type AntSider =
        | Breakpoint of SiderBreakpoint
        | ClassName of string
        | Collapsed of bool
        | CollapsedWidth of int
        | Collapsible of bool
        | DefaultCollapsed of bool
        | ReverseArrow of bool
        | Theme of Theme
        | Trigger of ReactElement
        | Width of string
        | OnCollapse of (bool -> CollapseType -> unit)
        | OnBreakpoint of (bool -> unit)
        static member Custom (key: string, value: obj): AntSider = unbox (key, value)
        static member ZeroWidthTriggerStyle (css: Props.CSSProp list): AntSider = unbox ("zeroWidthTriggerStyle", keyValueList CaseRules.LowerFirst css)
        static member Style (css: Props.CSSProp list): AntSider = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antLayout (props: AntLayout list) (children: ReactElement list): ReactElement =
       ofImport "Layout" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antHeader (props: AntHeader list) (children: ReactElement list): ReactElement =
       ofImport "Layout.Header" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antContent (props: AntContent list) (children: ReactElement list): ReactElement =
       ofImport "Layout.Content" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antFooter  (props: AntFooter list) (children: ReactElement list): ReactElement =
       ofImport "Layout.Footer" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antSider (props: AntSider list) (children: ReactElement list): ReactElement =
       ofImport "Layout.Sider" "antd" (keyValueList CaseRules.LowerFirst props) children