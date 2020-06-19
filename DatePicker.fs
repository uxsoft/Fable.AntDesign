namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

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

type AntDatePickerBase(partialImport) =
    inherit AntElement(partialImport)
    member x.AllowClear
        (v: bool) = x.attribute "allowClear" v
    member x.AutoFocus
        (v: bool) = x.attribute "autoFocus" v
    member x.ClassName
        (v: string) = x.attribute "className" v

    member x.DateRender
        (v: Moment -> Moment -> ReactElement) =
            let uncurried = System.Func<Moment, Moment, ReactElement> v
            x.attribute "dateRender" uncurried

    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.DisabledDate
        (v: Moment -> bool) = x.attribute "disabledDate" v
    member x.DropdownClassName
        (v: string) = x.attribute "dropdownClassName" v
    member x.GetPopupContainer
        (v: string -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.Locale
        (v: obj) = x.attribute "locale" v
    member x.Mode
        (v: DatePickerMode) = x.attribute "mode" v
    member x.Open
        (v: bool) = x.attribute "open" v
    member x.Picker
        (v: DatePickerPicker) = x.attribute "picker" v
    member x.Placeholder
        (v: string) = x.attribute "placeholder" v
    member x.PopupStyle(css: Props.CSSProp list) = x.attribute "popupStyle" (keyValueList CaseRules.LowerFirst css)
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.Bordered
        (v: bool) = x.attribute "bordered" v
    member x.SuffixIcon
        (v: ReactElement) = x.attribute "suffixIcon" v
    member x.OnOpenChange
        (v: bool -> unit) = x.attribute "onOpenChange" v

    member x.OnPanelChange
        (v: Moment -> DatePickerMode -> unit) =
            let uncurried = System.Func<Moment, DatePickerMode, unit> v
            x.attribute "onPanelChange" uncurried

    member x.InputReadOnly
        (v: bool) = x.attribute "inputReadOnly" v

type AntDatePicker() =
    inherit AntDatePickerBase(ofImport "DatePicker" "antd")
    member x.DefaultValue
        (v: Moment) = x.attribute "defaultValue" v
    member x.DefaultPickerValue
        (v: Moment) = x.attribute "defaultPickerValue" v
    member x.DisabledTime
        (v: Moment -> bool) = x.attribute "disabledTime" v
    member x.Format
        (v: string array) = x.attribute "format" v
    member x.RenderExtraFooter
        (v: DatePickerMode -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.ShowTime
        (v: bool) = x.attribute "showTime" v
    member x.ShowToday
        (v: bool) = x.attribute "showToday" v
    member x.Value
        (v: Moment) = x.attribute "value" v

    member x.OnChange
        (v: Moment -> string -> unit) =
            let uncurried = System.Func<Moment, string, unit> v
            x.attribute "onChange" uncurried

    member x.OnOk
        (v: unit -> unit) = x.attribute "onOk" v

type AntYearPicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.YearPicker" "antd")
    member x.DefaultValue
        (v: Moment) = x.attribute "defaultValue" v
    member x.DefaultPickerValue
        (v: Moment) = x.attribute "defaultPickerValue" v
    member x.Format
        (v: string) = x.attribute "format" v
    member x.RenderExtraFooter
        (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.Value
        (v: Moment) = x.attribute "value" v
    member x.OnChange
        (v: Moment -> string -> unit) =
            let uncurried = System.Func<Moment, string, unit> v
            x.attribute "onChange" uncurried

type AntQuarterPicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.QuarterPicker" "antd")
    member x.DefaultValue
        (v: Moment) = x.attribute "defaultValue" v
    member x.DefaultPickerValue
        (v: Moment) = x.attribute "defaultPickerValue" v
    member x.Format
        (v: string) = x.attribute "format" v
    member x.RenderExtraFooter
        (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.Value
        (v: Moment) = x.attribute "value" v
    member x.OnChange
        (v: Moment -> string -> unit) =
            let uncurried = System.Func<Moment, string, unit> v
            x.attribute "onChange" uncurried

type AntMonthPicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.MonthPicker" "antd")
    member x.DefaultValue
        (v: Moment) = x.attribute "defaultValue" v
    member x.DefaultPickerValue
        (v: Moment) = x.attribute "defaultPickerValue" v
    member x.Format
        (v: string) = x.attribute "format" v
    member x.MonthCellContentRender
        (v: string -> string -> ReactElement) =
            let uncurried = System.Func<string, string, ReactElement> v
            x.attribute "monthCellContentRender" uncurried
    member x.RenderExtraFooter
        (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.Value
        (v: Moment) = x.attribute "value" v
    member x.OnChange
        (v: Moment -> string -> unit) =
            let uncurried = System.Func<Moment, string, unit> v
            x.attribute "onChange" uncurried

type AntWeekPicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.WeekPicker" "antd")
    member x.DefaultValue
        (v: Moment) = x.attribute "defaultValue" v
    member x.DefaultPickerValue
        (v: Moment) = x.attribute "defaultPickerValue" v
    member x.Format
        (v: string) = x.attribute "format" v
    member x.Value
        (v: Moment) = x.attribute "value" v
    member x.OnChange
        (v: Moment -> string -> unit) =
            let uncurried = System.Func<Moment, string, unit> v
            x.attribute "onChange" uncurried
    member x.RenderExtraFooter
        (v: DatePickerMode -> ReactElement) = x.attribute "renderExtraFooter" v

type AntRangePicker() =
    inherit AntDatePickerBase(ofImport "DatePicker.RangePicker" "antd")
    member x.AllowEmpty
        (v: bool array) = x.attribute "allowEmpty" v
    member x.DefaultValue
        (v: Moment array) = x.attribute "defaultValue" v
    member x.DefaultPickerValue
        (v: Moment array) = x.attribute "defaultPickerValue" v
    member x.Disabled
        (v: bool array) = x.attribute "disabled" v
    member x.DisabledTime
        (v: Moment array * string -> bool) = x.attribute "disabledTime" v
    member x.Format
        (v: string array) = x.attribute "Format" v
    member x.Ranges
        (v: obj) = x.attribute "ranges" v
    member x.RenderExtraFooter
        (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.Separator
        (v: string) = x.attribute "separator" v
    member x.ShowTime
        (v: bool) = x.attribute "showTime" v
    member x.Value
        (v: Moment array) = x.attribute "value" v
    member x.OnCalendarChange
        (v: Moment array -> string array -> unit) =
            let uncurried = System.Func<Moment array, string array, unit> v
            x.attribute "onCalendarChange" uncurried
    member x.OnChange
        (v: Moment array -> string array -> unit) =
            let uncurried = System.Func<Moment array, string array, unit> v
            x.attribute "onChange" uncurried
