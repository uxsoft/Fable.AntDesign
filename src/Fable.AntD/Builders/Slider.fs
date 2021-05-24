module Fable.AntD.Builders.Slider

open Browser.Types
open Fable.AntD
open Fable.AntD.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

type SliderBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Slider" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement) = x.attr "autoFocus" true
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v
    [<CustomOperation("defaultValues")>] member _.defaultValues (x: DSLElement, v: float array) = x.attr "defaultValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("dots")>] member _.dots (x: DSLElement) = x.attr "dots" true
    [<CustomOperation("getTooltipPopupContainer")>] member _.getTooltipPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getTooltipPopupContainer" v
    [<CustomOperation("included")>] member _.included (x: DSLElement) = x.attr "included" true
    [<CustomOperation("marks")>] member _.marks (x: DSLElement, v: obj) = x.attr "marks" v
    [<CustomOperation("max")>] member _.max (x: DSLElement, v: float) = x.attr "max" v
    [<CustomOperation("min")>] member _.min (x: DSLElement, v: float) = x.attr "min" v
    [<CustomOperation("range")>] member _.range (x: DSLElement) = x.attr "range" true
    [<CustomOperation("reverse")>] member _.reverse (x: DSLElement) = x.attr "reverse" true
    [<CustomOperation("step")>] member _.step (x: DSLElement, v: int) = x.attr "step" v
    [<CustomOperation("tipFormatter")>] member _.tipFormatter (x: DSLElement, v: float -> ReactElement) = x.attr "tipFormatter" v
    [<CustomOperation("tooltipPlacement")>] member _.tooltipPlacement (x: DSLElement, v: TooltipPlacement) = x.attr "tooltipPlacement" v
    [<CustomOperation("tooltipVisible")>] member _.tooltipVisible (x: DSLElement) = x.attr "tooltipVisible" true
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: float) = x.attr "value" v
    [<CustomOperation("values")>] member _.values (x: DSLElement, v: float array) = x.attr "value" v
    [<CustomOperation("vertical")>] member _.vertical (x: DSLElement, v: bool) = x.attr "vertical" v
    [<CustomOperation("onAfterChange")>] member _.onAfterChange (x: DSLElement, v: float -> unit) = x.attr "onAfterChange" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v
