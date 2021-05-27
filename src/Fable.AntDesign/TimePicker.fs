module Fable.AntDesign.TimePicker

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.MomentJs
open Fable.Core.JsInterop
open System
open Fable.React.Props

type TimePickerBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "TimePicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
    [<CustomOperation("clearText")>] member _.clearText (x: DSLElement, v: string) = x.attr "clearText" v
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("disabledHours")>] member _.disabledHours (x: DSLElement, v: unit -> int array) = x.attr "disabledHours" v
    [<CustomOperation("disabledMinutes")>] member _.disabledMinutes (x: DSLElement, v: int -> int array) = x.attr "disabledMinutes" v
    [<CustomOperation("disabledSeconds")>] member _.disabledSeconds (x: DSLElement, v: int -> int array) = x.attr "disabledSeconds" v
    [<CustomOperation("format")>] member _.format (x: DSLElement, v: string) = x.attr "format" v
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: obj -> HTMLElement) = x.attr "getPopupContainer" v
    [<CustomOperation("hideDisabledOptions")>] member _.hideDisabledOptions (x: DSLElement, v: bool) = x.attr "hideDisabledOptions" v
    [<CustomOperation("hourStep")>] member _.hourStep (x: DSLElement, v: int) = x.attr "hourStep" v
    [<CustomOperation("inputReadOnly")>] member _.inputReadOnly (x: DSLElement, v: bool) = x.attr "inputReadOnly" v
    [<CustomOperation("minuteStep")>] member _.minuteStep (x: DSLElement, v: int) = x.attr "minuteStep" v
    [<CustomOperation("isOpen")>] member _.isOpen (x: DSLElement, v: bool) = x.attr "open" v
    [<CustomOperation("placeholder")>] member _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
    [<CustomOperation("popupClassName")>] member _.popupClassName (x: DSLElement, v: string) = x.attr "popupClassName" v
    [<CustomOperation("popupStyle")>] member _.popupStyle (x: DSLElement, v: CSSProp list) = x.attr "popupStyle" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("secondStep")>] member _.secondStep (x: DSLElement, v: int) = x.attr "secondStep" v
    [<CustomOperation("suffixIcon")>] member _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
    [<CustomOperation("clearIcon")>] member _.clearIcon (x: DSLElement, v: ReactElement) = x.attr "clearIcon" v
    [<CustomOperation("use12Hours")>] member _.use12Hours (x: DSLElement, v: bool) = x.attr "use12Hours" v
    [<CustomOperation("renderExtraFooter")>] member _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Func<Moment, string, unit>) = x.attr "onChange" v
    [<CustomOperation("onOpenChange")>] member _.onOpenChange (x: DSLElement, v: bool -> unit) = x.attr "onOpenChange" v

type TimeRangePickerBuilder() =
    inherit DatePicker.DatePickerBase()
    member x.Run(s: DSLElement) = ofImport "TimePicker.RangePicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowEmpty")>] member _.allowEmpty (x: DSLElement, v: bool array) = x.attr "allowEmpty" v
    [<CustomOperation("dateRender")>] member _.dateRender (x: DSLElement, v: Func<Moment, Moment, obj, ReactElement>) = x.attr "dateRender" v
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: Moment array) = x.attr "defaultValue" v
    [<CustomOperation("defaultPickerValue")>] member _.defaultPickerValue (x: DSLElement, v: Moment array) = x.attr "defaultPickerValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool array) = x.attr "disabled" v
    [<CustomOperation("disabledTime")>] member _.disabledTime (x: DSLElement, v: Moment array * string -> bool) = x.attr "disabledTime" v
    [<CustomOperation("format")>] member _.format (x: DSLElement, v: string array) = x.attr "Format" v
    [<CustomOperation("ranges")>] member _.ranges (x: DSLElement, v: obj) = x.attr "ranges" v
    // TODO better type
    [<CustomOperation("renderExtraFooter")>] member _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
    [<CustomOperation("separator")>] member _.separator (x: DSLElement, v: string) = x.attr "separator" v
    [<CustomOperation("showTime")>] member _.showTime (x: DSLElement, v: bool) = x.attr "showTime" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: Moment array) = x.attr "value" v
    [<CustomOperation("onCalendarChange")>] member _.onCalendarChange (x: DSLElement, v: Func<Moment array, string array, unit>) = x.attr "onCalendarChange" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Func<Moment array, string array, unit>) = x.attr "onChange" v
    [<CustomOperation("order")>] member _.order (x: DSLElement, v: bool) = x.attr "order" v