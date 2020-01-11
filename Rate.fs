namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Rate =
    [<RequireQualifiedAccess>]
    type AntRate =
        | AllowClear of bool
        | AllowHalf of bool
        | AutoFocus of bool
        | Character of ReactElement
        | ClassName of string
        | Count of int
        | DefaultValue of float
        | Disabled of bool
        | Tooltips of string array
        | Value of float
        | OnBlur of (unit -> unit)
        | OnChange of (float -> unit)
        | OnFocus of (unit -> unit)
        | OnHoverChange of (float -> unit)
        | OnKeyDown of (Event -> unit)
        static member Custom (key: string, value: obj): AntRate = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntRate = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antRate (props: AntRate list) (children: ReactElement list): ReactElement =
       ofImport "Rate" "antd" (keyValueList CaseRules.LowerFirst props) children