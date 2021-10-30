namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Slider = 

    [<StringEnum; RequireQualifiedAccess>]
    type TooltipPlacement =
        | Top
        | Left
        | Right
        | Bottom
        | TopLeft
        | TopRight
        | BottomLeft
        | BottomRight
        | LeftTop
        | LeftBottom
        | RightTop
        | RightBottom
    
    
    type SliderBuilder() =
        inherit ReactBuilder(import "Slider" "antd")
    
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v
        [<CustomOperation("defaultValues")>] member inline _.defaultValues (x: DSLElement, v: float array) = x.attr "defaultValue" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("dots")>] member inline _.dots (x: DSLElement, v: bool) = x.attr "dots" v
        [<CustomOperation("getTooltipPopupContainer")>] member inline _.getTooltipPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getTooltipPopupContainer" v
        [<CustomOperation("included")>] member inline _.included (x: DSLElement, v: bool) = x.attr "included" v
        [<CustomOperation("marks")>] member inline _.marks (x: DSLElement, v: obj) = x.attr "marks" v
        //TODO better type
        [<CustomOperation("max")>] member inline _.max (x: DSLElement, v: float) = x.attr "max" v
        [<CustomOperation("min")>] member inline _.min (x: DSLElement, v: float) = x.attr "min" v
        [<CustomOperation("range")>] member inline _.range (x: DSLElement, v: bool) = x.attr "range" v
        [<CustomOperation("reverse")>] member inline _.reverse (x: DSLElement, v: bool) = x.attr "reverse" v
        [<CustomOperation("step")>] member inline _.step (x: DSLElement, v: int) = x.attr "step" v
        [<CustomOperation("tipFormatter")>] member inline _.tipFormatter (x: DSLElement, v: float -> ReactElement) = x.attr "tipFormatter" v
        [<CustomOperation("tooltipPlacement")>] member inline _.tooltipPlacement (x: DSLElement, v: TooltipPlacement) = x.attr "tooltipPlacement" v
        [<CustomOperation("tooltipVisible")>] member inline _.tooltipVisible (x: DSLElement, v: bool) = x.attr "tooltipVisible" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: float) = x.attr "value" v
        [<CustomOperation("values")>] member inline _.values (x: DSLElement, v: float array) = x.attr "value" v
        [<CustomOperation("vertical")>] member inline _.vertical (x: DSLElement, v: bool) = x.attr "vertical" v
        [<CustomOperation("onAfterChange")>] member inline _.onAfterChange (x: DSLElement, v: float -> unit) = x.attr "onAfterChange" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v
    