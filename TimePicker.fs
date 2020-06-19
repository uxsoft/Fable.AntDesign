namespace Fable.AntD

open Fable.React
open Fable.MomentJs

type AntTimePicker() =
    inherit AntElement(ofImport "TimePicker" "antd")
    member x.AllowClear
        (v: bool) = x.attribute "allowClear" v
    member x.AutoFocus
        (v: bool) = x.attribute "autoFocus" v
    member x.ClassName
        (v: string) = x.attribute "className" v
    member x.ClearText
        (v: string) = x.attribute "clearText" v
    member x.DefaultOpenValue
        (v: Moment) = x.attribute "defaultOpenValue" v
    member x.DefaultValue
        (v: Moment) = x.attribute "defaultValue" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.DisabledHours
        (v: unit -> int array) = x.attribute "disabledHours" v
    member x.DisabledMinutes
        (v: int -> int array) = x.attribute "disabledMinutes" v
    member x.DisabledSeconds
        (v: int -> int array) = x.attribute "disabledSeconds" v
    member x.Format
        (v: string) = x.attribute "format" v
    member x.GetPopupContainer
        (v: obj -> ReactElement) = x.attribute "getPopupContainer" v
    member x.HideDisabledOptions
        (v: bool) = x.attribute "hideDisabledOptions" v
    member x.HourStep
        (v: int) = x.attribute "hourStep" v
    member x.InputReadOnly
        (v: bool) = x.attribute "inputReadOnly" v
    member x.MinuteStep
        (v: int) = x.attribute "minuteStep" v
    member x.Open
        (v: bool) = x.attribute "open" v
    member x.Placeholder
        (v: string) = x.attribute "placeholder" v
    member x.PopupClassName
        (v: string) = x.attribute "popupClassName" v
    member x.PopupStyle
        (v: obj) = x.attribute "popupStyle" v
    member x.SecondStep
        (v: int) = x.attribute "secondStep" v
    member x.SuffixIcon
        (v: ReactElement) = x.attribute "suffixIcon" v
    member x.ClearIcon
        (v: ReactElement) = x.attribute "clearIcon" v
    member x.Use12Hours
        (v: bool) = x.attribute "use12Hours" v
    member x.RenderExtraFooter
        (v: unit -> ReactElement) = x.attribute "renderExtraFooter" v
    member x.Value
        (v: Moment) = x.attribute "value" v

    member x.OnChange
        (v: Moment -> string -> unit) =
            let uncurried = System.Func<Moment, string, unit> v
            x.attribute "onChange" uncurried

    member x.OnOpenChange
        (v: bool -> unit) = x.attribute "onOpenChange" v
