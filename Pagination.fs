namespace Fable.AntD

open Fable.Core
open Fable.React

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
    
type Pagination() =
    inherit AntElement(ofImport "Pagination" "antd")
    member x.Current with set (v: int) = x.Attribute "current" v 
    member x.DefaultCurrent with set (v: int) = x.Attribute "defaultCurrent" v 
    member x.DefaultPageSize with set (v: int) = x.Attribute "defaultPageSize" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v
    member x.HideOnSinglePage with set (v: bool) = x.Attribute "hideOnSinglePage" v
    member x.ItemRender with set (v: (int -> PaginationType -> ReactElement -> ReactElement)) = x.Attribute "itemRender" v 
    member x.PageSize with set (v: int) = x.Attribute "pageSize" v 
    member x.PageSizeOptions with set (v: string[]) = x.Attribute "pageSizeOptions" v 
    member x.ShowLessItems with set (v: bool) = x.Attribute "showLessItems" v
    member x.ShowQuickJumper with set (v: bool) = x.Attribute "showQuickJumper" v
    member x.ShowSizeChanger with set (v: bool) = x.Attribute "showSizeChanger" v
    member x.ShowTitle with set (v: bool) = x.Attribute "showTitle" v
    member x.ShowTotal with set (v: (int -> int * int -> ReactElement)) = x.Attribute "showTotal" v 
    member x.Simple with set (v: bool) = x.Attribute "simple" v
    member x.Size with set (v: PaginationSize) = x.Attribute "size" v 
    member x.Total with set (v: int) = x.Attribute "total" v 
    member x.OnChange with set (v: (int -> int -> unit)) = x.Attribute "onChange" v 
    member x.OnShowSizeChange with set (v: (int -> int -> unit)) = x.Attribute "onShowSizeChange" v  