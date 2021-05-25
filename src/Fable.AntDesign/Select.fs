module Fable.AntDesign.Select

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types
open System

type SelectOptionBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Select.Option" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("key")>] member _.key (x: DSLElement, v: string) = x.attr "key" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: string) = x.attr "title" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v
    [<CustomOperation("className")>] member _.className (x: DSLElement, v: string) = x.attr "className" v

type SelectOptGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Select.OptGroup" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("Key")>] member _.Key (x: DSLElement, v: string) = x.attr "key" v
    [<CustomOperation("Label")>] member _.Label (x: DSLElement, v: ReactElement) = x.attr "label" v

[<StringEnum; RequireQualifiedAccess>]
type SelectMode =
    | Multiple
    | ComboBox
    | [<CompiledName("tags")>] Tag
    | Default

type SelectBuilder<'T>() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Select" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement) = x.attr "allowClear" true
    [<CustomOperation("autoClearSearchValue")>] member _.autoClearSearchValue (x: DSLElement) = x.attr "autoClearSearchValue" true
    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement) = x.attr "autoFocus" true
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true
    [<CustomOperation("clearIcon")>] member _.clearIcon (x: DSLElement, v: ReactElement) = x.attr "clearIcon" v
    [<CustomOperation("defaultActiveFirstOption")>] member _.defaultActiveFirstOption (x: DSLElement) = x.attr "defaultActiveFirstOption" true
    [<CustomOperation("defaultOpen")>] member _.defaultOpen (x: DSLElement) = x.attr "defaultOpen" true
    [<CustomOperation("defaultValues")>] member _.defaultValues (x: DSLElement, v: string array) = x.attr "defaultValue" v
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("dropdownClassName")>] member _.dropdownClassName (x: DSLElement, v: string) = x.attr "dropdownClassName" v
    [<CustomOperation("dropdownMatchSelectWidth")>] member _.dropdownMatchSelectWidth (x: DSLElement, v: bool) = x.attr "dropdownMatchSelectWidth" v
    [<CustomOperation("dropDownRender")>] member _.dropDownRender (x: DSLElement, v: Func<ReactElement, ReactElement>) = x.attr "dropDownRender" v
    [<CustomOperation("dropdownStyle")>] member _.dropdownStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "dropdownStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("filterOption")>] member _.filterOption (x: DSLElement, v: Func<string, 'T, bool>) = x.attr "filterOption" v
    [<CustomOperation("filterSort")>] member _.filterSort (x: DSLElement, v: Func<'T, 'T, int>) = x.attr "filterSort" v
    [<CustomOperation("firstActiveValue")>] member _.firstActiveValue (x: DSLElement, v: string array) = x.attr "firstActiveValue" v
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: ReactElement -> HTMLElement) = x.attr "getPopupContainer" v
    [<CustomOperation("labelInValue")>] member _.labelInValue (x: DSLElement) = x.attr "labelInValue" true
    [<CustomOperation("listHeight")>] member _.listHeight (x: DSLElement, v: int) = x.attr "listHeight" v
    [<CustomOperation("loading")>] member _.loading (x: DSLElement) = x.attr "loading" true
    [<CustomOperation("maxTagCount")>] member _.maxTagCount (x: DSLElement, v: int) = x.attr "maxTagCount" v
    [<CustomOperation("maxTagTextLength")>] member _.maxTagTextLength (x: DSLElement, v: int) = x.attr "maxTagTextLength" v
    [<CustomOperation("maxTagPlaceholder")>] member _.maxTagPlaceholder (x: DSLElement, v: string array -> ReactElement) = x.attr "maxTagPlaceholder" v
    [<CustomOperation("menuItemSelectedIcon")>] member _.menuItemSelectedIcon (x: DSLElement, v: ReactElement) = x.attr "menuItemSelectedIcon" v
    [<CustomOperation("mode")>] member _.mode (x: DSLElement, v: SelectMode) = x.attr "mode" v
    [<CustomOperation("notFoundContent")>] member _.notFoundContent (x: DSLElement, v: string) = x.attr "notFoundContent" v
    [<CustomOperation("isOpen")>] member _.isOpen (x: DSLElement) = x.attr "open" true
    [<CustomOperation("optionFilterProp")>] member _.optionFilterProp (x: DSLElement, v: string) = x.attr "optionFilterProp" v
    [<CustomOperation("optionLabelProp")>] member _.optionLabelProp (x: DSLElement, v: string) = x.attr "optionLabelProp" v
    [<CustomOperation("options")>] member _.options (x: DSLElement, v: 'T array) = x.attr "options" v
    [<CustomOperation("placeholder")>] member _.placeholder (x: DSLElement, v: ReactElement) = x.attr "placeholder" v
    [<CustomOperation("removeIcon")>] member _.removeIcon (x: DSLElement, v: ReactElement) = x.attr "removeIcon" v
    [<CustomOperation("searchValue")>] member _.searchValue (x: DSLElement, v: string) = x.attr "searchValue" v
    [<CustomOperation("showArrow")>] member _.showArrow (x: DSLElement) = x.attr "showArrow" true
    [<CustomOperation("showSearch")>] member _.showSearch (x: DSLElement) = x.attr "showSearch" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("suffixIcon")>] member _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
    [<CustomOperation("tagRender")>] member _.tagRender (x: DSLElement, v: Func<'T, ReactElement>) = x.attr "tagRender" v
    [<CustomOperation("tokenSeparators")>] member _.tokenSeparators (x: DSLElement, v: string array) = x.attr "tokenSeparators" v
    [<CustomOperation("values")>] member _.values (x: DSLElement, v: string array) = x.attr "value" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v
    [<CustomOperation("isVirtual")>] member _.isVirtual (x: DSLElement) = x.attr "virtual" true
    [<CustomOperation("onBlur")>] member _.onBlur (x: DSLElement, v: Event -> unit) = x.attr "onBlur" v
    [<CustomOperation("onChanges")>] member _.onChanges (x: DSLElement, v: string array -> unit) = x.attr "onChange" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
    [<CustomOperation("onDeselect")>] member _.onDeselect (x: DSLElement, v: string -> unit) = x.attr "onDeselect" v
    [<CustomOperation("onDropdownVisibleChange")>] member _.onDropdownVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onDropdownVisibleChange" v
    [<CustomOperation("onFocus")>] member _.onFocus (x: DSLElement, v: Event -> unit) = x.attr "onFocus" v
    [<CustomOperation("onInputKeyDown")>] member _.onInputKeyDown (x: DSLElement, v: KeyboardEvent -> unit) = x.attr "onInputKeyDown" v
    [<CustomOperation("onMouseEnter")>] member _.onMouseEnter (x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseEnter" v
    [<CustomOperation("onMouseLeave")>] member _.onMouseLeave (x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseLeave" v
    [<CustomOperation("onPopupScroll")>] member _.onPopupScroll (x: DSLElement, v: Event -> unit) = x.attr "onPopupScroll" v
    [<CustomOperation("onSearch")>] member _.onSearch (x: DSLElement, v: string -> unit) = x.attr "onSearch" v
    [<CustomOperation("onSelect")>] member _.onSelect (x: DSLElement, v: string -> unit) = x.attr "onSelect" v
