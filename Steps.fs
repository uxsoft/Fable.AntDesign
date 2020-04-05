namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
 
[<StringEnum; RequireQualifiedAccess>]
type StepsType = Default | Navigation

[<StringEnum; RequireQualifiedAccess>]
type StepsOrientation = Horizontal | Vertical

[<StringEnum; RequireQualifiedAccess>]
type StepsStatus = Process | Wait | Error | Finish


type Steps()  =
    inherit AntElement(ofImport "Steps" "antd")
    member x.ClassName with set (v: string) = x.Attribute "className" v
    member x.Type with set (v: StepsType) = x.Attribute "type" v
    member x.Current with set (v: int) = x.Attribute "current" v
    member x.Direction with set (v: StepsOrientation) = x.Attribute "direction" v
    member x.LabelPlacement with set (v: StepsOrientation  ) = x.Attribute "labelPlacement" v
    member x.ProgressDot with set (v: bool) = x.Attribute "progressDot" v
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Status with set (v: StepsStatus) = x.Attribute "status" v
    member x.Initial with set (v: int) = x.Attribute "initial" v
    member x.OnChange with set (v: (int -> unit)) = x.Attribute "onChange" v

type StepsItem()  =
    inherit AntElement(ofImport "Steps.Step" "antd")
    member x.Description with set (v: ReactElement) = x.Attribute "description" v
    member x.Icon with set (v: ReactElement) = x.Attribute "icon" v
    member x.Status with set (v: StepsStatus) = x.Attribute "status" v
    member x.Title with set (v: ReactElement) = x.Attribute "title" v
    member x.SubTitle with set (v: ReactElement) = x.Attribute "subTitle" v
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v