namespace Fable.AntD

open Browser.Types
open Fable.React

type AntInputNumber() =
    inherit AntElement(ofImport "InputNumber" "antd")
    member x.AutoFocus (v: bool) = x.attribute "disabled" v 
    member x.DefaultValue (v: float) = x.attribute "disabled" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Formatter (v: (float -> string)) = x.attribute "disabled" v 
    member x.Max (v: float) = x.attribute "disabled" v 
    member x.Min (v: float) = x.attribute "disabled" v 
    member x.Parser (v: (string -> float)) = x.attribute "disabled" v 
    member x.Precision (v: float) = x.attribute "disabled" v 
    member x.Size (v: Size) = x.attribute "disabled" v 
    member x.Step (v: float) = x.attribute "disabled" v 
    member x.Value (v: float) = x.attribute "disabled" v 
    member x.OnChange (v: (float -> unit)) = x.attribute "disabled" v 
    member x.OnPressEnter (v: (Event -> unit)) = x.attribute "disabled" v 