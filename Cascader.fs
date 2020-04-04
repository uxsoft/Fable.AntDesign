namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type ExpandTriggerOptions = Click | Hover
     
[<StringEnum; RequireQualifiedAccess>]
type PopupPlacementOptions = BottomLeft | BottomRight | TopLeft | TopRight
            
type FieldNames = {
    label: string
    value: string
    children: string
}

type ShowSearchSettings = {
    filter: (string -> string -> bool)
    limit: int
    matchInputWidth: bool
    render: (string -> string -> ReactElement)
    sort: (string -> string -> string -> int)
}

type CascaderOption = {
    value: string
    label: ReactElement option
    disabled: bool option
    children: CascaderOption array option
}

type AntCascader() =
    inherit AntElement("Cascader")
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
    member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v 
    member x.ChangeOnSelect with set (v: bool) = x.Attribute "changeOnSelect" v 
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.DefaultValue with set (v: string array) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.DisplayRender with set (v: (string -> CascaderOption array -> ReactElement)) = x.Attribute "displayRender" v 
    member x.ExpandTrigger with set (v: ExpandTriggerOptions) = x.Attribute "expandTrigger" v 
    member x.FieldNames with set (v: FieldNames) = x.Attribute "fieldNames" v 
    member x.GetPopupContainer with set (v: (unit -> HTMLElement)) = x.Attribute "getPopupContainer" v 
    member x.LoadData with set (v: (CascaderOption array -> unit)) = x.Attribute "loadData" v 
    member x.NotFoundContent with set (v: string) = x.Attribute "notFoundContent" v 
    member x.Options with set (v: CascaderOption array) = x.Attribute "options" v 
    member x.Placeholder with set (v: string) = x.Attribute "placeholder" v 
    member x.PopupClassName with set (v: string) = x.Attribute "popupClassName" v 
    member x.PopupPlacement with set (v: PopupPlacementOptions) = x.Attribute "popupPlacement" v 
    member x.PopupVisible with set (v: bool) = x.Attribute "popupVisible" v 
    member x.ShowSearch with set (v: bool) = x.Attribute "showSearch" v 
    member x.ShowSearchSettings with set (v: ShowSearchSettings) = x.Attribute "showSearch" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.SuffixIcon with set (v: ReactElement) = x.Attribute "suffixIcon" v 
    member x.Value with set (v: string array) = x.Attribute "value" v 
    member x.OnChange with set (v: (string -> CascaderOption array -> unit)) = x.Attribute "onChange" v 
    member x.OnPopupVisibleChange with set (v: (bool -> unit)) = x.Attribute "onPopupVisibleChange" v 
