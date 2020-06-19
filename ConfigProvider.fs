namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

type ConfigProviderCsp = { nonce: string }
type ConfigProviderPageHeader = { ghost: bool }
[<StringEnum; RequireQualifiedAccess>] type ConfigProviderDirection = Rtl | Ltr

type AntConfigProvider() =
    inherit AntElement<AntConfigProvider>(ofImport "ConfigProvider" "antd")
    member x.autoInsertSpaceInButton (v: bool) = x.attribute "autoInsertSpaceInButton" v 
    member x.componentSize (v: Size) = x.attribute "componentSize" v 
    member x.csp (v: ConfigProviderCsp) = x.attribute "csp" v 
    member x.renderEmpty (v: (string -> ReactElement)) = x.attribute "renderEmpty" v 
    member x.getPopupContainer (v: (ReactElement -> HTMLElement)) = x.attribute "getPopupContainer" v 
    member x.locale (v: obj) = x.attribute "locale" v 
    member x.prefixCls (v: string) = x.attribute "prefixCls" v 
    member x.pageHeader (v: ConfigProviderPageHeader) = x.attribute "pageHeader" v 
    member x.direction (v: ConfigProviderDirection) = x.attribute "direction" v 
    member x.form (form: AntForm) = x.attribute "form" form.JSON