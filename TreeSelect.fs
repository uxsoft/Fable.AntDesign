namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module TreeSelect =
        
    type AntTreeData = {
        value: string
        title: string
        children: AntTreeData array
    }
    
    type AntTreeFlatData = {
        id: string
        pId: string
        rootPId: string
    }
    
    [<RequireQualifiedAccess>]
    type AntTreeSelect =
        | AllowClear of bool
        | AutoClearSearchValue of bool
        | DefaultValue of string array
        | Disabled of bool
        | DropdownClassName of string
        | DropdownMatchSelectWidth of bool
        | FilterTreeNode of bool
        | GetPopupContainer of (unit -> ReactElement)
        | LabelInValue of bool
        | LoadData of (obj -> unit)
        | MaxTagCount of int
        | Multiple of bool
        | Placeholder of string
        | SearchPlaceholder of string
        | SearchValue of string
        | TreeIcon of bool
        | ShowCheckedStrategy of obj
        | ShowSearch of bool
        | Size of Size
        | SuffixIcon of ReactElement
        | TreeCheckable of bool
        | TreeCheckStrictly of bool
        | TreeData of AntTreeData array
        | TreeDataSimpleMode of AntTreeFlatData array
        | TreeDefaultExpandAll of bool
        | TreeDefaultExpandedKeys of string array
        | TreeExpandedKeys of string array
        | TreeNodeFilterProp of string
        | TreeNodeLabelProp of string
        | Value of string array
        | OnChange of (string -> string -> obj -> unit)
        | OnSearch of (string -> unit)
        | OnSelect of (string -> AntTreeData -> obj -> unit)
        | OnTreeExpand of (string array -> unit)
        static member Custom (key: string, value: obj): AntTreeSelect = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTreeSelect = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member DropdownStyle (css: Props.CSSProp list): AntTreeSelect = unbox ("dropdownStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntTreeSelectNode =
        | Selectable of bool
        | Checkable of bool
        | DisableCheckbox of bool
        | Disabled of bool
        | IsLeaf of bool
        | Key of string
        | Title of ReactElement
        | Value of string
        static member Custom (key: string, value: obj): AntTreeSelect = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTreeSelect = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antTreeSelect (props: AntTreeSelect list) (children: ReactElement list): ReactElement =
       ofImport "TreeSelect" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antTreeSelectNode (props: AntTreeSelectNode list) (children: ReactElement list): ReactElement =
       ofImport "TreeSelect.TreeNode" "antd" (keyValueList CaseRules.LowerFirst props) children