namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop
open System

[<AutoOpen>]
module Input =

    type InputBase(import) =
        inherit ReactBuilder(import)
        [<CustomOperation("addonAfter")>] member inline _.addonAfter (x: DSLElement, v: ReactElement) = x.attr "addonAfter" v 
        [<CustomOperation("addonBefore")>] member inline _.addonBefore (x: DSLElement, v: ReactElement) = x.attr "addonBefore" v 
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v 
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("maxLength")>] member inline _.maxLength (x: DSLElement, v: int) = x.attr "maxLength" v 
        [<CustomOperation("prefix")>] member inline _.prefix (x: DSLElement, v: ReactElement) = x.attr "prefix" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
        [<CustomOperation("suffix")>] member inline _.suffix (x: DSLElement, v: ReactElement) = x.attr "suffix" v 
        [<CustomOperation("htmlType")>] member inline _.htmlType (x: DSLElement, v: string) = x.attr "type" v 
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v 
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 
        [<CustomOperation("onPressEnter")>] member inline _.onPressEnter (x: DSLElement, v: Event -> unit) = x.attr "onPressEnter" v 
    
        // Inherited from html input
        [<CustomOperation("tabIndex")>] member inline _.tabIndex (x: DSLElement, v: int) = x.attr "tabIndex" v 
        [<CustomOperation("placeholder")>] member inline _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v 
    
    type InputBuilder() =
        inherit InputBase(import "Input" "antd")
    
    type AutoSizeType = { minRows: int option; maxRows: int option }
    
    type TextAreaBuilder() =
        inherit ReactBuilder(import "Input.TextArea" "antd")
    
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
        [<CustomOperation("autoSize")>] member inline _.autoSize (x: DSLElement, v: bool) = x.attr "autoSize" v
        [<CustomOperation("autoSizeType")>] member inline _.autoSizeType (x: DSLElement, v: AutoSizeType) = x.attr "autoSize" v
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v 
        [<CustomOperation("maxLength")>] member inline _.maxLength (x: DSLElement, v: int) = x.attr "maxLength" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v 
        [<CustomOperation("onPressEnter")>] member inline _.onPressEnter (x: DSLElement, v: KeyboardEvent -> unit) = x.attr "onPressEnter" v 
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 
        [<CustomOperation("onResize")>] member inline _.onResize (x: DSLElement, v: Func<{| width: float; height: float |}, unit>) = x.attr "onResize"  v  
    
    type SearchBuilder() =
        inherit InputBase(import "Input.Search" "antd")
    
        [<CustomOperation("showEnterButton")>] member inline _.showEnterButton (x: DSLElement, v: bool) = x.attr "enterButton" v
        [<CustomOperation("enterButton")>] member inline _.enterButton (x: DSLElement, v: ReactElement) = x.attr "enterButton" v
        [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v 
        [<CustomOperation("onSearch")>] member inline _.onSearch (x: DSLElement, v: Func<string, Event, unit>) = x.attr "onSearch" v 
    
    type PasswordBuilder() =
        inherit InputBase(import "Input.Password" "antd")
        
        [<CustomOperation("iconRender")>] member inline _.iconRender (x: DSLElement, v: bool -> ReactElement) = x.attr "iconRender" v 
        [<CustomOperation("visibilityToggle")>] member inline _.visibilityToggle (x: DSLElement, v: bool) = x.attr "visibilityToggle" v
        
    type InputGroupBuilder() =
        inherit ReactBuilder(import "Input.Group" "antd")
    
        [<CustomOperation("compact")>] member inline _.compact (x: DSLElement, v: bool) = x.attr "compact" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 