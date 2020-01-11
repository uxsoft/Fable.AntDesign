namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Affix =
    
    [<RequireQualifiedAccess>]
    type AntAffix  =
        | OffsetBottom of float
        | OffsetTop of float
        | Target of (unit -> ReactElement)
        | OnChange of (ReactElement -> unit)
        static member Custom (key: string, value: obj): AntAffix = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntAffix = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antAffix (props: AntAffix list) (children: ReactElement list): ReactElement =
       ofImport "Affix" "antd" (keyValueList CaseRules.LowerFirst props) children
    