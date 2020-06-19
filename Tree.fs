namespace Fable.AntD

open Fable.Core
open Fable.React
open System

[<StringEnum; RequireQualifiedAccess>]
type DirectoryTreeExpandAction =
    | Click
    | DoubleClick

type TreeData = {
    key: string
    title: string
    children: TreeData array
    disabled: bool
    selectable: bool
}

type AntTreeBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.autoExpandParent (v: bool) = x.attribute "autoExpandParent" v
    member x.blockNode (v: bool) = x.attribute "blockNode" v
    member x.checkable (v: bool) = x.attribute "checkable" v
    member x.checkedKeys (v: string array) = x.attribute "checkedKeys" v
    member x.checkStrictly (v: bool) = x.attribute "checkStrictly" v
    member x.defaultCheckedKeys (v: string array) = x.attribute "defaultCheckedKeys" v
    member x.defaultExpandAll (v: bool) = x.attribute "defaultExpandAll" v
    member x.defaultExpandedKeys (v: string array) = x.attribute "defaultExpandedKeys" v
    member x.defaultExpandParent (v: bool) = x.attribute "defaultExpandParent" v
    member x.defaultSelectedKeys (v: string array) = x.attribute "defaultSelectedKeys" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.draggable (v: bool) = x.attribute "draggable" v
    member x.expandedKeys (v: string array) = x.attribute "expandedKeys" v
    member x.filterTreeNode (v: obj -> bool) = x.attribute "filterTreeNode" v
    member x.loadData (v: obj -> unit) = x.attribute "loadData" v
    member x.loadedKeys (v: string array) = x.attribute "loadedKeys" v
    member x.multiple (v: bool) = x.attribute "multiple" v
    member x.selectable (v: bool) = x.attribute "selectable" v
    member x.selectedKeys (v: string array) = x.attribute "selectedKeys" v
    member x.showIcon (v: bool) = x.attribute "showIcon" v
    member x.switcherIcon (v: ReactElement) = x.attribute "switcherIcon" v
    member x.showLine (v: bool) = x.attribute "showLIne" v
    member x.onCheck (v: Func<string array, obj, unit>) = x.attribute "onCheck" v
    member x.onDragEnd (v: obj -> unit) = x.attribute "onDragEnd" v
    member x.onDragEnter (v: obj -> unit) = x.attribute "onDragEnter" v
    member x.onDragLeave (v: obj -> unit) = x.attribute "onDragLeave" v
    member x.onDragOver (v: obj -> unit) = x.attribute "onDragOver" v
    member x.onDragStart (v: obj -> unit) = x.attribute "onDragStart" v
    member x.onDrop (v: obj -> unit) = x.attribute "onDrop" v
    member x.onExpand (v: Func<string array, obj, unit>) = x.attribute "onExpand" v
    member x.onLoad (v: Func<string array, obj, unit>) = x.attribute "onLoad" v
    member x.onRightClick (v: obj -> unit) = x.attribute "onRightClick" v
    member x.onSelect (v: Func<string array, obj, unit>) = x.attribute "onSelect" v
    member x.treeData (v: TreeData array) = x.attribute "treeData" v

type AntTree() =
    inherit AntTreeBase<AntTree>(ofImport "Tree" "antd")

type AntDirectoryTree() =
    inherit AntTreeBase<AntDirectoryTree>(ofImport "Tree.DirectoryTree" "antd")
    member x.expandAction (v: DirectoryTreeExpandAction) = x.attribute "expandAction" v

type AntTreeNode() =
    inherit AntElement<AntTreeNode>(ofImport "Tree.TreeNode" "antd")
    member x.checkable (v: bool) = x.attribute "checkable" v
    member x.disableCheckbox (v: bool) = x.attribute "disableCheckbox" v
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.isLeaf (v: bool) = x.attribute "isLeaf" v
    member x.key (v: string) = x.attribute "key" v
    member x.selectable (v: bool) = x.attribute "selectable" v
    member x.title (v: ReactElement) = x.attribute "title" v