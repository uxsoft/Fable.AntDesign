namespace Fable.AntD

open Fable.React
open Fable.MomentJs

    type TimePicker () =
        inherit AntElement("TimePicker")
        member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
        member x.AutoFocus with set (v: bool) = x.Attribute "autoFocus" v 
        member x.ClassName with set (v: string) = x.Attribute "className" v 
        member x.ClearText with set (v: string) = x.Attribute "clearText" v
        member x.DefaultOpenValue with set (v: Moment) = x.Attribute "defaultOpenValue" v 
        member x.DefaultValue with set (v: Moment) = x.Attribute "defaultValue" v
        member x.Disabled with set (v: bool) = x.Attribute "disabled" v
        member x.DisabledHours with set (v: (unit -> int array)) = x.Attribute "disabledHours" v
        member x.DisabledMinutes with set (v: (int -> int array)) = x.Attribute "disabledMinutes" v
        member x.DisabledSeconds with set (v: (int -> int array)) = x.Attribute "disabledSeconds" v
        member x.Format with set (v: string) = x.Attribute "format" v 
        member x.GetPopupContainer with set (v: (obj -> ReactElement)) = x.Attribute "getPopupContainer" v 
        member x.HideDisabledOptions with set (v: bool) = x.Attribute "hideDisabledOptions" v
        member x.HourStep with set (v: int) = x.Attribute "hourStep" v
        member x.InputReadOnly with set (v: bool) = x.Attribute "inputReadOnly" v 
        member x.MinuteStep with set (v: int) = x.Attribute "minuteStep" v 
        member x.Open with set (v: bool) = x.Attribute "open" v
        member x.Placeholder with set (v: string) = x.Attribute "placeholder" v 
        member x.PopupClassName with set (v: string) = x.Attribute "popupClassName" v
        member x.PopupStyle with set (v: obj) = x.Attribute "popupStyle" v 
        member x.SecondStep with set (v: int) = x.Attribute "secondStep" v 
        member x.SuffixIcon with set (v: ReactElement) = x.Attribute "suffixIcon" v 
        member x.ClearIcon with set (v: ReactElement) = x.Attribute "clearIcon" v 
        member x.Use12Hours with set (v: bool) = x.Attribute "use12Hours" v
        member x.RenderExtraFooter with set (v: (unit -> ReactElement)) = x.Attribute "renderExtraFooter" v
        member x.Value with set (v: Moment) = x.Attribute "value" v 
        member x.OnChange with set (v: (Moment -> string -> unit)) = x.Attribute "onChange" v 
        member x.OnOpenChange with set (v: (bool -> unit)) = x.Attribute "onOpenChange" v 