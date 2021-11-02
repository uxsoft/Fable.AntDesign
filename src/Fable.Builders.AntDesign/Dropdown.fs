namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.AntDesign.Button
open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen>]
module Dropdown =

    [<StringEnum; RequireQualifiedAccess>]
    type DropdownPlacement = BottomLeft | BottomCenter | BottomRight | TopLeft | TopCenter | TopRight
    
    [<StringEnum; RequireQualifiedAccess>]
    type DropdownTrigger = Click | Hover | ContextMenu
    
    type DropdownBuilder() =
        inherit ReactBuilder(import "Dropdown" "antd")
    
        [<CustomOperation("arrow")>] member inline _.arrow (x: DSLElement, v: bool) = x.attr "arrow" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getPopupContainer" v 
        [<CustomOperation("overlay")>] member inline _.overlay (x: DSLElement, v: ReactElement) = x.attr "overlay" v 
        [<CustomOperation("overlayClassName")>] member inline _.overlayClassName (x: DSLElement, v: string) = x.attr "overlayClassName" v
        [<CustomOperation("overlayStyle")>] member inline _.overlayStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "overlayStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("onVisibleChange")>] member inline _.onVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onVisibleChange" v 
        [<CustomOperation("placement")>] member inline _.placement (x: DSLElement, v: DropdownPlacement) = x.attr "placement" v 
        [<CustomOperation("trigger")>] member inline _.trigger (x: DSLElement, v: DropdownTrigger array) = x.attr "trigger" v 
        [<CustomOperation("visible")>] member inline _.visible (x: DSLElement, v: bool) = x.attr "visible" v 
        
    type DropdownButtonBuilder() =
        inherit ReactBuilder(import "Dropdown.Button" "antd")
    
        [<CustomOperation("buttonsRender")>] member inline _.buttonsRender (x: DSLElement, v: ReactElement array array -> ReactElement) = x.attr "buttonsRender" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: Event -> unit) = x.attr "onClick" v 
        [<CustomOperation("onVisibleChange")>] member inline _.onVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onVisibleChange" v 
        [<CustomOperation("overlay")>] member inline _.overlay (x: DSLElement, v: ReactElement) = x.attr "overlay" v 
        [<CustomOperation("placement")>] member inline _.placement (x: DSLElement, v: DropdownPlacement) = x.attr "placement" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("trigger")>] member inline _.trigger (x: DSLElement, v: DropdownTrigger array) = x.attr "trigger" v
        [<CustomOperation("buttonType")>] member inline _.buttonType (x: DSLElement, v: ButtonType) = x.attr "type" v
        [<CustomOperation("visible")>] member inline _.visible (x: DSLElement, v: bool) = x.attr "visible" v