namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

[<AutoOpen>]
module TimePicker =
    
    [<RequireQualifiedAccess>]
    type AntTimePicker  =
        | AllowClear of bool
        | AutoFocus of bool
        | ClassName of string
        | ClearText of string
        | DefaultOpenValue of Moment
        | DefaultValue of Moment
        | Disabled of bool
        | DisabledHours of (unit -> int array)
        | DisabledMinutes of (int -> int array)
        | DisabledSeconds of (int -> int array)
        | Format of string
        | GetPopupContainer of (obj -> ReactElement)
        | HideDisabledOptions of bool
        | HourStep of int
        | InputReadOnly of bool 
        | MinuteStep of int
        | Open of bool
        | Placeholder of string
        | PopupClassName of string
        | PopupStyle of obj
        | SecondStep of int
        | SuffixIcon of ReactElement
        | ClearIcon of ReactElement
        | Use12Hours of bool
        | RenderExtraFooter of (unit -> ReactElement)
        | Value of Moment
        | OnChange of (Moment -> string -> unit)
        | OnOpenChange of (bool -> unit)
        static member Custom (key: string, value: obj): AntTimePicker = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTimePicker = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antTimePicker (props: AntTimePicker list) (children: ReactElement list): ReactElement =
       ofImport "TimePicker" "antd" (keyValueList CaseRules.LowerFirst props) children
    