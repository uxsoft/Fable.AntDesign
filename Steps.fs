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
    inherit AntElement(ofImport "Steps" "antd")
    member x.ClassName
        (v: string) = x.attribute "className" v
    member x.Type
        (v: StepsType) = x.attribute "type" v
    member x.Current
        (v: int) = x.attribute "current" v
    member x.Direction
        (v: StepsOrientation) = x.attribute "direction" v
    member x.LabelPlacement
        (v: StepsOrientation) = x.attribute "labelPlacement" v
    member x.ProgressDot
        (v: bool) = x.attribute "progressDot" v
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.Status
        (v: StepsStatus) = x.attribute "status" v
    member x.Initial
        (v: int) = x.attribute "initial" v
    member x.OnChange
        (v: int -> unit) = x.attribute "onChange" v

type AntStepsItem() =
    inherit AntElement(ofImport "Steps.Step" "antd")
    member x.Description
        (v: ReactElement) = x.attribute "description" v
    member x.Icon
        (v: ReactElement) = x.attribute "icon" v
    member x.Status
        (v: StepsStatus) = x.attribute "status" v
    member x.Title
        (v: ReactElement) = x.attribute "title" v
    member x.SubTitle
        (v: ReactElement) = x.attribute "subTitle" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
