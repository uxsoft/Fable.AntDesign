namespace Fable.AntD

open Browser.Types
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
    icon: ReactElement
    children: TreeData array
    disabled: bool
    selectable: bool
}

type TreeMouseEvent = {
    event: Event
    node: TreeData
}

type TreeDropEvent = {
    event: Event
    node: TreeData
    dragNode: TreeData
    dragNodesKeys: string array
    dropPosition: int
    dropToGap: bool
}

type AntTreeBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.autoExpandParent (v: bool) = x.attribute "autoExpandParent" v
    member x.blockNode (?v: bool) = x.attribute "blockNode" (Option.defaultValue true v)
    member x.checkable (?v: bool) = x.attribute "checkable" (Option.defaultValue true v)
    member x.checkedKeys (v: string array) = x.attribute "checkedKeys" v
    member x.checkStrictly (?v: bool) = x.attribute "checkStrictly" (Option.defaultValue true v)
    member x.defaultCheckedKeys (v: string array) = x.attribute "defaultCheckedKeys" v
    member x.defaultExpandAll (?v: bool) = x.attribute "defaultExpandAll" (Option.defaultValue true v)
    member x.defaultExpandedKeys (v: string array) = x.attribute "defaultExpandedKeys" v
    member x.defaultExpandParent (?v: bool) = x.attribute "defaultExpandParent" (Option.defaultValue true v)
    member x.defaultSelectedKeys (v: string array) = x.attribute "defaultSelectedKeys" v
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.draggable (?v: bool) = x.attribute "draggable" (Option.defaultValue true v)
    member x.expandedKeys (v: string array) = x.attribute "expandedKeys" v
    member x.filterTreeNode (v: TreeData -> bool) = x.attribute "filterTreeNode" v
    member x.height (v: float) = x.attribute "height" v
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.loadData (v: obj -> unit) = x.attribute "loadData" v
    member x.loadedKeys (v: string array) = x.attribute "loadedKeys" v
    member x.multiple (?v: bool) = x.attribute "multiple" (Option.defaultValue true v)
    member x.selectable (?v: bool) = x.attribute "selectable" (Option.defaultValue true v)
    member x.selectedKeys (v: string array) = x.attribute "selectedKeys" v
    member x.showIcon (?v: bool) = x.attribute "showIcon" (Option.defaultValue true v)
    member x.showLine (?v: bool) = x.attribute "showLine" (Option.defaultValue true v)
    member x.switcherIcon (v: ReactElement) = x.attribute "switcherIcon" v
    member x.titleRender (v: Func<TreeData, ReactElement>) = x.attribute "titleRender" v
    member x.treeData (v: TreeData array) = x.attribute "treeData" v
    member x.isVirtual (?v: bool) = x.attribute "virtual" (Option.defaultValue true v)
    member x.onCheck (v: Func<string array, obj, unit>) = x.attribute "onCheck" v
    member x.onDragEnd (v: TreeMouseEvent -> unit) = x.attribute "onDragEnd" v
    member x.onDragEnter (v: TreeMouseEvent -> unit) = x.attribute "onDragEnter" v
    member x.onDragLeave (v: TreeMouseEvent -> unit) = x.attribute "onDragLeave" v
    member x.onDragOver (v: TreeMouseEvent -> unit) = x.attribute "onDragOver" v
    member x.onDragStart (v: TreeMouseEvent -> unit) = x.attribute "onDragStart" v
    member x.onDrop (v: TreeDropEvent -> unit) = x.attribute "onDrop" v
    member x.onExpand (v: Func<string array, obj, unit>) = x.attribute "onExpand" v
    member x.onLoad (v: Func<string array, obj, unit>) = x.attribute "onLoad" v
    member x.onRightClick (v: TreeMouseEvent -> unit) = x.attribute "onRightClick" v
    member x.onSelect (v: Func<string array, obj, unit>) = x.attribute "onSelect" v

type AntTree() =
    inherit AntTreeBase<AntTree>(ofImport "Tree" "antd")

type AntDirectoryTree() =
    inherit AntTreeBase<AntDirectoryTree>(ofImport "Tree.DirectoryTree" "antd")
    member x.expandAction (v: DirectoryTreeExpandAction) = x.attribute "expandAction" v

type AntTreeNode() =
    inherit AntElement<AntTreeNode>(ofImport "Tree.TreeNode" "antd")
    member x.checkable (?v: bool) = x.attribute "checkable" (Option.defaultValue true v)
    member x.disableCheckbox (?v: bool) = x.attribute "disableCheckbox" v
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.isLeaf (?v: bool) = x.attribute "isLeaf" (Option.defaultValue true v)
    member x.key (v: string) = x.attribute "key" v
    member x.selectable (?v: bool) = x.attribute "selectable" (Option.defaultValue true v)
    member x.title (v: ReactElement) = x.attribute "title" v