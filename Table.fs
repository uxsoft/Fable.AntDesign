namespace Fable.AntD

open Browser.Types
open System.Drawing
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Table =
    
    [<StringEnum; RequireQualifiedAccess>] type AntTableLayout = Auto | Fixed
    [<StringEnum; RequireQualifiedAccess>] type AntTableRowSelectionType = Checkbox | Radio
    [<StringEnum; RequireQualifiedAccess>] type AntTableColumnAlign = Left | Right | Center
    [<StringEnum; RequireQualifiedAccess>] type AntTableColumnSortOrder = Ascend | Descend
    
    type AntTableEventHandlers = {
        onClick: (Event -> unit) option
        onDoubleClick: (Event -> unit) option
        onContextMenu: (Event -> unit) option
        onMouseEnter: (Event -> unit) option
        onMouseLeave: (Event -> unit) option
    }
    
    [<RequireQualifiedAccess>]
    type AntTableRowSelection<'T> =
        | ColumnWidth of int
        | ColumnTitle of ReactElement
        | Fixed of bool
        | GetCheckboxProps of ('T -> obj)
        | HideDefaultSelections of bool
        | SelectedRowKeys of string array
        | Selections of (obj array)
        | Type of AntTableRowSelectionType
        | OnChange of (string array -> 'T array -> unit)
        | OnSelect of ('T -> bool -> 'T array -> Event -> unit)
        | OnSelectAll of (bool -> 'T array -> 'T array -> unit)
        | OnSelectInvert of ('T array)
    
    [<RequireQualifiedAccess>]
    type AntTableScroll =
        | X of U2<int, bool>
        | Y of U2<int, bool>
        | ScrollToFirstRowOnChange
    
    [<RequireQualifiedAccess>]
    type AntTableSelection =
        | Key of string
        | Text of ReactElement
        | OnSelect of (string array)
    
    [<RequireQualifiedAccess>]
    type AntTableColumn<'T> =
        | Align of AntTableColumnAlign
        | Ellipsis of bool
        | ClassName of string
        | ColSpan of int
        | DataIndex of string
        | DefaultFilteredValue of string array
        | DefaultSortOrder of AntTableColumnSortOrder
        | FilterDropdown of ReactElement
        | FilterDropdownVisible of bool
        | Filtered of bool
        | FilteredValue of string array
        | FilterIcon of (bool -> ReactElement)
        | FilterMultiple of bool
        | Filters of obj array
        | Fixed of bool
        | Key of string
        | Render of (ReactElement -> 'T -> int -> ReactElement)
        | Sorter of bool
        | SortOrder of AntTableColumnSortOrder
        | SortDirections of AntTableColumnSortOrder array
        | Title of ReactElement
        | Width of string
        | OnCell of ('T -> int -> AntTableEventHandlers)
        | OnFilter of (unit -> unit)
        | OnFilterDropdownVisibleChange of (bool -> unit)
        | OnHeaderCell of (obj -> AntTableEventHandlers)
        static member Custom (key: string, value: obj): AntTableColumn<'T> = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTableColumn<'T> = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    [<RequireQualifiedAccess>]
    type AntTableColumnGroup =
        | Title of ReactElement
        static member Custom (key: string, value: obj): AntTableColumnGroup = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTableColumnGroup = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    [<RequireQualifiedAccess>]
    type AntTable<'T>  =
        | TableLayout of AntTableLayout
        | Bordered of bool
        | ChildrenColumnName of string array
        | Components of obj
        | DataSource of 'T array
        | DefaultExpandAllRows of bool
        | DefaultExpandedRowKeys of string array
        | ExpandedRowKeys of string array
        | ExpandedRowRender of ('T -> int -> int -> bool -> ReactElement)
        | ExpandIcon of (obj -> ReactElement)
        | ExpandRowByClick of bool
        | Footer of (obj -> ReactElement)
        | IndentSize of int
        | Loading of bool
        | Locale of obj
        | RowClassName of ('T -> int -> string)
        | RowKey of ('T -> string)
        | ShowHeader of bool
        | Size of Size
        | Title of (obj -> ReactElement)
        | OnChange of (obj -> obj -> obj -> obj -> unit)
        | OnExpand of (bool -> 'T -> unit)
        | OnExpandedRowsChange of ('T array)
        | OnHeaderRow of ('T -> int -> AntTableEventHandlers)
        | OnRow of ('T -> int -> AntTableEventHandlers)
        | GetPopupContainer of (ReactElement -> HTMLElement)
        static member Custom (key: string, value: obj): AntTable<'T> = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTable<'T> = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member Columns (columns: AntTableColumn<'T> list list): AntTable<'T> = unbox ("style", keyValueList CaseRules.LowerFirst columns)
        static member Pagination (config: AntPagination list): AntTable<'T> = unbox ("pagination", keyValueList CaseRules.LowerFirst config)
        static member RowSelection (config: AntTableRowSelection<'T> list): AntTable<'T> = unbox ("rowSelection", keyValueList CaseRules.LowerFirst config)
        static member Scroll (config: AntTableScroll list): AntTable<'T> = unbox ("scroll", keyValueList CaseRules.LowerFirst config)


    let inline antTable (props: AntTable<'T> list) (children: ReactElement list): ReactElement =
       ofImport "Table" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antTableColumn (props: AntTableColumn<'T> list) (children: ReactElement list): ReactElement =
        ofImport "Table.Column" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antTableColumnGroup (props: AntTableColumnGroup list) (children: ReactElement list): ReactElement =
        ofImport "Table.ColumnGroup" "antd" (keyValueList CaseRules.LowerFirst props) children

    