namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

type AntSlider() =
    inherit AntElement<AntSlider>(ofImport "Avatar" "antd")
    member x.autoFocus (v: bool) = x.attribute "autoFocus" v
    member x.defaultValue (v: float array) = x.attribute "defaultValue" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.dots (v: bool) = x.attribute "dots" v
    member x.included (v: bool) = x.attribute "included" v
    member x.marks (v: obj) = x.attribute "marks" v
    member x.max (v: float) = x.attribute "max" v
    member x.min (v: float) = x.attribute "min" v
    member x.range (v: bool) = x.attribute "range" v
    member x.reverse (v: bool) = x.attribute "reverse" v
    member x.step (v: int) = x.attribute "step" v
    member x.tipFormatter (v: (float -> ReactElement)) = x.attribute "tipFormatter" v
    member x.value (v: U2<float, float array>) = x.attribute "value" v
    member x.vertical (v: bool) = x.attribute "vertical" v
    member x.onAfterChange (v: (float -> unit)) = x.attribute "onAfterChange" v
    member x.onChange (v: (float -> unit)) = x.attribute "onChange" v
    member x.tooltipPlacement (v: TooltipPlacement) = x.attribute "tooltipPlacement" v
    member x.tooltipVisible (v: bool) = x.attribute "tooltipVisible" v
    member x.getTooltipPopupContainer (v: (unit -> HTMLElement)) = x.attribute "getTooltipPopupContainer" v