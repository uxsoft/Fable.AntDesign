namespace Fable.Builders.AntDesign

open System
open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Progress =
    
    [<StringEnum; RequireQualifiedAccess>]
    type ProgressType = Line | Circle | Dashboard
    
    [<StringEnum; RequireQualifiedAccess>]
    type ProgressStatus = Success | Exception | Normal | Active
    
    [<StringEnum; RequireQualifiedAccess>]
    type ProgressLinecap = Round | Square
    
    [<StringEnum; RequireQualifiedAccess>]
    type ProgressPosition = Top | Left | Bottom | Right
    
    type ProgressProp =
        | Format of Func<int, int, ReactElement>
        | Percent of int
        | ShowInfo of bool
        | Status of ProgressStatus
        | StrokeColor of string
        | StrokeLinecap of ProgressLinecap
        | StrokeWidth of int
        | Success of {| percent: int; strokeColor: string option |}
        | TrailColor of string
        | Width of string
        | GapDegree of int
        | GapPosition of ProgressPosition
        | Steps of int
        | ProgressType of ProgressType
    
    type ProgressBuilder()  =
        inherit ReactBuilder(import "Progress" "antd")
    
        [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: Func<int, int, ReactElement>) = x.attr "format" v
        [<CustomOperation("percent")>] member inline _.percent (x: DSLElement, v: int) = x.attr "percent" v
        [<CustomOperation("showInfo")>] member inline _.showInfo (x: DSLElement, v: bool) = x.attr "showInfo" v
        [<CustomOperation("status")>] member inline _.status (x: DSLElement, v: ProgressStatus) = x.attr "status" v
        [<CustomOperation("strokeColor")>] member inline _.strokeColor (x: DSLElement, v: string) = x.attr "strokeColor" v
        [<CustomOperation("strokeLinecap")>] member inline _.strokeLinecap (x: DSLElement, v: ProgressLinecap) = x.attr "strokeLinecap" v
        [<CustomOperation("strokeWidth")>] member inline _.strokeWidth (x: DSLElement, v: int) = x.attr "strokeWidth" v
        [<CustomOperation("success")>] member inline _.success (x: DSLElement, v: {| percent: int; strokeColor: string option |}) = x.attr "success" v
        [<CustomOperation("trailColor")>] member inline _.trailColor (x: DSLElement, v: string) = x.attr "trailColor" v
        [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: string) = x.attr "width" v
        [<CustomOperation("gapDegree")>] member inline _.gapDegree (x: DSLElement, v: int) = x.attr "gapDegree" v
        [<CustomOperation("gapPosition")>] member inline _.gapPosition (x: DSLElement, v: ProgressPosition) = x.attr "gapPosition" v
        [<CustomOperation("steps")>] member inline _.steps (x: DSLElement, v: int) = x.attr "steps" v
        [<CustomOperation("progressType")>] member inline _.progressType (x: DSLElement, v: ProgressType) = x.attr "type" v
    