namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Builders.AntDesign.Pagination
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module List =

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
        inherit ReactBuilder(import "List" "antd")
    
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
        [<CustomOperation("dataSource")>] member inline _.dataSource (x: DSLElement, v: 'T array) = x.attr "dataSource" v 
        [<CustomOperation("footer")>] member inline _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v 
        [<CustomOperation("grid")>] member inline _.grid (x: DSLElement, v: ListGridSettings list) = x.attr "grid" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("header")>] member inline _.header (x: DSLElement, v: ReactElement) = x.attr "header" v 
        [<CustomOperation("itemLayout")>] member inline _.itemLayout (x: DSLElement, v: ListItemLayout) = x.attr "itemLayout" v 
        [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v 
        [<CustomOperation("loadMore")>] member inline _.loadMore (x: DSLElement, v: ReactElement) = x.attr "loadMore" v 
        [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: obj) = x.attr "locale" v 
        [<CustomOperation("pagination")>] member inline _.pagination (x: DSLElement, v: PaginationProp list) = x.attr "pagination" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("renderItem")>] member inline _.renderItem (x: DSLElement, v: 'T -> ReactElement) = x.attr "renderItem" v  
        [<CustomOperation("rowKey")>] member inline _.rowKey (x: DSLElement, v: 'T -> string) = x.attr "rowKey" v  
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("split")>] member inline _.split (x: DSLElement, v: bool) = x.attr "split" v
    
    type ListItemBuilder() =
        inherit ReactBuilder(import "List.Item" "antd")
    
        [<CustomOperation("extra")>] member inline _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v 
        [<CustomOperation("actions")>] member inline _.actions (x: DSLElement, v: ReactElement array) = x.attr "actions" v 
    
    type ListItemMetaBuilder() =
        inherit ReactBuilder(import "List.Item.Meta" "antd")
    
        [<CustomOperation("avatar")>] member inline _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v 
        [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: ReactElement) = x.attr "description" v 
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 