namespace Fable.AntD

open System.Drawing
open Browser.Types
open Fable.Core
open Fable.React
open System

[<StringEnum; RequireQualifiedAccess>] type ConfigProviderDirection = Rtl | Ltr

type AntConfigProvider() =
    inherit AntElement<AntConfigProvider>(ofImport "ConfigProvider" "antd")
    member x.autoInsertSpaceInButton (?v: bool) = x.attribute "autoInsertSpaceInButton" (Option.defaultValue true v) 
    member x.componentSize (v: Size) = x.attribute "componentSize" v 
    member x.csp (v: {| nonce: string |}) = x.attribute "csp" v
    member x.form (v: AntForm<'T>) = x.attribute "form" v.JSON
    member x.input (v: AntInput) = x.attribute "input" v.JSON
    member x.renderEmpty (v: (string -> ReactElement)) = x.attribute "renderEmpty" v 
    member x.getPopupContainer (v: (ReactElement -> HTMLElement)) = x.attribute "getPopupContainer" v 
    member x.getTargetContainer (v: Func<unit, HTMLElement>) = x.attribute "getTargetContainer" v
    member x.locale (v: obj) = x.attribute "locale" v 
    member x.prefixCls (v: string) = x.attribute "prefixCls" v 
    member x.pageHeader (v: {| ghost: bool |}) = x.attribute "pageHeader" v 
    member x.direction (v: ConfigProviderDirection) = x.attribute "direction" v 
    member x.space (v: Size) = x.attribute "space" v
    member x.virtualize (?v: bool) = x.attribute "virtual" (Option.defaultValue true v)
    member x.dropdownMatchSelectWidth (v: int) = x.attribute "dropdownMatchSelectWidth" v