namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Browser.Types
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<AutoOpen>]
module Cascader =

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
        inherit ReactBuilder(import "Cascader" "antd")
    
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
        [<CustomOperation("changeOnSelect")>] member inline _.changeOnSelect (x: DSLElement, v: bool) = x.attr "changeOnSelect" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("displayRender")>] member inline _.displayRender (x: DSLElement, v: Func<string, CascaderOption array, ReactElement>) = x.attr "displayRender" v
        [<CustomOperation("dropdownRender")>] member inline _.dropdownRender (x: DSLElement, v: Func<ReactElement, ReactElement>) = x.attr "dropdownRender" v
        [<CustomOperation("expandIcon")>] member inline _.expandIcon (x: DSLElement, v: ReactElement) = x.attr "expandIcon" v
        [<CustomOperation("expandTrigger")>] member inline _.expandTrigger (x: DSLElement, v: ExpandTriggerOptions) = x.attr "expandTrigger" v
        [<CustomOperation("fieldNames")>] member inline _.fieldNames (x: DSLElement, v: FieldNames) = x.attr "fieldNames" v
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getPopupContainer" v
        [<CustomOperation("loadData")>] member inline _.loadData (x: DSLElement, v: CascaderOption array -> unit) = x.attr "loadData" v
        [<CustomOperation("notFoundContent")>] member inline _.notFoundContent (x: DSLElement, v: string) = x.attr "notFoundContent" v
        [<CustomOperation("options")>] member inline _.options (x: DSLElement, v: CascaderOption array) = x.attr "options" v
        [<CustomOperation("placeholder")>] member inline _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
        [<CustomOperation("popupClassName")>] member inline _.popupClassName (x: DSLElement, v: string) = x.attr "popupClassName" v
        [<CustomOperation("popupPlacement")>] member inline _.popupPlacement (x: DSLElement, v: PopupPlacementOptions) = x.attr "popupPlacement" v
        [<CustomOperation("popupVisible")>] member inline _.popupVisible (x: DSLElement, v: bool) = x.attr "popupVisible" v
        [<CustomOperation("showSearch")>] member inline _.showSearch (x: DSLElement, v: bool) = x.attr "showSearch" v
        [<CustomOperation("showSearchSettings")>] member inline _.showSearchSettings (x: DSLElement, v: ShowSearchSettings) = x.attr "showSearch" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("suffixIcon")>] member inline _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string array) = x.attr "value" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<string array, CascaderOption array, unit>) = x.attr "onChange" v
        [<CustomOperation("onPopupVisibleChange")>] member inline _.onPopupVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onPopupVisibleChange" v
    