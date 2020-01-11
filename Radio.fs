namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Radio =
        
    type AntRadioOption = {
        label: string
        value: string
        disabled: bool
    }
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntRadioButtonStyle = Outline | Solid
    
    [<RequireQualifiedAccess>]
    type AntRadio =
        | AutoFocus of bool
        | Checked of bool
        | DefaultChecked of bool
        | Disabled of bool
        | Value of obj
        static member Custom (key: string, value: obj): AntRadio = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntRadio = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntRadioButton =
        | AutoFocus of bool
        | Checked of bool
        | DefaultChecked of bool
        | Disabled of bool
        | Value of obj
        static member Custom (key: string, value: obj): AntRadioButton = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntRadioButton = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntRadioGroup =
        | DefaultValue of obj
        | Disabled of bool
        | Name of string
        | Options of AntRadioOption array
        | Size of Common.Size
        | Value of obj
        | OnChange of (Event -> unit)
        | ButtonStyle of AntRadioButtonStyle
        static member Custom (key: string, value: obj): AntRadioGroup = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntRadioGroup = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antRadio (props: AntRadio list) (children: ReactElement list): ReactElement =
       ofImport "Radio" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antRadioButton (props: AntRadioButton list) (children: ReactElement list): ReactElement =
       ofImport "Radio.Button" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antRadioGroup (props: AntRadioGroup list) (children: ReactElement list): ReactElement =
       ofImport "Radio.Group" "antd" (keyValueList CaseRules.LowerFirst props) children