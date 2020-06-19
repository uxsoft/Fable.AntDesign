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

type AntRadio(?partialImport) =
    inherit AntElement(defaultArg partialImport (ofImport "Radio" "antd"))
    member x.AutoFocus (v: bool) = x.attribute "autoFocus" v 
    member x.Checked (v: bool) = x.attribute "checked" v 
    member x.DefaultChecked (v: bool) = x.attribute "defaultChecked" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Value (v: obj) = x.attribute "value" v 

type AntRadioButton() =
    inherit AntRadio(ofImport "Radio.Button" "antd")

type AntRadioGroup() =
    inherit AntElement(ofImport "Radio.Group" "antd")
    member x.DefaultValue (v: obj) = x.attribute "defaultValue" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Name (v: string) = x.attribute "name" v 
    member x.Options (v: RadioOption array) = x.attribute "options" v 
    member x.Size (v: Size) = x.attribute "size" v 
    member x.Value (v: obj) = x.attribute "value" v 
    member x.OnChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.ButtonStyle (v: RadioButtonStyle) = x.attribute "buttonStyle" v 