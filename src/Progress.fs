namespace Fable.AntD

open System
open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type ProgressType = Line | Circle | Dashboard

[<StringEnum; RequireQualifiedAccess>]
type ProgressStatus = Success | Exception | Normal | Active

[<StringEnum; RequireQualifiedAccess>]
type ProgressLinecap = Round | Square

[<StringEnum; RequireQualifiedAccess>]
type ProgressPosition = Top | Left | Bottom | Right

type AntProgress()  =
    inherit AntElement<AntProgress>(ofImport "Progress" "antd")
    member x.format (v: (Func<int, {| percent: int; strokeColor: string option |}, string>)) = x.attribute "format" v
    member x.percent (v: int) = x.attribute "percent" v
    member x.showInfo (?v: bool) = x.attribute "showInfo" (Option.defaultValue true v)
    member x.status (v: ProgressStatus) = x.attribute "status" v
    member x.strokeColor (v: string) = x.attribute "strokeColor" v
    member x.strokeLinecap (v: ProgressLinecap) = x.attribute "strokeLinecap" v
    member x.strokeWidth (v: int) = x.attribute "strokeWidth" v
    member x.success (v: {| percent: int; strokeColor: string option |}) = x.attribute "success" {| percent = v |}
    member x.trailColor (v: string) = x.attribute "trailColor" v
    member x.width (v: string) = x.attribute "width" v
    member x.gapDegree (v: int) = x.attribute "gapDegree" v
    member x.gapPosition (v: ProgressPosition) = x.attribute "gapPosition" v
    member x.steps (v: int) = x.attribute "steps" v
    member x.progressType (v: ProgressType) = x.attribute "type" v
    