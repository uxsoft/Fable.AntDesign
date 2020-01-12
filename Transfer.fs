namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<AutoOpen>]
module Transfer =
        
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntTransferDirection = Left | Right

    type AntTransferLocale = {
        itemUnit: string
        itemsUnit: string
        searchPlaceholder: string
        notFoundContent: ReactElement
    }
    
    type AntTransferData = {
        key: string
        title: string
        description: string option
        disabled: bool
    }
    
    [<RequireQualifiedAccess>]
    type AntTransfer =
        | ClassName of string
        | DataSource of AntTransferData array
        | Disabled of bool
        | FilterOption of (string -> obj -> bool)
        | Footer of (obj -> ReactElement)
        | ListStyle of (obj -> obj)
        | Locale of AntTransferLocale
        | Operations of string array
        | Render of (AntTransferData -> ReactElement)
        | ShowSearch of bool
        | ShowSelectAll of bool
        | TargetKeys of string array
        | Titles of ReactElement array
        | OnChange of (string array -> AntTransferDirection -> string array -> unit)
        | OnScroll of (AntTransferDirection -> Event)
        | OnSearch of (AntTransferDirection -> string -> unit)
        | OnSelectChange of (string array -> string array -> unit)
        static member Custom (key: string, value: obj): AntTransfer = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTransfer = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member OperationsStyle (css: Props.CSSProp list): AntTransfer = unbox ("operationsStyle", keyValueList CaseRules.LowerFirst css)

    let inline antTransfer (props: AntTransfer list) (children: ReactElement list): ReactElement =
       ofImport "Transfer" "antd" (keyValueList CaseRules.LowerFirst props) children