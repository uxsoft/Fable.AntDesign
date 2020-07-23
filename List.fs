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

type AntListGrid() =
  inherit AntObject<AntListGrid>()
  member x.gutter (v: int ) = x.attribute "gutter" v
  member x.column (v: ColumnCount) = x.attribute "column" v
  member x.xs (v: ColumnCount) = x.attribute "xs" v
  member x.sm (v: ColumnCount) = x.attribute "sm" v
  member x.md (v: ColumnCount) = x.attribute "md" v
  member x.lg (v: ColumnCount) = x.attribute "lg" v
  member x.xl (v: ColumnCount) = x.attribute "xl" v
  member x.xxl (v: ColumnCount) = x.attribute "xxl" v

[<StringEnum; RequireQualifiedAccess>]
type ListSize = Small | Default | Large

type AntList<'T>() =
    inherit AntElement<AntList<'T>>(ofImport "List" "antd")
    member x.bordered (v: bool) = x.attribute "bordered" v 
    member x.footer (v: ReactElement) = x.attribute "footer" v 
    member x.grid (v: AntListGrid) = x.attribute "grid" v.JSON 
    member x.header (v: ReactElement) = x.attribute "header" v 
    member x.itemLayout (v: string) = x.attribute "itemLayout" v 
    member x.rowKey (v: ('T -> string)) = x.attribute "rowKey" v  
    member x.loading (v: bool) = x.attribute "loading" v 
    member x.loadMore (v: ReactElement) = x.attribute "loadMore" v 
    member x.locale (v: obj) = x.attribute "locale" v 
    member x.pagination (v: AntPagination) = x.attribute "pagination" v.JSON
    member x.size (v: Size) = x.attribute "size" v
    member x.split (v: bool) = x.attribute "split" v 
    member x.dataSource (v: ('T array)) = x.attribute "dataSource" v 
    member x.renderItem (v: ('T -> ReactElement)) = x.attribute "renderItem" v  

type AntListItem() =
    inherit AntElement<AntListItem>(ofImport "List.Item" "antd")
    member x.extra (v: ReactElement) = x.attribute "extra" v 
    member x.actions (v: ReactElement[]) = x.attribute "actions" v 

type AntListItemMeta() =
    inherit AntElement<AntListItemMeta>(ofImport "List.Item.Meta" "antd")
    member x.avatar (v: ReactElement) = x.attribute "avatar" v 
    member x.description (v: ReactElement) = x.attribute "description" v 
    member x.title (v: ReactElement) = x.attribute "title" v 