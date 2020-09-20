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
    inherit AntElement<AntRadio>(defaultArg partialImport (ofImport "Radio" "antd"))
    member x.autoFocus (?v: bool) = x.attribute "autoFocus" (Option.defaultValue true v) 
    member x.checked (?v: bool) = x.attribute "checked" (Option.defaultValue true v) 
    member x.defaultChecked (?v: bool) = x.attribute "defaultChecked" (Option.defaultValue true v) 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.value (v: obj) = x.attribute "value" v 

type AntRadioButton() =
    inherit AntRadio(ofImport "Radio.Button" "antd")

type AntRadioGroup() =
    inherit AntElement<AntRadioGroup>(ofImport "Radio.Group" "antd")
    member x.defaultValue (v: obj) = x.attribute "defaultValue" v 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.name (v: string) = x.attribute "name" v 
    member x.options (v: RadioOption array) = x.attribute "options" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.value (v: obj) = x.attribute "value" v 
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.buttonStyle (v: RadioButtonStyle) = x.attribute "buttonStyle" v 