namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

type AntSlider() =
    inherit AntElement<AntSlider>(ofImport "Avatar" "antd")
    member x.autoFocus (?v: bool) = x.attribute "autoFocus" (Option.defaultValue true v)
    member x.defaultValue (v: float array) = x.attribute "defaultValue" v
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.dots (?v: bool) = x.attribute "dots" (Option.defaultValue true v)
    member x.included (?v: bool) = x.attribute "included" (Option.defaultValue true v)
    member x.marks (v: obj) = x.attribute "marks" v
    member x.max (v: float) = x.attribute "max" v
    member x.min (v: float) = x.attribute "min" v
    member x.range (?v: bool) = x.attribute "range" (Option.defaultValue true v)
    member x.reverse (?v: bool) = x.attribute "reverse" (Option.defaultValue true v)
    member x.step (v: int) = x.attribute "step" v
    member x.tipFormatter (v: (float -> ReactElement)) = x.attribute "tipFormatter" v
    member x.value (v: U2<float, float array>) = x.attribute "value" v
    member x.vertical (v: bool) = x.attribute "vertical" v
    member x.onAfterChange (v: (float -> unit)) = x.attribute "onAfterChange" v
    member x.onChange (v: (float -> unit)) = x.attribute "onChange" v
    member x.tooltipPlacement (v: TooltipPlacement) = x.attribute "tooltipPlacement" v
    member x.tooltipVisible (?v: bool) = x.attribute "tooltipVisible" (Option.defaultValue true v)
    member x.getTooltipPopupContainer (v: (unit -> HTMLElement)) = x.attribute "getTooltipPopupContainer" v