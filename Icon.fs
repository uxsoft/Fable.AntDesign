namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Icon =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntIconTheme = Filled | Outline | TwoTone
    
    [<RequireQualifiedAccess>]
    type AntIcon =
        | Type of string
        | Theme of AntIconTheme
        | Spin of bool
        | Rotate of float
        | TwoToneColor of string
        static member Custom (key: string, value: obj): AntIcon = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntIcon = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antIcon (props: AntIcon list) (children: ReactElement list): ReactElement =
       ofImport "Icon" "antd" (keyValueList CaseRules.LowerFirst props) children