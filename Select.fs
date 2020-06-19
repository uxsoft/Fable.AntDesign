namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types
open System

type AntSelectOption() =
    inherit AntElement<AntSelectOption>(ofImport "Select.Option" "antd")
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.key (v: string) = x.attribute "key" v
    member x.title (v: string) = x.attribute "title" v
    member x.value (v: string) = x.attribute "value" v
    member x.className (v: string) = x.attribute "className" v

type AntSelectOptGroup() =
    inherit AntElement<AntSelectOptGroup>(ofImport "Select.OptGroup" "antd")
    member x.Key (v: string) = x.attribute "key" v
    member x.Label (v: ReactElement) = x.attribute "label" v

[<StringEnum; RequireQualifiedAccess>]
type SelectMode =
    | Multiple
    | ComboBox
    | [<CompiledName("tags")>] Tag
    | Default

type AntSelect() =
    inherit AntElement<AntSelect>(ofImport "Select" "antd")
    member x.allowClear (v: bool) = x.attribute "allowClear" v
    member x.autoClearSearchValue (v: bool) = x.attribute "autoClearSearchValue" v
    member x.autoFocus (v: bool) = x.attribute "autoFocus" v
    member x.defaultActiveFirstOption (v: bool) = x.attribute "defaultActiveFirstOption" v
    member x.defaultValue (v: string) = x.attribute "defaultValue" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.dropdownClassName (v: string) = x.attribute "dropdownClassName" v
    member x.dropdownMatchSelectWidth (v: bool) = x.attribute "dropdownMatchSelectWidth" v
    member x.dropDownRender (v: Func<ReactElement, obj, ReactElement>) = x.attribute "dropDownRender" v
    member x.filterOption (v: Func<string, string, bool>) = x.attribute "filterOption" v
    member x.firstActiveValue (v: string array) = x.attribute "firstActiveValue" v
    member x.getPopupContainer (v: ReactElement -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.labelInValue (v: bool) = x.attribute "labelInValue" v
    member x.maxTagCount (v: int) = x.attribute "maxTagCount" v
    member x.maxTagTextLength (v: int) = x.attribute "maxTagTextLength" v
    member x.maxTagPlaceholder (v: string array -> ReactElement) = x.attribute "maxTagPlaceholder" v
    member x.mode (v: SelectMode) = x.attribute "mode" v
    member x.notFoundContent (v: string) = x.attribute "notFoundContent" v
    member x.optionFilterProp (v: string) = x.attribute "optionFilterProp" v
    member x.optionLabelProp (v: string) = x.attribute "optionLabelProp" v
    member x.placeholder (v: ReactElement) = x.attribute "placeholder" v
    member x.showArrow (v: bool) = x.attribute "showArrow" v
    member x.showSearch (v: bool) = x.attribute "showSearch" v
    member x.size (v: Size) = x.attribute "size" v
    member x.suffixIcon (v: ReactElement) = x.attribute "suffixIcon" v
    member x.removeIcon (v: ReactElement) = x.attribute "removeIcon" v
    member x.clearIcon (v: ReactElement) = x.attribute "clearIcon" v
    member x.menuItemSelectedIcon (v: ReactElement) = x.attribute "menuItemSelectedIcon" v
    member x.tokenSeparators (v: string array) = x.attribute "tokenSeparators" v
    member x.value (v: string array) = x.attribute "value" v
    member x.onBlur (v: Event -> unit) = x.attribute "onBlur" v
    member x.onChange (v: string array -> unit) = x.attribute "onChange" v
    member x.onDeselect (v: string -> unit) = x.attribute "onDeselect" v
    member x.onFocus (v: Event -> unit) = x.attribute "onFocus" v
    member x.onInputKeyDown (v: KeyboardEvent -> unit) = x.attribute "onInputKeyDown" v
    member x.onMouseEnter (v: MouseEvent -> unit) = x.attribute "onMouseEnter" v
    member x.onMouseLeave (v: MouseEvent -> unit) = x.attribute "onMouseLeave" v
    member x.onPopupScroll (v: Event -> unit) = x.attribute "onPopupScroll" v
    member x.onSearch (v: string -> unit) = x.attribute "onSearch" v
    member x.onSelect (v: string -> unit) = x.attribute "onSelect" v
    member x.defaultOpen (v: bool) = x.attribute "defaultOpen" v
    member x.isOpen (v: bool) = x.attribute "open" v
    member x.onDropdownVisibleChange (v: bool -> unit) = x.attribute "onDropdownVisibleChange" v
    member x.loading (v: bool) = x.attribute "loading" v
    member x.dropdownStyle(css: Props.CSSProp list) = x.attribute "dropdownStyle" (keyValueList CaseRules.LowerFirst css)
    member x.dropdownMenuStyle(css: Props.CSSProp list) = x.attribute "dropdownMenuStyle" (keyValueList CaseRules.LowerFirst css)
