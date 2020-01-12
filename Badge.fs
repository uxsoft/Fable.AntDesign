namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Badge =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntBadgeStatus = Success | Processing | Default | Error | Warning

    [<RequireQualifiedAccess>]
    type AntBadge  =
        | Color of string
        | Count of ReactElement
        | Dot of bool
        | Offset of float array
        | OverflowCount of int
        | ShowZero of bool
        | Status of AntBadgeStatus
        | Text of string
        | Title of string
        static member Custom (key: string, value: obj): AntBadge = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntBadge = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antBadge (props: AntBadge list) (children: ReactElement list): ReactElement =
       ofImport "Badge" "antd" (keyValueList CaseRules.LowerFirst props) children
    