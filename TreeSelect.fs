namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type TreeSelectData =
    { value: string
      title: string
      children: TreeSelectData array }

type TreeFlatData =
    { id: string
      pId: string
      rootPId: string }

type AntTreeSelect() =
    inherit AntElement(ofImport "TreeSelect" "antd")
    member x.AllowClear
        with set (v: bool) = x.Attribute "allowClear" v
    member x.AutoClearSearchValue
        with set (v: bool) = x.Attribute "autoClearSearchValue" v
    member x.DefaultValue
        with set (v: string array) = x.Attribute "defaultValue" v
    member x.Disabled
        with set (v: bool) = x.Attribute "disabled" v
    member x.DropdownClassName
        with set (v: string) = x.Attribute "dropdownClassName" v
    member x.DropdownMatchSelectWidth
        with set (v: bool) = x.Attribute "dropdownMatchSelectWidth" v
    member x.FilterTreeNode
        with set (v: bool) = x.Attribute "filterTreeNode" v
    member x.GetPopupContainer
        with set (v: unit -> ReactElement) = x.Attribute "getPopupContainer" v
    member x.LabelInValue
        with set (v: bool) = x.Attribute "labelInValue" v
    member x.LoadData
        with set (v: obj -> unit) = x.Attribute "loadData" v
    member x.MaxTagCount
        with set (v: int) = x.Attribute "maxTagCount" v
    member x.Multiple
        with set (v: bool) = x.Attribute "multiple" v
    member x.Placeholder
        with set (v: string) = x.Attribute "placeholder" v
    member x.SearchPlaceholder
        with set (v: string) = x.Attribute "searchPlaceholder" v
    member x.SearchValue
        with set (v: string) = x.Attribute "searchValue" v
    member x.TreeIcon
        with set (v: bool) = x.Attribute "treeIcon" v
    member x.ShowCheckedStrategy
        with set (v: obj) = x.Attribute "showCheckedStrategy" v
    member x.ShowSearch
        with set (v: bool) = x.Attribute "showSearch" v
    member x.Size
        with set (v: Size) = x.Attribute "size" v
    member x.SuffixIcon
        with set (v: ReactElement) = x.Attribute "suffixIcon" v
    member x.TreeCheckable
        with set (v: bool) = x.Attribute "treeCheckable" v
    member x.TreeCheckStrictly
        with set (v: bool) = x.Attribute "treeCheckStrictly" v
    member x.TreeData
        with set (v: TreeSelectData array) = x.Attribute "treeData" v
    member x.TreeDataSimpleMode
        with set (v: TreeFlatData array) = x.Attribute "treeDataSimpleMode" v
    member x.TreeDefaultExpandAll
        with set (v: bool) = x.Attribute "treeDefaultExpandAll" v
    member x.TreeDefaultExpandedKeys
        with set (v: string array) = x.Attribute "treeDefaultExpandedKeys" v
    member x.TreeExpandedKeys
        with set (v: string array) = x.Attribute "treeExpandedKeys" v
    member x.TreeNodeFilterProp
        with set (v: string) = x.Attribute "treeNodeFilterProp" v
    member x.TreeNodeLabelProp
        with set (v: string) = x.Attribute "treeNodeLabelProp" v
    member x.Value
        with set (v: string array) = x.Attribute "value" v

    member x.OnChange
        with set (v: string -> string -> obj -> unit) =
            let uncurried = System.Func<string, string, obj, unit> v
            x.Attribute "onChange" uncurried

    member x.OnSearch
        with set (v: string -> unit) = x.Attribute "onSearch" v

    member x.OnSelect
        with set (v: string -> TreeSelectData -> obj -> unit) =
            let uncurried = System.Func<string, TreeSelectData, obj, unit> v
            x.Attribute "onSelect" uncurried

    member x.OnTreeExpand
        with set (v: string array -> unit) = x.Attribute "onTreeExpand" v
    member x.DropdownStyle
        with set (css: Props.CSSProp list) = x.Attribute "dropdownStyle" (keyValueList CaseRules.LowerFirst css)

type AntTreeSelectNode() =
    inherit AntElement(ofImport "TreeSelect.TreeNode" "antd")
    member x.Selectable
        with set (v: bool) = x.Attribute "selectable" v
    member x.Checkable
        with set (v: bool) = x.Attribute "checkable" v
    member x.DisableCheckbox
        with set (v: bool) = x.Attribute "disableCheckbox" v
    member x.Disabled
        with set (v: bool) = x.Attribute "disabled" v
    member x.IsLeaf
        with set (v: bool) = x.Attribute "isLeaf" v
    member x.Key
        with set (v: string) = x.Attribute "key" v
    member x.Title
        with set (v: ReactElement) = x.Attribute "title" v
    member x.Value
        with set (v: string) = x.Attribute "value" v
