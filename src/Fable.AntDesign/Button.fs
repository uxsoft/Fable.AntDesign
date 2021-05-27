module Fable.AntDesign.Button

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

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

type ButtonProp =
    | Disabled of bool
    | Ghost of bool
    | Href of string
    | HtmlType of ButtonHtmlType
    | Icon of ReactElement
    | Loading of bool
    | Shape of ButtonShape
    | Size of Common.Size
    | Target of string
    | Type of ButtonType
    | OnClick of (Browser.Types.Event -> unit)
    | Block of bool
    | Danger of bool

type ButtonBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Button" "antd" (createObj s.Attributes) s.Children
    
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("ghost")>] member _.ghost (x: DSLElement, v: bool) = x.attr "ghost" v
    [<CustomOperation("href")>] member _.href (x: DSLElement, v: string) = x.attr "href" v
    [<CustomOperation("htmlType")>] member _.htmlType (x: DSLElement, v: ButtonHtmlType) = x.attr "htmlType" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("loading")>] member _.loading (x: DSLElement, v: bool) = x.attr "loading" v
    [<CustomOperation("shape")>] member _.shape (x: DSLElement, v: ButtonShape) = x.attr "shape" v
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("target")>] member _.target (x: DSLElement, v: string) = x.attr "target" v
    [<CustomOperation("buttonType")>] member _.buttonType (x: DSLElement, v: ButtonType) = x.attr "type" v
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: Browser.Types.Event -> unit) = x.attr "onClick" v
    [<CustomOperation("block")>] member _.block (x: DSLElement, v: bool) = x.attr "block" v
    [<CustomOperation("danger")>] member _.danger (x: DSLElement, v: bool) = x.attr "danger" v

type ButtonGroupBuilder() =
    inherit ReactBuilder()
    
    member x.Run(s: DSLElement) =
        ofImport "Button.Group" "antd" (createObj s.Attributes) s.Children
