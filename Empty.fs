namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Empty =
    
    [<RequireQualifiedAccess>]
    type AntEmpty  =
        | Description of ReactElement
        | Image of ReactElement
        static member Custom (key: string, value: obj): AntEmpty = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntEmpty = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member ImageStyle (css: Props.CSSProp list): AntEmpty = unbox ("imageStyle", keyValueList CaseRules.LowerFirst css)
        
    let inline antEmpty (props: AntEmpty list) (children: ReactElement list): ReactElement =
       ofImport "Empty" "antd" (keyValueList CaseRules.LowerFirst props) children
    