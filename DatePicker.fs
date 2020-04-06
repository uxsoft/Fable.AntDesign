namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

[<StringEnum; RequireQualifiedAccess>]
type DatePickerMode = Time | Date | Month | Year | Decade

[<StringEnum; RequireQualifiedAccess>]
type DatePickerPicker = Date | Week | Month | Year

type AntDatePickerBase(partialImport) =
    inherit AntElement(partialImport)
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
    member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v 
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.DateRender with set (v: (Moment -> Moment -> ReactElement)) = x.Attribute "dateRender" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.DisabledDate with set (v: (Moment -> bool)) = x.Attribute "disabledDate" v 
    member x.DropdownClassName with set (v: string) = x.Attribute "dropdownClassName" v 
    member x.GetPopupContainer with set (v: (string -> HTMLElement)) = x.Attribute "getPopupContainer" v 
    member x.Locale with set (v: obj) = x.Attribute "locale" v 
    member x.Mode with set (v: DatePickerMode) = x.Attribute "mode" v 
    member x.Open with set (v: bool) = x.Attribute "open" v 
    member x.Picker with set (v: DatePickerPicker) = x.Attribute "picker" v 
    member x.Placeholder with set (v: string) = x.Attribute "placeholder" v 
    member x.PopupStyle (css: Props.CSSProp list) = x.Attribute "popupStyle" (keyValueList CaseRules.LowerFirst css)
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Bordered with set (v: bool) = x.Attribute "bordered" v 
    member x.SuffixIcon with set (v: ReactElement) = x.Attribute "suffixIcon" v 
    member x.OnOpenChange with set (v: (bool -> unit)) = x.Attribute "onOpenChange" v 
    member x.OnPanelChange with set (v: (Moment -> DatePickerMode -> unit)) = x.Attribute "onPanelChange" v
    member x.InputReadOnly with set (v: bool) = x.Attribute "inputReadOnly" v
    
type AntDatePicker() =
    inherit AntDatePickerBase(ofImport "DatePicker" "antd")
    member x.DefaultValue with set (v: Moment) = x.Attribute "defaultValue" v 
    member x.DefaultPickerValue with set (v: Moment) = x.Attribute "defaultPickerValue" v 
    member x.DisabledTime with set (v: (Moment -> bool)) = x.Attribute "disabledTime" v 
    member x.Format with set (v: string array) = x.Attribute "format" v 
    member x.RenderExtraFooter with set (v: (DatePickerMode -> ReactElement)) = x.Attribute "renderExtraFooter" v 
    member x.ShowTime with set (v: bool) = x.Attribute "showTime" v 
    member x.ShowToday with set (v: bool) = x.Attribute "showToday" v 
    member x.Value with set (v: Moment) = x.Attribute "value" v 
    member x.OnChange with set (v: (Moment -> string -> unit)) = x.Attribute "onChange" v 
    member x.OnOk with set (v: (unit -> unit)) = x.Attribute "onOk" v

type AntYearPicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.YearPicker" "antd")
    member x.DefaultValue with set (v: Moment) = x.Attribute "defaultValue" v 
    member x.DefaultPickerValue with set (v: Moment) = x.Attribute "defaultPickerValue" v 
    member x.Format with set (v: string) = x.Attribute "format" v 
    member x.RenderExtraFooter with set (v: (unit -> ReactElement)) = x.Attribute "renderExtraFooter" v 
    member x.Value with set (v: Moment) = x.Attribute "value" v 
    member x.OnChange with set (v: (Moment -> string -> unit)) = x.Attribute "onChange" v 

type AntMonthPicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.MonthPicker" "antd")
    member x.DefaultValue with set (v: Moment) = x.Attribute "defaultValue" v 
    member x.DefaultPickerValue with set (v: Moment) = x.Attribute "defaultPickerValue" v 
    member x.Format with set (v: string) = x.Attribute "format" v 
    member x.MonthCellContentRender with set (v: (string -> string -> ReactElement)) = x.Attribute "monthCellContentRender" v 
    member x.RenderExtraFooter with set (v: (unit -> ReactElement)) = x.Attribute "renderExtraFooter" v 
    member x.Value with set (v: Moment) = x.Attribute "value" v 
    member x.OnChange with set (v: (Moment -> string -> unit)) = x.Attribute "onChange" v 

type AntWeekPicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.WeekPicker" "antd")
    member x.DefaultValue with set (v: Moment) = x.Attribute "defaultValue" v 
    member x.DefaultPickerValue with set (v: Moment) = x.Attribute "defaultPickerValue" v 
    member x.Format with set (v: string) = x.Attribute "format" v 
    member x.Value with set (v: Moment) = x.Attribute "value" v 
    member x.OnChange with set (v: (Moment -> string -> unit)) = x.Attribute "onChange" v 
    member x.RenderExtraFooter with set (v: (DatePickerMode -> ReactElement)) = x.Attribute "renderExtraFooter" v 

type AntRangePicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.RangePicker" "antd")
    member x.AllowEmpty with set (v: bool array) = x.Attribute "allowEmpty" v 
    member x.DefaultValue with set (v: Moment array) = x.Attribute "defaultValue" v 
    member x.DefaultPickerValue with set (v: Moment array) = x.Attribute "defaultPickerValue" v 
    member x.Disabled with set (v: bool array) = x.Attribute "disabled" v 
    member x.DisabledTime with set (v: (Moment array * string -> bool)) = x.Attribute "disabledTime" v 
    member x.Format with set (v: string array) = x.Attribute "Format" v 
    member x.Ranges with set (v: obj) = x.Attribute "ranges" v 
    member x.RenderExtraFooter with set (v: (unit -> ReactElement)) = x.Attribute "renderExtraFooter" v 
    member x.Separator with set (v: string) = x.Attribute "separator" v 
    member x.ShowTime with set (v: bool) = x.Attribute "showTime" v 
    member x.Value with set (v: Moment array) = x.Attribute "value" v 
    member x.OnCalendarChange with set (v: (Moment array -> string array -> unit)) = x.Attribute "onCalendarChange" v 
    member x.OnChange with set (v: (Moment array -> string array -> unit)) = x.Attribute "onChange" v 