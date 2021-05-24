module Fable.AntD.Builders.Steps

open Fable.AntD.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type StepsType =
    | Default
    | Navigation

[<StringEnum; RequireQualifiedAccess>]
type StepsOrientation =
    | Horizontal
    | Vertical

[<StringEnum; RequireQualifiedAccess>]
type StepsStatus =
    | Process
    | Wait
    | Error
    | Finish

type StepsBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Steps" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("stepsType")>] member _.stepsType (x: DSLElement, v: StepsType) = x.attr "type" v
    [<CustomOperation("current")>] member _.current (x: DSLElement, v: int) = x.attr "current" v
    [<CustomOperation("direction")>] member _.direction (x: DSLElement, v: StepsOrientation) = x.attr "direction" v
    [<CustomOperation("labelPlacement")>] member _.labelPlacement (x: DSLElement, v: StepsOrientation) = x.attr "labelPlacement" v
    [<CustomOperation("progressDot")>] member _.progressDot (x: DSLElement) = x.attr "progressDot" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("status")>] member _.status (x: DSLElement, v: StepsStatus) = x.attr "status" v
    [<CustomOperation("initial")>] member _.initial (x: DSLElement, v: int) = x.attr "initial" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: int -> unit) = x.attr "onChange" v

type StepBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Steps.Step" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("description")>] member _.description (x: DSLElement, v: ReactElement) = x.attr "description" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("status")>] member _.status (x: DSLElement, v: StepsStatus) = x.attr "status" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("subTitle")>] member _.subTitle (x: DSLElement, v: ReactElement) = x.attr "subTitle" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    