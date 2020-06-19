namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

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

type FieldNames =
    { label: string
      value: string
      children: string }

type ShowSearchSettings =
    { filter: string -> string -> bool
      limit: int
      matchInputWidth: bool
      render: string -> string -> ReactElement
      sort: string -> string -> string -> int }

type CascaderOption =
    { value: string
      label: ReactElement option
      disabled: bool option
      children: CascaderOption array option }

type AntCascader() =
    inherit AntElement(ofImport "Cascader" "antd")
    member x.AllowClear
        (v: bool) = x.attribute "allowClear" v
    member x.AutoFocus
        (v: bool) = x.attribute "autoFocus" v
    member x.ChangeOnSelect
        (v: bool) = x.attribute "changeOnSelect" v
    member x.ClassName
        (v: string) = x.attribute "className" v
    member x.DefaultValue
        (v: string array) = x.attribute "defaultValue" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.DisplayRender
        (v: string -> CascaderOption array -> ReactElement) =
            let uncurried = System.Func<string, CascaderOption array, ReactElement> v
            x.attribute "displayRender" uncurried
    member x.ExpandTrigger
        (v: ExpandTriggerOptions) = x.attribute "expandTrigger" v
    member x.FieldNames
        (v: FieldNames) = x.attribute "fieldNames" v
    member x.GetPopupContainer
        (v: unit -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.LoadData
        (v: CascaderOption array -> unit) = x.attribute "loadData" v
    member x.NotFoundContent
        (v: string) = x.attribute "notFoundContent" v
    member x.Options
        (v: CascaderOption array) = x.attribute "options" v
    member x.Placeholder
        (v: string) = x.attribute "placeholder" v
    member x.PopupClassName
        (v: string) = x.attribute "popupClassName" v
    member x.PopupPlacement
        (v: PopupPlacementOptions) = x.attribute "popupPlacement" v
    member x.PopupVisible
        (v: bool) = x.attribute "popupVisible" v
    member x.ShowSearch
        (v: bool) = x.attribute "showSearch" v
    member x.ShowSearchSettings
        (v: ShowSearchSettings) = x.attribute "showSearch" v
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.SuffixIcon
        (v: ReactElement) = x.attribute "suffixIcon" v
    member x.Value
        (v: string array) = x.attribute "value" v
    member x.OnChange
        (v: string -> CascaderOption array -> unit) =
            let uncurried = System.Func<string, CascaderOption array, unit> v
            x.attribute "onChange" uncurried
    member x.OnPopupVisibleChange
        (v: bool -> unit) = x.attribute "onPopupVisibleChange" v
