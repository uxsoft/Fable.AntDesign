namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type ProgressType = Line | Circle | Dashboard
[<StringEnum; RequireQualifiedAccess>] type ProgressStatus = Success | Exception | Normal | Active
[<StringEnum; RequireQualifiedAccess>] type ProgressLinecap = Round | Square
[<StringEnum; RequireQualifiedAccess>] type ProgressPosition = Top | Left | Bottom | Right

type AntProgress()  =
    inherit AntElement(ofImport "Progress" "antd")
    member x.Type (v: ProgressType) = x.attribute "type" v
    member x.Format (v: (int -> string)) = x.attribute "format" v
    member x.Percent (v: int) = x.attribute "percent" v
    member x.ShowInfo (v: bool) = x.attribute "showInfo" v
    member x.Status (v: ProgressStatus) = x.attribute "status" v
    member x.StrokeLinecap (v: ProgressLinecap) = x.attribute "strokeLinecap" v
    member x.StrokeColor (v: string) = x.attribute "strokeColor" v
    member x.SuccessPercent (v: int) = x.attribute "successPercent" v
    member x.StrokeWidth (v: int) = x.attribute "strokeWidth" v
    member x.Width (v: string) = x.attribute "width" v
    member x.GapDegree (v: int) = x.attribute "gapDegree" v
    member x.GapPosition (v: ProgressPosition) = x.attribute "gapPosition" v
