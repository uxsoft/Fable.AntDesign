namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<StringEnum; RequireQualifiedAccess>]
type TooltipPlacement = Top | Left | Right | Bottom | TopLeft | TopRight | BottomLeft | BottomRight | LeftTop | LeftBottom | RightTop | RightBottom

[<StringEnum; RequireQualifiedAccess>]
type TooltipTrigger = Hover | Focus | Click | ContextMenu 

type AntPopover(?partialImport) =
    inherit AntElement(defaultArg partialImport (ofImport "Popover" "antd"))
    member x.ArrowPointAtCenter with set (v: bool) = x.Attribute "arrowPointAtCenter" v
    member x.AutoAdjustOverflow with set (v: bool) = x.Attribute "autoAdjustOverflow" v
    member x.DefaultVisible with set (v: bool) = x.Attribute "defaultVisible" v
    member x.GetPopupContainer with set (v: (unit -> ReactElement)) = x.Attribute "getPopupContainer" v 
    member x.MouseEnterDelay with set (v: float) = x.Attribute "mouseEnterDelay" v 
    member x.MouseLeaveDelay with set (v: float) = x.Attribute "mouseLeaveDelay" v 
    member x.OverlayClassName with set (v: string) = x.Attribute "overlayClassName" v
    member x.OverlayStyle with set (css: CSSProp list) =  x.Attribute "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    member x.Placement with set (v: TooltipPlacement) = x.Attribute "placement" v 
    member x.Trigger with set (v: TooltipTrigger) = x.Attribute "trigger" v 
    member x.Visible with set (v: bool) = x.Attribute "visible" v 
    member x.OnVisibleChange with set (v: (bool -> unit)) = x.Attribute "onVisibleChange" v 
    member x.Align with set (v: obj) = x.Attribute "align" v 

type AntPopconfirm() =
    inherit AntPopover(ofImport "Popconfirm" "antd")

type AntTooltip() =
    inherit AntPopover(ofImport "Tooltip" "antd")
    member x.Title with set (v: string) = x.Attribute "title" v