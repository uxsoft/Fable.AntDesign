module Fable.AntDesign.TreeSelect

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open System

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
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "TreeSelect" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowClear")>] member _.allowClear (x: DSLElement) = x.attr "allowClear" true
    [<CustomOperation("autoClearSearchValue")>] member _.autoClearSearchValue (x: DSLElement) = x.attr "autoClearSearchValue" true
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("dropdownClassName")>] member _.dropdownClassName (x: DSLElement, v: string) = x.attr "dropdownClassName" v
    [<CustomOperation("dropdownMatchSelectWidth")>] member _.dropdownMatchSelectWidth (x: DSLElement, v: bool) = x.attr "dropdownMatchSelectWidth" v
    [<CustomOperation("dropdownRender")>] member _.dropdownRender (x: DSLElement, v: Func<ReactElement, obj> -> ReactElement) = x.attr "dropdownRender" v
    [<CustomOperation("dropdownStyle")>] member _.dropdownStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "dropdownStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("filterTreeNode")>] member _.filterTreeNode (x: DSLElement, v: Func<string, TreeSelectData, bool>) = x.attr "filterTreeNode" v
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getPopupContainer" v
    [<CustomOperation("labelInValue")>] member _.labelInValue (x: DSLElement) = x.attr "labelInValue" true
    [<CustomOperation("listHeight")>] member _.listHeight (x: DSLElement, v: int) = x.attr "listHeight" v
    [<CustomOperation("loadData")>] member _.loadData (x: DSLElement, v: obj -> unit) = x.attr "loadData" v
    [<CustomOperation("maxTagCount")>] member _.maxTagCount (x: DSLElement, v: int) = x.attr "maxTagCount" v
    [<CustomOperation("maxTagPlaceholder")>] member _.maxTagPlaceholder (x: DSLElement, v: ReactElement) = x.attr "maxTagPlaceholder" v
    [<CustomOperation("multiple")>] member _.multiple (x: DSLElement) = x.attr "multiple" true
    [<CustomOperation("placeholder")>] member _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
    [<CustomOperation("searchPlaceholder")>] member _.searchPlaceholder (x: DSLElement, v: string) = x.attr "searchPlaceholder" v
    [<CustomOperation("searchValue")>] member _.searchValue (x: DSLElement, v: string) = x.attr "searchValue" v
    [<CustomOperation("showArrow")>] member _.showArrow (x: DSLElement) = x.attr "showArrow" true
    [<CustomOperation("showCheckedStrategy")>] member _.showCheckedStrategy (x: DSLElement, v: obj) = x.attr "showCheckedStrategy" v
    [<CustomOperation("showSearch")>] member _.showSearch (x: DSLElement) = x.attr "showSearch" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("suffixIcon")>] member _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
    [<CustomOperation("switcherIcon")>] member _.switcherIcon (x: DSLElement, v: ReactElement) = x.attr "switcherIcon" v
    [<CustomOperation("treeCheckable")>] member _.treeCheckable (x: DSLElement) = x.attr "treeCheckable" true
    [<CustomOperation("treeCheckStrictly")>] member _.treeCheckStrictly (x: DSLElement) = x.attr "treeCheckStrictly" true
    [<CustomOperation("treeData")>] member _.treeData (x: DSLElement, v: TreeSelectData array) = x.attr "treeData" v
    [<CustomOperation("treeDataSimpleMode")>] member _.treeDataSimpleMode (x: DSLElement, v: TreeFlatData array) = x.attr "treeDataSimpleMode" v
    [<CustomOperation("treeDefaultExpandAll")>] member _.treeDefaultExpandAll (x: DSLElement) = x.attr "treeDefaultExpandAll" true
    [<CustomOperation("treeDefaultExpandedKeys")>] member _.treeDefaultExpandedKeys (x: DSLElement, v: string array) = x.attr "treeDefaultExpandedKeys" v
    [<CustomOperation("treeExpandedKeys")>] member _.treeExpandedKeys (x: DSLElement, v: string array) = x.attr "treeExpandedKeys" v
    [<CustomOperation("treeIcon")>] member _.treeIcon (x: DSLElement) = x.attr "treeIcon" true
    [<CustomOperation("treeNodeFilterProp")>] member _.treeNodeFilterProp (x: DSLElement, v: string) = x.attr "treeNodeFilterProp" v
    [<CustomOperation("treeNodeLabelProp")>] member _.treeNodeLabelProp (x: DSLElement, v: string) = x.attr "treeNodeLabelProp" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string array) = x.attr "value" v
    [<CustomOperation("virtualize")>] member _.virtualize (x: DSLElement) = x.attr "virtual" true
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Func<string, string, obj, unit>) = x.attr "onChange" v
    [<CustomOperation("onDropdownVisibleChange")>] member _.onDropdownVisibleChange (x: DSLElement, v: Func<bool, unit>) = x.attr "onDropdownVisibleChange" v
    [<CustomOperation("onSearch")>] member _.onSearch (x: DSLElement, v: string -> unit) = x.attr "onSearch" v
    [<CustomOperation("onSelect")>] member _.onSelect (x: DSLElement, v: Func<string, TreeSelectData, obj, unit>) = x.attr "onSelect" v
    [<CustomOperation("onTreeExpand")>] member _.onTreeExpand (x: DSLElement, v: string array -> unit) = x.attr "onTreeExpand" v

type TreeSelectNodeBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "TreeSelect.TreeNode" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("checkable")>] member _.checkable (x: DSLElement) = x.attr "checkable" true
    [<CustomOperation("disableCheckbox")>] member _.disableCheckbox (x: DSLElement) = x.attr "disableCheckbox" true
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("isLeaf")>] member _.isLeaf (x: DSLElement) = x.attr "isLeaf" true
    [<CustomOperation("selectable")>] member _.selectable (x: DSLElement) = x.attr "selectable" true
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v
