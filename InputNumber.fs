namespace Fable.AntD

open Browser.Types
open Fable.React

type AntInputNumber() =
    inherit AntElement(ofImport "InputNumber" "antd")
    member x.AutoFocus with set (v: bool) = x.Attribute "disabled" v 
    member x.DefaultValue with set (v: float) = x.Attribute "disabled" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Formatter with set (v: (float -> string)) = x.Attribute "disabled" v 
    member x.Max with set (v: float) = x.Attribute "disabled" v 
    member x.Min with set (v: float) = x.Attribute "disabled" v 
    member x.Parser with set (v: (string -> float)) = x.Attribute "disabled" v 
    member x.Precision with set (v: float) = x.Attribute "disabled" v 
    member x.Size with set (v: Size) = x.Attribute "disabled" v 
    member x.Step with set (v: float) = x.Attribute "disabled" v 
    member x.Value with set (v: float) = x.Attribute "disabled" v 
    member x.OnChange with set (v: (float -> unit)) = x.Attribute "disabled" v 
    member x.OnPressEnter with set (v: (Event -> unit)) = x.Attribute "disabled" v 