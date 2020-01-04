namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module PageHeader =
    
    [<RequireQualifiedAccess>]
    type AntPageHeader =
        | Title of ReactElement
        | SubTitle of ReactElement
        | Ghost of bool
        | Avatar of ReactElement 
        | BackIcon of ReactElement
        | [<CompiledName("tags")>] TagList of ReactElement list
        | Extra of ReactElement
        | Breadcrumb of ReactElement
        | Footer of ReactElement
        | OnChange of (unit -> unit)
        static member Custom (key: string, value: obj): AntPageHeader = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntPageHeader = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antPageHeader (props: AntPageHeader list) (children: ReactElement list): ReactElement =
       ofImport "PageHeader" "antd" (keyValueList CaseRules.LowerFirst props) children
       