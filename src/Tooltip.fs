namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open System

[<StringEnum; RequireQualifiedAccess>]
type TooltipPlacement = Top | Left | Right | Bottom | TopLeft | TopRight | BottomLeft | BottomRight | LeftTop | LeftBottom | RightTop | RightBottom

[<StringEnum; RequireQualifiedAccess>]
type TooltipTrigger = Hover | Focus | Click | ContextMenu 

type AntTooltipBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.align (v: obj) = x.attribute "align" v
    member x.arrowPointAtCenter (?v: bool) = x.attribute "arrowPointAtCenter" (Option.defaultValue true v)
    member x.autoAdjustOverflow (?v: bool) = x.attribute "autoAdjustOverflow" (Option.defaultValue true v)
    member x.color (v: string) = x.attribute "color" v
    member x.defaultVisible (?v: bool) = x.attribute "defaultVisible" (Option.defaultValue true v)
    member x.destroyTooltipOnHide (v: bool) = x.attribute "destroyTooltipOnHide" v
    member x.getPopupContainer (v: (unit -> HTMLElement)) = x.attribute "getPopupContainer" v 
    member x.mouseEnterDelay (v: float) = x.attribute "mouseEnterDelay" v 
    member x.mouseLeaveDelay (v: float) = x.attribute "mouseLeaveDelay" v 
    member x.overlayClassName (v: string) = x.attribute "overlayClassName" v
    member x.overlayStyle (css: CSSProp list) =  x.attribute "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    member x.placement (v: TooltipPlacement) = x.attribute "placement" v 
    member x.trigger (v: TooltipTrigger) = x.attribute "trigger" v 
    member x.visible (?v: bool) = x.attribute "visible" (Option.defaultValue true v) 
    member x.onVisibleChange (v: (bool -> unit)) = x.attribute "onVisibleChange" v 

type AntPopover() =
    inherit AntTooltipBase<AntPopover>(ofImport "Popover" "antd")
    member x.content (v: ReactElement) = x.attribute "content" v
    member x.title (v: ReactElement) = x.attribute "title" v

type AntPopconfirm() =
    inherit AntTooltipBase<AntPopconfirm>(ofImport "Popconfirm" "antd")
    member x.cancelButtonProps (v: AntButton) = x.attribute "cancelButtonProps" v.JSON
    member x.cancelText (v: string) = x.attribute "cancelText" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.okButtonProps (v: AntButton) = x.attribute "okButtonProps" v.JSON
    member x.okText (v: string) = x.attribute "okText" v
    member x.okType (v: ButtonType) = x.attribute "okType" v
    member x.title (v: ReactElement) = x.attribute "title" v
    member x.onCancel (v: unit -> unit) = x.attribute "onCancel" v
    member x.onConfirm (v: unit -> unit) = x.attribute "onConfirm" v

type AntTooltip() =
    inherit AntTooltipBase<AntTooltip>(ofImport "Tooltip" "antd")
    member x.title (v: string) = x.attribute "title" v