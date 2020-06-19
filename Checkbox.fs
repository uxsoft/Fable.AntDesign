namespace Fable.AntD

open Browser.Types
open Fable.React

type AntCheckbox() =
    inherit AntElement(ofImport "Checkbox" "antd")
    member x.Autofocus (v: bool) = x.attribute "autofocus" v 
    member x.Checked (v: bool) = x.attribute "checked" v 
    member x.DefaultChecked (v: bool) = x.attribute "defaultChecked" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Indeterminate (v: bool) = x.attribute "indeterminate" v 
    member x.OnChange (v: (Event -> unit)) = x.attribute "onChange" v 

type AntCheckboxGroup() =
    inherit AntElement(ofImport "Checkbox.Group" "antd")
    member x.DefaultValue (v: string array) = x.attribute "defaultValue" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v  
    member x.Name (v: string) = x.attribute "name" v 
    member x.Options (v: string array) = x.attribute "options" v 
    member x.Value (v: string array) = x.attribute "value" v 
    member x.OnChange (v: (bool -> unit)) = x.attribute "onChange" v 
