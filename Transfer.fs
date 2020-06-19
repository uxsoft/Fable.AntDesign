namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types
open System

[<StringEnum; RequireQualifiedAccess>]
type TransferDirection =
    | Left
    | Right

type TransferLocale = {
    itemUnit: string
    itemsUnit: string
    searchPlaceholder: string
    notFoundContent: ReactElement
}

type TransferData = {
    key: string
    title: string
    description: string option
    disabled: bool
}

type AntTransfer() =
    inherit AntElement<AntTransfer>(ofImport "Transfer" "antd")
    member x.className (v: string) = x.attribute "ClassName" v
    member x.dataSource (v: TransferData array) = x.attribute "DataSource" v
    member x.disabled (v: bool) = x.attribute "Disabled" v
    member x.filterOption (v: Func<string, obj, bool>) = x.attribute "FilterOption" v
    member x.footer (v: obj -> ReactElement) = x.attribute "Footer" v
    member x.listStyle (v: obj -> obj) = x.attribute "ListStyle" v
    member x.locale (v: TransferLocale) = x.attribute "Locale" v
    member x.operations (v: string array) = x.attribute "Operations" v
    member x.render (v: TransferData -> ReactElement) = x.attribute "Render" v
    member x.showSearch (v: bool) = x.attribute "ShowSearch" v
    member x.showSelectAll (v: bool) = x.attribute "ShowSelectAll" v
    member x.targetKeys (v: string array) = x.attribute "TargetKeys" v
    member x.titles (v: ReactElement array) = x.attribute "Titles" v
    member x.onChange (v: Func<string array, TransferDirection, string array, unit>) = x.attribute "OnChange" v
    member x.onScroll (v: TransferDirection -> Event) = x.attribute "OnScroll" v
    member x.onSearch (v: Func<TransferDirection, string, unit>) = x.attribute "OnSearch" v
    member x.onSelectChange (v: Func<string array, string array, unit>) = x.attribute "OnSelectChange" v
    member x.operationsStyle (css: Props.CSSProp list) = x.attribute "operationsStyle" (keyValueList CaseRules.LowerFirst css)