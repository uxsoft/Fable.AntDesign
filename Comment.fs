namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Comment =
    
    [<RequireQualifiedAccess>]
    type AntComment  =
        | Actions of ReactElement array
        | Author of ReactElement
        | Avatar of ReactElement
        | Content of ReactElement
        | Datetime of ReactElement
        static member Custom (key: string, value: obj): AntComment = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntComment = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antComment (props: AntComment list) (children: ReactElement list): ReactElement =
       ofImport "Comment" "antd" (keyValueList CaseRules.LowerFirst props) children
    