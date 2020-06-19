namespace Fable.AntD

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

type AntSteps() =
    inherit AntElement<AntSteps>(ofImport "Steps" "antd")
    member x.className (v: string) = x.attribute "className" v
    member x.stepsType (v: StepsType) = x.attribute "type" v
    member x.current (v: int) = x.attribute "current" v
    member x.direction (v: StepsOrientation) = x.attribute "direction" v
    member x.labelPlacement (v: StepsOrientation) = x.attribute "labelPlacement" v
    member x.progressDot (v: bool) = x.attribute "progressDot" v
    member x.size (v: Size) = x.attribute "size" v
    member x.status (v: StepsStatus) = x.attribute "status" v
    member x.initial (v: int) = x.attribute "initial" v
    member x.onChange (v: int -> unit) = x.attribute "onChange" v

type AntStepsItem() =
    inherit AntElement<AntStepsItem>(ofImport "Steps.Step" "antd")
    member x.description (v: ReactElement) = x.attribute "description" v
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.status (v: StepsStatus) = x.attribute "status" v
    member x.title (v: ReactElement) = x.attribute "title" v
    member x.subTitle (v: ReactElement) = x.attribute "subTitle" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    