namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<AutoOpen>]
module Alert =
    
    [<StringEnum; RequireQualifiedAccess>] type AntAlertType = Success | Info | Warning | Error

    [<RequireQualifiedAccess>]
    type AntAlert  =
        | AfterClose of (unit -> unit)
        | Banner of bool
        | Closable of bool
        | CloseText of ReactElement
        | Description of ReactElement
        | Icon of ReactElement
        | Message of ReactElement
        | ShowIcon of bool
        | Type of AntAlertType
        | OnClose of (Event -> unit)
        static member Custom (key: string, value: obj): AntAlert = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntAlert = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antAlert (props: AntAlert list) (children: ReactElement list): ReactElement =
       ofImport "Alert" "antd" (keyValueList CaseRules.LowerFirst props) children
    