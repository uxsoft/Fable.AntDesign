namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Divider =
    [<StringEnum; RequireQualifiedAccess>] type AntDividerOrientation = Left | Right | Center
    [<StringEnum; RequireQualifiedAccess>] type AntDividerType = Horizontal | Vertical
            
    [<RequireQualifiedAccess>]
    type AntDivider  =
        | ClassName of string
        | Dashed of bool
        | Orientation of AntDividerOrientation
        | Type of AntDividerType
        static member Custom (key: string, value: obj): AntDivider = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntDivider = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antDivider (props: AntDivider list) (children: ReactElement list): ReactElement =
       ofImport "Divider" "antd" (keyValueList CaseRules.LowerFirst props) children
    