namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module List =

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ColumnCount =  
        | [<CompiledName("1")>] One
        | [<CompiledName("2")>] Two
        | [<CompiledName("3")>] Three
        | [<CompiledName("4")>] Four
        | [<CompiledName("6")>] Six
        | [<CompiledName("8")>] Eight
        | [<CompiledName("12")>] Twelve
        | [<CompiledName("24")>] TwentyFour

    [<StringEnum>]
    [<RequireQualifiedAccess>]
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

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ListSize = Small | Default | Large

    [<RequireQualifiedAccess>]
    type AntList =
        | Bordered of bool
        | Footer of ReactElement
        | Grid of ListGridType
        | Header of ReactElement
        | ItemLayout of string
        | RowKey of U2<string, obj -> string> 
        | Loading of bool
        | LoadMore of ReactElement
        | Locale of obj
        | Split of bool
        | DataSource of obj array
        | RenderItem of  (obj -> ReactElement)
        static member Custom (key: string, value: obj): AntList = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntList = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member Pagination (config: AntPagination list): AntList = unbox ("pagination", keyValueList CaseRules.LowerFirst config)

    [<RequireQualifiedAccess>]
    type AntListItem =
        | Extra of ReactElement
        | Actions of ReactElement[]
        | Key of obj
        static member Custom (key: string, value: obj): AntListItem = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntListItem = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntListItemMeta = 
        | Avatar of ReactElement
        | Description of ReactElement
        | Title of ReactElement
        static member Custom (key: string, value: obj): AntListItemMeta = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntListItemMeta = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antList (props: AntList list) (children: ReactElement list): ReactElement =
       ofImport "List" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    let inline antListItem (props: AntListItem list) (children: ReactElement list): ReactElement =
       ofImport "List.Item" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antListItemMeta (props: AntListItemMeta list) (children: ReactElement list): ReactElement =
       ofImport "List.Item.Meta" "antd" (keyValueList CaseRules.LowerFirst props) children