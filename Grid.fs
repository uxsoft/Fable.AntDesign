namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type RowAlign = Top | Middle | Bottom

[<StringEnum; RequireQualifiedAccess>]
type RowJustify =  Start | End | Center | [<CompiledName("space-around")>] SpaceAround | [<CompiledName("space-between")>] SpaceBetween

type AntRow() =
    inherit AntElement<AntRow>(ofImport "Row" "antd")
    member x.align (v: RowAlign) = x.attribute "align" v 
    member x.gutter (v: int) = x.attribute "gutter" v  
    member x.justify (v: RowJustify) = x.attribute "justify" v 

type AntColumn() =
    inherit AntElement<AntColumn>(ofImport "Col" "antd")
    member x.flex (v: string) = x.attribute "flex" v 
    member x.offset (v: int) = x.attribute "offset" v 
    member x.order (v: int) = x.attribute "order" v 
    member x.pull (v: int) = x.attribute "pull" v 
    member x.push (v: int) = x.attribute "push" v 
    member x.span (v: int) = x.attribute "span" v 
    member x.xs (v: int) = x.attribute "xs" v 
    member x.sm (v: int) = x.attribute "sm" v 
    member x.md (v: int) = x.attribute "md" v 
    member x.lg (v: int) = x.attribute "lg" v 
    member x.xl (v: int) = x.attribute "xl" v 
    member x.xxl (v: int) = x.attribute "xxl" v 