namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntRate() =
    inherit AntElement(ofImport "Rate" "antd")
    member x.AllowClear (v: bool) = x.attribute "allowClear" v 
    member x.AllowHalf (v: bool) = x.attribute "allowHalf" v 
    member x.AutoFocus (v: bool) = x.attribute "autoFocus" v 
    member x.Character (v: ReactElement) = x.attribute "character" v 
    member x.ClassName (v: string) = x.attribute "className" v 
    member x.Count (v: int) = x.attribute "count" v 
    member x.DefaultValue (v: float) = x.attribute "defaultValue" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Tooltips (v: string array) = x.attribute "tooltips" v 
    member x.Value (v: float) = x.attribute "value" v 
    member x.OnBlur (v: (unit -> unit)) = x.attribute "onBlur" v 
    member x.OnChange (v: (float -> unit)) = x.attribute "onChange" v 
    member x.OnFocus (v: (unit -> unit)) = x.attribute "onFocus" v 
    member x.OnHoverChange (v: (float -> unit)) = x.attribute "onHoverChange" v 
    member x.OnKeyDown (v: (Event -> unit)) = x.attribute "onKeyDown" v 