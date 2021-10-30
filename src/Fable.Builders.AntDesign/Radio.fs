namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop
  
[<AutoOpen>]
module Radio =
  
    type RadioOption = {
        label: string
        value: string
        disabled: bool
    }
    
    [<StringEnum; RequireQualifiedAccess>]
    type RadioButtonStyle = Outline | Solid
    
    type RadioBase<'T>(import) =
        inherit ReactBuilder(import)
    
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v 
        [<CustomOperation("isChecked")>] member inline _.isChecked (x: DSLElement, v: bool) = x.attr "checked" v 
        [<CustomOperation("defaultChecked")>] member inline _.defaultChecked (x: DSLElement, v: bool) = x.attr "defaultChecked" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: 'T) = x.attr "value" v 
    
    type RadioBuilder<'T>() =
        inherit RadioBase<'T>(import "Radio" "antd")
    
    type RadioButtonBuilder<'T>() =
        inherit RadioBase<'T>(import "Radio.Button" "antd")
    
    type RadioGroupBuilder<'T>() =
        inherit ReactBuilder(import "Radio.Group" "antd")
    
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: 'T) = x.attr "defaultValue" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("name")>] member inline _.name (x: DSLElement, v: string) = x.attr "name" v 
        [<CustomOperation("options")>] member inline _.options (x: DSLElement, v: RadioOption array) = x.attr "options" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: 'T) = x.attr "value" v 
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 
        [<CustomOperation("buttonStyle")>] member inline _.buttonStyle (x: DSLElement, v: RadioButtonStyle) = x.attr "buttonStyle" v 