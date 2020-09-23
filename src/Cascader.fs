namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React
open System

[<StringEnum; RequireQualifiedAccess>]
type ExpandTriggerOptions =
    | Click
    | Hover

[<StringEnum; RequireQualifiedAccess>]
type PopupPlacementOptions =
    | BottomLeft
    | BottomRight
    | TopLeft
    | TopRight

type FieldNames = {
    label: string
    value: string
    children: string
}

type ShowSearchSettings = {
    filter: string -> string -> bool
    limit: int
    matchInputWidth: bool
    render: string -> string -> ReactElement
    sort: string -> string -> string -> int
}

type CascaderOption = {
    value: string
    label: ReactElement
    disabled: bool
    children: CascaderOption array option
}

type AntCascader() =
    inherit AntElement<AntCascader>(ofImport "Cascader" "antd")
    member x.alowClear (?v: bool) = x.attribute "allowClear" (Option.defaultValue true v)
    member x.autoFocus (?v: bool) = x.attribute "autoFocus" (Option.defaultValue true v)
    member x.bordered (?v: bool) = x.attribute "bordered" (Option.defaultValue true v)
    member x.changeOnSelect (?v: bool) = x.attribute "changeOnSelect" (Option.defaultValue true v)
    member x.className (v: string) = x.attribute "className" v
    member x.defaultValue (v: string array) = x.attribute "defaultValue" v
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.displayRender (v: Func<string, CascaderOption array, ReactElement>) = x.attribute "displayRender" v
    member x.expandTrigger (v: ExpandTriggerOptions) = x.attribute "expandTrigger" v
    member x.fieldNames (v: FieldNames) = x.attribute "fieldNames" v
    member x.getPopupContainer (v: unit -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.loadData (v: CascaderOption array -> unit) = x.attribute "loadData" v
    member x.notFoundContent (v: string) = x.attribute "notFoundContent" v
    member x.options (v: CascaderOption array) = x.attribute "options" v
    member x.placeholder (v: string) = x.attribute "placeholder" v
    member x.popupClassName (v: string) = x.attribute "popupClassName" v
    member x.popupPlacement (v: PopupPlacementOptions) = x.attribute "popupPlacement" v
    member x.popupVisible (?v: bool) = x.attribute "popupVisible" (Option.defaultValue true v)
    member x.showSearch (?v: bool) = x.attribute "showSearch" (Option.defaultValue true v)
    member x.showSearchSettings (v: ShowSearchSettings) = x.attribute "showSearch" v
    member x.size (v: Size) = x.attribute "size" v
    member x.suffixIcon (v: ReactElement) = x.attribute "suffixIcon" v
    member x.value (v: string array) = x.attribute "value" v
    member x.onChange (v: Func<string, CascaderOption array, unit>) = x.attribute "onChange" v
    member x.onPopupVisibleChange (v: bool -> unit) = x.attribute "onPopupVisibleChange" v
