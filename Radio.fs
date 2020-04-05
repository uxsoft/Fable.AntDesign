namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React
  
type RadioOption = {
    label: string
    value: string
    disabled: bool
}

[<StringEnum; RequireQualifiedAccess>]
type RadioButtonStyle = Outline | Solid

type Radio(?partialImport) =
    inherit AntElement(defaultArg partialImport (ofImport "Radio" "antd"))
    member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v 
    member x.Checked with set (v: bool) = x.Attribute "checked" v 
    member x.DefaultChecked with set (v: bool) = x.Attribute "defaultChecked" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Value with set (v: obj) = x.Attribute "value" v 

type RadioButton() =
    inherit Radio(ofImport "Radio.Button" "antd")

type RadioGroup() =
    inherit AntElement(ofImport "Radio.Group" "antd")
    member x.DefaultValue with set (v: obj) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Name with set (v: string) = x.Attribute "name" v 
    member x.Options with set (v: RadioOption array) = x.Attribute "options" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.Value with set (v: obj) = x.Attribute "value" v 
    member x.OnChange with set (v: (Event -> unit)) = x.Attribute "onChange" v 
    member x.ButtonStyle with set (v: RadioButtonStyle) = x.Attribute "buttonStyle" v 