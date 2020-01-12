namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Tooltip =
        
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntTooltipPlacement = Top | Left | Right | Bottom | TopLeft | TopRight | BottomLeft | BottomRight | LeftTop | LeftBottom | RightTop | RightBottom
    
     [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntTooltipTrigger = Hover | Focus | Click | ContextMenu 
    
    [<RequireQualifiedAccess>]
    type AntTooltip =
        | ArrowPointAtCenter of bool
        | AutoAdjustOverflow of bool
        | DefaultVisible of bool
        | GetPopupContainer of (unit -> ReactElement)
        | MouseEnterDelay of float
        | MouseLeaveDelay of float
        | OverlayClassName of string
        | Placement of AntTooltipPlacement
        | Trigger of AntTooltipTrigger
        | Visible of bool
        | OnVisibleChange of (bool -> unit)
        | Align of obj
        static member Custom (key: string, value: obj): AntTooltip = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTooltip = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member OverlayStyle (css: Props.CSSProp list): AntTooltip = unbox ("overlayStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntPopover =
        | ArrowPointAtCenter of bool
        | AutoAdjustOverflow of bool
        | DefaultVisible of bool
        | GetPopupContainer of (unit -> ReactElement)
        | MouseEnterDelay of float
        | MouseLeaveDelay of float
        | OverlayClassName of string
        | Placement of AntTooltipPlacement
        | Trigger of AntTooltipTrigger
        | Visible of bool
        | OnVisibleChange of (bool -> unit)
        | Align of obj
        | Content of ReactElement
        | Title of ReactElement
        static member Custom (key: string, value: obj): AntPopover = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntPopover = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member OverlayStyle (css: Props.CSSProp list): AntPopover = unbox ("overlayStyle", keyValueList CaseRules.LowerFirst css)

    let inline antTooltip (props: AntTooltip list) (children: ReactElement list): ReactElement =
       ofImport "Tooltip" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antPopover (props: AntPopover list) (children: ReactElement list): ReactElement =
       ofImport "Popover" "antd" (keyValueList CaseRules.LowerFirst props) children