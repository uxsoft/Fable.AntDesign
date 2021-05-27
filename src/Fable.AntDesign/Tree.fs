module Fable.AntDesign.Tree

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type DirectoryTreeExpandAction =
    | Click
    | DoubleClick

type TreeData =
    {
        key: string
        title: string
        icon: ReactElement
        children: TreeData array
        disabled: bool
        selectable: bool
    }

type TreeMouseEvent<'T> =
    {
        event: MouseEvent
        node: 'T
    }

type TreeDropEvent<'T> =
    {
        event: Event
        node: 'T
        dragNode: 'T
        dragNodesKeys: string array
        dropPosition: int
        dropToGap: bool
    }

type TreeSelectedEvent<'T> =
    {
        selected: bool
        selectedNodes: 'T array
        node: 'T
        event: Event
    }
    
type TreeExpandEvent<'T> =
    {
        expanded: bool
        node: 'T
    }
    
type TreeCheckEvent<'T> =
    {
        ``checked``: bool
        checkedNodes: 'T array
        event: Event
        halfCheckedKeys: string array
    }

type TreeBase<'T>() =
    inherit ReactBuilder()
    [<CustomOperation("autoExpandParent")>] member _.autoExpandParent (x: DSLElement, v: bool) = x.attr "autoExpandParent" v
    [<CustomOperation("blockNode")>] member _.blockNode (x: DSLElement) = x.attr "blockNode" true
    [<CustomOperation("checkable")>] member _.checkable (x: DSLElement) = x.attr "checkable" true
    [<CustomOperation("checkedKeys")>] member _.checkedKeys (x: DSLElement, v: string array) = x.attr "checkedKeys" v
    [<CustomOperation("checkStrictly")>] member _.checkStrictly (x: DSLElement) = x.attr "checkStrictly" true
    [<CustomOperation("defaultCheckedKeys")>] member _.defaultCheckedKeys (x: DSLElement, v: string array) = x.attr "defaultCheckedKeys" v
    [<CustomOperation("defaultExpandAll")>] member _.defaultExpandAll (x: DSLElement) = x.attr "defaultExpandAll" true
    [<CustomOperation("defaultExpandedKeys")>] member _.defaultExpandedKeys (x: DSLElement, v: string array) = x.attr "defaultExpandedKeys" v
    [<CustomOperation("defaultExpandParent")>] member _.defaultExpandParent (x: DSLElement) = x.attr "defaultExpandParent" true
    [<CustomOperation("defaultSelectedKeys")>] member _.defaultSelectedKeys (x: DSLElement, v: string array) = x.attr "defaultSelectedKeys" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("draggable")>] member _.draggable (x: DSLElement) = x.attr "draggable" true
    [<CustomOperation("expandedKeys")>] member _.expandedKeys (x: DSLElement, v: string array) = x.attr "expandedKeys" v
    [<CustomOperation("filterTreeNode")>] member _.filterTreeNode (x: DSLElement, v: 'TEntity -> bool) = x.attr "filterTreeNode" v
    [<CustomOperation("height")>] member _.height (x: DSLElement, v: float) = x.attr "height" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("loadData")>] member _.loadData (x: DSLElement, v: 'T -> unit) = x.attr "loadData" v
    [<CustomOperation("loadedKeys")>] member _.loadedKeys (x: DSLElement, v: string array) = x.attr "loadedKeys" v
    [<CustomOperation("multiple")>] member _.multiple (x: DSLElement) = x.attr "multiple" true
    [<CustomOperation("selectable")>] member _.selectable (x: DSLElement) = x.attr "selectable" true
    [<CustomOperation("selectedKeys")>] member _.selectedKeys (x: DSLElement, v: string array) = x.attr "selectedKeys" v
    [<CustomOperation("showIcon")>] member _.showIcon (x: DSLElement) = x.attr "showIcon" true
    [<CustomOperation("showLine")>] member _.showLine (x: DSLElement) = x.attr "showLine" true
    [<CustomOperation("switcherIcon")>] member _.switcherIcon (x: DSLElement, v: ReactElement) = x.attr "switcherIcon" v
    [<CustomOperation("titleRender")>] member _.titleRender (x: DSLElement, v: Func<'TEntity, ReactElement>) = x.attr "titleRender" v
    [<CustomOperation("treeData")>] member _.treeData (x: DSLElement, v: 'TEntity array) = x.attr "treeData" v
    [<CustomOperation("virtualize")>] member _.virtualize (x: DSLElement) = x.attr "virtual" true
    [<CustomOperation("onCheck")>] member _.onCheck (x: DSLElement, v: Func<string array, TreeCheckEvent<'T>, unit>) = x.attr "onCheck" v
    [<CustomOperation("onDragEnd")>] member _.onDragEnd (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragEnd" v
    [<CustomOperation("onDragEnter")>] member _.onDragEnter (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragEnter" v
    [<CustomOperation("onDragLeave")>] member _.onDragLeave (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragLeave" v
    [<CustomOperation("onDragOver")>] member _.onDragOver (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragOver" v
    [<CustomOperation("onDragStart")>] member _.onDragStart (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragStart" v
    [<CustomOperation("onDrop")>] member _.onDrop (x: DSLElement, v: TreeDropEvent<'TEntity> -> unit) = x.attr "onDrop" v
    [<CustomOperation("onExpand")>] member _.onExpand (x: DSLElement, v: Func<string array, TreeExpandEvent<'T>, unit>) = x.attr "onExpand" v
    [<CustomOperation("onLoad")>] member _.onLoad (x: DSLElement, v: Func<string array, TreeMouseEvent<'T>, unit>) = x.attr "onLoad" v
    [<CustomOperation("onRightClick")>] member _.onRightClick (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onRightClick" v
    [<CustomOperation("onSelect")>] member _.onSelect (x: DSLElement, v: Func<string array, TreeSelectedEvent<'T>, unit>) = x.attr "onSelect" v

type TreeBuilder<'T>() =
    inherit TreeBase<'T>()
    member x.Run(s: DSLElement) = ofImport "Tree" "antd" (createObj s.Attributes) s.Children


type DirectoryTreeBuilder<'T>() =
    inherit TreeBase<'T>()
    member x.Run(s: DSLElement) = ofImport "Tree.DirectoryTree" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("expandAction")>] member _.expandAction (x: DSLElement, v: DirectoryTreeExpandAction) = x.attr "expandAction" v

type TreeNodeBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Tree.TreeNode" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("checkable")>] member _.checkable (x: DSLElement) = x.attr "checkable" true
    [<CustomOperation("disableCheckbox")>] member _.disableCheckbox (x: DSLElement) = x.attr "disableCheckbox" true
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("isLeaf")>] member _.isLeaf (x: DSLElement) = x.attr "isLeaf" true
    [<CustomOperation("key")>] member _.key (x: DSLElement, v: string) = x.attr "key" v
    [<CustomOperation("selectable")>] member _.selectable (x: DSLElement) = x.attr "selectable" true
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v