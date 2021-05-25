module Fable.AntDesign.Rate

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core.JsInterop
open Fable.React

type RateBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Rate" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement) = x.attr "allowClear" true
    [<CustomOperation("allowHalf")>] member _.allowHalf (x: DSLElement) = x.attr "allowHalf" true
    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement) = x.attr "autoFocus" true
    [<CustomOperation("character")>] member _.character (x: DSLElement, v: ReactElement) = x.attr "character" v 
    [<CustomOperation("className")>] member _.className (x: DSLElement, v: string) = x.attr "className" v 
    [<CustomOperation("count")>] member _.count (x: DSLElement, v: int) = x.attr "count" v 
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: float) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
    [<CustomOperation("tooltips")>] member _.tooltips (x: DSLElement, v: string array) = x.attr "tooltips" v 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: float) = x.attr "value" v 
    [<CustomOperation("onBlur")>] member _.onBlur (x: DSLElement, v: unit -> unit) = x.attr "onBlur" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: float -> unit) = x.attr "onChange" v 
    [<CustomOperation("onFocus")>] member _.onFocus (x: DSLElement, v: unit -> unit) = x.attr "onFocus" v 
    [<CustomOperation("onHoverChange")>] member _.onHoverChange (x: DSLElement, v: float -> unit) = x.attr "onHoverChange" v 
    [<CustomOperation("onKeyDown")>] member _.onKeyDown (x: DSLElement, v: Event -> unit) = x.attr "onKeyDown" v 