namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module InputNumber =

    type InputNumberBuilder() =
        inherit ReactBuilder(import "InputNumber" "antd")
        [<CustomOperation("addonAfter")>] member inline _.addonAfter (x: DSLElement, v: ReactElement) = x.attr "addonAfter" v 
        [<CustomOperation("addonBefore")>] member inline _.addonBefore (x: DSLElement, v: ReactElement) = x.attr "addonBefore" v 
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v 
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
        [<CustomOperation("controls")>] member inline _.controls (x: DSLElement, v: bool) = x.attr "controls" v 
        [<CustomOperation("decimalSeparator")>] member inline _.decimalSeparator (x: DSLElement, v: string) = x.attr "decimalSeparator" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("formatter")>] member inline _.formatter (x: DSLElement, v: float -> string) = x.attr "formatter" v 
        [<CustomOperation("keyboard")>] member inline _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v 
        [<CustomOperation("max")>] member inline _.max (x: DSLElement, v: float) = x.attr "max" v 
        [<CustomOperation("min")>] member inline _.min (x: DSLElement, v: float) = x.attr "min" v 
        [<CustomOperation("parser")>] member inline _.parser (x: DSLElement, v: string -> float) = x.attr "parser" v 
        [<CustomOperation("precision")>] member inline _.precision (x: DSLElement, v: float) = x.attr "precision" v 
        [<CustomOperation("readOnly")>] member inline _.readOnly (x: DSLElement, v: bool) = x.attr "readOnly" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
        [<CustomOperation("step")>] member inline _.step (x: DSLElement, v: float) = x.attr "step" v 
        [<CustomOperation("htmlType")>] member inline _.htmlType (x: DSLElement, v: string) = x.attr "type" v
        [<CustomOperation("stringMode")>] member inline _.stringMode (x: DSLElement, v: bool) = x.attr "stringMode" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: float) = x.attr "value" v 
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v 
        [<CustomOperation("onPressEnter")>] member inline _.onPressEnter (x: DSLElement, v: Event -> unit) = x.attr "onPressEnter" v
        [<CustomOperation("onStep")>] member inline _.onStep (x: DSLElement, v: obj -> unit) = x.attr "onStep" v 