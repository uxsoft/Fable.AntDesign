namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open System
open Feliz

[<AutoOpen>]
module TreeSelect =

    type TreeSelectData = {
        value: string
        title: string
        children: TreeSelectData array
    }
    
    type TreeFlatData = {
        id: string
        pId: string
        rootPId: string
    }
    
    type TreeSelectBuilder() =
        inherit ReactBuilder(import "TreeSelect" "antd")
    
        [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
        [<CustomOperation("autoClearSearchValue")>] member inline _.autoClearSearchValue (x: DSLElement, v: bool) = x.attr "autoClearSearchValue" v
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("dropdownClassName")>] member inline _.dropdownClassName (x: DSLElement, v: string) = x.attr "dropdownClassName" v
        [<CustomOperation("dropdownMatchSelectWidth")>] member inline _.dropdownMatchSelectWidth (x: DSLElement, v: bool) = x.attr "dropdownMatchSelectWidth" v
        [<CustomOperation("dropdownRender")>] member inline _.dropdownRender (x: DSLElement, v: Func<ReactElement, obj> -> ReactElement) = x.attr "dropdownRender" v
        [<CustomOperation("dropdownStyle")>] member inline _.dropdownStyle (x: DSLElement, v: IStyleAttribute list) = x.attr "dropdownStyle" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("filterTreeNode")>] member inline _.filterTreeNode (x: DSLElement, v: Func<string, TreeSelectData, bool>) = x.attr "filterTreeNode" v
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getPopupContainer" v
        [<CustomOperation("labelInValue")>] member inline _.labelInValue (x: DSLElement, v: bool) = x.attr "labelInValue" v
        [<CustomOperation("listHeight")>] member inline _.listHeight (x: DSLElement, v: int) = x.attr "listHeight" v
        [<CustomOperation("loadData")>] member inline _.loadData (x: DSLElement, v: obj -> unit) = x.attr "loadData" v
        [<CustomOperation("maxTagCount")>] member inline _.maxTagCount (x: DSLElement, v: int) = x.attr "maxTagCount" v
        [<CustomOperation("maxTagPlaceholder")>] member inline _.maxTagPlaceholder (x: DSLElement, v: ReactElement) = x.attr "maxTagPlaceholder" v
        [<CustomOperation("multiple")>] member inline _.multiple (x: DSLElement, v: bool) = x.attr "multiple" v
        [<CustomOperation("placeholder")>] member inline _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
        [<CustomOperation("searchPlaceholder")>] member inline _.searchPlaceholder (x: DSLElement, v: string) = x.attr "searchPlaceholder" v
        [<CustomOperation("searchValue")>] member inline _.searchValue (x: DSLElement, v: string) = x.attr "searchValue" v
        [<CustomOperation("showArrow")>] member inline _.showArrow (x: DSLElement, v: bool) = x.attr "showArrow" v
        [<CustomOperation("showCheckedStrategy")>] member inline _.showCheckedStrategy (x: DSLElement, v: obj) = x.attr "showCheckedStrategy" v
        // TODO better type
        [<CustomOperation("showSearch")>] member inline _.showSearch (x: DSLElement, v: bool) = x.attr "showSearch" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("suffixIcon")>] member inline _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
        [<CustomOperation("switcherIcon")>] member inline _.switcherIcon (x: DSLElement, v: ReactElement) = x.attr "switcherIcon" v
        [<CustomOperation("treeCheckable")>] member inline _.treeCheckable (x: DSLElement, v: bool) = x.attr "treeCheckable" v
        [<CustomOperation("treeCheckStrictly")>] member inline _.treeCheckStrictly (x: DSLElement, v: bool) = x.attr "treeCheckStrictly" v
        [<CustomOperation("treeData")>] member inline _.treeData (x: DSLElement, v: TreeSelectData array) = x.attr "treeData" v
        [<CustomOperation("treeDataSimpleMode")>] member inline _.treeDataSimpleMode (x: DSLElement, v: TreeFlatData array) = x.attr "treeDataSimpleMode" v
        [<CustomOperation("treeDefaultExpandAll")>] member inline _.treeDefaultExpandAll (x: DSLElement, v: bool) = x.attr "treeDefaultExpandAll" v
        [<CustomOperation("treeDefaultExpandedKeys")>] member inline _.treeDefaultExpandedKeys (x: DSLElement, v: string array) = x.attr "treeDefaultExpandedKeys" v
        [<CustomOperation("treeExpandedKeys")>] member inline _.treeExpandedKeys (x: DSLElement, v: string array) = x.attr "treeExpandedKeys" v
        [<CustomOperation("treeIcon")>] member inline _.treeIcon (x: DSLElement, v: bool) = x.attr "treeIcon" v
        [<CustomOperation("treeNodeFilterProp")>] member inline _.treeNodeFilterProp (x: DSLElement, v: string) = x.attr "treeNodeFilterProp" v
        [<CustomOperation("treeNodeLabelProp")>] member inline _.treeNodeLabelProp (x: DSLElement, v: string) = x.attr "treeNodeLabelProp" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string array) = x.attr "value" v
        [<CustomOperation("virtualize")>] member inline _.virtualize (x: DSLElement, v: bool) = x.attr "virtual" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<string, string, obj, unit>) = x.attr "onChange" v
        [<CustomOperation("onDropdownVisibleChange")>] member inline _.onDropdownVisibleChange (x: DSLElement, v: Func<bool, unit>) = x.attr "onDropdownVisibleChange" v
        [<CustomOperation("onSearch")>] member inline _.onSearch (x: DSLElement, v: string -> unit) = x.attr "onSearch" v
        [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, v: Func<string, TreeSelectData, obj, unit>) = x.attr "onSelect" v
        [<CustomOperation("onTreeExpand")>] member inline _.onTreeExpand (x: DSLElement, v: string array -> unit) = x.attr "onTreeExpand" v
    
    type TreeSelectNodeBuilder() =
        inherit ReactBuilder(import "TreeSelect.TreeNode" "antd")
    
        [<CustomOperation("checkable")>] member inline _.checkable (x: DSLElement, v: bool) = x.attr "checkable" v
        [<CustomOperation("disableCheckbox")>] member inline _.disableCheckbox (x: DSLElement, v: bool) = x.attr "disableCheckbox" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("isLeaf")>] member inline _.isLeaf (x: DSLElement, v: bool) = x.attr "isLeaf" v
        [<CustomOperation("selectable")>] member inline _.selectable (x: DSLElement, v: bool) = x.attr "selectable" v
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v
    