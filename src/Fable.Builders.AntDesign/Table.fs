namespace Fable.Builders.AntDesign

open System
open Browser.Types
open Fable.Builders.AntDesign
open Fable.Builders.Common
open Fable.Builders.AntDesign.Pagination
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz.Styles

[<AutoOpen>]
module Table =

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
        
    type TableComponentsHeader =
        { wrapper: ReactElement option
          row: ReactElement option
          cell: ReactElement option }
        
    type TableComponentsBody =
        { wrapper: ReactElement option
          row: ReactElement option
          cell: ReactElement option }
        
    type TableComponents =
        { table: ReactElement option
          header: TableComponentsHeader option
          body: TableComponentsBody option }

    type TableEventHandlers =
        { onClick: (Event -> unit) option
          onDoubleClick: (Event -> unit) option
          onContextMenu: (Event -> unit) option
          onMouseEnter: (Event -> unit) option
          onMouseLeave: (Event -> unit) option }
    
    [<RequireQualifiedAccess>]
    type TableScroll =
        | X of string
        | Y of string
        | ScrollToFirstRowOnChange
    
    [<RequireQualifiedAccess>]
    type TableSelection =
        | Key of string
        | Text of ReactElement 
        | OnSelect of (string array -> unit)
    
    [<RequireQualifiedAccess>]
    type TableExpandable<'T> =
        | ChildrenColumnName of string array
        | ColumnWidth of ICssUnit
        | DefaultExpandAllRows of bool 
        | DefaultExpandedRowKeys of string array
        | ExpandedRowClassName of Func<'T, int, int, string>
        | ExpandedRowKeys of string array 
        | ExpandedRowRender of Func<'T, int, int, bool, ReactElement> 
        | ExpandIcon of (obj -> ReactElement) 
        | ExpandIconColumnIndex of int 
        | ExpandRowByClick of bool
        | Fixed of bool
        | IndentSize of int 
        | RowExpandable of Func<'T, bool> 
        | OnExpand of Func<bool, 'T, unit> 
        | OnExpandedRowsChange of 'T array 
    
    [<RequireQualifiedAccess>]
    type TableRowSelection<'T> =
        | CheckStrictly of bool
        | ColumnTitle of ReactElement 
        | ColumnWidth of int 
        | Fixed of bool 
        | GetCheckboxProps of ('T -> obj) 
        | HideSelectAll of bool
        | PreserveSelectedRowKeys of bool
        | RenderCell of Func<bool, 'T, int, ReactElement, ReactElement> 
        | SelectedRowKeys of string array 
        | Selections of obj array 
        | Type of TableRowSelectionType 
        | OnChange of Func<string array, 'T array, unit> 
        | OnSelect of Func<'T, bool, 'T array, Event, unit> 
        | OnSelectAll of Func<bool, 'T array, 'T array, unit> 
        | OnSelectInvert of (string array -> unit)
        | OnSelectNone of (unit -> unit)
    
    [<RequireQualifiedAccess>]
    type TableColumnFilterMode =
        | Menu
        | Tree
    
    [<RequireQualifiedAccess>]
    type TableColumnProp<'T> =
        | Align of TableColumnAlign 
        | ClassName of string 
        | ColSpan of int 
        | DataIndex of string 
        | DefaultFilteredValue of string array 
        | DefaultSortOrder of TableColumnSortOrder
        | Editable of bool
        | Ellipsis of bool 
        | FilterDropdown of ReactElement 
        | FilterDropdownVisible of bool 
        | Filtered of bool
        | FilteredValue of string array 
        | FilterIcon of (bool -> ReactElement)
        | FilterMultiple of bool
        | FilterMode of TableColumnFilterMode 
        | FilterSearch of bool
        | Filters of obj array 
        | Fixed of bool
        | Key of string
        | Render of Func<ReactElement, 'T, int, ReactElement> 
        | Responsive of bool 
        | ShouldCellUpdate of Func<'T, 'T, bool>
        | ShowSorterTooltip of bool
        | SortDirections of TableColumnSortOrder array 
        | Sorter of bool 
        | SortOrder of TableColumnSortOrder 
        | Title of ReactElement 
        | Width of ICssUnit 
        | OnCell of Func<'T, int, TableEventHandlers> 
        | OnFilter of (unit -> unit) 
        | OnFilterDropdownVisibleChange of (bool -> unit) 
        | OnHeaderCell of (obj -> TableEventHandlers) 
    
    type TableColumnBuilder<'TColumn, 'TRecord>() =
        inherit ReactBuilder(import "Table.Column" "antd")
    
        [<CustomOperation("align")>] member inline _.align (x: DSLElement, v: TableColumnAlign) = x.attr "align" v
        [<CustomOperation("colSpan")>] member inline _.colSpan (x: DSLElement, v: int) = x.attr "colSpan" v
        [<CustomOperation("dataIndex")>] member inline _.dataIndex (x: DSLElement, v: string) = x.attr "dataIndex" v
        [<CustomOperation("defaultFilteredValue")>] member inline _.defaultFilteredValue (x: DSLElement, v: string array) = x.attr "defaultFilteredValue" v
        [<CustomOperation("defaultSortOrder")>] member inline _.defaultSortOrder (x: DSLElement, v: TableColumnSortOrder) = x.attr "defaultSortOrder" v
        [<CustomOperation("editable")>] member inline _.editable (x: DSLElement, v: bool) = x.attr "editable" v
        [<CustomOperation("ellipsis")>] member inline _.ellipsis (x: DSLElement, v: bool) = x.attr "ellipsis" v
        [<CustomOperation("filterDropdown")>] member inline _.filterDropdown (x: DSLElement, v: ReactElement) = x.attr "filterDropdown" v
        [<CustomOperation("filterDropdownVisible")>] member inline _.filterDropdownVisible (x: DSLElement, v: bool) = x.attr "filterDropdownVisible" v
        [<CustomOperation("filtered")>] member inline _.filtered (x: DSLElement, v: bool) = x.attr "filtered" v
        [<CustomOperation("filteredValue")>] member inline _.filteredValue (x: DSLElement, v: string array) = x.attr "filteredValue" v
        [<CustomOperation("filterIcon")>] member inline _.filterIcon (x: DSLElement, v: bool -> ReactElement) = x.attr "filterIcon" v
        [<CustomOperation("filterMultiple")>] member inline _.filterMultiple (x: DSLElement, v: bool) = x.attr "filterMultiple" v
        [<CustomOperation("filterMode")>] member inline _.filterMode (x: DSLElement, v: TableColumnFilterMode) = x.attr "filterMode" v
        [<CustomOperation("filters")>] member inline _.filters (x: DSLElement, v: 'v array) = x.attr "filters" v
        [<CustomOperation("filterSearch")>] member inline _.filterSearch (x: DSLElement, v: bool) = x.attr "filterSearch" v
        [<CustomOperation("fixed'")>] member inline _.isFixed (x: DSLElement, v: bool) = x.attr "fixed" v
        [<CustomOperation("render")>] member inline _.render (x: DSLElement, v: Func<'TColumn, 'TRecord, int, ReactElement>) = x.attr "render" v
        [<CustomOperation("responsive")>] member inline _.responsive (x: DSLElement, v: bool) = x.attr "responsive" v
        [<CustomOperation("shouldCellUpdate")>] member inline _.shouldCellUpdate (x: DSLElement, v: Func<'TRecord, 'TRecord, bool>) = x.attr "shouldCellUpdate" v
        [<CustomOperation("showSorterTooltip")>] member inline _.showSorterTooltip (x: DSLElement, v: bool) = x.attr "showSorterTooltip" v
        [<CustomOperation("sortDirections")>] member inline _.sortDirections (x: DSLElement, v: TableColumnSortOrder array) = x.attr "sortDirections" v
        [<CustomOperation("sorter")>] member inline _.sorter (x: DSLElement, v: bool) = x.attr "sorter" v
        [<CustomOperation("sortOrder")>] member inline _.sortOrder (x: DSLElement, v: TableColumnSortOrder) = x.attr "sortOrder" v
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
        [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: ICssUnit) = x.attr "width" v
        [<CustomOperation("onCell")>] member inline _.onCell (x: DSLElement, v: Func<'TRecord, int, TableEventHandlers>) = x.attr "onCell" v
        [<CustomOperation("onFilter")>] member inline _.onFilter (x: DSLElement, v: Func<'TItem, 'TRecord, bool>) = x.attr "onFilter" v
        [<CustomOperation("onFilterDropdownVisibleChange")>] member inline _.onFilterDropdownVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "onFilterDropdownVisibleChange" v
        [<CustomOperation("onHeaderCell")>] member inline _.onHeaderCell (x: DSLElement, v: obj -> TableEventHandlers) = x.attr "onHeaderCell" v
    
    type TableColumnGroupBuilder() =
        inherit ReactBuilder(import "Table.ColumnGroup" "antd")
    
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    
    type TableBuilder<'T>() =
        inherit ReactBuilder(import "Table" "antd")
    
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
        [<CustomOperation("columns")>] member inline _.columns (x: DSLElement, v: TableColumnProp<'T> list list) = x.attr "columns" (v |> List.map (keyValueList CaseRules.LowerFirst) |> List.toArray)
        [<CustomOperation("components")>] member inline _.components (x: DSLElement, v: TableComponents) = x.attr "components" v
        [<CustomOperation("dataSource")>] member inline _.dataSource (x: DSLElement, v: 'T array) = x.attr "dataSource" v
        [<CustomOperation("expandable")>] member inline _.expandable (x: DSLElement, v: TableExpandable<'T> list) = x.attr "expandable" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("footer")>] member inline _.footer (x: DSLElement, v: obj -> ReactElement) = x.attr "footer" v
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: ReactElement -> HTMLElement) = x.attr "getPopupContainer" v
        [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v
        [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: 'v) = x.attr "locale" v
        [<CustomOperation("pagination")>] member inline _.pagination(x: DSLElement, v: PaginationProp list) = x.attr "pagination" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("rowClassName")>] member inline _.rowClassName (x: DSLElement, v: Func<'T, int, string>) = x.attr "rowClassName" v
        [<CustomOperation("rowKey")>] member inline _.rowKey (x: DSLElement, v: 'T -> string) = x.attr "rowKey" v
        [<CustomOperation("rowSelection")>] member inline _.rowSelection(x: DSLElement, v: TableRowSelection<'T> list) = x.attr "rowSelection" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("scroll")>] member inline _.scroll(x: DSLElement, v: TableScroll list) = x.attr "scroll" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("showHeader")>] member inline _.showHeader (x: DSLElement, v: bool) = x.attr "showHeader" v
        [<CustomOperation("showSorterTooltip")>] member inline _.showSorterTooltip (x: DSLElement, v: bool) = x.attr "showSorterTooltip" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("sortDirections")>] member inline _.sortDirections (x: DSLElement, v: TableColumnSortOrder array) = x.attr "sortDirections" v
        [<CustomOperation("sticky")>] member inline _.sticky (x: DSLElement, v: bool) = x.attr "sticky" v
        [<CustomOperation("summary")>] member inline _.summary (x: DSLElement, v: Func<'T, ReactElement>) = x.attr "summary" v
        [<CustomOperation("tableLayout")>] member inline _.tableLayout (x: DSLElement, v: TableLayout) = x.attr "tableLayout" v
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: obj -> ReactElement) = x.attr "title" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: System.Func<obj, obj, obj, obj, unit>) = x.attr "onChange" v
        [<CustomOperation("onHeaderRow")>] member inline _.onHeaderRow (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onHeaderRow" v
        [<CustomOperation("onRow")>] member inline _.onRow (x: DSLElement, v: Func<'T, int, TableEventHandlers>) = x.attr "onRow" v
