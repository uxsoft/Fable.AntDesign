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
        (v: bool) = x.attribute "allowClear" v
    member x.AutoClearSearchValue
        (v: bool) = x.attribute "autoClearSearchValue" v
    member x.DefaultValue
        (v: string array) = x.attribute "defaultValue" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.DropdownClassName
        (v: string) = x.attribute "dropdownClassName" v
    member x.DropdownMatchSelectWidth
        (v: bool) = x.attribute "dropdownMatchSelectWidth" v
    member x.FilterTreeNode
        (v: bool) = x.attribute "filterTreeNode" v
    member x.GetPopupContainer
        (v: unit -> ReactElement) = x.attribute "getPopupContainer" v
    member x.LabelInValue
        (v: bool) = x.attribute "labelInValue" v
    member x.LoadData
        (v: obj -> unit) = x.attribute "loadData" v
    member x.MaxTagCount
        (v: int) = x.attribute "maxTagCount" v
    member x.Multiple
        (v: bool) = x.attribute "multiple" v
    member x.Placeholder
        (v: string) = x.attribute "placeholder" v
    member x.SearchPlaceholder
        (v: string) = x.attribute "searchPlaceholder" v
    member x.SearchValue
        (v: string) = x.attribute "searchValue" v
    member x.TreeIcon
        (v: bool) = x.attribute "treeIcon" v
    member x.ShowCheckedStrategy
        (v: obj) = x.attribute "showCheckedStrategy" v
    member x.ShowSearch
        (v: bool) = x.attribute "showSearch" v
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.SuffixIcon
        (v: ReactElement) = x.attribute "suffixIcon" v
    member x.TreeCheckable
        (v: bool) = x.attribute "treeCheckable" v
    member x.TreeCheckStrictly
        (v: bool) = x.attribute "treeCheckStrictly" v
    member x.TreeData
        (v: TreeSelectData array) = x.attribute "treeData" v
    member x.TreeDataSimpleMode
        (v: TreeFlatData array) = x.attribute "treeDataSimpleMode" v
    member x.TreeDefaultExpandAll
        (v: bool) = x.attribute "treeDefaultExpandAll" v
    member x.TreeDefaultExpandedKeys
        (v: string array) = x.attribute "treeDefaultExpandedKeys" v
    member x.TreeExpandedKeys
        (v: string array) = x.attribute "treeExpandedKeys" v
    member x.TreeNodeFilterProp
        (v: string) = x.attribute "treeNodeFilterProp" v
    member x.TreeNodeLabelProp
        (v: string) = x.attribute "treeNodeLabelProp" v
    member x.Value
        (v: string array) = x.attribute "value" v

    member x.OnChange
        (v: string -> string -> obj -> unit) =
            let uncurried = System.Func<string, string, obj, unit> v
            x.attribute "onChange" uncurried

    member x.OnSearch
        (v: string -> unit) = x.attribute "onSearch" v

    member x.OnSelect
        (v: string -> TreeSelectData -> obj -> unit) =
            let uncurried = System.Func<string, TreeSelectData, obj, unit> v
            x.attribute "onSelect" uncurried

    member x.OnTreeExpand
        (v: string array -> unit) = x.attribute "onTreeExpand" v
    member x.DropdownStyle
        (css: Props.CSSProp list) = x.attribute "dropdownStyle" (keyValueList CaseRules.LowerFirst css)

type AntTreeSelectNode() =
    inherit AntElement(ofImport "TreeSelect.TreeNode" "antd")
    member x.Selectable
        (v: bool) = x.attribute "selectable" v
    member x.Checkable
        (v: bool) = x.attribute "checkable" v
    member x.DisableCheckbox
        (v: bool) = x.attribute "disableCheckbox" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.IsLeaf
        (v: bool) = x.attribute "isLeaf" v
    member x.Key
        (v: string) = x.attribute "key" v
    member x.Title
        (v: ReactElement) = x.attribute "title" v
    member x.Value
        (v: string) = x.attribute "value" v
