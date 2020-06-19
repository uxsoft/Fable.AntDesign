namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntAutoComplete() =
    inherit AntElement<AntAutoComplete>(ofImport "AutoComplete" "antd")
    member x.AllowClear (v: bool) = x.attribute "allowClear" v
    member x.AutoFocus (v: bool) = x.attribute "autoFocus" v
    member x.Backfill (v: bool) = x.attribute "backfill" v
    member x.DefaultActiveFirstOption (v: bool) = x.attribute "defaultActiveFirstOption" v
    member x.DefaultValue (v: string array) = x.attribute "defaultValue" v
    member x.Disabled (v: bool) = x.attribute "disabled" v
    member x.FilterOption (v: bool) = x.attribute "filterOption" v
    member x.OptionLabelProp (v: string) = x.attribute "optionLabelProp" v
    member x.Placeholder (v: string) = x.attribute "placeholder" v
    member x.OnBlur (v: unit -> unit) = x.attribute "onBlur" v
    member x.OnChange (v: string -> unit) = x.attribute "onChange" v
    member x.OnFocus
        (v: unit -> unit) = x.attribute "onFocus" v
    member x.OnSearch
        (v: string -> unit) = x.attribute "onSearch" v
    member x.OnSelect
        (v: string -> obj -> unit) =
            let uncurried = System.Func<string, obj, unit> v
            x.attribute "onSelect" uncurried
    member x.DefaultOpen
        (v: bool) = x.attribute "defaultOpen" v
    member x.Open
        (v: bool) = x.attribute "open" v
    member x.OnDropdownVisibleChange
        (v: bool -> unit) = x.attribute "onDropdownVisibleChange" v
    member x.DropdownMenuStyle
        (css: Props.CSSProp list) = x.attribute "dropdownMenuStyle" (keyValueList CaseRules.LowerFirst css)
