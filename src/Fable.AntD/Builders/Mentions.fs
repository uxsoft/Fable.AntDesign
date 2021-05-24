module Fable.AntD.Builders.Mentions

open Browser.Types
open Fable.AntD.Builders.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type MentionsPlacement =
    | Top
    | Bottom

type MentionsBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Mentions" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autofocus")>] member _.autofocus (x: DSLElement) = x.attr "autofocus" true
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v
    [<CustomOperation("filterOption")>] member _.filterOption (x: DSLElement, v: Func<string, obj, bool>) = x.attr "filterOption" v
    [<CustomOperation("notFoundContent")>] member _.notFoundContent (x: DSLElement, v: ReactElement) = x.attr "notFoundContent" v
    [<CustomOperation("placement")>] member _.placement (x: DSLElement, v: MentionsPlacement) = x.attr "placement" v
    [<CustomOperation("prefix")>] member _.prefix (x: DSLElement, v: string array) = x.attr "prefix" v
    [<CustomOperation("split")>] member _.split (x: DSLElement, v: string) = x.attr "split" v
    [<CustomOperation("validateSearch")>] member _.validateSearch (x: DSLElement, v: Func<string, obj, unit>) = x.attr "validateSearch" v
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
    [<CustomOperation("onSelect")>] member _.onSelect (x: DSLElement, v: Func<obj, string, unit>) = x.attr "onSelect" v
    [<CustomOperation("onSearch")>] member _.onSearch (x: DSLElement, v: Func<string, string, unit>) = x.attr "onSearch" v
    [<CustomOperation("onFocus")>] member _.onFocus (x: DSLElement, v: unit -> unit) = x.attr "onFocus" v
    [<CustomOperation("onBlur")>] member _.onBlur (x: DSLElement, v: unit -> unit) = x.attr "onBlur" v
    [<CustomOperation("getPopupContainer")>] member _.getPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getPopupContainer" v

type MentionBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Mentions.Option" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("value")>] member _.value (x: DSLElement, v: string) = x.attr "value" v
