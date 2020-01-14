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
open Fable.MomentJs

[<AutoOpen>]
module DatePicker =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntDatePickerMode = Time | Date | Month | Year | Decade
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntDatePickerPicker = Date | Week | Month | Year

    [<RequireQualifiedAccess>]
    type AntDatePicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (Moment -> Moment -> ReactElement)
        | Disabled of bool
        | DisabledDate of (Moment -> bool)
        | DropdownClassName of string
        | GetPopupContainer of (string -> HTMLElement)
        | Locale of obj
        | Mode of AntDatePickerMode
        | Open of bool
        | Picker of AntDatePickerPicker
        | Placeholder of string
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (Moment -> AntDatePickerMode -> unit)

        | DefaultValue of Moment
        | DefaultPickerValue of Moment
        | DisabledTime of (Moment -> bool)
        | Format of string array
        | RenderExtraFooter of (AntDatePickerMode -> ReactElement)
        | ShowTime of bool
        | ShowToday of bool
        | Value of Moment
        | OnChange of (Moment -> string -> unit)
        | OnOk of (unit -> unit)
        
        static member Custom (key: string, value: obj): AntDatePicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntDatePicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member PopupStyle (css: Props.CSSProp list): AntDatePicker = unbox ("popupStyle", keyValueList CaseRules.LowerFirst css)
    
    [<RequireQualifiedAccess>]
    type AntYearPicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (Moment -> Moment -> ReactElement)
        | Disabled of bool
        | DisabledDate of (Moment -> bool)
        | DropdownClassName of string
        | GetPopupContainer of (string -> ReactElement)
        | Locale of obj
        | Mode of AntDatePickerMode
        | Open of bool
        | Picker of AntDatePickerPicker
        | Placeholder of string
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (Moment -> AntDatePickerMode -> unit)

        | DefaultValue of Moment
        | DefaultPickerValue of Moment
        | Format of string
        | RenderExtraFooter of (unit -> ReactElement)
        | Value of Moment
        | OnChange of (Moment -> string -> unit)
        static member Custom (key: string, value: obj): AntYearPicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntYearPicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member PopupStyle (css: Props.CSSProp list): AntYearPicker = unbox ("popupStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntMonthPicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (Moment -> Moment -> ReactElement)
        | Disabled of bool
        | DisabledDate of (Moment -> bool)
        | DropdownClassName of string
        | GetPopupContainer of (string -> ReactElement)
        | Locale of obj
        | Mode of AntDatePickerMode
        | Open of bool
        | Picker of AntDatePickerPicker
        | Placeholder of string
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (Moment -> AntDatePickerMode -> unit)

        | DefaultValue of Moment
        | DefaultPickerValue of Moment
        | Format of string
        | MonthCellContentRender of (string -> string -> ReactElement)
        | RenderExtraFooter of (unit -> ReactElement)
        | Value of Moment
        | OnChange of (Moment -> string -> unit)
        static member Custom (key: string, value: obj): AntMonthPicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMonthPicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member PopupStyle (css: Props.CSSProp list): AntMonthPicker = unbox ("popupStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntWeekPicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (Moment -> Moment -> ReactElement)
        | Disabled of bool
        | DisabledDate of (Moment -> bool)
        | DropdownClassName of string
        | GetPopupContainer of (string -> ReactElement)
        | Locale of obj
        | Mode of AntDatePickerMode
        | Open of bool
        | Picker of AntDatePickerPicker
        | Placeholder of string
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (Moment -> AntDatePickerMode -> unit)     

        | DefaultValue of Moment
        | DefaultPickerValue of Moment
        | Format of string
        | Value of Moment
        | OnChange of (Moment -> string -> unit)
        | RenderExtraFooter of (AntDatePickerMode -> ReactElement)
        static member Custom (key: string, value: obj): AntWeekPicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntWeekPicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member PopupStyle (css: Props.CSSProp list): AntWeekPicker = unbox ("popupStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntRangePicker =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | DateRender of (Moment -> Moment -> ReactElement)
        | DisabledDate of (Moment -> bool)
        | DropdownClassName of string
        | GetPopupContainer of (string -> ReactElement)
        | Locale of obj
        | Mode of AntDatePickerMode
        | Open of bool
        | Picker of AntDatePickerPicker
        | Placeholder of string
        | Size of Size
        | SuffixIcon of ReactElement
        | OnOpenChange of (bool -> unit)
        | OnPanelChange of (Moment -> AntDatePickerMode -> unit)

        | AllowEmpty of bool array
        | DefaultValue of Moment array
        | DefaultPickerValue of Moment array
        | Disabled of bool array
        | DisabledTime of (Moment array * string -> bool)
        | Format of string array
        | Ranges of obj
        | RenderExtraFooter of (unit -> ReactElement)
        | Separator of string
        | ShowTime of bool
        | Value of Moment array
        | OnCalendarChange of (Moment array -> string array -> unit)
        | OnChange of (Moment array -> string array -> unit)
        static member Custom (key: string, value: obj): AntRangePicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntRangePicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member PopupStyle (css: Props.CSSProp list): AntRangePicker = unbox ("popupStyle", keyValueList CaseRules.LowerFirst css)

    let inline antDatePicker (props: AntDatePicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antYearPicker (props: AntMonthPicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker.YearPicker" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antMonthPicker (props: AntMonthPicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker.MonthPicker" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antWeekPicker (props: AntWeekPicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker.WeekPicker" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antRangePicker (props: AntRangePicker list) (children: ReactElement list): ReactElement =
       ofImport "DatePicker.RangePicker" "antd" (keyValueList CaseRules.LowerFirst props) children