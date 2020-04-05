namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type RowAlign = Top | Middle | Bottom

[<StringEnum; RequireQualifiedAccess>]
type RowJustify =  Start | End | Center | [<CompiledName("space-around")>] SpaceAround | [<CompiledName("space-between")>] SpaceBetween

type Row() =
    inherit AntElement(ofImport "Row" "antd")
    member x.Align with set (v: RowAlign) = x.Attribute "align" v 
    member x.Gutter with set (v: int) = x.Attribute "gutter" v  
    member x.Justify with set (v: RowJustify) = x.Attribute "justify" v 

type Column() =
    inherit AntElement(ofImport "Col" "antd")
    member x.Flex with set (v: string) = x.Attribute "flex" v 
    member x.Offset with set (v: int) = x.Attribute "offset" v 
    member x.Order with set (v: int) = x.Attribute "order" v 
    member x.Pull with set (v: int) = x.Attribute "pull" v 
    member x.Push with set (v: int) = x.Attribute "push" v 
    member x.Span with set (v: int) = x.Attribute "span" v 
    member x.Xs with set (v: int) = x.Attribute "xs" v 
    member x.Sm with set (v: int) = x.Attribute "sm" v 
    member x.Md with set (v: int) = x.Attribute "md" v 
    member x.Lg with set (v: int) = x.Attribute "lg" v 
    member x.Xl with set (v: int) = x.Attribute "xl" v 
    member x.Xxl with set (v: int) = x.Attribute "xxl" v 