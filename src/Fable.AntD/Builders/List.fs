module Fable.AntD.Builders.List

open Fable.AntD.Builders.Common
open Fable.AntD.Builders.Pagination
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

type ListGridSettings =
    | Column of int
    | Gutter of int
    | Xs of int
    | Sm of int
    | Md of int
    | Lg of int
    | Xl of int
    | Xxl of int

[<StringEnum; RequireQualifiedAccess>]
type ListSize = Small | Default | Large

[<StringEnum; RequireQualifiedAccess>]
type ListItemLayout = Vertical | Horizontal

type ListBuilder<'T>() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "List" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true 
    [<CustomOperation("dataSource")>] member _.dataSource (x: DSLElement, v: 'T array) = x.attr "dataSource" v 
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v 
    [<CustomOperation("grid")>] member _.grid (x: DSLElement, v: ListGridSettings list) = x.attr "grid" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("header")>] member _.header (x: DSLElement, v: ReactElement) = x.attr "header" v 
    [<CustomOperation("itemLayout")>] member _.itemLayout (x: DSLElement, v: ListItemLayout) = x.attr "itemLayout" v 
    [<CustomOperation("loading")>] member _.loading (x: DSLElement) = x.attr "loading" true 
    [<CustomOperation("loadMore")>] member _.loadMore (x: DSLElement, v: ReactElement) = x.attr "loadMore" v 
    [<CustomOperation("locale")>] member _.locale (x: DSLElement, v: obj) = x.attr "locale" v 
    [<CustomOperation("pagination")>] member _.pagination (x: DSLElement, v: PaginationSettings list) = x.attr "pagination" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("renderItem")>] member _.renderItem (x: DSLElement, v: 'T -> ReactElement) = x.attr "renderItem" v  
    [<CustomOperation("rowKey")>] member _.rowKey (x: DSLElement, v: 'T -> string) = x.attr "rowKey" v  
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("split")>] member _.split (x: DSLElement) = x.attr "split" true

type ListItemBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "List.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v 
    [<CustomOperation("actions")>] member _.actions (x: DSLElement, v: ReactElement[]) = x.attr "actions" v 

type ListItemMetaBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "List.Item.Meta" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("avatar")>] member _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v 
    [<CustomOperation("description")>] member _.description (x: DSLElement, v: ReactElement) = x.attr "description" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 