namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Button =

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ButtonType =
        | Primary
        | Dashed
        | Ghost
        | Danger

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ButtonSize =
        | Small
        | Default
        | Large

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ButtonShape =
        | Circle
        | [<CompiledName("circle-outline")>] CircleOutline
    
    [<RequireQualifiedAccess>]
    type AntButton =
        | Ghost of bool
        | Href of string
        | Target of string
        | Type of ButtonType
        | HtmlType of string
        | Icon of string
        | Shape of ButtonShape
        | Size of ButtonSize
        | Loading of bool
        | OnClick of (Event -> unit)
        static member Custom (key: string, value: obj): AntButton = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntButton = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antButton (props: AntButton list) (children: ReactElement list): ReactElement =
       ofImport "Button" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antButtonGroup (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Button.Group" "antd" (keyValueList CaseRules.LowerFirst props) children