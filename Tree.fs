namespace Fable.AntD

open Fable.Core
open Fable.React
      
[<StringEnum; RequireQualifiedAccess>] type DirectoryTreeExpandAction = Click | DoubleClick

type TreeData = {
    key: string
    title: string
    children: TreeData array
    disabled: bool
    selectable: bool
}

type AntTree(?partialImport) =
    inherit AntElement(defaultArg partialImport (ofImport "Tree" "antd"))
    member x.AutoExpandParent with set (v: bool) = x.Attribute "autoExpandParent" v
    member x.BlockNode with set (v: bool) = x.Attribute "blockNode" v
    member x.Checkable with set (v: bool) = x.Attribute "checkable" v
    member x.CheckedKeys with set (v: string array) = x.Attribute "checkedKeys" v 
    member x.CheckStrictly with set (v: bool) = x.Attribute "checkStrictly" v
    member x.DefaultCheckedKeys with set (v: string array) = x.Attribute "defaultCheckedKeys" v 
    member x.DefaultExpandAll with set (v: bool) = x.Attribute "defaultExpandAll" v
    member x.DefaultExpandedKeys with set (v: string array) = x.Attribute "defaultExpandedKeys" v
    member x.DefaultExpandParent with set (v: bool) = x.Attribute "defaultExpandParent" v
    member x.DefaultSelectedKeys with set (v: string array) = x.Attribute "defaultSelectedKeys" v
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v
    member x.Draggable with set (v: bool) = x.Attribute "draggable" v
    member x.ExpandedKeys with set (v: string array) = x.Attribute "expandedKeys" v
    member x.FilterTreeNode with set (v: (obj -> bool)) = x.Attribute "filterTreeNode" v 
    member x.LoadData with set (v: (obj -> unit)) = x.Attribute "loadData" v 
    member x.LoadedKeys with set (v: string array) = x.Attribute "loadedKeys" v 
    member x.Multiple with set (v: bool) = x.Attribute "multiple" v
    member x.Selectable with set (v: bool) = x.Attribute "selectable" v
    member x.SelectedKeys with set (v: string array) = x.Attribute "selectedKeys" v
    member x.ShowIcon with set (v: bool) = x.Attribute "showIcon" v
    member x.SwitcherIcon with set (v: ReactElement) = x.Attribute "switcherIcon" v 
    member x.ShowLIne with set (v: bool) = x.Attribute "showLIne" v
    member x.OnCheck with set (v: (string array -> obj -> unit)) = x.Attribute "onCheck" v 
    member x.OnDragEnd with set (v: (obj -> unit)) = x.Attribute "onDragEnd" v 
    member x.OnDragEnter with set (v: (obj -> unit)) = x.Attribute "onDragEnter" v
    member x.OnDragLeave with set (v: (obj -> unit)) = x.Attribute "onDragLeave" v
    member x.OnDragOver with set (v: (obj -> unit)) = x.Attribute "onDragOver" v
    member x.OnDragStart with set (v: (obj -> unit)) = x.Attribute "onDragStart" v
    member x.OnDrop with set (v: (obj -> unit)) = x.Attribute "onDrop" v
    member x.OnExpand with set (v:  (string array -> obj -> unit)) = x.Attribute "onExpand" v
    member x.OnLoad with set (v: (string array -> obj -> unit)) = x.Attribute "onLoad" v
    member x.OnRightClick with set (v: (obj -> unit)) = x.Attribute "onRightClick" v
    member x.OnSelect with set (v: (string array -> obj -> unit)) = x.Attribute "onSelect" v 
    member x.TreeData with set (v: TreeData array) = x.Attribute "treeData" v 

type AntDirectoryTree() =
    inherit AntTree(ofImport "Tree.DirectoryTree" "antd") 
    member x.ExpandAction with set (v: DirectoryTreeExpandAction) = x.Attribute "expandAction" v 

type AntTreeNode() =
    inherit AntElement(ofImport "Tree.TreeNode" "antd")
    member x.Checkable with set (v: bool) = x.Attribute "checkable" v
    member x.DisableCheckbox with set (v: bool) = x.Attribute "disableCheckbox" v
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v
    member x.Icon with set (v: ReactElement) = x.Attribute "icon" v 
    member x.IsLeaf with set (v: bool) = x.Attribute "isLeaf" v
    member x.Key with set (v: string) = x.Attribute "key" v 
    member x.Selectable with set (v: bool) = x.Attribute "selectable" v
    member x.Title with set (v: ReactElement) = x.Attribute "title" v