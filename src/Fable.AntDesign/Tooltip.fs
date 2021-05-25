module Fable.AntDesign.Tooltip

open Browser.Types
open Fable.AntDesign.Common
open Fable.AntDesign.Button
open Fable.AntDesign.Slider
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type TooltipTrigger = Hover | Focus | Click | ContextMenu 

type TooltipBaseBuilder() =
    inherit ReactBuilder()
    [<CustomOperation("align")>] member _.align (x: DSLElement, v: obj) = x.attr "align" v
    [<CustomOperation("arrowPointAtCenter")>] member _.arrowPointAtCenter (x: DSLElement, ?v: bool) = x.attr "arrowPointAtCenter" (Option.defaultValue true v)
    [<CustomOperation("autoAdjustOverflow")>] member _.autoAdjustOverflow (x: DSLElement, ?v: bool) = x.attr "autoAdjustOverflow" (Option.defaultValue true v)
    [<CustomOperation("color")>] member _.color (x: DSLElement, v: string) = x.attr "color" v
    [<CustomOperation("defaultVisible")>] member _.defaultVisible (x: DSLElement, ?v: bool) = x.attr "defaultVisible" (Option.defaultValue true v)
    [<CustomOperation("destroyTooltipOnHide")>] member _.destroyTooltipOnHide (x: DSLElement, v: bool) = x.attr "destroyTooltipOnHide" v
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: (unit -> HTMLElement)) = x.attr "getPopupContainer" v 
    [<CustomOperation("mouseEnterDelay")>] member _.mouseEnterDelay (x: DSLElement, v: float) = x.attr "mouseEnterDelay" v 
    [<CustomOperation("mouseLeaveDelay")>] member _.mouseLeaveDelay (x: DSLElement, v: float) = x.attr "mouseLeaveDelay" v 
    [<CustomOperation("overlayClassName")>] member _.overlayClassName (x: DSLElement, v: string) = x.attr "overlayClassName" v
    [<CustomOperation("overlayStyle")>] member _.overlayStyle (x: DSLElement, css: Props.CSSProp list) =  x.attr "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("placement")>] member _.placement (x: DSLElement, v: TooltipPlacement) = x.attr "placement" v 
    [<CustomOperation("trigger")>] member _.trigger (x: DSLElement, v: TooltipTrigger) = x.attr "trigger" v 
    [<CustomOperation("visible")>] member _.visible (x: DSLElement, ?v: bool) = x.attr "visible" (Option.defaultValue true v) 
    [<CustomOperation("onVisibleChange")>] member _.onVisibleChange (x: DSLElement, v: (bool -> unit)) = x.attr "onVisibleChange" v 

type PopoverBuilder() =
    inherit TooltipBaseBuilder()

    member x.Run(s: DSLElement) =
        ofImport "Popover" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("content")>] member _.content (x: DSLElement, v: ReactElement) = x.attr "content" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v

type PopconfirmBuilder() =
    inherit TooltipBaseBuilder()

    member x.Run(s: DSLElement) =
        ofImport "Popconfirm" "antd" (createObj s.Attributes) s.Children

    //TODO better type
    [<CustomOperation("cancelButtonProps")>] member _.cancelButtonProps (x: DSLElement, v: DSLElement) = x.attr "cancelButtonProps" (createObj v.Attributes)
    [<CustomOperation("cancelText")>] member _.cancelText (x: DSLElement, v: string) = x.attr "cancelText" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    
    //TODO better type
    [<CustomOperation("okButtonProps")>] member _.okButtonProps (x: DSLElement, v: DSLElement) = x.attr "okButtonProps" (createObj v.Attributes)
    [<CustomOperation("okText")>] member _.okText (x: DSLElement, v: string) = x.attr "okText" v
    [<CustomOperation("okType")>] member _.okType (x: DSLElement, v: ButtonType) = x.attr "okType" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("onCancel")>] member _.onCancel (x: DSLElement, v: unit -> unit) = x.attr "onCancel" v
    [<CustomOperation("onConfirm")>] member _.onConfirm (x: DSLElement, v: unit -> unit) = x.attr "onConfirm" v

type TooltipBuilder() =
    inherit TooltipBaseBuilder()

    member x.Run(s: DSLElement) =
        ofImport "Tooltip" "antd" (createObj s.Attributes) s.Children
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: string) = x.attr "title" v