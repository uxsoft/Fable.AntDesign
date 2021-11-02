namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.MomentJs
open Fable.Core.JsInterop
open System
open Feliz

[<AutoOpen>]
module TimePicker = 

    type TimePickerBuilder() =
        inherit ReactBuilder(import "TimePicker" "antd")
    
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
        [<CustomOperation("clearText")>] member inline _.clearText (x: DSLElement, v: string) = x.attr "clearText" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("disabledHours")>] member inline _.disabledHours (x: DSLElement, v: unit -> int array) = x.attr "disabledHours" v
        [<CustomOperation("disabledMinutes")>] member inline _.disabledMinutes (x: DSLElement, v: int -> int array) = x.attr "disabledMinutes" v
        [<CustomOperation("disabledSeconds")>] member inline _.disabledSeconds (x: DSLElement, v: int -> int array) = x.attr "disabledSeconds" v
        [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string) = x.attr "format" v
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: obj -> HTMLElement) = x.attr "getPopupContainer" v
        [<CustomOperation("hideDisabledOptions")>] member inline _.hideDisabledOptions (x: DSLElement, v: bool) = x.attr "hideDisabledOptions" v
        [<CustomOperation("hourStep")>] member inline _.hourStep (x: DSLElement, v: int) = x.attr "hourStep" v
        [<CustomOperation("inputReadOnly")>] member inline _.inputReadOnly (x: DSLElement, v: bool) = x.attr "inputReadOnly" v
        [<CustomOperation("minuteStep")>] member inline _.minuteStep (x: DSLElement, v: int) = x.attr "minuteStep" v
        [<CustomOperation("isOpen")>] member inline _.isOpen (x: DSLElement, v: bool) = x.attr "open" v
        [<CustomOperation("placeholder")>] member inline _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
        [<CustomOperation("popupClassName")>] member inline _.popupClassName (x: DSLElement, v: string) = x.attr "popupClassName" v
        [<CustomOperation("popupStyle")>] member inline _.popupStyle (x: DSLElement, v: IStyleAttribute list) = x.attr "popupStyle" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("secondStep")>] member inline _.secondStep (x: DSLElement, v: int) = x.attr "secondStep" v
        [<CustomOperation("suffixIcon")>] member inline _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
        [<CustomOperation("clearIcon")>] member inline _.clearIcon (x: DSLElement, v: ReactElement) = x.attr "clearIcon" v
        [<CustomOperation("use12Hours")>] member inline _.use12Hours (x: DSLElement, v: bool) = x.attr "use12Hours" v
        [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment, string, unit>) = x.attr "onChange" v
        [<CustomOperation("onOpenChange")>] member inline _.onOpenChange (x: DSLElement, v: bool -> unit) = x.attr "onOpenChange" v
    
    type TimeRangePickerBuilder() =
        inherit DatePicker.DatePickerBase(import "TimePicker.RangePicker" "antd")
    
        [<CustomOperation("allowEmpty")>] member inline _.allowEmpty (x: DSLElement, v: bool array) = x.attr "allowEmpty" v
        [<CustomOperation("dateRender")>] member inline _.dateRender (x: DSLElement, v: Func<Moment, Moment, obj, ReactElement>) = x.attr "dateRender" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment array) = x.attr "defaultValue" v
        [<CustomOperation("defaultPickerValue")>] member inline _.defaultPickerValue (x: DSLElement, v: Moment array) = x.attr "defaultPickerValue" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool array) = x.attr "disabled" v
        [<CustomOperation("disabledTime")>] member inline _.disabledTime (x: DSLElement, v: Moment array * string -> bool) = x.attr "disabledTime" v
        [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string array) = x.attr "Format" v
        [<CustomOperation("ranges")>] member inline _.ranges (x: DSLElement, v: obj) = x.attr "ranges" v
        // TODO better type
        [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
        [<CustomOperation("separator")>] member inline _.separator (x: DSLElement, v: string) = x.attr "separator" v
        [<CustomOperation("showTime")>] member inline _.showTime (x: DSLElement, v: bool) = x.attr "showTime" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment array) = x.attr "value" v
        [<CustomOperation("onCalendarChange")>] member inline _.onCalendarChange (x: DSLElement, v: Func<Moment array, string array, unit>) = x.attr "onCalendarChange" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment array, string array, unit>) = x.attr "onChange" v
        [<CustomOperation("order")>] member inline _.order (x: DSLElement, v: bool) = x.attr "order" v