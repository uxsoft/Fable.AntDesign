namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser.Types
open System

[<AutoOpen>]
module Transfer =

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
        inherit ReactBuilder(import "Transfer" "antd")
    
        [<CustomOperation("dataSource")>] member inline _.dataSource (x: DSLElement, v: TransferData array) = x.attr "dataSource" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("filterOption")>] member inline _.filterOption (x: DSLElement, v: Func<string, obj, bool>) = x.attr "filterOption" v
        [<CustomOperation("footer")>] member inline _.footer (x: DSLElement, v: obj -> ReactElement) = x.attr "footer" v
        [<CustomOperation("listStyle")>] member inline _.listStyle (x: DSLElement, v: obj -> obj) = x.attr "listStyle" v
        [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: TransferLocale) = x.attr "locale" v
        [<CustomOperation("operations")>] member inline _.operations (x: DSLElement, v: string array) = x.attr "operations" v
        [<CustomOperation("oneWay")>] member inline _.oneWay (x: DSLElement, v: bool) = x.attr "oneWay" v
        [<CustomOperation("operationsStyle")>] member inline _.operationsStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "operationsStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("pagination")>] member inline _.pagination (x: DSLElement, v: bool) = x.attr "pagination" v
        [<CustomOperation("render")>] member inline _.render (x: DSLElement, v: TransferData -> ReactElement) = x.attr "render" v
        [<CustomOperation("selectedKeys")>] member inline _.selectedKeys (x: DSLElement, v: string array) = x.attr "selectedKeys" v
        [<CustomOperation("showSearch")>] member inline _.showSearch (x: DSLElement, v: bool) = x.attr "showSearch" v
        [<CustomOperation("showSelectAll")>] member inline _.showSelectAll (x: DSLElement, v: bool) = x.attr "showSelectAll" v
        [<CustomOperation("targetKeys")>] member inline _.targetKeys (x: DSLElement, v: string array) = x.attr "targetKeys" v
        [<CustomOperation("titles")>] member inline _.titles (x: DSLElement, v: ReactElement array) = x.attr "titles" v
        [<CustomOperation("selectAllLabels")>] member inline _.selectAllLabels (x: DSLElement, v: ReactElement) = x.attr "selectAllLabels" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<string array, TransferDirection, string array, unit>) = x.attr "onChange" v
        [<CustomOperation("onScroll")>] member inline _.onScroll (x: DSLElement, v: TransferDirection -> Event) = x.attr "onScroll" v
        [<CustomOperation("onSearch")>] member inline _.onSearch (x: DSLElement, v: Func<TransferDirection, string, unit>) = x.attr "onSearch" v
        [<CustomOperation("onSelectChange")>] member inline _.onSelectChange (x: DSLElement, v: Func<string array, string array, unit>) = x.attr "onSelectChange" v
