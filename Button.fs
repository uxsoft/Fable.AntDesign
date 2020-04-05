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

type Button() =
    inherit AntElement(ofImport "Button" "antd")
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v
    member x.Ghost with set (v: bool) = x.Attribute "ghost" v
    member x.Href with set (v: string) = x.Attribute "href" v
    member x.HtmlType with set (v: string) = x.Attribute "htmlType" v
    member x.Icon with set (v: ReactElement) = x.Attribute "icon" v
    member x.Loading with set (v: bool) = x.Attribute "loading" v
    member x.Shape with set (v: ButtonShape) = x.Attribute "shape" v
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Target with set (v: string) = x.Attribute "target" v
    member x.Type with set (v: ButtonType) = x.Attribute "type" v
    member x.OnClick with set (v: Event -> unit) = x.Attribute "onClick" v
    member x.Block with set (v: bool) = x.Attribute "block" v
    member x.Danger with set (v: bool) = x.Attribute "danger" v

type ButtonGroup() =
    inherit AntElement(ofImport "Button.Group" "antd")