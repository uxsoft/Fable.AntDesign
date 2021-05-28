module Fable.AntDesign.InputNumber

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type InputNumberBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "InputNumber" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v 
    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
    [<CustomOperation("formatter")>] member inline _.formatter (x: DSLElement, v: float -> string) = x.attr "formatter" v 
    [<CustomOperation("max")>] member inline _.max (x: DSLElement, v: float) = x.attr "max" v 
    [<CustomOperation("min")>] member inline _.min (x: DSLElement, v: float) = x.attr "min" v 
    [<CustomOperation("parser")>] member inline _.parser (x: DSLElement, v: string -> float) = x.attr "parser" v 
    [<CustomOperation("precision")>] member inline _.precision (x: DSLElement, v: float) = x.attr "precision" v 
    [<CustomOperation("decimalSeparator")>] member inline _.decimalSeparator (x: DSLElement, v: string) = x.attr "decimalSeparator" v
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("step")>] member inline _.step (x: DSLElement, v: float) = x.attr "step" v 
    [<CustomOperation("htmlType")>] member inline _.htmlType (x: DSLElement, v: string) = x.attr "type" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: float) = x.attr "value" v 
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v 
    [<CustomOperation("onPressEnter")>] member inline _.onPressEnter (x: DSLElement, v: Event -> unit) = x.attr "onPressEnter" v 