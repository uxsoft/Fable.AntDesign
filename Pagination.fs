namespace Fable.AntD

open Fable.Core
open Fable.React
open System

[<StringEnum; RequireQualifiedAccess>]
type PaginationType =
    | Page
    | Prev
    | Next
    | [<CompiledName("jump-prev")>] JumpPrev
    | [<CompiledName("jump-next")>] JumpNext

[<StringEnum; RequireQualifiedAccess>]
type PaginationSize =
    | Small
    | Default

type AntPagination() =
    inherit AntElement<AntPagination>(ofImport "Pagination" "antd")
    member x.current (v: int) = x.attribute "current" v
    member x.defaultCurrent (v: int) = x.attribute "defaultCurrent" v
    member x.defaultPageSize (v: int) = x.attribute "defaultPageSize" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.hideOnSinglePage (v: bool) = x.attribute "hideOnSinglePage" v
    member x.itemRender (v: Func<int, PaginationType, ReactElement, ReactElement>) = x.attribute "itemRender" v
    member x.pageSize (v: int) = x.attribute "pageSize" v
    member x.pageSizeOptions (v: string []) = x.attribute "pageSizeOptions" v
    member x.showLessItems (v: bool) = x.attribute "showLessItems" v
    member x.showQuickJumper (v: bool) = x.attribute "showQuickJumper" v
    member x.showSizeChanger (v: bool) = x.attribute "showSizeChanger" v
    member x.showTitle (v: bool) = x.attribute "showTitle" v
    member x.showTotal (v: Func<int, int * int, ReactElement>) = x.attribute "showTotal" v
    member x.simple (v: bool) = x.attribute "simple" v
    member x.size (v: PaginationSize) = x.attribute "size" v
    member x.total (v: int) = x.attribute "total" v
    member x.onChange (v: Func<int, int, unit>) = x.attribute "onChange" v
    member x.onShowSizeChange (v: Func<int, int, unit>) = x.attribute "onShowSizeChange" v