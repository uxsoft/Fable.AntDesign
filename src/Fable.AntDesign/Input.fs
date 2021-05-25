module Fable.AntDesign.Input

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop
open System

type InputBase() =
    inherit ReactBuilder()
    [<CustomOperation("addonAfter")>] member _.addonAfter (x: DSLElement, v: ReactElement) = x.attr "addonAfter" v 
    [<CustomOperation("addonBefore")>] member _.addonBefore (x: DSLElement, v: ReactElement) = x.attr "addonBefore" v 
    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement) = x.attr "allowClear" true 
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true 
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true 
    [<CustomOperation("maxLength")>] member _.maxLength (x: DSLElement, v: int) = x.attr "maxLength" v 
    [<CustomOperation("prefix")>] member _.prefix (x: DSLElement, v: ReactElement) = x.attr "prefix" v 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("suffix")>] member _.suffix (x: DSLElement, v: ReactElement) = x.attr "suffix" v 
    [<CustomOperation("htmlType")>] member _.htmlType (x: DSLElement, v: string) = x.attr "type" v 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 
    [<CustomOperation("onPressEnter")>] member _.onPressEnter (x: DSLElement, v: Event -> unit) = x.attr "onPressEnter" v 

    // Inherited from html input
    [<CustomOperation("tabIndex")>] member _.tabIndex (x: DSLElement, v: int) = x.attr "tabIndex" v 
    [<CustomOperation("placeholder")>] member _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v 

type InputBuilder() =
    inherit InputBase()
    member x.Run(s: DSLElement) = ofImport "Input" "antd" (createObj s.Attributes) s.Children


type AutoSizeType = { minRows: int option; maxRows: int option }

type TextAreaBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Input.TextArea" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement) = x.attr "allowClear" true
    [<CustomOperation("autoSize")>] member _.autoSize (x: DSLElement) = x.attr "autoSize" true
    [<CustomOperation("autoSizeType")>] member _.autoSizeType (x: DSLElement, v: AutoSizeType) = x.attr "autoSize" v
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v 
    [<CustomOperation("maxLength")>] member _.maxLength (x: DSLElement, v: int) = x.attr "maxLength" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v 
    [<CustomOperation("onPressEnter")>] member _.onPressEnter (x: DSLElement, v: KeyboardEvent -> unit) = x.attr "onPressEnter" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 
    [<CustomOperation("onResize")>] member _.onResize (x: DSLElement, v: Func<{| width: float; height: float |}, unit>) = x.attr "onResize"  v  

type SearchBuilder() =
    inherit InputBase()
    member x.Run(s: DSLElement) = ofImport "Input.Search" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("showEnterButton")>] member _.showEnterButton (x: DSLElement) = x.attr "enterButton" true
    [<CustomOperation("enterButton")>] member _.enterButton (x: DSLElement, v: ReactElement) = x.attr "enterButton" v
    [<CustomOperation("loading")>] member _.loading (x: DSLElement) = x.attr "loading" true 
    [<CustomOperation("onSearch")>] member _.onSearch (x: DSLElement, v: Func<string, Event, unit>) = x.attr "onSearch" v 

type PasswordBuilder() =
    inherit InputBase()
    member x.Run(s: DSLElement) = ofImport "Input.Password" "antd" (createObj s.Attributes) s.Children
    
    [<CustomOperation("iconRender")>] member _.iconRender (x: DSLElement, v: bool -> ReactElement) = x.attr "iconRender" v 
    [<CustomOperation("visibilityToggle")>] member _.visibilityToggle (x: DSLElement) = x.attr "visibilityToggle" true
    
type InputGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Input.Group" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("compact")>] member _.compact (x: DSLElement) = x.attr "compact" true 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 