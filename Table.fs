namespace Fable.AntD

open Browser.Types
open System.Drawing
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

type TableEventHandlers =
    { onClick: (Event -> unit) option
      onDoubleClick: (Event -> unit) option
      onContextMenu: (Event -> unit) option
      onMouseEnter: (Event -> unit) option
      onMouseLeave: (Event -> unit) option }

type AntTableRowSelection<'T>() =
    inherit AntElement(ofImport "Table" "antd")
    member x.ColumnWidth
        (v: int) = x.attribute "columnWidth" v
    member x.ColumnTitle
        (v: ReactElement) = x.attribute "columnTitle" v
    member x.Fixed
        (v: bool) = x.attribute "fixed" v
    member x.GetCheckboxProps
        (v: 'T -> obj) = x.attribute "getCheckboxProps" v
    member x.HideDefaultSelections
        (v: bool) = x.attribute "hideDefaultSelections" v
    member x.SelectedRowKeys
        (v: string array) = x.attribute "selectedRowKeys" v
    member x.Selections
        (v: obj array) = x.attribute "selections" v
    member x.Type
        (v: TableRowSelectionType) = x.attribute "type" v

    member x.OnChange
        (v: string array -> 'T array -> unit) =
            let uncurried = System.Func<string array, 'T array, unit> v
            x.attribute "onChange" uncurried

    member x.OnSelect
        (v: 'T -> bool -> 'T array -> Event -> unit) =
            let uncurried = System.Func<'T, bool, 'T array, Event, unit> v
            x.attribute "onSelect" uncurried

    member x.OnSelectAll
        (v: bool -> 'T array -> 'T array -> unit) =
            let uncurried = System.Func<bool, 'T array, 'T array, unit> v
            x.attribute "onSelectAll" uncurried

    member x.OnSelectInvert
        (v: 'T array) = x.attribute "onSelectInvert" v

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

type AntTableColumn<'T>() =
    inherit AntElement(ofImport "Table.Column" "antd")
    member x.Align
        (v: TableColumnAlign) = x.attribute "align" v
    member x.Ellipsis
        (v: bool) = x.attribute "ellipsis" v
    member x.ClassName
        (v: string) = x.attribute "className" v
    member x.ColSpan
        (v: int) = x.attribute "colSpan" v
    member x.DataIndex
        (v: string) = x.attribute "dataIndex" v
    member x.DefaultFilteredValue
        (v: string array) = x.attribute "defaultFilteredValue" v
    member x.DefaultSortOrder
        (v: TableColumnSortOrder) = x.attribute "defaultSortOrder" v
    member x.FilterDropdown
        (v: ReactElement) = x.attribute "filterDropdown" v
    member x.FilterDropdownVisible
        (v: bool) = x.attribute "filterDropdownVisible" v
    member x.Filtered
        (v: bool) = x.attribute "filtered" v
    member x.FilteredValue
        (v: string array) = x.attribute "filteredValue" v
    member x.FilterIcon
        (v: bool -> ReactElement) = x.attribute "filterIcon" v
    member x.FilterMultiple
        (v: bool) = x.attribute "filterMultiple" v
    member x.Filters
        (v: obj array) = x.attribute "filters" v
    member x.Fixed
        (v: bool) = x.attribute "fixed" v
    member x.Key
        (v: string) = x.attribute "key" v
    member x.Render
        (v: ReactElement -> 'T -> int -> ReactElement) =
            let uncurried = System.Func<ReactElement, 'T, int, ReactElement> v
            x.attribute "render" uncurried
    member x.Sorter
        (v: bool) = x.attribute "sorter" v
    member x.SortOrder
        (v: TableColumnSortOrder) = x.attribute "sortOrder" v
    member x.SortDirections
        (v: TableColumnSortOrder array) = x.attribute "sortDirections" v
    member x.Title
        (v: ReactElement) = x.attribute "title" v
    member x.Width
        (v: string) = x.attribute "width" v
    member x.OnCell
        (v: 'T -> int -> TableEventHandlers) =
            let uncurried = System.Func<'T, int, TableEventHandlers> v
            x.attribute "onCell" uncurried
    member x.OnFilter
        (v: unit -> unit) = x.attribute "onFilter" v
    member x.OnFilterDropdownVisibleChange
        (v: bool -> unit) = x.attribute "onFilterDropdownVisibleChange" v
    member x.OnHeaderCell
        (v: obj -> TableEventHandlers) = x.attribute "onHeaderCell" v

[<RequireQualifiedAccess>]
type TableColumnGroup = Title of ReactElement

type AntTable<'T>() =
    inherit AntElement(ofImport "Table.ColumnGroup" "antd")
    member x.TableLayout
        (v: TableLayout) = x.attribute "tableLayout" v
    member x.Bordered
        (v: bool) = x.attribute "bordered" v
    member x.ChildrenColumnName
        (v: string array) = x.attribute "childrenColumnName" v
    member x.Components
        (v: obj) = x.attribute "components" v
    member x.DataSource
        (v: 'T array) = x.attribute "dataSource" v
    member x.DefaultExpandAllRows
        (v: bool) = x.attribute "defaultExpandAllRows" v
    member x.DefaultExpandedRowKeys
        (v: string array) = x.attribute "defaultExpandedRowKeys" v
    member x.ExpandedRowKeys
        (v: string array) = x.attribute "expandedRowKeys" v
    member x.ExpandedRowRender
        (v: 'T -> int -> int -> bool -> ReactElement) =
            let uncurried = System.Func<'T, int, int, bool, ReactElement> v
            x.attribute "expandedRowRender" uncurried
    member x.ExpandIcon
        (v: obj -> ReactElement) = x.attribute "expandIcon" v
    member x.ExpandRowByClick
        (v: bool) = x.attribute "expandRowByClick" v
    member x.Footer
        (v: obj -> ReactElement) = x.attribute "footer" v
    member x.IndentSize
        (v: int) = x.attribute "indentSize" v
    member x.Loading
        (v: bool) = x.attribute "loading" v
    member x.Locale
        (v: obj) = x.attribute "locale" v
    member x.RowClassName
        (v: 'T -> int -> string) =
            let uncurried = System.Func<'T, int, string> v
            x.attribute "rowClassName" uncurried
    member x.RowKey
        (v: 'T -> string) = x.attribute "rowKey" v
    member x.ShowHeader
        (v: bool) = x.attribute "showHeader" v
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.Title
        (v: obj -> ReactElement) = x.attribute "title" v
    member x.OnChange
        (v: obj -> obj -> obj -> obj -> unit) =
            let uncurried = System.Func<obj, obj, obj, obj, unit> v
            x.attribute "onChange" uncurried
    member x.OnExpand
        (v: bool -> 'T -> unit) =
            let uncurried = System.Func<bool, 'T, unit> v
            x.attribute "onExpand" uncurried
    member x.OnExpandedRowsChange
        (v: 'T array) = x.attribute "onExpandedRowsChange" v
    member x.OnHeaderRow
        (v: 'T -> int -> TableEventHandlers) =
            let uncurried = System.Func<'T, int, TableEventHandlers> v
            x.attribute "onHeaderRow" uncurried
    member x.OnRow
        (v: 'T -> int -> TableEventHandlers) =
            let uncurried = System.Func<'T, int, TableEventHandlers> v
            x.attribute "onRow" uncurried
    member x.GetPopupContainer
        (v: ReactElement -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.Columns(columns: AntTableColumn<'T> list list) =
        x.attribute "columns" (keyValueList CaseRules.LowerFirst columns)
    member x.Pagination(config: AntPagination list) =
        x.attribute "pagination" (keyValueList CaseRules.LowerFirst config)
    member x.RowSelection(config: AntTableRowSelection<'T>) = x.attribute "rowSelection" config.Props
    member x.Scroll(config: TableScroll list) = x.attribute "scroll" (keyValueList CaseRules.LowerFirst config)
