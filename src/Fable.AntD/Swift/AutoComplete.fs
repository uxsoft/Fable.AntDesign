namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System

type AntAutoCompleteOption() =
    inherit AntObject<AntAutoCompleteOption>()
    member x.value (v: string) = x.attribute "value" v 
    member x.label (v: ReactElement) = x.attribute "label" v    
    member x.options (v: AntAutoCompleteOption array) = x.attribute "options" (v |> Array.map (fun i -> i.JSON))

type AntAutoComplete() =
    inherit AntElement<AntAutoComplete>(ofImport "AutoComplete" "antd")
    member x.allowClear (?v: bool) = x.attribute "allowClear" (Option.defaultValue true v)
    member x.autoFocus (?v: bool) = x.attribute "autoFocus" (Option.defaultValue true v)
    member x.backfill (?v: bool) = x.attribute "backfill" (Option.defaultValue true v)
    member x.defaultActiveFirstOption (?v: bool) = x.attribute "defaultActiveFirstOption" (Option.defaultValue true v)
    member x.defaultOpen (?v: bool) = x.attribute "defaultOpen" (Option.defaultValue true v)
    member x.defaultValue (v: string array) = x.attribute "defaultValue" v
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.dropdownClassName (v: string) = x.attribute "dropdownClassName" v
    member x.dropdownMatchSelectWidth (?v: bool) = x.attribute "dropdownMatchSelectWidth" (Option.defaultValue true v)
    member x.filterOption (?v: bool) = x.attribute "filterOption" (Option.defaultValue true v)
    member x.notFoundContent (v: string) = x.attribute "notFoundContent" v
    member x.isOpen (?v: bool) = x.attribute "open" (Option.defaultValue true v)
    member x.options (v: AntAutoCompleteOption array) = x.attribute "options" (v |> Array.map (fun i -> i.JSON))
    member x.placeholder (v: string) = x.attribute "placeholder" v
    member x.value (v: string) = x.attribute "value" v
    member x.onBlur (v: unit -> unit) = x.attribute "onBlur" v
    member x.onChange (v: string -> unit) = x.attribute "onChange" v
    member x.onDropdownVisibleChange (v: bool -> unit) = x.attribute "onDropdownVisibleChange" v
    member x.onFocus (v: unit -> unit) = x.attribute "onFocus" v
    member x.onSearch (v: string -> unit) = x.attribute "onSearch" v
    member x.onSelect (v: Func<string, obj, unit>) = x.attribute "onSelect" v