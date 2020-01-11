namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module AutoComplete =
    
    [<RequireQualifiedAccess>]
    type AntAutoComplete  =
        | AllowClear of bool
        | AutoFocus of bool
        | Backfill of bool
        | DefaultActiveFirstOption of bool
        | DefaultValue of string array
        | Disabled of bool
        | FilterOption of bool
        | OptionLabelProp of string
        | Placeholder of string
        | OnBlur of (unit -> unit)
        | OnChange of (string -> unit)
        | OnFocus of (unit -> unit)
        | OnSearch of (string -> unit)
        | OnSelect of (string -> obj -> unit)
        | DefaultOpen of bool
        | Open of bool
        | OnDropdownVisibleChange of (bool -> unit)
        static member Custom (key: string, value: obj): AntAutoComplete = unbox (key, value)
        static member DropdownMenuStyle (css: Props.CSSProp list): AntAutoComplete = unbox ("dropdownMenuStyle", keyValueList CaseRules.LowerFirst css)
        static member Style (css: Props.CSSProp list): AntAutoComplete = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antAutoComplete (props: AntAutoComplete list) (children: ReactElement list): ReactElement =
       ofImport "AutoComplete" "antd" (keyValueList CaseRules.LowerFirst props) children
