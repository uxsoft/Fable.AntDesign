namespace Fable.Builders.AntDesign

open System
open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Pagination =

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
    
    type PaginationProp =
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
        inherit ReactBuilder(import "Pagination" "antd")
        
        [<CustomOperation("current")>] member inline _.current (x: DSLElement, v: int) = x.attr "current" v
        [<CustomOperation("defaultCurrent")>] member inline _.defaultCurrent (x: DSLElement, v: int) = x.attr "defaultCurrent" v
        [<CustomOperation("defaultPageSize")>] member inline _.defaultPageSize (x: DSLElement, v: int) = x.attr "defaultPageSize" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("hideOnSinglePage")>] member inline _.hideOnSinglePage (x: DSLElement, v: bool) = x.attr "hideOnSinglePage" v
        [<CustomOperation("itemRender")>] member inline _.itemRender (x: DSLElement, v: Func<int, PaginationType, ReactElement, ReactElement>) = x.attr "itemRender" v
        [<CustomOperation("pageSize")>] member inline _.pageSize (x: DSLElement, v: int) = x.attr "pageSize" v
        [<CustomOperation("pageSizeOptions")>] member inline _.pageSizeOptions (x: DSLElement, v: string []) = x.attr "pageSizeOptions" v
        [<CustomOperation("showLessItems")>] member inline _.showLessItems (x: DSLElement, v: bool) = x.attr "showLessItems" v
        [<CustomOperation("showQuickJumper")>] member inline _.showQuickJumper (x: DSLElement, v: bool) = x.attr "showQuickJumper" v
        [<CustomOperation("showSizeChanger")>] member inline _.showSizeChanger (x: DSLElement, v: bool) = x.attr "showSizeChanger" v
        [<CustomOperation("showTitle")>] member inline _.showTitle (x: DSLElement, v: bool) = x.attr "showTitle" v
        [<CustomOperation("showTotal")>] member inline _.showTotal (x: DSLElement, v: Func<int, int * int, ReactElement>) = x.attr "showTotal" v
        [<CustomOperation("simple")>] member inline _.simple (x: DSLElement, v: bool) = x.attr "simple" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: PaginationSize) = x.attr "size" v
        [<CustomOperation("responsive")>] member inline _.responsive (x: DSLElement, v: bool) = x.attr "responsive" v
        [<CustomOperation("total")>] member inline _.total (x: DSLElement, v: int) = x.attr "total" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<int, int, unit>) = x.attr "onChange" v
        [<CustomOperation("onShowSizeChange")>] member inline _.onShowSizeChange (x: DSLElement, v: Func<int, int, unit>) = x.attr "onShowSizeChange" v
        