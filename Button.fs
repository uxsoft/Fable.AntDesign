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
    type AntButtonType =
        | Primary
        | Dashed
        | Ghost
        | Link
        | Default

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntButtonShape =
        | Circle
        | Round
    
    [<RequireQualifiedAccess>]
    type AntButton =
        | Disabled of bool
        | Ghost of bool
        | Href of string
        | HtmlType of string
        | Icon of ReactElement
        | Loading of bool
        | Shape of AntButtonShape
        | Size of Common.Size
        | Target of string
        | Type of AntButtonType
        | OnClick of (Event -> unit)
        | Block of bool
        | Danger of bool
        static member Custom (key: string, value: obj): AntButton = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntButton = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antButton (props: AntButton list) (children: ReactElement list): ReactElement =
       ofImport "Button" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antButtonGroup (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Button.Group" "antd" (keyValueList CaseRules.LowerFirst props) children