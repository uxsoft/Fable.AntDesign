namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Input =
    
    [<RequireQualifiedAccess>]
    type AntInput  =
        | AddonAfter of ReactElement
        | AddonBefore of ReactElement
        | DefaultValue of string
        | Disabled of bool
        | Id of string
        | MaxLength of int
        | Prefix of ReactElement
        | Size of Size
        | Suffix of ReactElement
        | Type of string
        | TabIndex of int
        | Value of string
        | OnChange of (Event -> unit)
        | OnPressEnter of (Event -> unit)
        | AllowClear of bool
        | Placeholder of string
        static member Custom (key: string, value: obj): AntInput = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntInput = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antInput (props: AntInput list) (children: ReactElement list): ReactElement =
       ofImport "Input" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    type AutoSizeType = { minRows: int option; maxRows: int option }

    [<RequireQualifiedAccess>]
    type AntTextArea =
        | AutoSize of U2<bool, AutoSizeType>
        | DefaultValue of string
        | Value of string
        | OnPressEnter of (KeyboardEvent -> unit)
        | AllowClear of bool
        static member Custom (key: string, value: obj): AntTextArea = unbox(key, value)
        static member Style (css: Props.CSSProp list) : AntTextArea = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antTextarea (props: AntTextArea list) (children: ReactElement list): ReactElement =
       ofImport "Input.TextArea" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    [<RequireQualifiedAccess>]   
    type AntSearch =
        | AddonAfter of ReactElement
        | AddonBefore of ReactElement
        | DefaultValue of string
        | Disabled of bool
        | Id of string
        | MaxLength of int
        | Prefix of ReactElement
        | Size of Size
        | Suffix of ReactElement
        | Type of string
        | TabIndex of int
        | Value of string
        | OnChange of (Event -> unit)
        | OnPressEnter of (Event -> unit)
        | AllowClear of bool
        | Placeholder of string
        | EnterButton of U2<bool, ReactElement>
        | Loading of bool
        | OnSearch of (string * Event -> unit)
        static member Custom (key: string, value: obj): AntSearch = unbox(key, value)
        static member Style (css: Props.CSSProp list) : AntSearch = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antSearch (props: AntSearch list) (children: ReactElement list): ReactElement =
       ofImport "Input.Search" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    [<RequireQualifiedAccess>]
    type AntInputGroup =
        | Compact of bool
        | Size of Size
        static member Custom (key: string, value: obj): AntInputGroup = unbox(key, value)
        static member Style (css: Props.CSSProp list) : AntInputGroup = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antInputGroup (props: AntInputGroup list) (children: ReactElement list): ReactElement =
       ofImport "Input.Group" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    [<RequireQualifiedAccess>]   
    type AntPassword =
    | AddonAfter of ReactElement
    | AddonBefore of ReactElement
    | DefaultValue of string
    | Disabled of bool
    | Id of string
    | MaxLength of int
    | Prefix of ReactElement
    | Size of Size
    | Suffix of ReactElement
    | Type of string
    | TabIndex of int
    | Value of string
    | OnChange of (Event -> unit)
    | OnPressEnter of (Event -> unit)
    | AllowClear of bool
    | Placeholder of string    
    | VisibilityToggle of bool
        static member Custom (key: string, value: obj): AntPassword = unbox(key, value)
        static member Style (css: Props.CSSProp list) : AntPassword = unbox ("style", keyValueList CaseRules.LowerFirst css)    

    let inline antPassword (props: AntPassword list) (children: ReactElement list): ReactElement =
       ofImport "Input.Password" "antd" (keyValueList CaseRules.LowerFirst props) children