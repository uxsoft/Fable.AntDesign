module Fable.AntDesign.Table

open System
open Browser.Types
open Fable.AntDesign.Common
open Fable.AntDesign.Pagination
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type TableLayout =
    | Auto
    | Fixed

[<StringEnum; RequireQualifiedAccess>]
type TableRowSelectionType =
    | Checkbox
    | Radio

[<StringEnum; RequireQualifiedAccess>]
type TableColumnAlign =
    | Left
    | Right
    | Center

[<StringEnum; RequireQualifiedAccess>]
type TableColumnSortOrder =
    | Ascend
    | Descend

type TableEventHandlers = {
    onClick: (Event -> unit) option
    onDoubleClick: (Event -> unit) option
    onContextMenu: (Event -> unit) option
    onMouseEnter: (Event -> unit) option
    onMouseLeave: (Event -> unit) option
}

[<RequireQualifiedAccess>]
type TableScroll =
    | X of string
    | Y of string
    | ScrollToFirstRowOnChange

type TableSelection =
    | Text of ReactElement 
    | OnSelect of string array

type TableExpandable<'T> =
    | ChildrenColumnName of string array 
    | DefaultExpandAllRows of bool 
    | DefaultExpandedRowKeys of string array 
    | ExpandIcon of (obj -> ReactElement) 
    | ExpandIconColumnIndex of int 
    | ExpandedRowKeys of string array 
    | ExpandedRowRender of Func<'T, int, int, bool, ReactElement> 
    | ExpandRowByClick of bool 
    | IndentSize of int 
    | RowExpandable of Func<'T, bool> 
    | OnExpand of Func<bool, 'T, unit> 
    | OnExpandedRowsChange of 'T array 

