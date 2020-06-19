namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System

type AntAutoCompleteOption = {
    label: ReactElement
    value: string
}

type AntAutoComplete() =
    inherit AntElement<AntAutoComplete>(ofImport "AutoComplete" "antd")
    member x.options (v: AntAutoCompleteOption array) = x.attribute "options" v
    member x.allowClear (v: bool) = x.attribute "allowClear" v
    member x.autoFocus (v: bool) = x.attribute "autoFocus" v
    member x.backfill (v: bool) = x.attribute "backfill" v
    member x.defaultActiveFirstOption (v: bool) = x.attribute "defaultActiveFirstOption" v
    member x.defaultValue (v: string array) = x.attribute "defaultValue" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.filterOption (v: bool) = x.attribute "filterOption" v
    member x.optionLabelProp (v: string) = x.attribute "optionLabelProp" v
    member x.placeholder (v: string) = x.attribute "placeholder" v
    member x.onBlur (v: unit -> unit) = x.attribute "onBlur" v
    member x.onChange (v: string -> unit) = x.attribute "onChange" v
    member x.onFocus (v: unit -> unit) = x.attribute "onFocus" v
    member x.onSearch (v: string -> unit) = x.attribute "onSearch" v
    member x.onSelect (v: Func<string, obj, unit>) = x.attribute "onSelect" v
    member x.defaultOpen (v: bool) = x.attribute "defaultOpen" v
    member x.isOpen (v: bool) = x.attribute "open" v
    member x.onDropdownVisibleChange (v: bool -> unit) = x.attribute "onDropdownVisibleChange" v
    member x.dropdownMenuStyle (css: Props.CSSProp list) = x.attribute "dropdownMenuStyle" (keyValueList CaseRules.LowerFirst css)
    member x.notFoundContent (v: string) = x.attribute "notFoundContent" v