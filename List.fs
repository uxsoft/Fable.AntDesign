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

type List<'T>() =
    inherit AntElement(ofImport "List" "antd")
    member x.Bordered with set (v: bool) = x.Attribute "bordered" v 
    member x.Footer with set (v: ReactElement) = x.Attribute "footer" v 
    member x.Grid with set (v: ListGridType) = x.Attribute "grid" v 
    member x.Header with set (v: ReactElement) = x.Attribute "header" v 
    member x.ItemLayout with set (v: string) = x.Attribute "itemLayout" v 
    member x.RowKey with set (v: ('T -> string)) = x.Attribute "rowKey" v  
    member x.Loading with set (v: bool) = x.Attribute "loading" v 
    member x.LoadMore with set (v: ReactElement) = x.Attribute "loadMore" v 
    member x.Locale with set (v: obj) = x.Attribute "locale" v 
    member x.Split with set (v: bool) = x.Attribute "split" v 
    member x.DataSource with set (v: ('T array)) = x.Attribute "dataSource" v 
    member x.RenderItem with set (v: ('T -> ReactElement)) = x.Attribute "renderItem" v  
    member x.Pagination with set (pagination: Pagination) = x.Attribute "pagination" pagination.Props

type ListItem() =
    inherit AntElement(ofImport "List.Item" "antd")
    member x.Extra with set (v: ReactElement) = x.Attribute "extra" v 
    member x.Actions with set (v: ReactElement[]) = x.Attribute "actions" v 
    member x.Key with set (v: string) = x.Attribute "key" v 

type ListItemMeta() =
    inherit AntElement(ofImport "List.Item.Meta" "antd")
    member x.Avatar with set (v: ReactElement) = x.Attribute "avatar" v 
    member x.Description with set (v: ReactElement) = x.Attribute "description" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 