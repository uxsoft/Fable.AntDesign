namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type DropdownPlacement = BottomLeft | BottomCenter | BottomRight | TopLeft | TopCenter | TopRight

[<StringEnum; RequireQualifiedAccess>]
type DropdownTrigger = Click | Hover | ContextMenu

type AntDropdown() =
    inherit AntElement(ofImport "Dropdown" "antd")
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.GetPopupContainer (v: (unit -> HTMLElement)) = x.attribute "getPopupContainer" v 
    member x.Overlay (v: ReactElement) = x.attribute "overlay" v 
    member x.OverlayClassName (v: string) = x.attribute "overlayClassName" v
    member x.OverlayStyle (css: Props.CSSProp list) = x.attribute "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    member x.Placement (v: DropdownPlacement) = x.attribute "placement" v 
    member x.Trigger (v: DropdownTrigger array) = x.attribute "trigger" v 
    member x.Visible (v: bool) = x.attribute "visible" v 
    member x.OnVisibleChange (v: (bool -> unit)) = x.attribute "onVisibleChange" v 
    
type AntDropdownButton() =
    inherit AntElement(ofImport "Dropdown.Button" "antd")
    member x.Disabled (v: bool) = x.attribute "disabled" v
    member x.Icon (v: bool) = x.attribute "icon" v
    member x.Overlay (v: ReactElement) = x.attribute "disabled" v 
    member x.Placement (v: DropdownPlacement) = x.attribute "disabled" v 
    member x.Size (v: Size) = x.attribute "size" v
    member x.Trigger (v: DropdownTrigger array) = x.attribute "trigger" v
    member x.Type (v: ButtonType) = x.attribute "type" v
    member x.Visible (v: bool) = x.attribute "visible" v
    member x.OnClick (v: Event -> unit) = x.attribute "onClick" v 
    member x.OnVisibleChange (v: (bool -> unit)) = x.attribute "onVisibleChange" v 
    member x.ButtonsRender (v: ReactElement array array -> ReactElement) = x.attribute "buttonsRender" v