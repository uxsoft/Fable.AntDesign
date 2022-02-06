namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System

[<AutoOpen>]
module AutoComplete =

    type AutoCompleteOptionBuilder<'T>() =
        inherit ReactBuilder()
        
        member x.Run(s: DSLElement) = createObj s.Attributes
        
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v 
        [<CustomOperation("label")>] member inline _.label (x: DSLElement, v: ReactElement) = x.attr "label" v    
        [<CustomOperation("options")>] member inline _.options (x: DSLElement, v: 'T array) = x.attr "options" v
        //TODO flatten builder
        
        
    
    type AutoCompleteBuilder<'T>() =
        inherit ReactBuilder(import "AutoComplete" "antd")
    
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
        [<CustomOperation("backfill")>] member inline _.backfill (x: DSLElement, v: bool) = x.attr "backfill" v
        [<CustomOperation("defaultActiveFirstOption")>] member inline _.defaultActiveFirstOption (x: DSLElement, v: bool) = x.attr "defaultActiveFirstOption" v
        [<CustomOperation("defaultOpen")>] member inline _.defaultOpen (x: DSLElement, v: bool) = x.attr "defaultOpen" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("dropdownClassName")>] member inline _.dropdownClassName (x: DSLElement, v: string) = x.attr "dropdownClassName" v
        [<CustomOperation("dropdownMatchSelectWidth")>] member inline _.dropdownMatchSelectWidth (x: DSLElement, v: bool) = x.attr "dropdownMatchSelectWidth" v
        [<CustomOperation("filterOption")>] member inline _.filterOption (x: DSLElement, v: bool) = x.attr "filterOption" v
        [<CustomOperation("notFoundContent")>] member inline _.notFoundContent (x: DSLElement, v: string) = x.attr "notFoundContent" v
        [<CustomOperation("isOpen")>] member inline _.isOpen (x: DSLElement, v: bool) = x.attr "open" v
        [<CustomOperation("options")>] member inline _.options (x: DSLElement, v: 'T array) = x.attr "options" v
        [<CustomOperation("placeholder")>] member inline _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v
        [<CustomOperation("onBlur")>] member inline _.onBlur (x: DSLElement, v: unit -> unit) = x.attr "onBlur" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
        [<CustomOperation("onDropdownVisibleChange")>] member inline _.onDropdownVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onDropdownVisibleChange" v
        [<CustomOperation("onFocus")>] member inline _.onFocus (x: DSLElement, v: unit -> unit) = x.attr "onFocus" v
        [<CustomOperation("onSearch")>] member inline _.onSearch (x: DSLElement, v: string -> unit) = x.attr "onSearch" v
        [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, v: Func<string, 'T, unit>) = x.attr "onSelect" v