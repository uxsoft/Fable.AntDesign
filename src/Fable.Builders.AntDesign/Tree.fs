namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<AutoOpen>]
module Tree =

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
    
    type TreeBase<'T>(import) =
        inherit ReactBuilder(import)
        [<CustomOperation("autoExpandParent")>] member inline _.autoExpandParent (x: DSLElement, v: bool) = x.attr "autoExpandParent" v
        [<CustomOperation("blockNode")>] member inline _.blockNode (x: DSLElement, v: bool) = x.attr "blockNode" v
        [<CustomOperation("checkable")>] member inline _.checkable (x: DSLElement, v: bool) = x.attr "checkable" v
        [<CustomOperation("checkedKeys")>] member inline _.checkedKeys (x: DSLElement, v: string array) = x.attr "checkedKeys" v
        [<CustomOperation("checkStrictly")>] member inline _.checkStrictly (x: DSLElement, v: bool) = x.attr "checkStrictly" v
        [<CustomOperation("defaultCheckedKeys")>] member inline _.defaultCheckedKeys (x: DSLElement, v: string array) = x.attr "defaultCheckedKeys" v
        [<CustomOperation("defaultExpandAll")>] member inline _.defaultExpandAll (x: DSLElement, v: bool) = x.attr "defaultExpandAll" v
        [<CustomOperation("defaultExpandedKeys")>] member inline _.defaultExpandedKeys (x: DSLElement, v: string array) = x.attr "defaultExpandedKeys" v
        [<CustomOperation("defaultExpandParent")>] member inline _.defaultExpandParent (x: DSLElement, v: bool) = x.attr "defaultExpandParent" v
        [<CustomOperation("defaultSelectedKeys")>] member inline _.defaultSelectedKeys (x: DSLElement, v: string array) = x.attr "defaultSelectedKeys" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("draggable")>] member inline _.draggable (x: DSLElement, v: bool) = x.attr "draggable" v
        [<CustomOperation("expandedKeys")>] member inline _.expandedKeys (x: DSLElement, v: string array) = x.attr "expandedKeys" v
        [<CustomOperation("filterTreeNode")>] member inline _.filterTreeNode (x: DSLElement, v: 'TEntity -> bool) = x.attr "filterTreeNode" v
        [<CustomOperation("height")>] member inline _.height (x: DSLElement, v: float) = x.attr "height" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("loadData")>] member inline _.loadData (x: DSLElement, v: 'T -> unit) = x.attr "loadData" v
        [<CustomOperation("loadedKeys")>] member inline _.loadedKeys (x: DSLElement, v: string array) = x.attr "loadedKeys" v
        [<CustomOperation("multiple")>] member inline _.multiple (x: DSLElement, v: bool) = x.attr "multiple" v
        [<CustomOperation("selectable")>] member inline _.selectable (x: DSLElement, v: bool) = x.attr "selectable" v
        [<CustomOperation("selectedKeys")>] member inline _.selectedKeys (x: DSLElement, v: string array) = x.attr "selectedKeys" v
        [<CustomOperation("showIcon")>] member inline _.showIcon (x: DSLElement, v: bool) = x.attr "showIcon" v
        [<CustomOperation("showLine")>] member inline _.showLine (x: DSLElement, v: bool) = x.attr "showLine" v
        [<CustomOperation("switcherIcon")>] member inline _.switcherIcon (x: DSLElement, v: ReactElement) = x.attr "switcherIcon" v
        [<CustomOperation("titleRender")>] member inline _.titleRender (x: DSLElement, v: Func<'TEntity, ReactElement>) = x.attr "titleRender" v
        [<CustomOperation("treeData")>] member inline _.treeData (x: DSLElement, v: 'TEntity array) = x.attr "treeData" v
        [<CustomOperation("virtualize")>] member inline _.virtualize (x: DSLElement, v: bool) = x.attr "virtual" v
        [<CustomOperation("onCheck")>] member inline _.onCheck (x: DSLElement, v: Func<string array, TreeCheckEvent<'T>, unit>) = x.attr "onCheck" v
        [<CustomOperation("onDragEnd")>] member inline _.onDragEnd (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragEnd" v
        [<CustomOperation("onDragEnter")>] member inline _.onDragEnter (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragEnter" v
        [<CustomOperation("onDragLeave")>] member inline _.onDragLeave (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragLeave" v
        [<CustomOperation("onDragOver")>] member inline _.onDragOver (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragOver" v
        [<CustomOperation("onDragStart")>] member inline _.onDragStart (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onDragStart" v
        [<CustomOperation("onDrop")>] member inline _.onDrop (x: DSLElement, v: TreeDropEvent<'TEntity> -> unit) = x.attr "onDrop" v
        [<CustomOperation("onExpand")>] member inline _.onExpand (x: DSLElement, v: Func<string array, TreeExpandEvent<'T>, unit>) = x.attr "onExpand" v
        [<CustomOperation("onLoad")>] member inline _.onLoad (x: DSLElement, v: Func<string array, TreeMouseEvent<'T>, unit>) = x.attr "onLoad" v
        [<CustomOperation("onRightClick")>] member inline _.onRightClick (x: DSLElement, v: TreeMouseEvent<'TEntity> -> unit) = x.attr "onRightClick" v
        [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, v: Func<string array, TreeSelectedEvent<'T>, unit>) = x.attr "onSelect" v
    
    type TreeBuilder<'T>() =
        inherit TreeBase<'T>(import "Tree" "antd")
    
    type DirectoryTreeBuilder<'T>() =
        inherit TreeBase<'T>(import "Tree.DirectoryTree" "antd")
    
        [<CustomOperation("expandAction")>] member inline _.expandAction (x: DSLElement, v: DirectoryTreeExpandAction) = x.attr "expandAction" v
    
    type TreeNodeBuilder() =
        inherit ReactBuilder(import "Tree.TreeNode" "antd")
    
        [<CustomOperation("checkable")>] member inline _.checkable (x: DSLElement, v: bool) = x.attr "checkable" v
        [<CustomOperation("disableCheckbox")>] member inline _.disableCheckbox (x: DSLElement, v: bool) = x.attr "disableCheckbox" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("isLeaf")>] member inline _.isLeaf (x: DSLElement, v: bool) = x.attr "isLeaf" v
        [<CustomOperation("key")>] member inline _.key (x: DSLElement, v: string) = x.attr "key" v
        [<CustomOperation("selectable")>] member inline _.selectable (x: DSLElement, v: bool) = x.attr "selectable" v
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v