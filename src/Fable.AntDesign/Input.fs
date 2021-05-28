module Fable.AntDesign.Input

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop
open System

type InputBase() =
    inherit ReactBuilder()
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
    inherit InputBase()
    member x.Run(s: DSLElement) = ofImport "Input" "antd" (createObj s.Attributes) s.Children


type AutoSizeType = { minRows: int option; maxRows: int option }

type TextAreaBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Input.TextArea" "antd" (createObj s.Attributes) s.Children

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
    inherit InputBase()
    member x.Run(s: DSLElement) = ofImport "Input.Search" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("showEnterButton")>] member inline _.showEnterButton (x: DSLElement, v: bool) = x.attr "enterButton" v
    [<CustomOperation("enterButton")>] member inline _.enterButton (x: DSLElement, v: ReactElement) = x.attr "enterButton" v
    [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v 
    [<CustomOperation("onSearch")>] member inline _.onSearch (x: DSLElement, v: Func<string, Event, unit>) = x.attr "onSearch" v 

type PasswordBuilder() =
    inherit InputBase()
    member x.Run(s: DSLElement) = ofImport "Input.Password" "antd" (createObj s.Attributes) s.Children
    
    [<CustomOperation("iconRender")>] member inline _.iconRender (x: DSLElement, v: bool -> ReactElement) = x.attr "iconRender" v 
    [<CustomOperation("visibilityToggle")>] member inline _.visibilityToggle (x: DSLElement, v: bool) = x.attr "visibilityToggle" v
    
type InputGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Input.Group" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("compact")>] member inline _.compact (x: DSLElement, v: bool) = x.attr "compact" v 
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 