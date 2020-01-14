namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module ConfigProvider =
    
    type AntConfigProviderCsp = { nonce: string }
    type AntConfigProviderPageHeader = { ghost: bool }
    [<StringEnum; RequireQualifiedAccess>] type AntConfigProviderDirection = Rtl | Ltr
    
    [<RequireQualifiedAccess>]
    type AntConfigProvider  =
        | AutoInsertSpaceInButton of bool
        | ComponentSize of Common.Size
        | Csp of AntConfigProviderCsp
        | RenderEmpty of (string -> ReactElement)
        | GetPopupContainer of (ReactElement -> HTMLElement)
        | Locale of obj
        | PrefixCls of string
        | PageHeader of AntConfigProviderPageHeader
        | Direction of AntConfigProviderDirection
        static member Custom (key: string, value: obj): AntConfigProvider = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntConfigProvider = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member Form (props: AntForm list): AntConfigProvider = unbox ("form", keyValueList CaseRules.LowerFirst props)
        
    let inline antConfigProvider (props: AntConfigProvider list) (children: ReactElement list): ReactElement =
       ofImport "ConfigProvider" "antd" (keyValueList CaseRules.LowerFirst props) children
    