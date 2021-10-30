namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Grid =

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
        inherit ReactBuilder(import "Row" "antd")
        
        [<CustomOperation("align")>] member inline _.align (x: DSLElement, v: RowAlign) = x.attr "align" v 
        [<CustomOperation("gutter")>] member inline _.gutter (x: DSLElement, v: int) = x.attr "gutter" v  
        [<CustomOperation("justify")>] member inline _.justify (x: DSLElement, v: RowJustify) = x.attr "justify" v
        [<CustomOperation("wrap")>] member inline _.wrap (x: DSLElement, v: bool) = x.attr "wrap" v
    
    type ColBuilder() =
        inherit ReactBuilder(import "Col" "antd")
        
        [<CustomOperation("flex")>] member inline _.flex (x: DSLElement, v: string) = x.attr "flex" v 
        [<CustomOperation("offset")>] member inline _.offset (x: DSLElement, v: int) = x.attr "offset" v 
        [<CustomOperation("order")>] member inline _.order (x: DSLElement, v: int) = x.attr "order" v 
        [<CustomOperation("pull")>] member inline _.pull (x: DSLElement, v: int) = x.attr "pull" v 
        [<CustomOperation("push")>] member inline _.push (x: DSLElement, v: int) = x.attr "push" v 
        [<CustomOperation("span")>] member inline _.span (x: DSLElement, v: int) = x.attr "span" v 
        [<CustomOperation("xs")>] member inline _.xs (x: DSLElement, v: int) = x.attr "xs" v 
        [<CustomOperation("sm")>] member inline _.sm (x: DSLElement, v: int) = x.attr "sm" v 
        [<CustomOperation("md")>] member inline _.md (x: DSLElement, v: int) = x.attr "md" v 
        [<CustomOperation("lg")>] member inline _.lg (x: DSLElement, v: int) = x.attr "lg" v 
        [<CustomOperation("xl")>] member inline _.xl (x: DSLElement, v: int) = x.attr "xl" v 
        [<CustomOperation("xxl")>] member inline _.xxl (x: DSLElement, v: int) = x.attr "xxl" v 