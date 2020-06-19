namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

type ConfigProviderCsp = { nonce: string }
type ConfigProviderPageHeader = { ghost: bool }
[<StringEnum; RequireQualifiedAccess>] type ConfigProviderDirection = Rtl | Ltr

type AntConfigProvider() =
    inherit AntElement(ofImport "ConfigProvider" "antd")
    member x.AutoInsertSpaceInButton (v: bool) = x.attribute "autoInsertSpaceInButton" v 
    member x.ComponentSize (v: Size) = x.attribute "componentSize" v 
    member x.Csp (v: ConfigProviderCsp) = x.attribute "csp" v 
    member x.RenderEmpty (v: (string -> ReactElement)) = x.attribute "renderEmpty" v 
    member x.GetPopupContainer (v: (ReactElement -> HTMLElement)) = x.attribute "getPopupContainer" v 
    member x.Locale (v: obj) = x.attribute "locale" v 
    member x.PrefixCls (v: string) = x.attribute "prefixCls" v 
    member x.PageHeader (v: ConfigProviderPageHeader) = x.attribute "pageHeader" v 
    member x.Direction (v: ConfigProviderDirection) = x.attribute "direction" v 
    member x.Form (form: AntForm) = x.attribute "form" form.Props