namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<AutoOpen>]
module Checkbox =
    
    [<RequireQualifiedAccess>]
    type AntCheckbox =
        | Autofocus of bool
        | Checked of bool
        | DefaultChecked of bool
        | Disabled of bool
        | Indeterminate of bool
        | OnChange of (Event -> unit)
        static member Custom (key: string, value: obj): AntCheckbox = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCheckbox = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntCheckboxGroup =
        | DefaultValue of string array
        | Disabled of bool 
        | Name of string
        | Options of string array
        | Value of string array
        | OnChange of (bool -> unit)
        static member Custom (key: string, value: obj): AntCheckboxGroup = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCheckboxGroup = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antCheckBox (props: AntCheckbox list) (children: ReactElement list): ReactElement =
       ofImport "Checkbox" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antCheckBoxGroup (props: AntCheckboxGroup list) (children: ReactElement list): ReactElement =
       ofImport "Checkbox.Group" "antd" (keyValueList CaseRules.LowerFirst props) children