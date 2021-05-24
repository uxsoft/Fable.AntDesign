module Fable.AntD.Builders.Radio

open Browser.Types
open Fable.AntD.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop
  
type RadioOption = {
    label: string
    value: string
    disabled: bool
}

[<StringEnum; RequireQualifiedAccess>]
type RadioButtonStyle = Outline | Solid

type RadioBase() =
    inherit ReactBuilder()

    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement) = x.attr "autoFocus" true 
    [<CustomOperation("isChecked")>] member _.isChecked (x: DSLElement) = x.attr "checked" true 
    [<CustomOperation("defaultChecked")>] member _.defaultChecked (x: DSLElement) = x.attr "defaultChecked" true 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: obj) = x.attr "value" v 

type RadioBuilder() =
    inherit RadioBase()
    member x.Run(s: DSLElement) = ofImport "Radio" "antd" (createObj s.Attributes) s.Children

type RadioButtonBuilder() =
    inherit RadioBase()
    member x.Run(s: DSLElement) = ofImport "Radio.Button" "antd" (createObj s.Attributes) s.Children

type RadioGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Radio.Group" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: obj) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true 
    [<CustomOperation("name")>] member _.name (x: DSLElement, v: string) = x.attr "name" v 
    [<CustomOperation("options")>] member _.options (x: DSLElement, v: RadioOption array) = x.attr "options" v 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: obj) = x.attr "value" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: (Event -> unit)) = x.attr "onChange" v 
    [<CustomOperation("buttonStyle")>] member _.buttonStyle (x: DSLElement, v: RadioButtonStyle) = x.attr "buttonStyle" v 