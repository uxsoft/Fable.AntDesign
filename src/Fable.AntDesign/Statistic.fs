module Fable.AntDesign.Statistic

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs
open Fable.React.Props

type StatisticBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Statistic" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("decimalSeparator")>] member _.decimalSeparator (x: DSLElement, v: string) = x.attr "decimalSeparator" v
    [<CustomOperation("formatter")>] member _.formatter (x: DSLElement, v: string -> ReactElement) = x.attr "formatter" v
    [<CustomOperation("groupSeparator")>] member _.groupSeparator (x: DSLElement, v: string) = x.attr "groupSeparator" v
    [<CustomOperation("precision")>] member _.precision (x: DSLElement, v: int) = x.attr "precision" v
    [<CustomOperation("prefix")>] member _.prefix (x: DSLElement, v: ReactElement) = x.attr "prefix" v
    [<CustomOperation("suffix")>] member _.suffix (x: DSLElement, v: ReactElement) = x.attr "suffix" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v
    [<CustomOperation("valueStyle")>] member _.valueStyle (x: DSLElement, css: CSSProp list) = x.attr "valueStyle" (keyValueList CaseRules.LowerFirst css)

type StatisticCountdownBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Statistic.Countdown" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("format")>] member _.format (x: DSLElement, v: string) = x.attr "format" v
    [<CustomOperation("onFinish")>] member _.onFinish (x: DSLElement, v: unit -> unit) = x.attr "onFinish" v
    [<CustomOperation("prefix")>] member _.prefix (x: DSLElement, v: ReactElement) = x.attr "prefix" v
    [<CustomOperation("suffix")>] member _.suffix (x: DSLElement, v: ReactElement) = x.attr "suffix" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("valueStyle")>] member _.valueStyle (x: DSLElement, css: CSSProp list) = x.attr "valueStyle" (keyValueList CaseRules.LowerFirst css)