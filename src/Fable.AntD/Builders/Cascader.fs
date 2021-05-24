module Fable.AntD.Builders.Cascader

open Fable.AntD.Builders.Common
open Browser.Types
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

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

type CascaderBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Cascader" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement) = x.attr "allowClear" true
    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement) = x.attr "autoFocus" true
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true
    [<CustomOperation("changeOnSelect")>] member _.changeOnSelect (x: DSLElement) = x.attr "changeOnSelect" true
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("displayRender")>] member _.displayRender (x: DSLElement, v: Func<string, CascaderOption array, ReactElement>) = x.attr "displayRender" v
    [<CustomOperation("dropdownRender")>] member _.dropdownRender (x: DSLElement, v: Func<ReactElement, ReactElement>) = x.attr "dropdownRender" v
    [<CustomOperation("expandIcon")>] member _.expandIcon (x: DSLElement, v: ReactElement) = x.attr "expandIcon" v
    [<CustomOperation("expandTrigger")>] member _.expandTrigger (x: DSLElement, v: ExpandTriggerOptions) = x.attr "expandTrigger" v
    [<CustomOperation("fieldNames")>] member _.fieldNames (x: DSLElement, v: FieldNames) = x.attr "fieldNames" v
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getPopupContainer" v
    [<CustomOperation("loadData")>] member _.loadData (x: DSLElement, v: CascaderOption array -> unit) = x.attr "loadData" v
    [<CustomOperation("notFoundContent")>] member _.notFoundContent (x: DSLElement, v: string) = x.attr "notFoundContent" v
    [<CustomOperation("options")>] member _.options (x: DSLElement, v: CascaderOption array) = x.attr "options" v
    [<CustomOperation("placeholder")>] member _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
    [<CustomOperation("popupClassName")>] member _.popupClassName (x: DSLElement, v: string) = x.attr "popupClassName" v
    [<CustomOperation("popupPlacement")>] member _.popupPlacement (x: DSLElement, v: PopupPlacementOptions) = x.attr "popupPlacement" v
    [<CustomOperation("popupVisible")>] member _.popupVisible (x: DSLElement) = x.attr "popupVisible" true
    [<CustomOperation("showSearch")>] member _.showSearch (x: DSLElement) = x.attr "showSearch" true
    [<CustomOperation("showSearchSettings")>] member _.showSearchSettings (x: DSLElement, v: ShowSearchSettings) = x.attr "showSearch" v
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("suffixIcon")>] member _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string array) = x.attr "value" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Func<string array, CascaderOption array, unit>) = x.attr "onChange" v
    [<CustomOperation("onPopupVisibleChange")>] member _.onPopupVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onPopupVisibleChange" v
