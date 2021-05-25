module Fable.AntDesign.Progress

open System
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type ProgressType = Line | Circle | Dashboard

[<StringEnum; RequireQualifiedAccess>]
type ProgressStatus = Success | Exception | Normal | Active

[<StringEnum; RequireQualifiedAccess>]
type ProgressLinecap = Round | Square

[<StringEnum; RequireQualifiedAccess>]
type ProgressPosition = Top | Left | Bottom | Right

type ProgressBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Progress" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("format")>] member _.format (x: DSLElement, v: Func<int, int, ReactElement>) = x.attr "format" v
    [<CustomOperation("percent")>] member _.percent (x: DSLElement, v: int) = x.attr "percent" v
    [<CustomOperation("showInfo")>] member _.showInfo (x: DSLElement) = x.attr "showInfo" true
    [<CustomOperation("status")>] member _.status (x: DSLElement, v: ProgressStatus) = x.attr "status" v
    [<CustomOperation("strokeColor")>] member _.strokeColor (x: DSLElement, v: string) = x.attr "strokeColor" v
    [<CustomOperation("strokeLinecap")>] member _.strokeLinecap (x: DSLElement, v: ProgressLinecap) = x.attr "strokeLinecap" v
    [<CustomOperation("strokeWidth")>] member _.strokeWidth (x: DSLElement, v: int) = x.attr "strokeWidth" v
    [<CustomOperation("success")>] member _.success (x: DSLElement, v: {| percent: int; strokeColor: string option |}) = x.attr "success" v
    [<CustomOperation("trailColor")>] member _.trailColor (x: DSLElement, v: string) = x.attr "trailColor" v
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v
    [<CustomOperation("gapDegree")>] member _.gapDegree (x: DSLElement, v: int) = x.attr "gapDegree" v
    [<CustomOperation("gapPosition")>] member _.gapPosition (x: DSLElement, v: ProgressPosition) = x.attr "gapPosition" v
    [<CustomOperation("steps")>] member _.steps (x: DSLElement, v: int) = x.attr "steps" v
    [<CustomOperation("progressType")>] member _.progressType (x: DSLElement, v: ProgressType) = x.attr "type" v
    