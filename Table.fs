namespace Fable.AntD

open Browser.Types
open System.Drawing
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type TableLayout = Auto | Fixed
[<StringEnum; RequireQualifiedAccess>] type TableRowSelectionType = Checkbox | Radio
[<StringEnum; RequireQualifiedAccess>] type TableColumnAlign = Left | Right | Center
[<StringEnum; RequireQualifiedAccess>] type TableColumnSortOrder = Ascend | Descend

type TableEventHandlers = {
    onClick: (Event -> unit) option
    onDoubleClick: (Event -> unit) option
    onContextMenu: (Event -> unit) option
    onMouseEnter: (Event -> unit) option
    onMouseLeave: (Event -> unit) option
}

type TableRowSelection<'T>() =
    inherit AntElement("Table")
    member x.ColumnWidth with set (v: int)= x.Attribute "columnWidth" v
    member x.ColumnTitle with set (v: ReactElement  )= x.Attribute "columnTitle" v
    member x.Fixed with set (v: bool  )= x.Attribute "fixed" v
    member x.GetCheckboxProps with set (v: ('T -> obj))= x.Attribute "getCheckboxProps" v
    member x.HideDefaultSelections with set (v: bool  )= x.Attribute "hideDefaultSelections" v
    member x.SelectedRowKeys with set (v: string array )= x.Attribute "selectedRowKeys" v
    member x.Selections with set (v: (obj array) )= x.Attribute "selections" v
    member x.Type with set (v: TableRowSelectionType  )= x.Attribute "type" v
    member x.OnChange with set (v: (string array -> 'T array -> unit)    ) = x.Attribute "onChange" v
    member x.OnSelect with set (v: ('T -> bool -> 'T array -> Event -> unit) ) = x.Attribute "onSelect" v
    member x.OnSelectAll with set (v: (bool -> 'T array -> 'T array -> unit)  ) = x.Attribute "onSelectAll" v
    member x.OnSelectInvert with set (v: ('T array) )= x.Attribute "onSelectInvert" v

type TableScroll =
    | X of U2<int, bool>
    | Y of U2<int, bool>
    | ScrollToFirstRowOnChange

[<RequireQualifiedAccess>]
type AntTableSelection =
    | Key of string
    | Text of ReactElement
    | OnSelect of (string array)

type AntTableColumn<'T>() =
    inherit AntElement("Table.Column")
    member x.Align with set (v: TableColumnAlign)= x.Attribute "align" v
    member x.Ellipsis with set (v: bool )= x.Attribute "ellipsis" v
    member x.ClassName with set (v: string )= x.Attribute "className" v
    member x.ColSpan with set (v: int  )= x.Attribute "colSpan" v
    member x.DataIndex with set (v: string  )= x.Attribute "dataIndex" v
    member x.DefaultFilteredValue with set (v: string array )= x.Attribute "defaultFilteredValue" v
    member x.DefaultSortOrder with set (v: TableColumnSortOrder  )= x.Attribute "defaultSortOrder" v
    member x.FilterDropdown with set (v: ReactElement  )= x.Attribute "filterDropdown" v
    member x.FilterDropdownVisible with set (v: bool  )= x.Attribute "filterDropdownVisible" v
    member x.Filtered with set (v: bool  )= x.Attribute "filtered" v
    member x.FilteredValue with set (v: string array )= x.Attribute "filteredValue" v
    member x.FilterIcon with set (v: (bool -> ReactElement))= x.Attribute "filterIcon" v
    member x.FilterMultiple with set (v: bool  )= x.Attribute "filterMultiple" v
    member x.Filters with set (v: obj array )= x.Attribute "filters" v
    member x.Fixed with set (v: bool  )= x.Attribute "fixed" v
    member x.Key with set (v: string  )= x.Attribute "key" v
    member x.Render with set (v: (ReactElement -> 'T -> int -> ReactElement)) = x.Attribute "render" v
    member x.Sorter with set (v: bool  )= x.Attribute "sorter" v
    member x.SortOrder with set (v: TableColumnSortOrder)= x.Attribute "sortOrder" v
    member x.SortDirections with set (v: TableColumnSortOrder array )= x.Attribute "sortDirections" v
    member x.Title with set (v: ReactElement)= x.Attribute "title" v
    member x.Width with set (v: string)= x.Attribute "width" v
    member x.OnCell with set (v: ('T -> int -> TableEventHandlers)) = x.Attribute "onCell" v
    member x.OnFilter with set (v: (unit -> unit))= x.Attribute "onFilter" v
    member x.OnFilterDropdownVisibleChange with set (v: (bool -> unit))= x.Attribute "onFilterDropdownVisibleChange" v
    member x.OnHeaderCell with set (v: (obj -> TableEventHandlers))= x.Attribute "onHeaderCell" v

[<RequireQualifiedAccess>]
type TableColumnGroup =
    | Title of ReactElement

type AntTable<'T>()  =
    inherit AntElement("Table.ColumnGroup")
    member x.TableLayout with set (v: TableLayout)= x.Attribute "tableLayout" v
    member x.Bordered with set (v: bool)= x.Attribute "bordered" v
    member x.ChildrenColumnName with set (v: string array)= x.Attribute "childrenColumnName" v
    member x.Components with set (v: obj)= x.Attribute "components" v
    member x.DataSource with set (v: 'T array )= x.Attribute "dataSource" v
    member x.DefaultExpandAllRows with set (v: bool  )= x.Attribute "defaultExpandAllRows" v
    member x.DefaultExpandedRowKeys with set (v: string array )= x.Attribute "defaultExpandedRowKeys" v
    member x.ExpandedRowKeys with set (v: string array )= x.Attribute "expandedRowKeys" v
    member x.ExpandedRowRender with set (v: ('T -> int -> int -> bool -> ReactElement)  ) = x.Attribute "expandedRowRender" v
    member x.ExpandIcon with set (v: (obj -> ReactElement))= x.Attribute "expandIcon" v
    member x.ExpandRowByClick with set (v: bool  )= x.Attribute "expandRowByClick" v
    member x.Footer with set (v: (obj -> ReactElement))= x.Attribute "footer" v
    member x.IndentSize with set (v: int  )= x.Attribute "indentSize" v
    member x.Loading with set (v: bool  )= x.Attribute "loading" v
    member x.Locale with set (v: obj  )= x.Attribute "locale" v
    member x.RowClassName with set (v: ('T -> int -> string)) = x.Attribute "rowClassName" v
    member x.RowKey with set (v: ('T -> string))= x.Attribute "rowKey" v
    member x.ShowHeader with set (v: bool  )= x.Attribute "showHeader" v
    member x.Size with set (v: Size  )= x.Attribute "size" v
    member x.Title with set (v: (obj -> ReactElement))= x.Attribute "title" v
    member x.OnChange with set (v: (obj -> obj -> obj -> obj -> unit)  ) = x.Attribute "onChange" v
    member x.OnExpand with set (v: (bool -> 'T -> unit)) = x.Attribute "onExpand" v
    member x.OnExpandedRowsChange with set (v: ('T array) )= x.Attribute "onExpandedRowsChange" v
    member x.OnHeaderRow with set (v: ('T -> int -> TableEventHandlers)) = x.Attribute "onHeaderRow" v
    member x.OnRow with set (v: ('T -> int -> TableEventHandlers)) = x.Attribute "onRow" v
    member x.GetPopupContainer with set (v: (ReactElement -> HTMLElement))= x.Attribute "getPopupContainer" v
    member x.Columns (columns: AntTableColumn<'T> list list) = x.Attribute "columns" (keyValueList CaseRules.LowerFirst columns)
    member x.Pagination (config: Pagination list) = x.Attribute "pagination" (keyValueList CaseRules.LowerFirst config)
    member x.RowSelection (config: TableRowSelection<'T> list) = x.Attribute "rowSelection" (keyValueList CaseRules.LowerFirst config)
    member x.Scroll (config: TableScroll list) = x.Attribute "scroll" (keyValueList CaseRules.LowerFirst config)