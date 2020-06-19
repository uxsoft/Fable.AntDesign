namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<StringEnum; RequireQualifiedAccess>]
type TooltipPlacement = Top | Left | Right | Bottom | TopLeft | TopRight | BottomLeft | BottomRight | LeftTop | LeftBottom | RightTop | RightBottom

[<StringEnum; RequireQualifiedAccess>]
type TooltipTrigger = Hover | Focus | Click | ContextMenu 

type AntPopoverBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.arrowPointAtCenter (v: bool) = x.attribute "arrowPointAtCenter" v
    member x.autoAdjustOverflow (v: bool) = x.attribute "autoAdjustOverflow" v
    member x.defaultVisible (v: bool) = x.attribute "defaultVisible" v
    member x.getPopupContainer (v: (unit -> ReactElement)) = x.attribute "getPopupContainer" v 
    member x.mouseEnterDelay (v: float) = x.attribute "mouseEnterDelay" v 
    member x.mouseLeaveDelay (v: float) = x.attribute "mouseLeaveDelay" v 
    member x.overlayClassName (v: string) = x.attribute "overlayClassName" v
    member x.overlayStyle (css: CSSProp list) =  x.attribute "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    member x.placement (v: TooltipPlacement) = x.attribute "placement" v 
    member x.trigger (v: TooltipTrigger) = x.attribute "trigger" v 
    member x.visible (v: bool) = x.attribute "visible" v 
    member x.onVisibleChange (v: (bool -> unit)) = x.attribute "onVisibleChange" v 
    member x.align (v: obj) = x.attribute "align" v 

type AntPopover() =
    inherit AntPopoverBase<AntPopover>(ofImport "Popover" "antd")

type AntPopconfirm() =
    inherit AntPopoverBase<AntPopconfirm>(ofImport "Popconfirm" "antd")

type AntTooltip() =
    inherit AntPopoverBase<AntTooltip>(ofImport "Tooltip" "antd")
    member x.Title (v: string) = x.attribute "title" v