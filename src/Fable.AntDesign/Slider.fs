module Fable.AntDesign.Slider

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type TooltipPlacement = Top | Left | Right | Bottom | TopLeft | TopRight | BottomLeft | BottomRight | LeftTop | LeftBottom | RightTop | RightBottom


type SliderBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Slider" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v
    [<CustomOperation("defaultValues")>] member _.defaultValues (x: DSLElement, v: float array) = x.attr "defaultValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("dots")>] member _.dots (x: DSLElement, v: bool) = x.attr "dots" v
    [<CustomOperation("getTooltipPopupContainer")>] member _.getTooltipPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getTooltipPopupContainer" v
    [<CustomOperation("included")>] member _.included (x: DSLElement, v: bool) = x.attr "included" v
    [<CustomOperation("marks")>] member _.marks (x: DSLElement, v: obj) = x.attr "marks" v
    //TODO better type
    [<CustomOperation("max")>] member _.max (x: DSLElement, v: float) = x.attr "max" v
    [<CustomOperation("min")>] member _.min (x: DSLElement, v: float) = x.attr "min" v
    [<CustomOperation("range")>] member _.range (x: DSLElement, v: bool) = x.attr "range" v
    [<CustomOperation("reverse")>] member _.reverse (x: DSLElement, v: bool) = x.attr "reverse" v
    [<CustomOperation("step")>] member _.step (x: DSLElement, v: int) = x.attr "step" v
    [<CustomOperation("tipFormatter")>] member _.tipFormatter (x: DSLElement, v: float -> ReactElement) = x.attr "tipFormatter" v
    [<CustomOperation("tooltipPlacement")>] member _.tooltipPlacement (x: DSLElement, v: TooltipPlacement) = x.attr "tooltipPlacement" v
    [<CustomOperation("tooltipVisible")>] member _.tooltipVisible (x: DSLElement, v: bool) = x.attr "tooltipVisible" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: float) = x.attr "value" v
    [<CustomOperation("values")>] member _.values (x: DSLElement, v: float array) = x.attr "value" v
    [<CustomOperation("vertical")>] member _.vertical (x: DSLElement, v: bool) = x.attr "vertical" v
    [<CustomOperation("onAfterChange")>] member _.onAfterChange (x: DSLElement, v: float -> unit) = x.attr "onAfterChange" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v
