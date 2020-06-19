namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type ButtonType =
    | Primary
    | Dashed
    | Ghost
    | Link
    | Default

[<StringEnum; RequireQualifiedAccess>]
type ButtonShape =
    | Circle
    | Round

type AntButton() =
    inherit AntElement<AntButton>(ofImport "Button" "antd")
    member x.Disabled (v: bool) = x.attribute "disabled" v
    member x.Ghost (v: bool) = x.attribute "ghost" v
    member x.Href (v: string) = x.attribute "href" v
    member x.HtmlType (v: string) = x.attribute "htmlType" v
    member x.Icon (v: ReactElement) = x.attribute "icon" v
    member x.Loading (v: bool) = x.attribute "loading" v
    member x.Shape (v: ButtonShape) = x.attribute "shape" v
    member x.Size (v: Size) = x.attribute "size" v
    member x.Target (v: string) = x.attribute "target" v
    member x.Type (v: ButtonType) = x.attribute "type" v
    member x.OnClick (v: Event -> unit) = x.attribute "onClick" v
    member x.Block (v: bool) = x.attribute "block" v
    member x.Danger (v: bool) = x.attribute "danger" v

type AntButtonGroup() =
    inherit AntElement<AntButtonGroup>(ofImport "Button.Group" "antd")