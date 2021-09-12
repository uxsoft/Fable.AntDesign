module Fable.Builders.AntDesign.Statistic

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs
open Fable.React.Props

type StatisticBuilder()  =
    inherit ReactBuilder(import "Statistic" "antd")

    [<CustomOperation("decimalSeparator")>] member inline _.decimalSeparator (x: DSLElement, v: string) = x.attr "decimalSeparator" v
    [<CustomOperation("formatter")>] member inline _.formatter (x: DSLElement, v: string -> ReactElement) = x.attr "formatter" v
    [<CustomOperation("groupSeparator")>] member inline _.groupSeparator (x: DSLElement, v: string) = x.attr "groupSeparator" v
    [<CustomOperation("precision")>] member inline _.precision (x: DSLElement, v: int) = x.attr "precision" v
    [<CustomOperation("prefix")>] member inline _.prefix (x: DSLElement, v: ReactElement) = x.attr "prefix" v
    [<CustomOperation("suffix")>] member inline _.suffix (x: DSLElement, v: ReactElement) = x.attr "suffix" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v
    [<CustomOperation("valueStyle")>] member inline _.valueStyle (x: DSLElement, css: CSSProp list) = x.attr "valueStyle" (keyValueList CaseRules.LowerFirst css)

type StatisticCountdownBuilder()  =
    inherit ReactBuilder(import "Statistic.Countdown" "antd")

    [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string) = x.attr "format" v
    [<CustomOperation("onFinish")>] member inline _.onFinish (x: DSLElement, v: unit -> unit) = x.attr "onFinish" v
    [<CustomOperation("prefix")>] member inline _.prefix (x: DSLElement, v: ReactElement) = x.attr "prefix" v
    [<CustomOperation("suffix")>] member inline _.suffix (x: DSLElement, v: ReactElement) = x.attr "suffix" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("valueStyle")>] member inline _.valueStyle (x: DSLElement, css: CSSProp list) = x.attr "valueStyle" (keyValueList CaseRules.LowerFirst css)