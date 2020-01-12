namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

[<AutoOpen>]
module Calendar =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntCalendarMode = Month | Year

    [<RequireQualifiedAccess>]
    type AntCalendar  =
        | DateCellRender of (Moment -> ReactElement)
        | DateFullCellRender of (Moment -> ReactElement)
        | DefaultValue of Moment
        | DisabledDate of (Moment -> bool)
        | Fullscreen of bool
        | Locale of obj
        | Mode of AntCalendarMode
        | MonthCellRender of (Moment -> ReactElement)
        | MonthFullCellRender of (Moment -> ReactElement)
        | ValidRange of Moment array
        | Value of Moment
        | OnPanelChange of (Moment -> string -> unit)
        | OnSelect of (Moment -> unit)
        | OnChange of (Moment -> unit)
        | HeaderRender of (obj -> ReactElement)
        static member Custom (key: string, value: obj): AntCalendar = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCalendar = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antCalendar (props: AntCalendar list) (children: ReactElement list): ReactElement =
       ofImport "Calendar" "antd" (keyValueList CaseRules.LowerFirst props) children
    