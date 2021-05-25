module Fable.AntDesign.Transfer

open Fable.AntDesign.Common
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

type TransferBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Transfer" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("dataSource")>] member _.dataSource (x: DSLElement, v: TransferData array) = x.attr "dataSource" v
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("filterOption")>] member _.filterOption (x: DSLElement, v: Func<string, obj, bool>) = x.attr "filterOption" v
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: obj -> ReactElement) = x.attr "footer" v
    [<CustomOperation("listStyle")>] member _.listStyle (x: DSLElement, v: obj -> obj) = x.attr "listStyle" v
    [<CustomOperation("locale")>] member _.locale (x: DSLElement, v: TransferLocale) = x.attr "locale" v
    [<CustomOperation("operations")>] member _.operations (x: DSLElement, v: string array) = x.attr "operations" v
    [<CustomOperation("oneWay")>] member _.oneWay (x: DSLElement) = x.attr "oneWay" true
    [<CustomOperation("operationsStyle")>] member _.operationsStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "operationsStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("pagination")>] member _.pagination (x: DSLElement) = x.attr "pagination" true
    [<CustomOperation("render")>] member _.render (x: DSLElement, v: TransferData -> ReactElement) = x.attr "render" v
    [<CustomOperation("selectedKeys")>] member _.selectedKeys (x: DSLElement, v: string array) = x.attr "selectedKeys" v
    [<CustomOperation("showSearch")>] member _.showSearch (x: DSLElement) = x.attr "showSearch" true
    [<CustomOperation("showSelectAll")>] member _.showSelectAll (x: DSLElement) = x.attr "showSelectAll" true
    [<CustomOperation("targetKeys")>] member _.targetKeys (x: DSLElement, v: string array) = x.attr "targetKeys" v
    [<CustomOperation("titles")>] member _.titles (x: DSLElement, v: ReactElement array) = x.attr "titles" v
    [<CustomOperation("selectAllLabels")>] member _.selectAllLabels (x: DSLElement, v: ReactElement) = x.attr "selectAllLabels" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Func<string array, TransferDirection, string array, unit>) = x.attr "onChange" v
    [<CustomOperation("onScroll")>] member _.onScroll (x: DSLElement, v: TransferDirection -> Event) = x.attr "onScroll" v
    [<CustomOperation("onSearch")>] member _.onSearch (x: DSLElement, v: Func<TransferDirection, string, unit>) = x.attr "onSearch" v
    [<CustomOperation("onSelectChange")>] member _.onSelectChange (x: DSLElement, v: Func<string array, string array, unit>) = x.attr "onSelectChange" v
