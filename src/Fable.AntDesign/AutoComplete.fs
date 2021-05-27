module Fable.AntDesign.AutoComplete

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System

type AutoCompleteOptionBuilder() =
    inherit ReactBuilder()
    
    member x.Run(s: DSLElement) = createObj s.Attributes
    
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v 
    [<CustomOperation("label")>] member _.label (x: DSLElement, v: ReactElement) = x.attr "label" v    
    [<CustomOperation("options")>] member _.options (x: DSLElement, v: obj array) = x.attr "options" v
    //TODO flatten builder
    
    

type AutoCompleteBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "AutoComplete" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
    [<CustomOperation("backfill")>] member _.backfill (x: DSLElement, v: bool) = x.attr "backfill" v
    [<CustomOperation("defaultActiveFirstOption")>] member _.defaultActiveFirstOption (x: DSLElement, v: bool) = x.attr "defaultActiveFirstOption" v
    [<CustomOperation("defaultOpen")>] member _.defaultOpen (x: DSLElement, v: bool) = x.attr "defaultOpen" v
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("dropdownClassName")>] member _.dropdownClassName (x: DSLElement, v: string) = x.attr "dropdownClassName" v
    [<CustomOperation("dropdownMatchSelectWidth")>] member _.dropdownMatchSelectWidth (x: DSLElement, v: bool) = x.attr "dropdownMatchSelectWidth" v
    [<CustomOperation("filterOption")>] member _.filterOption (x: DSLElement, v: bool) = x.attr "filterOption" v
    [<CustomOperation("notFoundContent")>] member _.notFoundContent (x: DSLElement, v: string) = x.attr "notFoundContent" v
    [<CustomOperation("isOpen")>] member _.isOpen (x: DSLElement, v: bool) = x.attr "open" v
    [<CustomOperation("options")>] member _.options (x: DSLElement, v: obj array) = x.attr "options" v
    [<CustomOperation("placeholder")>] member _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v
    [<CustomOperation("onBlur")>] member _.onBlur (x: DSLElement, v: unit -> unit) = x.attr "onBlur" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
    [<CustomOperation("onDropdownVisibleChange")>] member _.onDropdownVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onDropdownVisibleChange" v
    [<CustomOperation("onFocus")>] member _.onFocus (x: DSLElement, v: unit -> unit) = x.attr "onFocus" v
    [<CustomOperation("onSearch")>] member _.onSearch (x: DSLElement, v: string -> unit) = x.attr "onSearch" v
    [<CustomOperation("onSelect")>] member _.onSelect (x: DSLElement, v: Func<string, obj, unit>) = x.attr "onSelect" v