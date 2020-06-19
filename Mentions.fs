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
        (v: bool) = x.attribute "autofocus" v
    member x.DefaultValue
        (v: string) = x.attribute "defaultValue" v

    member x.FilterOption
        (v: string -> obj -> bool) =
            let uncurried = System.Func<string, obj, bool> v
            x.attribute "filterOption" uncurried

    member x.NotFoundContent
        (v: ReactElement) = x.attribute "notFoundContent" v
    member x.Placement
        (v: MentionsPlacement) = x.attribute "placement" v
    member x.Prefix
        (v: string array) = x.attribute "prefix" v
    member x.Split
        (v: string) = x.attribute "split" v

    member x.ValidateSearch
        (v: string -> obj -> unit) =
            let uncurried = System.Func<string, obj, unit> v
            x.attribute "validateSearch" uncurried

    member x.Value
        (v: string) = x.attribute "value" v
    member x.OnChange
        (v: string -> unit) = x.attribute "onChange" v

    member x.OnSelect
        (v: obj -> string -> unit) =
            let uncurried = System.Func<obj, string, unit> v
            x.attribute "onSelect" uncurried

    member x.OnSearch
        (v: string -> string -> unit) =
            let uncurried = System.Func<string, string, unit> v
            x.attribute "onSearch" uncurried

    member x.OnFocus
        (v: unit -> unit) = x.attribute "onFocus" v
    member x.OnBlur
        (v: unit -> unit) = x.attribute "onBlur" v
    member x.GetPopupContainer
        (v: unit -> HTMLElement) = x.attribute "getPopupContainer" v

type MentionsOption() =
    inherit AntElement(ofImport "Mentions.Option" "antd")
    member x.Value
        (v: string) = x.attribute "value" v
