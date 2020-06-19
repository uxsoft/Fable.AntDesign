namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type DirectoryTreeExpandAction =
    | Click
    | DoubleClick

type TreeData =
    { key: string
      title: string
      children: TreeData array
      disabled: bool
      selectable: bool }

type AntTree(?partialImport) =
    inherit AntElement(defaultArg partialImport (ofImport "Tree" "antd"))
    member x.AutoExpandParent
        (v: bool) = x.attribute "autoExpandParent" v
    member x.BlockNode
        (v: bool) = x.attribute "blockNode" v
    member x.Checkable
        (v: bool) = x.attribute "checkable" v
    member x.CheckedKeys
        (v: string array) = x.attribute "checkedKeys" v
    member x.CheckStrictly
        (v: bool) = x.attribute "checkStrictly" v
    member x.DefaultCheckedKeys
        (v: string array) = x.attribute "defaultCheckedKeys" v
    member x.DefaultExpandAll
        (v: bool) = x.attribute "defaultExpandAll" v
    member x.DefaultExpandedKeys
        (v: string array) = x.attribute "defaultExpandedKeys" v
    member x.DefaultExpandParent
        (v: bool) = x.attribute "defaultExpandParent" v
    member x.DefaultSelectedKeys
        (v: string array) = x.attribute "defaultSelectedKeys" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.Draggable
        (v: bool) = x.attribute "draggable" v
    member x.ExpandedKeys
        (v: string array) = x.attribute "expandedKeys" v
    member x.FilterTreeNode
        (v: obj -> bool) = x.attribute "filterTreeNode" v
    member x.LoadData
        (v: obj -> unit) = x.attribute "loadData" v
    member x.LoadedKeys
        (v: string array) = x.attribute "loadedKeys" v
    member x.Multiple
        (v: bool) = x.attribute "multiple" v
    member x.Selectable
        (v: bool) = x.attribute "selectable" v
    member x.SelectedKeys
        (v: string array) = x.attribute "selectedKeys" v
    member x.ShowIcon
        (v: bool) = x.attribute "showIcon" v
    member x.SwitcherIcon
        (v: ReactElement) = x.attribute "switcherIcon" v
    member x.ShowLIne
        (v: bool) = x.attribute "showLIne" v

    member x.OnCheck
        (v: string array -> obj -> unit) =
            let uncurried = System.Func<string array, obj, unit> v
            x.attribute "onCheck" uncurried

    member x.OnDragEnd
        (v: obj -> unit) = x.attribute "onDragEnd" v
    member x.OnDragEnter
        (v: obj -> unit) = x.attribute "onDragEnter" v
    member x.OnDragLeave
        (v: obj -> unit) = x.attribute "onDragLeave" v
    member x.OnDragOver
        (v: obj -> unit) = x.attribute "onDragOver" v
    member x.OnDragStart
        (v: obj -> unit) = x.attribute "onDragStart" v
    member x.OnDrop
        (v: obj -> unit) = x.attribute "onDrop" v

    member x.OnExpand
        (v: string array -> obj -> unit) =
            let uncurried = System.Func<string array, obj, unit> v
            x.attribute "onExpand" uncurried

    member x.OnLoad
        (v: string array -> obj -> unit) =
            let uncurried = System.Func<string array, obj, unit> v
            x.attribute "onLoad" uncurried

    member x.OnRightClick
        (v: obj -> unit) = x.attribute "onRightClick" v

    member x.OnSelect
        (v: string array -> obj -> unit) =
            let uncurried = System.Func<string array, obj, unit> v
            x.attribute "onSelect" uncurried

    member x.TreeData
        (v: TreeData array) = x.attribute "treeData" v

type AntDirectoryTree() =
    inherit AntTree(ofImport "Tree.DirectoryTree" "antd")
    member x.ExpandAction
        (v: DirectoryTreeExpandAction) = x.attribute "expandAction" v

type AntTreeNode() =
    inherit AntElement(ofImport "Tree.TreeNode" "antd")
    member x.Checkable
        (v: bool) = x.attribute "checkable" v
    member x.DisableCheckbox
        (v: bool) = x.attribute "disableCheckbox" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.Icon
        (v: ReactElement) = x.attribute "icon" v
    member x.IsLeaf
        (v: bool) = x.attribute "isLeaf" v
    member x.Key
        (v: string) = x.attribute "key" v
    member x.Selectable
        (v: bool) = x.attribute "selectable" v
    member x.Title
        (v: ReactElement) = x.attribute "title" v
