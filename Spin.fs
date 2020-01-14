namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Spin =
    
    [<RequireQualifiedAccess>]
    type AntSpin  =
        | Delay of int
        | Indicator of ReactElement
        | Size of Size
        | Spinning of bool
        | Tip of string
        | WrapperClassName of string
        static member Custom (key: string, value: obj): AntSpin = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSpin = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antSpin (props: AntSpin list) (children: ReactElement list): ReactElement =
       ofImport "Spin" "antd" (keyValueList CaseRules.LowerFirst props) children
    