namespace Fable.AntD

open Browser.Types
open Fable.React

type AntInputNumber() =
    inherit AntElement<AntInputNumber>(ofImport "InputNumber" "antd")
    member x.autoFocus (?v: bool) = x.attribute "autoFocus" (Option.defaultValue true v) 
    member x.defaultValue (v: float) = x.attribute "defaultValue" v 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.formatter (v: (float -> string)) = x.attribute "formatter" v 
    member x.max (v: float) = x.attribute "max" v 
    member x.min (v: float) = x.attribute "min" v 
    member x.parser (v: (string -> float)) = x.attribute "parser" v 
    member x.precision (v: float) = x.attribute "precision" v 
    member x.decimalSeparator (v: string) = x.attribute "decimalSeparator" v
    member x.size (v: Size) = x.attribute "size" v 
    member x.step (v: float) = x.attribute "step" v 
    member x.htmlType (v: string) = x.attribute "type" v
    member x.value (v: float) = x.attribute "value" v 
    member x.onChange (v: (float -> unit)) = x.attribute "onChange" v 
    member x.onPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 