type TableRowSelection<'T> =
    | ColumnWidth of int 
    | ColumnTitle of ReactElement 
    | IsFixed of string 
    | GetCheckboxProps of ('T -> obj) 
    | HideSelectAll of bool
    | RenderCell of Func<bool, 'T, int, ReactElement, ReactElement> 
    | SelectedRowKeys of string array 
    | Selections of obj array 
    | SelectionType of TableRowSelectionType 
    | OnChange of Func<string array, 'T array, unit> 
    | OnSelect of Func<'T, bool, 'T array, Event, unit> 
    | OnSelectAll of Func<bool, 'T array, 'T array, unit> 
    | OnSelectInvert of 'T array 

type TableColumnProp<'T> =
    | Align of TableColumnAlign 
    | Ellipsis of bool 
    | ClassName of string 
    | ColSpan of int 
    | DataIndex of string 
    | DefaultFilteredValue of string array 
    | DefaultSortOrder of TableColumnSortOrder 
    | FilterDropdown of ReactElement 
    | FilterDropdownVisible of bool 
    | Filtered of bool
    | FilteredValue of string array 
    | FilterIcon of (bool -> ReactElement) 
    | FilterMultiple of bool 
    | Filters of obj array 
    | IsFixed of bool 
    | Render of Func<ReactElement, 'T, int, ReactElement> 
    | Responsive of bool 
    | ShouldCellUpdate of Func<'T, 'T, bool> 
    | Sorter of bool 
    | SortOrder of TableColumnSortOrder 
    | SortDirections of TableColumnSortOrder array 
    | Title of ReactElement 
    | Width of string 
    | OnCell of Func<'T, int, TableEventHandlers> 
    | OnFilter of (unit -> unit) 
    | OnFilterDropdownVisibleChange of (bool -> unit) 
    | OnHeaderCell of (obj -> TableEventHandlers) 
    | ShowSorterTooltip of bool 

type TableColumnBuilder<'T>() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Table.Column" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("align")>] member _.align (x: DSLElement, v: TableColumnAlign) = x.attr "align" v
    [<CustomOperation("ellipsis")>] member _.ellipsis (x: DSLElement, v: bool) = x.attr "ellipsis" v
    [<CustomOperation("className")>] member _.className (x: DSLElement, v: string) = x.attr "className" v
    [<CustomOperation("colSpan")>] member _.colSpan (x: DSLElement, v: int) = x.attr "colSpan" v
    [<CustomOperation("dataIndex")>] member _.dataIndex (x: DSLElement, v: string) = x.attr "dataIndex" v
    [<CustomOperation("defaultFilteredValue")>] member _.defaultFilteredValue (x: DSLElement, v: string array) = x.attr "defaultFilteredValue" v
    [<CustomOperation("defaultSortOrder")>] member _.defaultSortOrder (x: DSLElement, v: TableColumnSortOrder) = x.attr "defaultSortOrder" v
    [<CustomOperation("filterDropdown")>] member _.filterDropdown (x: DSLElement, v: ReactElement) = x.attr "filterDropdown" v
    [<CustomOperation("filterDropdownVisible")>] member _.filterDropdownVisible (x: DSLElement, v: bool) = x.attr "filterDropdownVisible" v
    [<CustomOperation("filtered")>] member _.filtered (x: DSLElement, v: bool) = x.attr "filtered" v
    [<CustomOperation("filteredValue")>] member _.filteredValue (x: DSLElement, v: string array) = x.attr "filteredValue" v
    [<CustomOperation("filterIcon")>] member _.filterIcon (x: DSLElement, v: bool -> ReactElement) = x.attr "filterIcon" v
    [<CustomOperation("filterMultiple")>] member _.filterMultiple (x: DSLElement, v: bool) = x.attr "filterMultiple" v
    [<CustomOperation("filters")>] member _.filters (x: DSLElement, v: obj array) = x.attr "filters" v
    [<CustomOperation("isFixed")>] member _.isFixed (x: DSLElement, v: bool) = x.attr "fixed" v
    [<CustomOperation("render")>] member _.render (x: DSLElement, v: Func<ReactElement, 'T, int, ReactElement>) = x.attr "render" v
    [<CustomOperation("responsive")>] member _.responsive (x: DSLElement, v: bool) = x.attr "responsive" v
    [<CustomOperation("shouldCellUpdate")>] member _.shouldCellUpdate (x: DSLElement, v: Func<'T, 'T, bool>) = x.attr "shouldCellUpdate" v
    [<CustomOperation("sorter")>] member _.sorter (x: DSLElement, v: bool) = x.attr "sorter" v
    [<CustomOperation("sortOrder")>] member _.sortOrder (x: DSLElement, v: TableColumnSortOrder) = x.attr "sortOrder" v
    [<CustomOperation("sortDirections")>] member _.sortDirections (x: DSLElement, v: TableColumnSortOrder array) = x.attr "sortDirections" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v
    [<CustomOperation("onCell")>] member _.onCell (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onCell" v
    [<CustomOperation("onFilter")>] member _.onFilter (x: DSLElement, v: unit -> unit) = x.attr "onFilter" v
    [<CustomOperation("onFilterDropdownVisibleChange")>] member _.onFilterDropdownVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onFilterDropdownVisibleChange" v
    [<CustomOperation("onHeaderCell")>] member _.onHeaderCell (x: DSLElement, v: obj -> TableEventHandlers) = x.attr "onHeaderCell" v
    [<CustomOperation("showSorterTooltip")>] member _.showSorterTooltip (x: DSLElement, v: bool) = x.attr "showSorterTooltip" v

type TableColumnGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Table.ColumnGroup" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v

type TableBuilder<'T>() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Table" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("tableLayout")>] member _.tableLayout (x: DSLElement, v: TableLayout) = x.attr "tableLayout" v
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
    [<CustomOperation("columns")>] member _.columns (x: DSLElement, v: TableColumnProp<'T> list list) = x.attr "columns" (v |> List.map (keyValueList CaseRules.LowerFirst) |> List.toArray)
    [<CustomOperation("components")>] member _.components (x: DSLElement, v: obj) = x.attr "components" v
    [<CustomOperation("dataSource")>] member _.dataSource (x: DSLElement, v: 'T array) = x.attr "dataSource" v
    [<CustomOperation("expandable")>] member _.expandable (x: DSLElement, v: TableExpandable<'T> list) = x.attr "expandable" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: obj -> ReactElement) = x.attr "footer" v
    [<CustomOperation("loading")>] member _.loading (x: DSLElement, v: bool) = x.attr "loading" v
    [<CustomOperation("locale")>] member _.locale (x: DSLElement, v: obj) = x.attr "locale" v
    [<CustomOperation("pagination")>] member _.pagination(x: DSLElement, v: PaginationProp list) = x.attr "pagination" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("rowClassName")>] member _.rowClassName (x: DSLElement, v: Func<'T, int, string>) = x.attr "rowClassName" v
    [<CustomOperation("rowKey")>] member _.rowKey (x: DSLElement, v: 'T -> string) = x.attr "rowKey" v
    [<CustomOperation("rowSelection")>] member _.rowSelection(x: DSLElement, v: TableRowSelection<'T> list) = x.attr "rowSelection" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("scroll")>] member _.scroll(x: DSLElement, v: TableScroll list) = x.attr "scroll" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("showHeader")>] member _.showHeader (x: DSLElement, v: bool) = x.attr "showHeader" v
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("summary")>] member _.summary (x: DSLElement, v: Func<'T, ReactElement>) = x.attr "summary" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: obj -> ReactElement) = x.attr "title" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: System.Func<obj, obj, obj, obj, unit>) = x.attr "onChange" v
    [<CustomOperation("onHeaderRow")>] member _.onHeaderRow (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onHeaderRow" v
    [<CustomOperation("onRow")>] member _.onRow (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onRow" v
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: ReactElement -> HTMLElement) = x.attr "getPopupContainer" v
    [<CustomOperation("sortDirections")>] member _.sortDirections (x: DSLElement, v: TableColumnSortOrder array) = x.attr "sortDirections" v
    [<CustomOperation("showSorterTooltip")>] member _.showSorterTooltip (x: DSLElement, v: bool) = x.attr "showSorterTooltip" v