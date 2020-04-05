namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types
  
[<StringEnum; RequireQualifiedAccess>]
type TransferDirection = Left | Right

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

type Transfer() =
    inherit AntElement(ofImport "Transfer" "antd")
    member x.ClassName with set (v: string) = x.Attribute "ClassName" v
    member x.DataSource with set (v: TransferData array) = x.Attribute "DataSource" v
    member x.Disabled with set (v: bool) = x.Attribute "Disabled" v
    member x.FilterOption with set (v: (string->obj->bool)) = x.Attribute "FilterOption" v
    member x.Footer with set (v: (obj->ReactElement)) = x.Attribute "Footer" v
    member x.ListStyle with set (v: (obj->obj)) = x.Attribute "ListStyle" v
    member x.Locale with set (v: TransferLocale) = x.Attribute "Locale" v
    member x.Operations with set (v: string array) = x.Attribute "Operations" v
    member x.Render with set (v: (TransferData->ReactElement)) = x.Attribute "Render" v
    member x.ShowSearch with set (v: bool) = x.Attribute "ShowSearch" v
    member x.ShowSelectAll with set (v: bool) = x.Attribute "ShowSelectAll" v
    member x.TargetKeys with set (v: string array) = x.Attribute "TargetKeys" v
    member x.Titles with set (v: ReactElement array) = x.Attribute "Titles" v
    member x.OnChange with set (v: (string array->TransferDirection->string array->unit)) = x.Attribute "OnChange" v
    member x.OnScroll with set (v: (TransferDirection->Event)) = x.Attribute "OnScroll" v
    member x.OnSearch with set (v: (TransferDirection->string->unit)) = x.Attribute "OnSearch" v
    member x.OnSelectChange with set (v: (string array->string array->unit)) = x.Attribute "OnSelectChange" v
    member x.OperationsStyle with set (css: Props.CSSProp list) = x.Attribute "operationsStyle" ("operationsStyle", keyValueList CaseRules.LowerFirst css)