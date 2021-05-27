module Fable.AntDesign.InputNumber

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type InputNumberBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "InputNumber" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v 
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
    [<CustomOperation("formatter")>] member _.formatter (x: DSLElement, v: float -> string) = x.attr "formatter" v 
    [<CustomOperation("max")>] member _.max (x: DSLElement, v: float) = x.attr "max" v 
    [<CustomOperation("min")>] member _.min (x: DSLElement, v: float) = x.attr "min" v 
    [<CustomOperation("parser")>] member _.parser (x: DSLElement, v: string -> float) = x.attr "parser" v 
    [<CustomOperation("precision")>] member _.precision (x: DSLElement, v: float) = x.attr "precision" v 
    [<CustomOperation("decimalSeparator")>] member _.decimalSeparator (x: DSLElement, v: string) = x.attr "decimalSeparator" v
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("step")>] member _.step (x: DSLElement, v: float) = x.attr "step" v 
    [<CustomOperation("htmlType")>] member _.htmlType (x: DSLElement, v: string) = x.attr "type" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: float) = x.attr "value" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v 
    [<CustomOperation("onPressEnter")>] member _.onPressEnter (x: DSLElement, v: Event -> unit) = x.attr "onPressEnter" v 