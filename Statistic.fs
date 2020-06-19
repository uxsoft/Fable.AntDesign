namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

type AntStatistic()  =
    inherit AntElement(ofImport "Statistic" "antd")
    member x.DecimalSeparator (v: string  ) = x.attribute "decimalSeparator" v
    member x.Formatter (v: (string -> ReactElement)) = x.attribute "formatter" v
    member x.GroupSeparator (v: string) = x.attribute "groupSeparator" v
    member x.Precision (v: int) = x.attribute "precision" v
    member x.Prefix (v: ReactElement) = x.attribute "prefix" v
    member x.Suffix (v: ReactElement) = x.attribute "suffix" v
    member x.Title (v: ReactElement) = x.attribute "title" v
    member x.Value (v: string) = x.attribute "value" v
    member x.ValueStyle (css: Props.CSSProp list) = x.attribute "valueStyle" (keyValueList CaseRules.LowerFirst css)

type AntStatisticCountdown()  =
    inherit AntElement(ofImport "Statistic.Countdown" "antd")
    member x.Format (v: string) = x.attribute "format" v
    member x.OnFinish (v: (unit -> unit)) = x.attribute "onFinish" v
    member x.Prefix (v: ReactElement) = x.attribute "prefix" v
    member x.Suffix (v: ReactElement) = x.attribute "suffix" v
    member x.Title (v: ReactElement) = x.attribute "title" v
    member x.Value (v: U2<float, Moment> ) = x.attribute "value" v
    member x.ValueStyle (css: Props.CSSProp list) = x.attribute "valueStyle" (keyValueList CaseRules.LowerFirst css)