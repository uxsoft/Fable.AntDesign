namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser.Types
open System

[<AutoOpen>]
module Select = 

    type SelectOptionBuilder() =
        inherit ReactBuilder(import "Select.Option" "antd")
    
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("key")>] member inline _.key (x: DSLElement, v: string) = x.attr "key" v
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: string) = x.attr "title" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v
    
    type SelectOptGroupBuilder() =
        inherit ReactBuilder(import "Select.OptGroup" "antd")
    
        [<CustomOperation("key")>] member inline _.key (x: DSLElement, v: string) = x.attr "key" v
        [<CustomOperation("label")>] member inline _.label (x: DSLElement, v: ReactElement) = x.attr "label" v
    
    [<StringEnum; RequireQualifiedAccess>]
    type SelectMode =
        | Multiple
        | ComboBox
        | [<CompiledName("tags")>] Tag
        | Default
    
    type SelectBuilder<'T>() =
        inherit ReactBuilder(import "Select" "antd")
    
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
        [<CustomOperation("autoClearSearchValue")>] member inline _.autoClearSearchValue (x: DSLElement, v: bool) = x.attr "autoClearSearchValue" v
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
        [<CustomOperation("clearIcon")>] member inline _.clearIcon (x: DSLElement, v: ReactElement) = x.attr "clearIcon" v
        [<CustomOperation("defaultActiveFirstOption")>] member inline _.defaultActiveFirstOption (x: DSLElement, v: bool) = x.attr "defaultActiveFirstOption" v
        [<CustomOperation("defaultOpen")>] member inline _.defaultOpen (x: DSLElement, v: bool) = x.attr "defaultOpen" v
        [<CustomOperation("defaultValues")>] member inline _.defaultValues (x: DSLElement, v: string array) = x.attr "defaultValue" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("dropdownClassName")>] member inline _.dropdownClassName (x: DSLElement, v: string) = x.attr "dropdownClassName" v
        [<CustomOperation("dropdownMatchSelectWidth")>] member inline _.dropdownMatchSelectWidth (x: DSLElement, v: bool) = x.attr "dropdownMatchSelectWidth" v
        [<CustomOperation("dropDownRender")>] member inline _.dropDownRender (x: DSLElement, v: Func<ReactElement, ReactElement>) = x.attr "dropDownRender" v
        [<CustomOperation("dropdownStyle")>] member inline _.dropdownStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "dropdownStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("fieldNames")>] member inline _.fieldNames (x: DSLElement, v: {| label: string; key: string; options: string |}) = x.attr "fieldNames" v
        [<CustomOperation("filterOption")>] member inline _.filterOption (x: DSLElement, v: Func<string, 'T, bool>) = x.attr "filterOption" v
        [<CustomOperation("filterSort")>] member inline _.filterSort (x: DSLElement, v: Func<'T, 'T, int>) = x.attr "filterSort" v
        [<CustomOperation("firstActiveValue")>] member inline _.firstActiveValue (x: DSLElement, v: string array) = x.attr "firstActiveValue" v
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: ReactElement -> HTMLElement) = x.attr "getPopupContainer" v
        [<CustomOperation("labelInValue")>] member inline _.labelInValue (x: DSLElement, v: bool) = x.attr "labelInValue" v
        [<CustomOperation("listHeight")>] member inline _.listHeight (x: DSLElement, v: int) = x.attr "listHeight" v
        [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v
        [<CustomOperation("maxTagCount")>] member inline _.maxTagCount (x: DSLElement, v: int) = x.attr "maxTagCount" v
        [<CustomOperation("maxTagPlaceholder")>] member inline _.maxTagPlaceholder (x: DSLElement, v: string array -> ReactElement) = x.attr "maxTagPlaceholder" v
        [<CustomOperation("maxTagTextLength")>] member inline _.maxTagTextLength (x: DSLElement, v: int) = x.attr "maxTagTextLength" v
        [<CustomOperation("menuItemSelectedIcon")>] member inline _.menuItemSelectedIcon (x: DSLElement, v: ReactElement) = x.attr "menuItemSelectedIcon" v
        [<CustomOperation("mode")>] member inline _.mode (x: DSLElement, v: SelectMode) = x.attr "mode" v
        [<CustomOperation("notFoundContent")>] member inline _.notFoundContent (x: DSLElement, v: string) = x.attr "notFoundContent" v
        [<CustomOperation("isOpen")>] member inline _.isOpen (x: DSLElement, v: bool) = x.attr "open" v
        [<CustomOperation("optionFilterProp")>] member inline _.optionFilterProp (x: DSLElement, v: string) = x.attr "optionFilterProp" v
        [<CustomOperation("optionLabelProp")>] member inline _.optionLabelProp (x: DSLElement, v: string) = x.attr "optionLabelProp" v
        [<CustomOperation("options")>] member inline _.options (x: DSLElement, v: 'T array) = x.attr "options" v
        [<CustomOperation("placeholder")>] member inline _.placeholder (x: DSLElement, v: ReactElement) = x.attr "placeholder" v
        [<CustomOperation("removeIcon")>] member inline _.removeIcon (x: DSLElement, v: ReactElement) = x.attr "removeIcon" v
        [<CustomOperation("searchValue")>] member inline _.searchValue (x: DSLElement, v: string) = x.attr "searchValue" v
        [<CustomOperation("showArrow")>] member inline _.showArrow (x: DSLElement, v: bool) = x.attr "showArrow" v
        [<CustomOperation("showSearch")>] member inline _.showSearch (x: DSLElement, v: bool) = x.attr "showSearch" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("suffixIcon")>] member inline _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
        [<CustomOperation("tagRender")>] member inline _.tagRender (x: DSLElement, v: Func<'T, ReactElement>) = x.attr "tagRender" v
        [<CustomOperation("tokenSeparators")>] member inline _.tokenSeparators (x: DSLElement, v: string array) = x.attr "tokenSeparators" v
        [<CustomOperation("values")>] member inline _.values (x: DSLElement, v: string array) = x.attr "value" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v
        [<CustomOperation("isVirtual")>] member inline _.isVirtual (x: DSLElement, v: bool) = x.attr "virtual" v
        [<CustomOperation("onBlur")>] member inline _.onBlur (x: DSLElement, v: Event -> unit) = x.attr "onBlur" v
        [<CustomOperation("onChanges")>] member inline _.onChanges (x: DSLElement, v: string array -> unit) = x.attr "onChange" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
        [<CustomOperation("onDeselect")>] member inline _.onDeselect (x: DSLElement, v: string -> unit) = x.attr "onDeselect" v
        [<CustomOperation("onDropdownVisibleChange")>] member inline _.onDropdownVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onDropdownVisibleChange" v
        [<CustomOperation("onFocus")>] member inline _.onFocus (x: DSLElement, v: Event -> unit) = x.attr "onFocus" v
        [<CustomOperation("onInputKeyDown")>] member inline _.onInputKeyDown (x: DSLElement, v: KeyboardEvent -> unit) = x.attr "onInputKeyDown" v
        [<CustomOperation("onMouseEnter")>] member inline _.onMouseEnter (x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseEnter" v
        [<CustomOperation("onMouseLeave")>] member inline _.onMouseLeave (x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseLeave" v
        [<CustomOperation("onPopupScroll")>] member inline _.onPopupScroll (x: DSLElement, v: Event -> unit) = x.attr "onPopupScroll" v
        [<CustomOperation("onSearch")>] member inline _.onSearch (x: DSLElement, v: string -> unit) = x.attr "onSearch" v
        [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, v: string -> unit) = x.attr "onSelect" v
    