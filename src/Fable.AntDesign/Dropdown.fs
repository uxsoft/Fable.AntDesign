module Fable.AntDesign.Dropdown

open Browser.Types
open Fable.AntDesign.Button
open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type DropdownPlacement = BottomLeft | BottomCenter | BottomRight | TopLeft | TopCenter | TopRight

[<StringEnum; RequireQualifiedAccess>]
type DropdownTrigger = Click | Hover | ContextMenu

type DropdownBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Dropdown" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("arrow")>] member _.arrow (x: DSLElement) = x.attr "arrow" true 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true 
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: (unit -> HTMLElement)) = x.attr "getPopupContainer" v 
    [<CustomOperation("overlay")>] member _.overlay (x: DSLElement, v: ReactElement) = x.attr "overlay" v 
    [<CustomOperation("overlayClassName")>] member _.overlayClassName (x: DSLElement, v: string) = x.attr "overlayClassName" v
    [<CustomOperation("overlayStyle")>] member _.overlayStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("onVisibleChange")>] member _.onVisibleChange (x: DSLElement, v: (bool -> unit)) = x.attr "onVisibleChange" v 
    [<CustomOperation("placement")>] member _.placement (x: DSLElement, v: DropdownPlacement) = x.attr "placement" v 
    [<CustomOperation("trigger")>] member _.trigger (x: DSLElement, v: DropdownTrigger array) = x.attr "trigger" v 
    [<CustomOperation("visible")>] member _.visible (x: DSLElement) = x.attr "visible" true 
    
type DropdownButtonBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Dropdown.Button" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("buttonsRender")>] member _.buttonsRender (x: DSLElement, v: ReactElement array array -> ReactElement) = x.attr "buttonsRender" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: Event -> unit) = x.attr "onClick" v 
    [<CustomOperation("onVisibleChange")>] member _.onVisibleChange (x: DSLElement, v: (bool -> unit)) = x.attr "onVisibleChange" v 
    [<CustomOperation("overlay")>] member _.overlay (x: DSLElement, v: ReactElement) = x.attr "overlay" v 
    [<CustomOperation("placement")>] member _.placement (x: DSLElement, v: DropdownPlacement) = x.attr "placement" v 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("trigger")>] member _.trigger (x: DSLElement, v: DropdownTrigger array) = x.attr "trigger" v
    [<CustomOperation("buttonType")>] member _.buttonType (x: DSLElement, v: ButtonType) = x.attr "type" v
    [<CustomOperation("visible")>] member _.visible (x: DSLElement) = x.attr "visible" true