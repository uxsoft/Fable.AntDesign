namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Progress =
    
    [<StringEnum; RequireQualifiedAccess>] type AntProgressType = Line | Circle | Dashboard
    [<StringEnum; RequireQualifiedAccess>] type AntProgressStatus = Success | Exception | Normal | Active
    [<StringEnum; RequireQualifiedAccess>] type AntProgressLinecap = Round | Square
    [<StringEnum; RequireQualifiedAccess>] type AntProgressPosition = Top | Left | Bottom | Right
    
    [<RequireQualifiedAccess>]
    type AntProgress  =
        | Type of AntProgressType
        | Format of (int -> string)
        | Percent of int
        | ShowInfo of bool
        | Status of AntProgressStatus
        | StrokeLinecap of AntProgressLinecap
        | StrokeColor of string
        | SuccessPercent of int
        | StrokeWidth of int
        | Width of string
        | GapDegree of int
        | GapPosition of AntProgressPosition
        static member Custom (key: string, value: obj): AntProgress = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntProgress = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antProgress (props: AntProgress list) (children: ReactElement list): ReactElement =
       ofImport "Progress" "antd" (keyValueList CaseRules.LowerFirst props) children
    