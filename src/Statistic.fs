namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

type AntStatistic()  =
    inherit AntElement<AntStatistic>(ofImport "Statistic" "antd")
    member x.decimalSeparator (v: string) = x.attribute "decimalSeparator" v
    member x.formatter (v: (string -> ReactElement)) = x.attribute "formatter" v
    member x.groupSeparator (v: string) = x.attribute "groupSeparator" v
    member x.precision (v: int) = x.attribute "precision" v
    member x.prefix (v: ReactElement) = x.attribute "prefix" v
    member x.suffix (v: ReactElement) = x.attribute "suffix" v
    member x.title (v: ReactElement) = x.attribute "title" v
    member x.value (v: string) = x.attribute "value" v
    member x.valueStyle (css: Props.CSSProp list) = x.attribute "valueStyle" (keyValueList CaseRules.LowerFirst css)

type AntStatisticCountdown()  =
    inherit AntElement<AntStatisticCountdown>(ofImport "Statistic.Countdown" "antd")
    member x.format (v: string) = x.attribute "format" v
    member x.onFinish (v: (unit -> unit)) = x.attribute "onFinish" v
    member x.prefix (v: ReactElement) = x.attribute "prefix" v
    member x.suffix (v: ReactElement) = x.attribute "suffix" v
    member x.title (v: ReactElement) = x.attribute "title" v
    member x.value (v: U2<float, Moment> ) = x.attribute "value" v
    member x.valueStyle (css: Props.CSSProp list) = x.attribute "valueStyle" (keyValueList CaseRules.LowerFirst css)