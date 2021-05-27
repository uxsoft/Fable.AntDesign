module Fable.AntDesign.Grid

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type RowAlign = Top | Middle | Bottom

[<StringEnum; RequireQualifiedAccess>]
type RowJustify =  Start | End | Center | [<CompiledName("space-around")>] SpaceAround | [<CompiledName("space-between")>] SpaceBetween

type ColProp =
    | Flex of string 
    | Offset of int 
    | Order of int 
    | Pull of int 
    | Push of int 
    | Span of int 
    | Xs of int 
    | Sm of int 
    | Md of int 
    | Lg of int 
    | Xl of int 
    | Xxl of int 

type RowBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Row" "antd" (createObj s.Attributes) s.Children
    
    [<CustomOperation("align")>] member _.align (x: DSLElement, v: RowAlign) = x.attr "align" v 
    [<CustomOperation("gutter")>] member _.gutter (x: DSLElement, v: int) = x.attr "gutter" v  
    [<CustomOperation("justify")>] member _.justify (x: DSLElement, v: RowJustify) = x.attr "justify" v 

type ColBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Col" "antd" (createObj s.Attributes) s.Children
    
    [<CustomOperation("flex")>] member _.flex (x: DSLElement, v: string) = x.attr "flex" v 
    [<CustomOperation("offset")>] member _.offset (x: DSLElement, v: int) = x.attr "offset" v 
    [<CustomOperation("order")>] member _.order (x: DSLElement, v: int) = x.attr "order" v 
    [<CustomOperation("pull")>] member _.pull (x: DSLElement, v: int) = x.attr "pull" v 
    [<CustomOperation("push")>] member _.push (x: DSLElement, v: int) = x.attr "push" v 
    [<CustomOperation("span")>] member _.span (x: DSLElement, v: int) = x.attr "span" v 
    [<CustomOperation("xs")>] member _.xs (x: DSLElement, v: int) = x.attr "xs" v 
    [<CustomOperation("sm")>] member _.sm (x: DSLElement, v: int) = x.attr "sm" v 
    [<CustomOperation("md")>] member _.md (x: DSLElement, v: int) = x.attr "md" v 
    [<CustomOperation("lg")>] member _.lg (x: DSLElement, v: int) = x.attr "lg" v 
    [<CustomOperation("xl")>] member _.xl (x: DSLElement, v: int) = x.attr "xl" v 
    [<CustomOperation("xxl")>] member _.xxl (x: DSLElement, v: int) = x.attr "xxl" v 