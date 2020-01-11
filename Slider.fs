namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Slider =
    
    [<RequireQualifiedAccess>]
    type AntSlider =
        | AutoFocus of bool
        | DefaultValue of U2<float, float array>
        | Disabled of bool
        | Dots of bool
        | Included of bool
        | Marks of obj
        | Max of float
        | Min of float
        | Range of bool
        | Reverse of bool
        | Step of int
        | TipFormatter of (float -> ReactElement)
        | Value of U2<float, float array>
        | Vertical of bool
        | OnAfterChange of (float -> unit)
        | OnChange of (float -> unit)
        | TooltipPlacement of AntTooltipPlacement
        | TooltipVisible of bool
        | GetTooltipPopupContainer of (unit -> ReactElement)
        static member Custom (key: string, value: obj): AntSlider = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSlider = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antAvatar (props: AntSlider list) (children: ReactElement list): ReactElement =
       ofImport "Avatar" "antd" (keyValueList CaseRules.LowerFirst props) children