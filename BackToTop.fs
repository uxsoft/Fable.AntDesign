namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module BackToTop =
    
    [<RequireQualifiedAccess>]
    type AntBackToTop  =
        | Target of (unit -> HTMLElement)
        | VisibilityHeight of int
        | OnClick of (unit -> unit)
        static member Custom (key: string, value: obj): AntBackToTop = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntBackToTop = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antBackToTop (props: AntBackToTop list) (children: ReactElement list): ReactElement =
       ofImport "BackTop" "antd" (keyValueList CaseRules.LowerFirst props) children
    