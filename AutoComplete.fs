namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AutoComplete() =
    inherit AntElement(ofImport "AutoComplete" "antd")
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
    member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v 
    member x.Backfill with set (v: bool) = x.Attribute "backfill" v 
    member x.DefaultActiveFirstOption with set (v: bool) = x.Attribute "defaultActiveFirstOption" v 
    member x.DefaultValue with set (v: string array) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.FilterOption with set (v: bool) = x.Attribute "filterOption" v 
    member x.OptionLabelProp with set (v: string) = x.Attribute "optionLabelProp" v 
    member x.Placeholder with set (v: string) = x.Attribute "placeholder" v 
    member x.OnBlur with set (v: (unit -> unit)) = x.Attribute "onBlur" v 
    member x.OnChange with set (v: (string -> unit)) = x.Attribute "onChange" v 
    member x.OnFocus with set (v: (unit -> unit)) = x.Attribute "onFocus" v 
    member x.OnSearch with set (v: (string -> unit)) = x.Attribute "onSearch" v 
    member x.OnSelect with set (v: (string -> obj -> unit)) = x.Attribute "onSelect" v 
    member x.DefaultOpen with set (v: bool) = x.Attribute "defaultOpen" v 
    member x.Open with set (v: bool) = x.Attribute "open" v 
    member x.OnDropdownVisibleChange with set (v: (bool -> unit)) = x.Attribute "onDropdownVisibleChange" v 
    member x.DropdownMenuStyle with set (css: Props.CSSProp list) = x.Attribute "dropdownMenuStyle" (keyValueList CaseRules.LowerFirst css)
