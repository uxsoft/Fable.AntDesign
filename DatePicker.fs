namespace Fable.AntD

open System
open System
open Browser.Types
open Browser.Types
open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module DatePicker =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type CalendarMode = Time | Date | Month | Year | Decade
    
    [<RequireQualifiedAccess>]
    type AntDatePicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (DateTime -> ReactElement)
        | Disabled of bool
        | DisabledDate of (DateTime -> bool)
        | DropdownClassName of string
        | GetCalendarContainer of (obj -> obj)
        | Locale of obj
        | Mode of CalendarMode
        | Open of bool
        | Placeholder of string
        | PopupStyle of obj
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | DefaultValue of DateTime
        | DefaultPickerValue of DateTime
        | DisabledTime of (DateTime -> bool)
        | Format of U2<string, string list>
        | RenderExtraFooter of (string -> ReactElement)
        | ShowTime of bool
        | ShowToday of bool
        | Value of DateTime
        | OnChange of (DateTime * string -> unit)
        | OnOk of (unit -> unit)
        | OnPanelChange of (string * string -> unit)
        static member Custom (key: string, value: obj): AntDatePicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntDatePicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antDatePicker (props: AntDatePicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker" "antd" (keyValueList CaseRules.LowerFirst props) children

    [<RequireQualifiedAccess>]
    type AntMonthPicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (DateTime -> ReactElement)
        | Disabled of bool
        | DisabledDate of (DateTime -> bool)
        | DropdownClassName of string
        | GetCalendarContainer of (obj -> obj)
        | Locale of obj
        | Mode of CalendarMode
        | Open of bool
        | Placeholder of string
        | PopupStyle of obj
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (string * string -> unit)
        | DefaultValue of DateTime
        | DefaultPickerValue of DateTime
        | Format of U2<string, string list>
        | MonthCellContentRender of (string * string -> ReactElement)
        | Value of DateTime
        | OnChange of (DateTime * string -> unit)
        static member Custom (key: string, value: obj): AntMonthPicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMonthPicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antMonthPicker (props: AntMonthPicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker.MonthPicker" "antd" (keyValueList CaseRules.LowerFirst props) children

    [<RequireQualifiedAccess>]
    type AntRangePicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (DateTime -> ReactElement)
        | Disabled of bool
        | DisabledDate of (DateTime -> bool)
        | DropdownClassName of string
        | GetCalendarContainer of (obj -> obj)
        | Locale of obj
        | Mode of CalendarMode
        | Open of bool
        | Placeholder of string
        | PopupStyle of obj
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (string * string -> unit)
        | DefaultValue of DateTime list
        | DefaultPickerValue of DateTime list
        | DisabledTime of (DateTime list * string -> bool)
        | Format of U2<string, string list>
        | Ranges of Map<string, DateTime>
        | RenderExtraFooter of (unit -> ReactElement)
        | Separator of string
        | ShowTime of bool
        | Value of DateTime list
        | OnCalendarChange of (DateTime list * string list -> unit)
        | OnChange of (DateTime * DateTime -> unit)
        | OnOk of (DateTime list -> unit)
        static member Custom (key: string, value: obj): AntRangePicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntRangePicker = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antRangePicker (props: AntRangePicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker.RangePicker" "antd" (keyValueList CaseRules.LowerFirst props) children

    [<RequireQualifiedAccess>]
    type AntWeekPicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (DateTime -> ReactElement)
        | Disabled of bool
        | DisabledDate of (DateTime -> bool)
        | DropdownClassName of string
        | GetCalendarContainer of (obj -> obj)
        | Locale of obj
        | Mode of CalendarMode
        | Open of bool
        | Placeholder of string
        | PopupStyle of obj
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (string * string -> unit)        
        | DefaultValue of DateTime
        | DefaultPickerValue of DateTime
        | Format of string
        | Value of DateTime
        | OnChange of (DateTime * string -> unit)
        | RenderExtraFooter of (string -> ReactElement)
        static member Custom (key: string, value: obj): AntWeekPicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntWeekPicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antWeekPicker (props: AntWeekPicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker.WeekPicker" "antd" (keyValueList CaseRules.LowerFirst props) children