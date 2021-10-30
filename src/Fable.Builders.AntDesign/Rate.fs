namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Rate =

    type RateBuilder() =
        inherit ReactBuilder(import "Rate" "antd")
    
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
        [<CustomOperation("allowHalf")>] member inline _.allowHalf (x: DSLElement, v: bool) = x.attr "allowHalf" v
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
        [<CustomOperation("character")>] member inline _.character (x: DSLElement, v: ReactElement) = x.attr "character" v 
        [<CustomOperation("className")>] member inline _.className (x: DSLElement, v: string) = x.attr "className" v 
        [<CustomOperation("count")>] member inline _.count (x: DSLElement, v: int) = x.attr "count" v 
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("tooltips")>] member inline _.tooltips (x: DSLElement, v: string array) = x.attr "tooltips" v 
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: float) = x.attr "value" v 
        [<CustomOperation("onBlur")>] member inline _.onBlur (x: DSLElement, v: unit -> unit) = x.attr "onBlur" v 
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v 
        [<CustomOperation("onFocus")>] member inline _.onFocus (x: DSLElement, v: unit -> unit) = x.attr "onFocus" v 
        [<CustomOperation("onHoverChange")>] member inline _.onHoverChange (x: DSLElement, v: float -> unit) = x.attr "onHoverChange" v 
        [<CustomOperation("onKeyDown")>] member inline _.onKeyDown (x: DSLElement, v: Event -> unit) = x.attr "onKeyDown" v 