namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Switch =
    
    [<RequireQualifiedAccess>]
    type AntSwitch =
        | AutoFocus of bool
        | Checked of bool
        | CheckedChildren of ReactElement
        | DefaultChecked of bool
        | Disabled of bool
        | Loading of bool
        | Size of Common.Size
        | UnCheckedChildren of ReactElement
        | OnChange of (bool -> Event -> unit)
        | OnClick of (bool -> Event -> unit)
        | ClassName of string
        static member Custom (key: string, value: obj): AntSwitch = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSwitch = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antSwitch (props: AntSwitch list) (children: ReactElement list): ReactElement =
       ofImport "Switch" "antd" (keyValueList CaseRules.LowerFirst props) children