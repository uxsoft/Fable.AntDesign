namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React
open System

[<StringEnum; RequireQualifiedAccess>]
type MentionsPlacement =
    | Top
    | Bottom

type AntMentions() =
    inherit AntElement<AntMentions>(ofImport "Mentions" "antd")
    member x.autofocus (?v: bool) = x.attribute "autofocus" (Option.defaultValue true v)
    member x.defaultValue (v: string) = x.attribute "defaultValue" v
    member x.filterOption (v: Func<string, obj, bool>) = x.attribute "filterOption" v
    member x.notFoundContent (v: ReactElement) = x.attribute "notFoundContent" v
    member x.placement (v: MentionsPlacement) = x.attribute "placement" v
    member x.prefix (v: string array) = x.attribute "prefix" v
    member x.split (v: string) = x.attribute "split" v
    member x.validateSearch (v: Func<string, obj, unit>) = x.attribute "validateSearch" v
    member x.value (v: string) = x.attribute "value" v
    member x.onChange (v: string -> unit) = x.attribute "onChange" v
    member x.onSelect (v: Func<obj, string, unit>) = x.attribute "onSelect" v
    member x.onSearch (v: Func<string, string, unit>) = x.attribute "onSearch" v
    member x.onFocus (v: unit -> unit) = x.attribute "onFocus" v
    member x.onBlur (v: unit -> unit) = x.attribute "onBlur" v
    member x.getPopupContainer (v: unit -> HTMLElement) = x.attribute "getPopupContainer" v

type AntMentionsOption() =
    inherit AntElement<AntMentionsOption>(ofImport "Mentions.Option" "antd")
    member x.value (v: string) = x.attribute "value" v
