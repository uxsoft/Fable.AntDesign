namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type ButtonType =
    | Primary
    | Ghost
    | Dashed
    | Link
    | Text
    | Default
    
[<StringEnum; RequireQualifiedAccess>]
type ButtonHtmlType =
    | Submit
    | Reset
    | Button

[<StringEnum; RequireQualifiedAccess>]
type ButtonShape =
    | Circle
    | Round

type AntButton() =
    inherit AntElement<AntButton>(ofImport "Button" "antd")
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.ghost (?v: bool) = x.attribute "ghost" (Option.defaultValue true v)
    member x.href (v: string) = x.attribute "href" v
    member x.htmlType (v: ButtonHtmlType) = x.attribute "htmlType" v
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.loading (v: bool) = x.attribute "loading" v
    member x.shape (v: ButtonShape) = x.attribute "shape" v
    member x.size (v: Size) = x.attribute "size" v
    member x.target (v: string) = x.attribute "target" v
    member x.buttonType (v: ButtonType) = x.attribute "type" v
    member x.onClick (v: Event -> unit) = x.attribute "onClick" v
    member x.block (?v: bool) = x.attribute "block" (Option.defaultValue true v)
    member x.danger (?v: bool) = x.attribute "danger" (Option.defaultValue true v)

type AntButtonGroup() =
    inherit AntElement<AntButtonGroup>(ofImport "Button.Group" "antd")