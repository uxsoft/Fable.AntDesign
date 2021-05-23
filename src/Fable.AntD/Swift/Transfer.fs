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
    member x.className (v: string) = x.attribute "className" v
    member x.dataSource (v: TransferData array) = x.attribute "dataSource" v
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.filterOption (v: Func<string, obj, bool>) = x.attribute "filterOption" v
    member x.footer (v: obj -> ReactElement) = x.attribute "footer" v
    member x.listStyle (v: obj -> obj) = x.attribute "listStyle" v
    member x.locale (v: TransferLocale) = x.attribute "locale" v
    member x.operations (v: string array) = x.attribute "operations" v
    member x.oneWay (?v: bool) = x.attribute "oneWay" (Option.defaultValue true v)
    member x.operationsStyle (css: Props.CSSProp list) = x.attribute "operationsStyle" (keyValueList CaseRules.LowerFirst css)
    member x.pagination (?v: bool) = x.attribute "pagination" (Option.defaultValue true v)
    member x.render (v: TransferData -> ReactElement) = x.attribute "render" v
    member x.selectedKeys (v: string array) = x.attribute "selectedKeys" v
    member x.showSearch (?v: bool) = x.attribute "showSearch" (Option.defaultValue true v)
    member x.showSelectAll (?v: bool) = x.attribute "showSelectAll" (Option.defaultValue true v)
    member x.targetKeys (v: string array) = x.attribute "targetKeys" v
    member x.titles (v: ReactElement array) = x.attribute "titles" v
    member x.selectAllLabels (v: ReactElement) = x.attribute "selectAllLabels" v
    member x.onChange (v: Func<string array, TransferDirection, string array, unit>) = x.attribute "onChange" v
    member x.onScroll (v: TransferDirection -> Event) = x.attribute "onScroll" v
    member x.onSearch (v: Func<TransferDirection, string, unit>) = x.attribute "onSearch" v
    member x.onSelectChange (v: Func<string array, string array, unit>) = x.attribute "onSelectChange" v
