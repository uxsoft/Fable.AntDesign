namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type ColumnCount =  
    | [<CompiledName("1")>] One
    | [<CompiledName("2")>] Two
    | [<CompiledName("3")>] Three
    | [<CompiledName("4")>] Four
    | [<CompiledName("6")>] Six
    | [<CompiledName("8")>] Eight
    | [<CompiledName("12")>] Twelve
    | [<CompiledName("24")>] TwentyFour

[<StringEnum; RequireQualifiedAccess>]
type ColumnType = 
    | Gutter 
    | Column
    | Xs 
    | Sm 
    | Md 
    | Lg 
    | Xl 
    | Xxl

type ListGridType = {
  gutter: int option
  column: ColumnCount option
  xs: ColumnCount option
  sm: ColumnCount option
  md: ColumnCount option
  lg: ColumnCount option
  xl: ColumnCount option
  xxl: ColumnCount option
}

[<StringEnum; RequireQualifiedAccess>]
type ListSize = Small | Default | Large

type AntList<'T>() =
    inherit AntElement(ofImport "List" "antd")
    member x.Bordered (v: bool) = x.attribute "bordered" v 
    member x.Footer (v: ReactElement) = x.attribute "footer" v 
    member x.Grid (v: ListGridType) = x.attribute "grid" v 
    member x.Header (v: ReactElement) = x.attribute "header" v 
    member x.ItemLayout (v: string) = x.attribute "itemLayout" v 
    member x.RowKey (v: ('T -> string)) = x.attribute "rowKey" v  
    member x.Loading (v: bool) = x.attribute "loading" v 
    member x.LoadMore (v: ReactElement) = x.attribute "loadMore" v 
    member x.Locale (v: obj) = x.attribute "locale" v 
    member x.Split (v: bool) = x.attribute "split" v 
    member x.DataSource (v: ('T array)) = x.attribute "dataSource" v 
    member x.RenderItem (v: ('T -> ReactElement)) = x.attribute "renderItem" v  
    member x.Pagination (pagination: AntPagination) = x.attribute "pagination" pagination.Props

type AntListItem() =
    inherit AntElement(ofImport "List.Item" "antd")
    member x.Extra (v: ReactElement) = x.attribute "extra" v 
    member x.Actions (v: ReactElement[]) = x.attribute "actions" v 
    member x.Key (v: string) = x.attribute "key" v 

type AntListItemMeta() =
    inherit AntElement(ofImport "List.Item.Meta" "antd")
    member x.Avatar (v: ReactElement) = x.attribute "avatar" v 
    member x.Description (v: ReactElement) = x.attribute "description" v 
    member x.Title (v: ReactElement) = x.attribute "title" v 