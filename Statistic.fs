namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs

type AntStatistic()  =
    inherit AntElement(ofImport "Statistic" "antd")
    member x.DecimalSeparator with set (v: string  ) = x.Attribute "decimalSeparator" v
    member x.Formatter with set (v: (string -> ReactElement)) = x.Attribute "formatter" v
    member x.GroupSeparator with set (v: string) = x.Attribute "groupSeparator" v
    member x.Precision with set (v: int) = x.Attribute "precision" v
    member x.Prefix with set (v: ReactElement) = x.Attribute "prefix" v
    member x.Suffix with set (v: ReactElement) = x.Attribute "suffix" v
    member x.Title with set (v: ReactElement) = x.Attribute "title" v
    member x.Value with set (v: string) = x.Attribute "value" v
    member x.ValueStyle (css: Props.CSSProp list) = x.Attribute "valueStyle" (keyValueList CaseRules.LowerFirst css)

type AntStatisticCountdown()  =
    inherit AntElement(ofImport "Statistic.Countdown" "antd")
    member x.Format with set (v: string) = x.Attribute "format" v
    member x.OnFinish with set (v: (unit -> unit)) = x.Attribute "onFinish" v
    member x.Prefix with set (v: ReactElement) = x.Attribute "prefix" v
    member x.Suffix with set (v: ReactElement) = x.Attribute "suffix" v
    member x.Title with set (v: ReactElement) = x.Attribute "title" v
    member x.Value with set (v: U2<float, Moment> ) = x.Attribute "value" v
    member x.ValueStyle (css: Props.CSSProp list) = x.Attribute "valueStyle" (keyValueList CaseRules.LowerFirst css)