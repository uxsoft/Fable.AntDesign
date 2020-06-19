namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

type AntSelectOption() =
    inherit AntElement(ofImport "Select.Option" "antd")
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.Key
        (v: string) = x.attribute "key" v
    member x.Title
        (v: string) = x.attribute "title" v
    member x.Value
        (v: string) = x.attribute "value" v
    member x.ClassName
        (v: string) = x.attribute "className" v

type AntSelectOptGroup() =
    inherit AntElement(ofImport "Select.OptGroup" "antd")
    member x.Key
        (v: string) = x.attribute "key" v
    member x.Label
        (v: ReactElement) = x.attribute "label" v

[<StringEnum; RequireQualifiedAccess>]
type SelectMode =
    | Multiple
    | ComboBox
    | [<CompiledName("tags")>] Tag
    | Default

type AntSelect() =
    inherit AntElement(ofImport "Select" "antd")
    member x.AllowClear
        (v: bool) = x.attribute "allowClear" v
    member x.AutoClearSearchValue
        (v: bool) = x.attribute "autoClearSearchValue" v
    member x.AutoFocus
        (v: bool) = x.attribute "autoFocus" v
    member x.DefaultActiveFirstOption
        (v: bool) = x.attribute "defaultActiveFirstOption" v
    member x.DefaultValue
        (v: string) = x.attribute "defaultValue" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.DropdownClassName
        (v: string) = x.attribute "dropdownClassName" v
    member x.DropdownMatchSelectWidth
        (v: bool) = x.attribute "dropdownMatchSelectWidth" v

    member x.DropDownRender
        (v: ReactElement -> obj -> ReactElement) =
            let uncurried = System.Func<ReactElement, obj, ReactElement> v
            x.attribute "dropDownRender" uncurried

    member x.FilterOption
        (v: string -> string -> bool) =
            let uncurried = System.Func<string, string, bool> v
            x.attribute "filterOption" uncurried
    member x.FirstActiveValue
        (v: string array) = x.attribute "firstActiveValue" v
    member x.GetPopupContainer
        (v: ReactElement -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.LabelInValue
        (v: bool) = x.attribute "labelInValue" v
    member x.MaxTagCount
        (v: int) = x.attribute "maxTagCount" v
    member x.MaxTagTextLength
        (v: int) = x.attribute "maxTagTextLength" v
    member x.MaxTagPlaceholder
        (v: string array -> ReactElement) = x.attribute "maxTagPlaceholder" v
    member x.Mode
        (v: SelectMode) = x.attribute "mode" v
    member x.NotFoundContent
        (v: string) = x.attribute "notFoundContent" v
    member x.OptionFilterProp
        (v: string) = x.attribute "optionFilterProp" v
    member x.OptionLabelProp
        (v: string) = x.attribute "optionLabelProp" v
    member x.Placeholder
        (v: ReactElement) = x.attribute "placeholder" v
    member x.ShowArrow
        (v: bool) = x.attribute "showArrow" v
    member x.ShowSearch
        (v: bool) = x.attribute "showSearch" v
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.SuffixIcon
        (v: ReactElement) = x.attribute "suffixIcon" v
    member x.RemoveIcon
        (v: ReactElement) = x.attribute "removeIcon" v
    member x.ClearIcon
        (v: ReactElement) = x.attribute "clearIcon" v
    member x.MenuItemSelectedIcon
        (v: ReactElement) = x.attribute "menuItemSelectedIcon" v
    member x.TokenSeparators
        (v: string array) = x.attribute "tokenSeparators" v
    member x.Value
        (v: string array) = x.attribute "value" v
    member x.OnBlur
        (v: Event -> unit) = x.attribute "onBlur" v
    member x.OnChange
        (v: string array -> unit) = x.attribute "onChange" v
    member x.OnDeselect
        (v: string -> unit) = x.attribute "onDeselect" v
    member x.OnFocus
        (v: Event -> unit) = x.attribute "onFocus" v
    member x.OnInputKeyDown
        (v: KeyboardEvent -> unit) = x.attribute "onInputKeyDown" v
    member x.OnMouseEnter
        (v: MouseEvent -> unit) = x.attribute "onMouseEnter" v
    member x.OnMouseLeave
        (v: MouseEvent -> unit) = x.attribute "onMouseLeave" v
    member x.OnPopupScroll
        (v: Event -> unit) = x.attribute "onPopupScroll" v
    member x.OnSearch
        (v: string -> unit) = x.attribute "onSearch" v
    member x.OnSelect
        (v: string -> unit) = x.attribute "onSelect" v
    member x.DefaultOpen
        (v: bool) = x.attribute "defaultOpen" v
    member x.Open
        (v: bool) = x.attribute "open" v
    member x.OnDropdownVisibleChange
        (v: bool -> unit) = x.attribute "onDropdownVisibleChange" v
    member x.Loading
        (v: bool) = x.attribute "loading" v
    member x.DropdownStyle(css: Props.CSSProp list) =
        x.attribute "dropdownStyle" (keyValueList CaseRules.LowerFirst css)
    member x.DropdownMenuStyle(css: Props.CSSProp list) =
        x.attribute "dropdownMenuStyle" (keyValueList CaseRules.LowerFirst css)
