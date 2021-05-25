module Fable.AntDesign.ConfigProvider

open System.Drawing
open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>] type ConfigProviderDirection = Rtl | Ltr

type ConfigProviderBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "ConfigProvider" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autoInsertSpaceInButton")>] member _.autoInsertSpaceInButton (x: DSLElement) = x.attr "autoInsertSpaceInButton" true 
    [<CustomOperation("componentSize")>] member _.componentSize (x: DSLElement, v: Size) = x.attr "componentSize" v 
    [<CustomOperation("csp")>] member _.csp (x: DSLElement, v: {| nonce: string |}) = x.attr "csp" v
    [<CustomOperation("form")>] member _.form (x: DSLElement, v: obj) = x.attr "form" v //TODO discriminated union
    [<CustomOperation("input")>] member _.input (x: DSLElement, v: obj) = x.attr "input" v //TODO discriminated union
    [<CustomOperation("renderEmpty")>] member _.renderEmpty (x: DSLElement, v: string -> ReactElement) = x.attr "renderEmpty" v 
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: ReactElement -> HTMLElement) = x.attr "getPopupContainer" v 
    [<CustomOperation("getTargetContainer")>] member _.getTargetContainer (x: DSLElement, v: Func<unit, HTMLElement>) = x.attr "getTargetContainer" v
    [<CustomOperation("locale")>] member _.locale (x: DSLElement, v: obj) = x.attr "locale" v 
    [<CustomOperation("prefixCls")>] member _.prefixCls (x: DSLElement, v: string) = x.attr "prefixCls" v 
    [<CustomOperation("pageHeader")>] member _.pageHeader (x: DSLElement, v: {| ghost: bool |}) = x.attr "pageHeader" v 
    [<CustomOperation("direction")>] member _.direction (x: DSLElement, v: ConfigProviderDirection) = x.attr "direction" v 
    [<CustomOperation("space")>] member _.space (x: DSLElement, v: Size) = x.attr "space" v
    [<CustomOperation("virtualize")>] member _.virtualize (x: DSLElement) = x.attr "virtual" true
    [<CustomOperation("dropdownMatchSelectWidth")>] member _.dropdownMatchSelectWidth (x: DSLElement, v: int) = x.attr "dropdownMatchSelectWidth" v