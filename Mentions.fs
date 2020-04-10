namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type MentionsPlacement =
    | Top
    | Bottom

type Mentions() =
    inherit AntElement(ofImport "Mentions" "antd")
    member x.Autofocus
        with set (v: bool) = x.Attribute "autofocus" v
    member x.DefaultValue
        with set (v: string) = x.Attribute "defaultValue" v

    member x.FilterOption
        with set (v: string -> obj -> bool) =
            let uncurried = System.Func<string, obj, bool> v
            x.Attribute "filterOption" uncurried

    member x.NotFoundContent
        with set (v: ReactElement) = x.Attribute "notFoundContent" v
    member x.Placement
        with set (v: MentionsPlacement) = x.Attribute "placement" v
    member x.Prefix
        with set (v: string array) = x.Attribute "prefix" v
    member x.Split
        with set (v: string) = x.Attribute "split" v

    member x.ValidateSearch
        with set (v: string -> obj -> unit) =
            let uncurried = System.Func<string, obj, unit> v
            x.Attribute "validateSearch" uncurried

    member x.Value
        with set (v: string) = x.Attribute "value" v
    member x.OnChange
        with set (v: string -> unit) = x.Attribute "onChange" v

    member x.OnSelect
        with set (v: obj -> string -> unit) =
            let uncurried = System.Func<obj, string, unit> v
            x.Attribute "onSelect" uncurried

    member x.OnSearch
        with set (v: string -> string -> unit) =
            let uncurried = System.Func<string, string, unit> v
            x.Attribute "onSearch" uncurried

    member x.OnFocus
        with set (v: unit -> unit) = x.Attribute "onFocus" v
    member x.OnBlur
        with set (v: unit -> unit) = x.Attribute "onBlur" v
    member x.GetPopupContainer
        with set (v: unit -> HTMLElement) = x.Attribute "getPopupContainer" v

type MentionsOption() =
    inherit AntElement(ofImport "Mentions.Option" "antd")
    member x.Value
        with set (v: string) = x.Attribute "value" v
