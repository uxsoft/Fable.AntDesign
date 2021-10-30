namespace Fable.Builders.AntDesign

open Fable.Builders
open Fable.Builders.Common
open Fable.Core
open Feliz
open Fable.Core.JsInterop

[<AutoOpen>]
module Button =

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
    
    [<RequireQualifiedAccess>]
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
        inherit ReactBuilder(import "Button" "antd")
        
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("ghost")>] member inline _.ghost (x: DSLElement, v: bool) = x.attr "ghost" v
        [<CustomOperation("href")>] member inline _.href (x: DSLElement, v: string) = x.attr "href" v
        [<CustomOperation("htmlType")>] member inline _.htmlType (x: DSLElement, v: ButtonHtmlType) = x.attr "htmlType" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v
        [<CustomOperation("shape")>] member inline _.shape (x: DSLElement, v: ButtonShape) = x.attr "shape" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("target")>] member inline _.target (x: DSLElement, v: string) = x.attr "target" v
        [<CustomOperation("buttonType")>] member inline _.buttonType (x: DSLElement, v: ButtonType) = x.attr "type" v
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: Browser.Types.Event -> unit) = x.attr "onClick" v
        [<CustomOperation("block")>] member inline _.block (x: DSLElement, v: bool) = x.attr "block" v
        [<CustomOperation("danger")>] member inline _.danger (x: DSLElement, v: bool) = x.attr "danger" v
    
    type ButtonGroupBuilder() =
        inherit ReactBuilder(import "Button.Group" "antd")
