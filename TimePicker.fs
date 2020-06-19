namespace Fable.AntD

open Browser.Types
open Fable.React
open Fable.MomentJs
open System

type AntTimePicker() =
    inherit AntElement<AntTimePicker>(ofImport "TimePicker" "antd")
    member x.allowClear (v: bool) = x.attribute "allowClear" v
    member x.autoFocus (v: bool) = x.attribute "autoFocus" v
    member x.bordered (v: bool) = x.attribute "bordered" v
    member x.className (v: string) = x.attribute "className" v
    member x.clearText (v: string) = x.attribute "clearText" v
    member x.defaultValue (v: Moment) = x.attribute "defaultValue" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.disabledHours (v: unit -> int array) = x.attribute "disabledHours" v
    member x.disabledMinutes (v: int -> int array) = x.attribute "disabledMinutes" v
    member x.disabledSeconds (v: int -> int array) = x.attribute "disabledSeconds" v
    member x.format (v: string) = x.attribute "format" v
    member x.getPopupContainer (v: obj -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.hideDisabledOptions (v: bool) = x.attribute "hideDisabledOptions" v
    member x.hourStep (v: int) = x.attribute "hourStep" v
    member x.inputReadOnly (v: bool) = x.attribute "inputReadOnly" v
    member x.minuteStep (v: int) = x.attribute "minuteStep" v
    member x.isOpen (v: bool) = x.attribute "open" v
    member x.placeholder (v: string) = x.attribute "placeholder" v
    member x.popupClassName (v: string) = x.attribute "popupClassName" v
    member x.popupStyle (v: obj) = x.attribute "popupStyle" v
    member x.secondStep (v: int) = x.attribute "secondStep" v
    member x.suffixIcon (v: ReactElement) = x.attribute "suffixIcon" v
    member x.clearIcon (v: ReactElement) = x.attribute "clearIcon" v
    member x.use12Hours (v: bool) = x.attribute "use12Hours" v
    member x.renderExtraFooter (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.value (v: Moment) = x.attribute "value" v
    member x.onChange (v: Func<Moment, string, unit>) = x.attribute "onChange" v
    member x.onOpenChange (v: bool -> unit) = x.attribute "onOpenChange" v

type AntTimeRagePicker() =
    inherit AntDatePickerBase<AntTimeRagePicker>(ofImport "TimePicker.RangePicker" "antd")
    member x.allowEmpty (v: bool array) = x.attribute "allowEmpty" v
    member x.dateRender (v: Func<Moment, Moment, obj, ReactElement>) = x.attribute "dateRender" v
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
    member x.order (v: bool) = x.attribute "order" v