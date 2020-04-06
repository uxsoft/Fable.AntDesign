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
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.GetPopupContainer with set (v: (unit -> HTMLElement)) = x.Attribute "getPopupContainer" v 
    member x.Overlay with set (v: ReactElement) = x.Attribute "overlay" v 
    member x.OverlayClassName with set (v: string) = x.Attribute "overlayClassName" v
    member x.OverlayStyle (css: Props.CSSProp list) = x.Attribute "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    member x.Placement with set (v: DropdownPlacement) = x.Attribute "placement" v 
    member x.Trigger with set (v: DropdownTrigger array) = x.Attribute "trigger" v 
    member x.Visible with set (v: bool) = x.Attribute "visible" v 
    member x.OnVisibleChange with set (v: (bool -> unit)) = x.Attribute "onVisibleChange" v 
    
type AntDropdownButton() =
    inherit AntElement(ofImport "Dropdown.Button" "antd")
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v
    member x.Icon with set (v: bool) = x.Attribute "icon" v
    member x.Overlay with set (v: ReactElement) = x.Attribute "disabled" v 
    member x.Placement with set (v: DropdownPlacement) = x.Attribute "disabled" v 
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Trigger with set (v: DropdownTrigger array) = x.Attribute "trigger" v
    member x.Type with set (v: ButtonType) = x.Attribute "type" v
    member x.Visible with set (v: bool) = x.Attribute "visible" v
    member x.OnClick with set (v: Event -> unit) = x.Attribute "onClick" v 
    member x.OnVisibleChange with set (v: (bool -> unit)) = x.Attribute "onVisibleChange" v 
    member x.ButtonsRender (v: ReactElement array array -> ReactElement) = x.Attribute "buttonsRender" v