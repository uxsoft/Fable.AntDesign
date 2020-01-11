namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Cascader =
        
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ExpandTriggerOptions = Click | Hover
         
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type PopupPlacementOptions = BottomLeft | BottomRight | TopLeft | TopRight
                
    type FieldNames = {
        label: string
        value: string
        children: string
    }
    
    type ShowSearchSettings = {
        filter: (string -> string -> bool)
        limit: int
        matchInputWidth: bool
        render: (string -> string -> ReactElement)
        sort: (string -> string -> string -> int)
    }
    
    type AntCascaderOption = {
        value: string
        label: ReactElement option
        disabled: bool option
        children: AntCascaderOption array option
    }
    
    [<RequireQualifiedAccess>]
    type AntCascader =
        | AllowClear of bool
        | AutoFocus of bool
        | ChangeOnSelect of bool
        | ClassName of string
        | DefaultValue of string array
        | Disabled of bool
        | DisplayRender of (string -> AntCascaderOption array -> ReactElement)
        | ExpandTrigger of ExpandTriggerOptions
        | FieldNames of FieldNames
        | GetPopupContainer of (unit -> ReactElement)
        | LoadData of (AntCascaderOption array -> unit)
        | NotFoundContent of string
        | Options of AntCascaderOption array
        | Placeholder of string
        | PopupClassName of string
        | PopupPlacement of PopupPlacementOptions
        | PopupVisible of bool
        | ShowSearch of bool
        | [<CompiledName("showSearch")>] ShowSearchSettings of ShowSearchSettings
        | Size of Common.Size
        | SuffixIcon of ReactElement
        | Value of string array
        | OnChange of (string -> AntCascaderOption array -> unit)
        | OnPopupVisibleChange of (bool -> unit)
        static member Custom (key: string, value: obj): AntCascader = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCascader = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antCascader (props: AntCascader list) (children: ReactElement list): ReactElement =
       ofImport "Cascader" "antd" (keyValueList CaseRules.LowerFirst props) children