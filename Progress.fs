namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type ProgressType = Line | Circle | Dashboard
[<StringEnum; RequireQualifiedAccess>] type ProgressStatus = Success | Exception | Normal | Active
[<StringEnum; RequireQualifiedAccess>] type ProgressLinecap = Round | Square
[<StringEnum; RequireQualifiedAccess>] type ProgressPosition = Top | Left | Bottom | Right

type Progress()  =
    inherit AntElement(ofImport "Progress" "antd")
    member x.Type with set (v: ProgressType) = x.Attribute "type" v
    member x.Format with set (v: (int -> string)) = x.Attribute "format" v
    member x.Percent with set (v: int) = x.Attribute "percent" v
    member x.ShowInfo with set (v: bool) = x.Attribute "showInfo" v
    member x.Status with set (v: ProgressStatus) = x.Attribute "status" v
    member x.StrokeLinecap with set (v: ProgressLinecap) = x.Attribute "strokeLinecap" v
    member x.StrokeColor with set (v: string) = x.Attribute "strokeColor" v
    member x.SuccessPercent with set (v: int) = x.Attribute "successPercent" v
    member x.StrokeWidth with set (v: int) = x.Attribute "strokeWidth" v
    member x.Width with set (v: string) = x.Attribute "width" v
    member x.GapDegree with set (v: int) = x.Attribute "gapDegree" v
    member x.GapPosition with set (v: ProgressPosition) = x.Attribute "gapPosition" v
