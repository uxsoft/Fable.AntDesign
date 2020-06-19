namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntRate() =
    inherit AntElement<AntRate>(ofImport "Rate" "antd")
    member x.allowClear (v: bool) = x.attribute "allowClear" v 
    member x.allowHalf (v: bool) = x.attribute "allowHalf" v 
    member x.autoFocus (v: bool) = x.attribute "autoFocus" v 
    member x.character (v: ReactElement) = x.attribute "character" v 
    member x.className (v: string) = x.attribute "className" v 
    member x.count (v: int) = x.attribute "count" v 
    member x.defaultValue (v: float) = x.attribute "defaultValue" v 
    member x.disabled (v: bool) = x.attribute "disabled" v 
    member x.tooltips (v: string array) = x.attribute "tooltips" v 
    member x.value (v: float) = x.attribute "value" v 
    member x.onBlur (v: (unit -> unit)) = x.attribute "onBlur" v 
    member x.onChange (v: (float -> unit)) = x.attribute "onChange" v 
    member x.onFocus (v: (unit -> unit)) = x.attribute "onFocus" v 
    member x.onHoverChange (v: (float -> unit)) = x.attribute "onHoverChange" v 
    member x.onKeyDown (v: (Event -> unit)) = x.attribute "onKeyDown" v 