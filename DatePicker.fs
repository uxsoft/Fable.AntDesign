namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs
open System

[<StringEnum; RequireQualifiedAccess>]
type DatePickerMode =
    | Time
    | Date
    | Month
    | Year
    | Decade

[<StringEnum; RequireQualifiedAccess>]
type DatePickerPicker =
    | Date
    | Week
    | Month
    | Year

type AntDatePickerBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.allowClear (v: bool) = x.attribute "allowClear" v
    member x.autoFocus (v: bool) = x.attribute "autoFocus" v
    member x.className (v: string) = x.attribute "className" v
    member x.dateRender (v: Func<Moment, Moment, ReactElement>) = x.attribute "dateRender" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.disabledDate (v: Moment -> bool) = x.attribute "disabledDate" v
    member x.dropdownClassName (v: string) = x.attribute "dropdownClassName" v
    member x.getPopupContainer (v: string -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.locale (v: obj) = x.attribute "locale" v
    member x.mode (v: DatePickerMode) = x.attribute "mode" v
    member x.isOpen (v: bool) = x.attribute "open" v
    member x.picker (v: DatePickerPicker) = x.attribute "picker" v
    member x.placeholder (v: string) = x.attribute "placeholder" v
    member x.popupStyle(css: Props.CSSProp list) = x.attribute "popupStyle" (keyValueList CaseRules.LowerFirst css)
    member x.size (v: Size) = x.attribute "size" v
    member x.bordered (v: bool) = x.attribute "bordered" v
    member x.suffixIcon (v: ReactElement) = x.attribute "suffixIcon" v
    member x.onOpenChange (v: bool -> unit) = x.attribute "onOpenChange" v
    member x.onPanelChange (v: Func<Moment, DatePickerMode, unit>) = x.attribute "onPanelChange" v
    member x.inputReadOnly (v: bool) = x.attribute "inputReadOnly" v

type AntDatePicker() =
    inherit AntDatePickerBase<AntDatePicker>(ofImport "DatePicker" "antd")
    member x.defaultValue (v: Moment) = x.attribute "defaultValue" v
    member x.defaultPickerValue (v: Moment) = x.attribute "defaultPickerValue" v
    member x.disabledTime (v: Moment -> bool) = x.attribute "disabledTime" v
    member x.format (v: string array) = x.attribute "format" v
    member x.renderExtraFooter (v: DatePickerMode -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.showTime (v: bool) = x.attribute "showTime" v
    member x.showToday (v: bool) = x.attribute "showToday" v
    member x.value (v: Moment) = x.attribute "value" v
    member x.onChange (v: Func<Moment, string, unit>) = x.attribute "onChange" v
    member x.onOk (v: unit -> unit) = x.attribute "onOk" v

type AntYearPicker() =
    inherit AntDatePickerBase<AntYearPicker>(ofImport "DatePicker.YearPicker" "antd")
    member x.defaultValue (v: Moment) = x.attribute "defaultValue" v
    member x.defaultPickerValue (v: Moment) = x.attribute "defaultPickerValue" v
    member x.format (v: string) = x.attribute "format" v
    member x.renderExtraFooter (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.value (v: Moment) = x.attribute "value" v
    member x.onChange (v: Func<Moment, string, unit>) = x.attribute "onChange" v

type AntQuarterPicker() =
    inherit AntDatePickerBase<AntQuarterPicker>(ofImport "DatePicker.QuarterPicker" "antd")
    member x.defaultValue (v: Moment) = x.attribute "defaultValue" v
    member x.defaultPickerValue (v: Moment) = x.attribute "defaultPickerValue" v
    member x.format (v: string) = x.attribute "format" v
    member x.renderExtraFooter (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.value (v: Moment) = x.attribute "value" v
    member x.onChange (v: Func<Moment, string, unit>) = x.attribute "onChange" v

type AntMonthPicker() =
    inherit AntDatePickerBase<AntMonthPicker>(ofImport "DatePicker.MonthPicker" "antd")
    member x.defaultValue (v: Moment) = x.attribute "defaultValue" v
    member x.defaultPickerValue (v: Moment) = x.attribute "defaultPickerValue" v
    member x.format (v: string) = x.attribute "format" v
    member x.monthCellContentRender (v: Func<string, string, ReactElement>) = x.attribute "monthCellContentRender" v
    member x.renderExtraFooter (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.value (v: Moment) = x.attribute "value" v
    member x.onChange (v: Func<Moment, string, unit>) = x.attribute "onChange" v

type AntWeekPicker() =
    inherit AntDatePickerBase<AntWeekPicker>(ofImport "DatePicker.WeekPicker" "antd")
    member x.defaultValue (v: Moment) = x.attribute "defaultValue" v
    member x.defaultPickerValue (v: Moment) = x.attribute "defaultPickerValue" v
    member x.format (v: string) = x.attribute "format" v
    member x.value (v: Moment) = x.attribute "value" v
    member x.onChange (v: Func<Moment, string, unit>) = x.attribute "onChange" v
    member x.renderExtraFooter (v: DatePickerMode -> ReactElement) = x.attribute "renderExtraFooter" v

type AntRangePicker() =
    inherit AntDatePickerBase<AntRangePicker>(ofImport "DatePicker.RangePicker" "antd")
    member x.allowEmpty (v: bool array) = x.attribute "allowEmpty" v
    member x.defaultValue (v: Moment array) = x.attribute "defaultValue" v
    member x.defaultPickerValue (v: Moment array) = x.attribute "defaultPickerValue" v
    member x.disabled (v: bool array) = x.attribute "disabled" v
    member x.disabledTime (v: Moment array * string -> bool) = x.attribute "disabledTime" v
    member x.format (v: string array) = x.attribute "Format" v
    member x.ranges (v: obj) = x.attribute "ranges" v
    member x.renderExtraFooter (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.separator (v: string) = x.attribute "separator" v
    member x.showTime (v: bool) = x.attribute "showTime" v
    member x.value (v: Moment array) = x.attribute "value" v
    member x.onCalendarChange (v: Func<Moment array, string array, unit>) = x.attribute "onCalendarChange" v
    member x.onChange (v: Func<Moment array, string array, unit>) = x.attribute "onChange" v