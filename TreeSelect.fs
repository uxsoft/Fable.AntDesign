namespace Fable.AntD

open Browser.Types
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

type AntTreeSelect() =
    inherit AntElement<AntTreeSelect>(ofImport "TreeSelect" "antd")
    member x.allowClear (v: bool) = x.attribute "allowClear" v
    member x.autoClearSearchValue (v: bool) = x.attribute "autoClearSearchValue" v
    member x.bordered (v: bool) = x.attribute "bordered" v
    member x.defaultValue (v: string array) = x.attribute "defaultValue" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.dropdownClassName (v: string) = x.attribute "dropdownClassName" v
    member x.dropdownMatchSelectWidth (v: bool) = x.attribute "dropdownMatchSelectWidth" v
    member x.dropdownRender (v: Func<ReactElement, obj> -> ReactElement) = x.attribute "dropdownRender" v
    member x.dropdownStyle (css: Props.CSSProp list) = x.attribute "dropdownStyle" (keyValueList CaseRules.LowerFirst css)
    member x.filterTreeNode (v: bool) = x.attribute "filterTreeNode" v
    member x.getPopupContainer (v: unit -> HTMLElement) = x.attribute "getPopupContainer" v
    member x.labelInValue (v: bool) = x.attribute "labelInValue" v
    member x.listHeight (v: int) = x.attribute "listHeight" v
    member x.loadData (v: obj -> unit) = x.attribute "loadData" v
    member x.maxTagCount (v: int) = x.attribute "maxTagCount" v
    member x.multiple (v: bool) = x.attribute "multiple" v
    member x.placeholder (v: string) = x.attribute "placeholder" v
    member x.searchPlaceholder (v: string) = x.attribute "searchPlaceholder" v
    member x.searchValue (v: string) = x.attribute "searchValue" v
    member x.treeIcon (v: bool) = x.attribute "treeIcon" v
    member x.switcherIcon (v: ReactElement) = x.attribute "switcherIcon" v
    member x.showCheckedStrategy (v: obj) = x.attribute "showCheckedStrategy" v
    member x.showSearch (v: bool) = x.attribute "showSearch" v
    member x.size (v: Size) = x.attribute "size" v
    member x.suffixIcon (v: ReactElement) = x.attribute "suffixIcon" v
    member x.treeCheckable (v: bool) = x.attribute "treeCheckable" v
    member x.treeCheckStrictly (v: bool) = x.attribute "treeCheckStrictly" v
    member x.treeData (v: TreeSelectData array) = x.attribute "treeData" v
    member x.treeDataSimpleMode (v: TreeFlatData array) = x.attribute "treeDataSimpleMode" v
    member x.treeDefaultExpandAll (v: bool) = x.attribute "treeDefaultExpandAll" v
    member x.treeDefaultExpandedKeys (v: string array) = x.attribute "treeDefaultExpandedKeys" v
    member x.treeExpandedKeys (v: string array) = x.attribute "treeExpandedKeys" v
    member x.treeNodeFilterProp (v: string) = x.attribute "treeNodeFilterProp" v
    member x.treeNodeLabelProp (v: string) = x.attribute "treeNodeLabelProp" v
    member x.value (v: string array) = x.attribute "value" v
    member x.virtual (v: bool) = x.attribute "virtual" v
    member x.onChange (v: Func<string, string, obj, unit>) = x.attribute "onChange" v
    member x.onSearch (v: string -> unit) = x.attribute "onSearch" v
    member x.onSelect (v: Func<string, TreeSelectData, obj, unit>) = x.attribute "onSelect" v
    member x.onTreeExpand (v: string array -> unit) = x.attribute "onTreeExpand" v

type AntTreeSelectNode() =
    inherit AntElement<AntTreeSelectNode>(ofImport "TreeSelect.TreeNode" "antd")
    member x.selectable (v: bool) = x.attribute "selectable" v
    member x.checkable (v: bool) = x.attribute "checkable" v
    member x.disableCheckbox (v: bool) = x.attribute "disableCheckbox" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.isLeaf (v: bool) = x.attribute "isLeaf" v
    member x.title (v: ReactElement) = x.attribute "title" v
    member x.value (v: string) = x.attribute "value" v
