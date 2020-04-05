namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type Rate() =
    inherit AntElement(ofImport "Rate" "antd")
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
    member x.AllowHalf with set (v: bool) = x.Attribute "allowHalf" v 
    member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v 
    member x.Character with set (v: ReactElement) = x.Attribute "character" v 
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.Count with set (v: int) = x.Attribute "count" v 
    member x.DefaultValue with set (v: float) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Tooltips with set (v: string array) = x.Attribute "tooltips" v 
    member x.Value with set (v: float) = x.Attribute "value" v 
    member x.OnBlur with set (v: (unit -> unit)) = x.Attribute "onBlur" v 
    member x.OnChange with set (v: (float -> unit)) = x.Attribute "onChange" v 
    member x.OnFocus with set (v: (unit -> unit)) = x.Attribute "onFocus" v 
    member x.OnHoverChange with set (v: (float -> unit)) = x.Attribute "onHoverChange" v 
    member x.OnKeyDown with set (v: (Event -> unit)) = x.Attribute "onKeyDown" v 