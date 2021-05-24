module Fable.AntD.Builders.Checkbox

open Browser.Types
open Fable.AntD.Builders.Common
open Fable.React
open Fable.Core.JsInterop

type CheckboxBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Checkbox" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autofocus")>] member _.autofocus (x: DSLElement) = x.attr "autofocus" true 
    [<CustomOperation("isChecked")>] member _.isChecked (x: DSLElement) = x.attr "checked" true 
    [<CustomOperation("defaultChecked")>] member _.defaultChecked (x: DSLElement) = x.attr "defaultChecked" true 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true 
    [<CustomOperation("indeterminate")>] member _.indeterminate (x: DSLElement) = x.attr "indeterminate" true 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 

type CheckboxGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Checkbox.Group" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true  
    [<CustomOperation("name")>] member _.name (x: DSLElement, v: string) = x.attr "name" v 
    [<CustomOperation("options")>] member _.options (x: DSLElement, v: string array) = x.attr "options" v 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string array) = x.attr "value" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: bool -> unit) = x.attr "onChange" v 
