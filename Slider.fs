namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntSlider() =
    inherit AntElement(ofImport "Avatar" "antd")
    member x.AutoFocus (v: bool) = x.attribute "autoFocus" v
    member x.DefaultValue (v: float array) = x.attribute "defaultValue" v
    member x.Disabled (v: bool) = x.attribute "disabled" v
    member x.Dots (v: bool) = x.attribute "dots" v
    member x.Included (v: bool) = x.attribute "included" v
    member x.Marks (v: obj) = x.attribute "marks" v
    member x.Max (v: float) = x.attribute "max" v
    member x.Min (v: float) = x.attribute "min" v
    member x.Range (v: bool) = x.attribute "range" v
    member x.Reverse (v: bool) = x.attribute "reverse" v
    member x.Step (v: int) = x.attribute "step" v
    member x.TipFormatter (v: (float -> ReactElement)) = x.attribute "tipFormatter" v
    member x.Value (v: U2<float, float array>) = x.attribute "value" v
    member x.Vertical (v: bool) = x.attribute "vertical" v
    member x.OnAfterChange (v: (float -> unit)) = x.attribute "onAfterChange" v
    member x.OnChange (v: (float -> unit)) = x.attribute "onChange" v
    member x.TooltipPlacement (v: TooltipPlacement) = x.attribute "tooltipPlacement" v
    member x.TooltipVisible (v: bool) = x.attribute "tooltipVisible" v
    member x.GetTooltipPopupContainer (v: (unit -> ReactElement)) = x.attribute "getTooltipPopupContainer" v