namespace Fable.AntD

open Browser.Types
open Fable.React

type Checkbox() =
    inherit AntElement(ofImport "Checkbox" "antd")
    member x.Autofocus with set (v: bool) = x.Attribute "autofocus" v 
    member x.Checked with set (v: bool) = x.Attribute "checked" v 
    member x.DefaultChecked with set (v: bool) = x.Attribute "defaultChecked" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Indeterminate with set (v: bool) = x.Attribute "indeterminate" v 
    member x.OnChange with set (v: (Event -> unit)) = x.Attribute "onChange" v 

type CheckboxGroup() =
    inherit AntElement(ofImport "Checkbox.Group" "antd")
    member x.DefaultValue with set (v: string array) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v  
    member x.Name with set (v: string) = x.Attribute "name" v 
    member x.Options with set (v: string array) = x.Attribute "options" v 
    member x.Value with set (v: string array) = x.Attribute "value" v 
    member x.OnChange with set (v: (bool -> unit)) = x.Attribute "onChange" v 
