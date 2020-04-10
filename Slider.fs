namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntSlider() =
    inherit AntElement(ofImport "Avatar" "antd")
    member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v
    member x.DefaultValue with set (v: float array) = x.Attribute "defaultValue" v
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v
    member x.Dots with set (v: bool) = x.Attribute "dots" v
    member x.Included with set (v: bool) = x.Attribute "included" v
    member x.Marks with set (v: obj) = x.Attribute "marks" v
    member x.Max with set (v: float) = x.Attribute "max" v
    member x.Min with set (v: float) = x.Attribute "min" v
    member x.Range with set (v: bool) = x.Attribute "range" v
    member x.Reverse with set (v: bool) = x.Attribute "reverse" v
    member x.Step with set (v: int) = x.Attribute "step" v
    member x.TipFormatter with set (v: (float -> ReactElement)) = x.Attribute "tipFormatter" v
    member x.Value with set (v: U2<float, float array>) = x.Attribute "value" v
    member x.Vertical with set (v: bool) = x.Attribute "vertical" v
    member x.OnAfterChange with set (v: (float -> unit)) = x.Attribute "onAfterChange" v
    member x.OnChange with set (v: (float -> unit)) = x.Attribute "onChange" v
    member x.TooltipPlacement with set (v: TooltipPlacement) = x.Attribute "tooltipPlacement" v
    member x.TooltipVisible with set (v: bool) = x.Attribute "tooltipVisible" v
    member x.GetTooltipPopupContainer with set (v: (unit -> ReactElement)) = x.Attribute "getTooltipPopupContainer" v