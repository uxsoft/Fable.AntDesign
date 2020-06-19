namespace Fable.AntD

open Browser.Types
open System.Drawing
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System

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
    | X of U2<int, bool>
    | Y of U2<int, bool>
    | ScrollToFirstRowOnChange

[<RequireQualifiedAccess>]
type TableSelection =
    | Key of string
    | Text of ReactElement
    | OnSelect of string array

type AntTableRowSelection<'T>() =
    inherit AntObject<AntTableRowSelection<'T>>()
    member x.columnWidth (v: int) = x.attribute "columnWidth" v
    member x.columnTitle (v: ReactElement) = x.attribute "columnTitle" v
    member x.isFixed (v: bool) = x.attribute "fixed" v
    member x.getCheckboxProps (v: 'T -> obj) = x.attribute "getCheckboxProps" v
    member x.hideDefaultSelections (v: bool) = x.attribute "hideDefaultSelections" v
    member x.selectedRowKeys (v: string array) = x.attribute "selectedRowKeys" v
    member x.selections (v: obj array) = x.attribute "selections" v
    member x.selectionType (v: TableRowSelectionType) = x.attribute "type" v
    member x.onChange (v: Func<string array, 'T array, unit>) = x.attribute "onChange" v
    member x.onSelect (v: Func<'T, bool, 'T array, Event, unit>) = x.attribute "onSelect" v
    member x.onSelectAll (v: Func<bool, 'T array, 'T array, unit>) = x.attribute "onSelectAll" v
    member x.onSelectInvert (v: 'T array) = x.attribute "onSelectInvert" v

type AntTableColumn<'T>() =
    inherit AntElement<AntTableColumn<'T>>(ofImport "Table.Column" "antd")
    member x.align (v: TableColumnAlign) = x.attribute "align" v
    member x.ellipsis (v: bool) = x.attribute "ellipsis" v
    member x.className (v: string) = x.attribute "className" v
    member x.colSpan (v: int) = x.attribute "colSpan" v
    member x.dataIndex (v: string) = x.attribute "dataIndex" v
    member x.defaultFilteredValue (v: string array) = x.attribute "defaultFilteredValue" v
    member x.defaultSortOrder (v: TableColumnSortOrder) = x.attribute "defaultSortOrder" v
    member x.filterDropdown (v: ReactElement) = x.attribute "filterDropdown" v
    member x.filterDropdownVisible (v: bool) = x.attribute "filterDropdownVisible" v
    member x.filtered (v: bool) = x.attribute "filtered" v
    member x.filteredValue (v: string array) = x.attribute "filteredValue" v
    member x.filterIcon (v: bool -> ReactElement) = x.attribute "filterIcon" v
    member x.filterMultiple (v: bool) = x.attribute "filterMultiple" v
    member x.filters (v: obj array) = x.attribute "filters" v
    member x.isFixed (v: bool) = x.attribute "fixed" v
    member x.render (v: Func<ReactElement, 'T, int, ReactElement>) = x.attribute "render" v
    member x.sorter (v: bool) = x.attribute "sorter" v
    member x.sortOrder (v: TableColumnSortOrder) = x.attribute "sortOrder" v
    member x.sortDirections (v: TableColumnSortOrder array) = x.attribute "sortDirections" v
    member x.title (v: ReactElement) = x.attribute "title" v
    member x.width (v: string) = x.attribute "width" v
    member x.onCell (v: Func<'T, int, TableEventHandlers>) = x.attribute "onCell" v
    member x.onFilter (v: unit -> unit) = x.attribute "onFilter" v
    member x.onFilterDropdownVisibleChange (v: bool -> unit) = x.attribute "onFilterDropdownVisibleChange" v
    member x.onHeaderCell (v: obj -> TableEventHandlers) = x.attribute "onHeaderCell" v

type TableColumnGroup() =
    inherit AntElement<TableColumnGroup>(ofImport "Table.ColumnGroup" "antd")
    member x.title (v: ReactElement) = x.attribute "title" v

type AntTable<'T>() =
    inherit AntElement<AntTable<'T>>(ofImport "Table" "antd")
    member x.tableLayout (v: TableLayout) = x.attribute "tableLayout" v
    member x.bordered (v: bool) = x.attribute "bordered" v
    member x.childrenColumnName (v: string array) = x.attribute "childrenColumnName" v
    member x.components (v: obj) = x.attribute "components" v
    member x.dataSource (v: 'T array) = x.attribute "dataSource" v
    member x.defaultExpandAllRows (v: bool) = x.attribute "defaultExpandAllRows" v
    member x.defaultExpandedRowKeys (v: string array) = x.attribute "defaultExpandedRowKeys" v
    member x.expandedRowKeys (v: string array) = x.attribute "expandedRowKeys" v
    member x.expandedRowRender (v: Func<'T, int, int, bool, ReactElement>) = x.attribute "expandedRowRender" v
    member x.expandIcon (v: obj -> ReactElement) = x.attribute "expandIcon" v
    member x.expandRowByClick (v: bool) = x.attribute "expandRowByClick" v
    member x.footer (v: obj -> ReactElement) = x.attribute "footer" v
    member x.indentSize (v: int) = x.attribute "indentSize" v
    member x.loading (v: bool) = x.attribute "loading" v
    member x.locale (v: obj) = x.attribute "locale" v
    member x.rowClassName (v: Func<'T, int, string>) = x.attribute "rowClassName" v
    member x.rowKey (v: 'T -> string) = x.attribute "rowKey" v
    member x.showHeader (v: bool) = x.attribute "showHeader" v
    member x.size (v: Size) = x.attribute "size" v
    member x.title (v: obj -> ReactElement) = x.attribute "title" v
    member x.onChange (v: System.Func<obj, obj, obj, obj, unit>) = x.attribute "onChange" v
    member x.onExpand (v: Func<bool, 'T, unit>) = x.attribute "onExpand" v
    member x.onExpandedRowsChange (v: 'T array) = x.attribute "onExpandedRowsChange" v
    member x.onHeaderRow (v: Func<'T, int, TableEventHandlers>) = x.attribute "onHeaderRow" v
    member x.onRow (v: Func<'T, int, TableEventHandlers>) = x.attribute "onRow" v
    member x.getPopupContainer (v: ReactElement -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.columns(columns: AntTableColumn<'T> list) = x.attribute "columns" (columns |> List.map (fun i -> i.JSON))
    member x.pagination(v: AntPagination) = x.attribute "pagination" v.JSON
    member x.rowSelection(v: AntTableRowSelection<'T>) = x.attribute "rowSelection" v.JSON
    member x.scroll(config: TableScroll list) = x.attribute "scroll" (keyValueList CaseRules.LowerFirst config)
