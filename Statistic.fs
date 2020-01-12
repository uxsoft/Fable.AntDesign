namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

[<AutoOpen>]
module Statistic =
    
    [<RequireQualifiedAccess>]
    type AntStatistic  =
        | DecimalSeparator of string
        | Formatter of (string -> ReactElement)
        | GroupSeparator of string
        | Precision of int
        | Prefix of ReactElement
        | Suffix of ReactElement
        | Title of ReactElement
        | Value of string
        static member Custom (key: string, value: obj): AntStatistic = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntStatistic = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member ValueStyle (css: Props.CSSProp list): AntStatistic = unbox ("valueStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntStatisticCountdown  =
        | Format of string
        | OnFinish of (unit -> unit)
        | Prefix of ReactElement
        | Suffix of ReactElement
        | Title of ReactElement
        | Value of U2<float, Moment>
        static member Custom (key: string, value: obj): AntStatisticCountdown = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntStatisticCountdown = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member ValueStyle (css: Props.CSSProp list): AntStatisticCountdown = unbox ("valueStyle", keyValueList CaseRules.LowerFirst css)

        
    let inline antStatistic (props: AntStatistic list) (children: ReactElement list): ReactElement =
       ofImport "Statistic" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antStatisticCountdown (props: AntStatisticCountdown list) (children: ReactElement list): ReactElement =
       ofImport "Statistic.Countdown" "antd" (keyValueList CaseRules.LowerFirst props) children