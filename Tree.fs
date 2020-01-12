namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Tree =
        
    [<StringEnum; RequireQualifiedAccess>] type AntDirectoryTreeExpandAction = Click | DoubleClick

    type AntTreeData = {
        key: string
        title: string
        children: AntTreeData array
        disabled: bool
        selectable: bool
    }
    
    [<RequireQualifiedAccess>]
    type AntTree =
        | AutoExpandParent of bool
        | BlockNode of bool
        | Checkable of bool
        | CheckedKeys of string array
        | CheckStrictly of bool
        | DefaultCheckedKeys of string array
        | DefaultExpandAll of bool
        | DefaultExpandedKeys of string array
        | DefaultExpandParent of bool
        | DefaultSelectedKeys of string array
        | Disabled of bool
        | Draggable of bool
        | ExpandedKeys of string array
        | FilterTreeNode of (obj -> bool)
        | LoadData of (obj -> unit)
        | LoadedKeys of string array
        | Multiple of bool
        | Selectable of bool
        | SelectedKeys of string array
        | ShowIcon of bool
        | SwitcherIcon of ReactElement
        | ShowLIne of bool
        | OnCheck of (string array -> obj -> unit)
        | OnDragEnd of (obj -> unit)
        | OnDragEnter of (obj -> unit)
        | OnDragLeave of (obj -> unit)
        | OnDragOver of (obj -> unit)
        | OnDragStart of (obj -> unit)
        | OnDrop of (obj -> unit)
        | OnExpand of (string array -> obj -> unit)
        | OnLoad of (string array -> obj -> unit)
        | OnRightClick of (obj -> unit)
        | OnSelect of (string array -> obj -> unit)
        | TreeData of AntTreeData array
        static member Custom (key: string, value: obj): AntTree = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTree = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntDirectoryTree =
        | AutoExpandParent of bool
        | BlockNode of bool
        | Checkable of bool
        | CheckedKeys of string array
        | CheckStrictly of bool
        | DefaultCheckedKeys of string array
        | DefaultExpandAll of bool
        | DefaultExpandedKeys of string array
        | DefaultExpandParent of bool
        | DefaultSelectedKeys of string array
        | Disabled of bool
        | Draggable of bool
        | ExpandedKeys of string array
        | FilterTreeNode of (obj -> bool)
        | LoadData of (obj -> unit)
        | LoadedKeys of string array
        | Multiple of bool
        | Selectable of bool
        | SelectedKeys of string array
        | ShowIcon of bool
        | SwitcherIcon of ReactElement
        | ShowLIne of bool
        | OnCheck of (string array -> obj -> unit)
        | OnDragEnd of (obj -> unit)
        | OnDragEnter of (obj -> unit)
        | OnDragLeave of (obj -> unit)
        | OnDragOver of (obj -> unit)
        | OnDragStart of (obj -> unit)
        | OnDrop of (obj -> unit)
        | OnExpand of (string array -> obj -> unit)
        | OnLoad of (string array -> obj -> unit)
        | OnRightClick of (obj -> unit)
        | OnSelect of (string array -> obj -> unit)
        | TreeData of AntTreeData array

        | ExpandAction of AntDirectoryTreeExpandAction
        static member Custom (key: string, value: obj): AntDirectoryTree = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntDirectoryTree = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntTreeNode =
        | Checkable of bool
        | DisableCheckbox of bool
        | Disabled of bool
        | Icon of ReactElement
        | IsLeaf of bool
        | Key of string
        | Selectable of bool
        | Title of ReactElement
        static member Custom (key: string, value: obj): AntTreeNode = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTreeNode = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antTree (props: AntTree list) (children: ReactElement list): ReactElement =
       ofImport "Tree" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antDirectoryTree (props: AntDirectoryTree list) (children: ReactElement list): ReactElement =
       ofImport "Tree.DirectoryTree" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antTreeNode (props: AntTreeNode list) (children: ReactElement list): ReactElement =
       ofImport "Tree.TreeNode" "antd" (keyValueList CaseRules.LowerFirst props) children
