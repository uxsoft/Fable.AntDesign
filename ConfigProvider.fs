namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

type ConfigProviderCsp = { nonce: string }
type ConfigProviderPageHeader = { ghost: bool }
[<StringEnum; RequireQualifiedAccess>] type ConfigProviderDirection = Rtl | Ltr

type AntConfigProvider() =
    inherit AntElement(ofImport "ConfigProvider" "antd")
    member x.AutoInsertSpaceInButton with set (v: bool) = x.Attribute "autoInsertSpaceInButton" v 
    member x.ComponentSize with set (v: Size) = x.Attribute "componentSize" v 
    member x.Csp with set (v: ConfigProviderCsp) = x.Attribute "csp" v 
    member x.RenderEmpty with set (v: (string -> ReactElement)) = x.Attribute "renderEmpty" v 
    member x.GetPopupContainer with set (v: (ReactElement -> HTMLElement)) = x.Attribute "getPopupContainer" v 
    member x.Locale with set (v: obj) = x.Attribute "locale" v 
    member x.PrefixCls with set (v: string) = x.Attribute "prefixCls" v 
    member x.PageHeader with set (v: ConfigProviderPageHeader) = x.Attribute "pageHeader" v 
    member x.Direction with set (v: ConfigProviderDirection) = x.Attribute "direction" v 
    member x.Form with set (form: AntForm) = x.Attribute "form" form.Props