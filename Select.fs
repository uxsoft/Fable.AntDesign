namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

type AntSelectOption() =
    inherit AntElement(ofImport "Select.Option" "antd")
    member x.Disabled
        with set (v: bool) = x.Attribute "disabled" v
    member x.Key
        with set (v: string) = x.Attribute "key" v
    member x.Title
        with set (v: string) = x.Attribute "title" v
    member x.Value
        with set (v: string) = x.Attribute "value" v
    member x.ClassName
        with set (v: string) = x.Attribute "className" v

type AntSelectOptGroup() =
    inherit AntElement(ofImport "Select.OptGroup" "antd")
    member x.Key
        with set (v: string) = x.Attribute "key" v
    member x.Label
        with set (v: ReactElement) = x.Attribute "label" v

[<StringEnum; RequireQualifiedAccess>]
type SelectMode =
    | Multiple
    | ComboBox
    | [<CompiledName("tags")>] Tag
    | Default

type AntSelect() =
    inherit AntElement(ofImport "Select" "antd")
    member x.AllowClear
        with set (v: bool) = x.Attribute "allowClear" v
    member x.AutoClearSearchValue
        with set (v: bool) = x.Attribute "autoClearSearchValue" v
    member x.AutoFocus
        with set (v: bool) = x.Attribute "autoFocus" v
    member x.DefaultActiveFirstOption
        with set (v: bool) = x.Attribute "defaultActiveFirstOption" v
    member x.DefaultValue
        with set (v: string) = x.Attribute "defaultValue" v
    member x.Disabled
        with set (v: bool) = x.Attribute "disabled" v
    member x.DropdownClassName
        with set (v: string) = x.Attribute "dropdownClassName" v
    member x.DropdownMatchSelectWidth
        with set (v: bool) = x.Attribute "dropdownMatchSelectWidth" v

    member x.DropDownRender
        with set (v: ReactElement -> obj -> ReactElement) =
            let uncurried = System.Func<ReactElement, obj, ReactElement> v
            x.Attribute "dropDownRender" uncurried

    member x.FilterOption
        with set (v: string -> string -> bool) =
            let uncurried = System.Func<string, string, bool> v
            x.Attribute "filterOption" uncurried
    member x.FirstActiveValue
        with set (v: string array) = x.Attribute "firstActiveValue" v
    member x.GetPopupContainer
        with set (v: ReactElement -> HTMLElement) = x.Attribute "getPopupContainer" v
    member x.LabelInValue
        with set (v: bool) = x.Attribute "labelInValue" v
    member x.MaxTagCount
        with set (v: int) = x.Attribute "maxTagCount" v
    member x.MaxTagTextLength
        with set (v: int) = x.Attribute "maxTagTextLength" v
    member x.MaxTagPlaceholder
        with set (v: string array -> ReactElement) = x.Attribute "maxTagPlaceholder" v
    member x.Mode
        with set (v: SelectMode) = x.Attribute "mode" v
    member x.NotFoundContent
        with set (v: string) = x.Attribute "notFoundContent" v
    member x.OptionFilterProp
        with set (v: string) = x.Attribute "optionFilterProp" v
    member x.OptionLabelProp
        with set (v: string) = x.Attribute "optionLabelProp" v
    member x.Placeholder
        with set (v: ReactElement) = x.Attribute "placeholder" v
    member x.ShowArrow
        with set (v: bool) = x.Attribute "showArrow" v
    member x.ShowSearch
        with set (v: bool) = x.Attribute "showSearch" v
    member x.Size
        with set (v: Size) = x.Attribute "size" v
    member x.SuffixIcon
        with set (v: ReactElement) = x.Attribute "suffixIcon" v
    member x.RemoveIcon
        with set (v: ReactElement) = x.Attribute "removeIcon" v
    member x.ClearIcon
        with set (v: ReactElement) = x.Attribute "clearIcon" v
    member x.MenuItemSelectedIcon
        with set (v: ReactElement) = x.Attribute "menuItemSelectedIcon" v
    member x.TokenSeparators
        with set (v: string array) = x.Attribute "tokenSeparators" v
    member x.Value
        with set (v: string array) = x.Attribute "value" v
    member x.OnBlur
        with set (v: Event -> unit) = x.Attribute "onBlur" v
    member x.OnChange
        with set (v: string array -> unit) = x.Attribute "onChange" v
    member x.OnDeselect
        with set (v: string -> unit) = x.Attribute "onDeselect" v
    member x.OnFocus
        with set (v: Event -> unit) = x.Attribute "onFocus" v
    member x.OnInputKeyDown
        with set (v: KeyboardEvent -> unit) = x.Attribute "onInputKeyDown" v
    member x.OnMouseEnter
        with set (v: MouseEvent -> unit) = x.Attribute "onMouseEnter" v
    member x.OnMouseLeave
        with set (v: MouseEvent -> unit) = x.Attribute "onMouseLeave" v
    member x.OnPopupScroll
        with set (v: Event -> unit) = x.Attribute "onPopupScroll" v
    member x.OnSearch
        with set (v: string -> unit) = x.Attribute "onSearch" v
    member x.OnSelect
        with set (v: string -> unit) = x.Attribute "onSelect" v
    member x.DefaultOpen
        with set (v: bool) = x.Attribute "defaultOpen" v
    member x.Open
        with set (v: bool) = x.Attribute "open" v
    member x.OnDropdownVisibleChange
        with set (v: bool -> unit) = x.Attribute "onDropdownVisibleChange" v
    member x.Loading
        with set (v: bool) = x.Attribute "loading" v
    member x.DropdownStyle(css: Props.CSSProp list) =
        x.Attribute "dropdownStyle" (keyValueList CaseRules.LowerFirst css)
    member x.DropdownMenuStyle(css: Props.CSSProp list) =
        x.Attribute "dropdownMenuStyle" (keyValueList CaseRules.LowerFirst css)
