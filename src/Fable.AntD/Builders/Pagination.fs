module Fable.AntD.Builders.Pagination

open System
open Fable.AntD.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

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

type PaginationSettings =
    | Current of int
    | DefaultCurrent of int
    | DefaultPageSize of int
    | Disabled of bool
    | HideOnSinglePage of bool
    | ItemRender of (int * PaginationType -> ReactElement)
    | PageSize of int
    | PageSizeOptions of string array
    | Responsive of bool
    | ShowLessItems of bool
    | ShowQuickJumper of bool
    | ShowSizeChanger of bool
    | ShowTitle of bool
    | ShowTotal of (int * int -> bool)
    | Simple of bool
    | Size of PaginationSize
    | Total of int
    | OnChange of (int * int -> unit)
    | OnShowSizeChange of (int * int -> unit)
    
type PaginationBuilder() =
    inherit ReactBuilder()
    
    member _.Run(s: DSLElement) = ofImport "Pagination" "antd" (createObj s.Attributes) s.Children
        
    [<CustomOperation("current")>] member _.current (x: DSLElement, v: int) = x.attr "current" v
    [<CustomOperation("defaultCurrent")>] member _.defaultCurrent (x: DSLElement, v: int) = x.attr "defaultCurrent" v
    [<CustomOperation("defaultPageSize")>] member _.defaultPageSize (x: DSLElement, v: int) = x.attr "defaultPageSize" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("hideOnSinglePage")>] member _.hideOnSinglePage (x: DSLElement) = x.attr "hideOnSinglePage" true
    [<CustomOperation("itemRender")>] member _.itemRender (x: DSLElement, v: Func<int, PaginationType, ReactElement, ReactElement>) = x.attr "itemRender" v
    [<CustomOperation("pageSize")>] member _.pageSize (x: DSLElement, v: int) = x.attr "pageSize" v
    [<CustomOperation("pageSizeOptions")>] member _.pageSizeOptions (x: DSLElement, v: string []) = x.attr "pageSizeOptions" v
    [<CustomOperation("showLessItems")>] member _.showLessItems (x: DSLElement, v: bool) = x.attr "showLessItems" v
    [<CustomOperation("showQuickJumper")>] member _.showQuickJumper (x: DSLElement) = x.attr "showQuickJumper" true
    [<CustomOperation("showSizeChanger")>] member _.showSizeChanger (x: DSLElement) = x.attr "showSizeChanger" true
    [<CustomOperation("showTitle")>] member _.showTitle (x: DSLElement) = x.attr "showTitle" true
    [<CustomOperation("showTotal")>] member _.showTotal (x: DSLElement, v: Func<int, int * int, ReactElement>) = x.attr "showTotal" v
    [<CustomOperation("simple")>] member _.simple (x: DSLElement) = x.attr "simple" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: PaginationSize) = x.attr "size" v
    [<CustomOperation("responsive")>] member _.responsive (x: DSLElement) = x.attr "responsive" true
    [<CustomOperation("total")>] member _.total (x: DSLElement, v: int) = x.attr "total" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Func<int, int, unit>) = x.attr "onChange" v
    [<CustomOperation("onShowSizeChange")>] member _.onShowSizeChange (x: DSLElement, v: Func<int, int, unit>) = x.attr "onShowSizeChange" v
    