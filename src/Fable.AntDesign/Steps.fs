module Fable.AntDesign.Steps

open Fable.AntDesign.Common
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

    [<CustomOperation("stepsType")>] member inline _.stepsType (x: DSLElement, v: StepsType) = x.attr "type" v
    [<CustomOperation("current")>] member inline _.current (x: DSLElement, v: int) = x.attr "current" v
    [<CustomOperation("direction")>] member inline _.direction (x: DSLElement, v: StepsOrientation) = x.attr "direction" v
    [<CustomOperation("labelPlacement")>] member inline _.labelPlacement (x: DSLElement, v: StepsOrientation) = x.attr "labelPlacement" v
    [<CustomOperation("progressDot")>] member inline _.progressDot (x: DSLElement, v: bool) = x.attr "progressDot" v
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("status")>] member inline _.status (x: DSLElement, v: StepsStatus) = x.attr "status" v
    [<CustomOperation("initial")>] member inline _.initial (x: DSLElement, v: int) = x.attr "initial" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: int -> unit) = x.attr "onChange" v

type StepBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Steps.Step" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: ReactElement) = x.attr "description" v
    [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("status")>] member inline _.status (x: DSLElement, v: StepsStatus) = x.attr "status" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("subTitle")>] member inline _.subTitle (x: DSLElement, v: ReactElement) = x.attr "subTitle" v
    [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    