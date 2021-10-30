namespace Fable.Builders.AntDesign

open System.Drawing
open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<AutoOpen>]
module ConfigProvider =

    [<StringEnum; RequireQualifiedAccess>]
    type ConfigProviderDirection = Rtl | Ltr
    
    type ConfigProviderBuilder() =
        inherit ReactBuilder(import "ConfigProvider" "antd")
    
        [<CustomOperation("autoInsertSpaceInButton")>] member inline _.autoInsertSpaceInButton (x: DSLElement, v: bool) = x.attr "autoInsertSpaceInButton" v 
        [<CustomOperation("componentSize")>] member inline _.componentSize (x: DSLElement, v: Size) = x.attr "componentSize" v 
        [<CustomOperation("csp")>] member inline _.csp (x: DSLElement, v: {| nonce: string |}) = x.attr "csp" v
        [<CustomOperation("form")>] member inline _.form (x: DSLElement, v: obj) = x.attr "form" v //TODO discriminated union
        [<CustomOperation("input")>] member inline _.input (x: DSLElement, v: obj) = x.attr "input" v //TODO discriminated union
        [<CustomOperation("renderEmpty")>] member inline _.renderEmpty (x: DSLElement, v: string -> ReactElement) = x.attr "renderEmpty" v 
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: ReactElement -> HTMLElement) = x.attr "getPopupContainer" v 
        [<CustomOperation("getTargetContainer")>] member inline _.getTargetContainer (x: DSLElement, v: Func<unit, HTMLElement>) = x.attr "getTargetContainer" v
        [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: obj) = x.attr "locale" v 
        [<CustomOperation("prefixCls")>] member inline _.prefixCls (x: DSLElement, v: string) = x.attr "prefixCls" v 
        [<CustomOperation("pageHeader")>] member inline _.pageHeader (x: DSLElement, v: {| ghost: bool |}) = x.attr "pageHeader" v 
        [<CustomOperation("direction")>] member inline _.direction (x: DSLElement, v: ConfigProviderDirection) = x.attr "direction" v 
        [<CustomOperation("space")>] member inline _.space (x: DSLElement, v: Size) = x.attr "space" v
        [<CustomOperation("virtualize")>] member inline _.virtualize (x: DSLElement, v: bool) = x.attr "virtual" v
        [<CustomOperation("dropdownMatchSelectWidth")>] member inline _.dropdownMatchSelectWidth (x: DSLElement, v: int) = x.attr "dropdownMatchSelectWidth" v