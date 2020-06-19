namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>]
type TransferDirection =
    | Left
    | Right

type TransferLocale =
    { itemUnit: string
      itemsUnit: string
      searchPlaceholder: string
      notFoundContent: ReactElement }

type TransferData =
    { key: string
      title: string
      description: string option
      disabled: bool }

type AntTransfer() =
    inherit AntElement(ofImport "Transfer" "antd")
    member x.ClassName
        (v: string) = x.attribute "ClassName" v
    member x.DataSource
        (v: TransferData array) = x.attribute "DataSource" v
    member x.Disabled
        (v: bool) = x.attribute "Disabled" v

    member x.FilterOption
        (v: string -> obj -> bool) =
            let uncurried = System.Func<string, obj, bool> v
            x.attribute "FilterOption" uncurried

    member x.Footer
        (v: obj -> ReactElement) = x.attribute "Footer" v
    member x.ListStyle
        (v: obj -> obj) = x.attribute "ListStyle" v
    member x.Locale
        (v: TransferLocale) = x.attribute "Locale" v
    member x.Operations
        (v: string array) = x.attribute "Operations" v
    member x.Render
        (v: TransferData -> ReactElement) = x.attribute "Render" v
    member x.ShowSearch
        (v: bool) = x.attribute "ShowSearch" v
    member x.ShowSelectAll
        (v: bool) = x.attribute "ShowSelectAll" v
    member x.TargetKeys
        (v: string array) = x.attribute "TargetKeys" v
    member x.Titles
        (v: ReactElement array) = x.attribute "Titles" v

    member x.OnChange
        (v: string array -> TransferDirection -> string array -> unit) =
            let uncurried = System.Func<string array, TransferDirection, string array, unit> v
            x.attribute "OnChange" uncurried

    member x.OnScroll
        (v: TransferDirection -> Event) = x.attribute "OnScroll" v

    member x.OnSearch
        (v: TransferDirection -> string -> unit) =
            let uncurried = System.Func<TransferDirection, string, unit> v
            x.attribute "OnSearch" uncurried

    member x.OnSelectChange
        (v: string array -> string array -> unit) =
            let uncurried = System.Func<string array, string array, unit> v
            x.attribute "OnSelectChange" uncurried

    member x.OperationsStyle
        (css: Props.CSSProp list) =
            x.attribute "operationsStyle" ("operationsStyle", keyValueList CaseRules.LowerFirst css)
