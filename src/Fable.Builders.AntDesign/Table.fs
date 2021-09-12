module Fable.Builders.AntDesign.Table

open System
open Browser.Types
open Fable.Builders.Common
open Fable.Builders.AntDesign.Pagination
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
    inherit ReactBuilder(import "Table.Column" "antd")

    [<CustomOperation("align")>] member inline _.align (x: DSLElement, v: TableColumnAlign) = x.attr "align" v
    [<CustomOperation("ellipsis")>] member inline _.ellipsis (x: DSLElement, v: bool) = x.attr "ellipsis" v
    [<CustomOperation("className")>] member inline _.className (x: DSLElement, v: string) = x.attr "className" v
    [<CustomOperation("colSpan")>] member inline _.colSpan (x: DSLElement, v: int) = x.attr "colSpan" v
    [<CustomOperation("dataIndex")>] member inline _.dataIndex (x: DSLElement, v: string) = x.attr "dataIndex" v
    [<CustomOperation("defaultFilteredValue")>] member inline _.defaultFilteredValue (x: DSLElement, v: string array) = x.attr "defaultFilteredValue" v
    [<CustomOperation("defaultSortOrder")>] member inline _.defaultSortOrder (x: DSLElement, v: TableColumnSortOrder) = x.attr "defaultSortOrder" v
    [<CustomOperation("filterDropdown")>] member inline _.filterDropdown (x: DSLElement, v: ReactElement) = x.attr "filterDropdown" v
    [<CustomOperation("filterDropdownVisible")>] member inline _.filterDropdownVisible (x: DSLElement, v: bool) = x.attr "filterDropdownVisible" v
    [<CustomOperation("filtered")>] member inline _.filtered (x: DSLElement, v: bool) = x.attr "filtered" v
    [<CustomOperation("filteredValue")>] member inline _.filteredValue (x: DSLElement, v: string array) = x.attr "filteredValue" v
    [<CustomOperation("filterIcon")>] member inline _.filterIcon (x: DSLElement, v: bool -> ReactElement) = x.attr "filterIcon" v
    [<CustomOperation("filterMultiple")>] member inline _.filterMultiple (x: DSLElement, v: bool) = x.attr "filterMultiple" v
    [<CustomOperation("filters")>] member inline _.filters (x: DSLElement, v: obj array) = x.attr "filters" v
    [<CustomOperation("isFixed")>] member inline _.isFixed (x: DSLElement, v: bool) = x.attr "fixed" v
    [<CustomOperation("render")>] member inline _.render (x: DSLElement, v: Func<ReactElement, 'T, int, ReactElement>) = x.attr "render" v
    [<CustomOperation("responsive")>] member inline _.responsive (x: DSLElement, v: bool) = x.attr "responsive" v
    [<CustomOperation("shouldCellUpdate")>] member inline _.shouldCellUpdate (x: DSLElement, v: Func<'T, 'T, bool>) = x.attr "shouldCellUpdate" v
    [<CustomOperation("sorter")>] member inline _.sorter (x: DSLElement, v: bool) = x.attr "sorter" v
    [<CustomOperation("sortOrder")>] member inline _.sortOrder (x: DSLElement, v: TableColumnSortOrder) = x.attr "sortOrder" v
    [<CustomOperation("sortDirections")>] member inline _.sortDirections (x: DSLElement, v: TableColumnSortOrder array) = x.attr "sortDirections" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: string) = x.attr "width" v
    [<CustomOperation("onCell")>] member inline _.onCell (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onCell" v
    [<CustomOperation("onFilter")>] member inline _.onFilter (x: DSLElement, v: unit -> unit) = x.attr "onFilter" v
    [<CustomOperation("onFilterDropdownVisibleChange")>] member inline _.onFilterDropdownVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onFilterDropdownVisibleChange" v
    [<CustomOperation("onHeaderCell")>] member inline _.onHeaderCell (x: DSLElement, v: obj -> TableEventHandlers) = x.attr "onHeaderCell" v
    [<CustomOperation("showSorterTooltip")>] member inline _.showSorterTooltip (x: DSLElement, v: bool) = x.attr "showSorterTooltip" v

type TableColumnGroupBuilder() =
    inherit ReactBuilder(import "Table.ColumnGroup" "antd")

    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v

type TableBuilder<'T>() =
    inherit ReactBuilder(import "Table" "antd")

    [<CustomOperation("tableLayout")>] member inline _.tableLayout (x: DSLElement, v: TableLayout) = x.attr "tableLayout" v
    [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
    [<CustomOperation("columns")>] member inline _.columns (x: DSLElement, v: TableColumnProp<'T> list list) = x.attr "columns" (v |> List.map (keyValueList CaseRules.LowerFirst) |> List.toArray)
    [<CustomOperation("components")>] member inline _.components (x: DSLElement, v: obj) = x.attr "components" v
    [<CustomOperation("dataSource")>] member inline _.dataSource (x: DSLElement, v: 'T array) = x.attr "dataSource" v
    [<CustomOperation("expandable")>] member inline _.expandable (x: DSLElement, v: TableExpandable<'T> list) = x.attr "expandable" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("footer")>] member inline _.footer (x: DSLElement, v: obj -> ReactElement) = x.attr "footer" v
    [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v
    [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: obj) = x.attr "locale" v
    [<CustomOperation("pagination")>] member inline _.pagination(x: DSLElement, v: PaginationProp list) = x.attr "pagination" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("rowClassName")>] member inline _.rowClassName (x: DSLElement, v: Func<'T, int, string>) = x.attr "rowClassName" v
    [<CustomOperation("rowKey")>] member inline _.rowKey (x: DSLElement, v: 'T -> string) = x.attr "rowKey" v
    [<CustomOperation("rowSelection")>] member inline _.rowSelection(x: DSLElement, v: TableRowSelection<'T> list) = x.attr "rowSelection" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("scroll")>] member inline _.scroll(x: DSLElement, v: TableScroll list) = x.attr "scroll" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("showHeader")>] member inline _.showHeader (x: DSLElement, v: bool) = x.attr "showHeader" v
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("summary")>] member inline _.summary (x: DSLElement, v: Func<'T, ReactElement>) = x.attr "summary" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: obj -> ReactElement) = x.attr "title" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: System.Func<obj, obj, obj, obj, unit>) = x.attr "onChange" v
    [<CustomOperation("onHeaderRow")>] member inline _.onHeaderRow (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onHeaderRow" v
    [<CustomOperation("onRow")>] member inline _.onRow (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onRow" v
    [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: ReactElement -> HTMLElement) = x.attr "getPopupContainer" v
    [<CustomOperation("sortDirections")>] member inline _.sortDirections (x: DSLElement, v: TableColumnSortOrder array) = x.attr "sortDirections" v
    [<CustomOperation("showSorterTooltip")>] member inline _.showSorterTooltip (x: DSLElement, v: bool) = x.attr "showSorterTooltip" v