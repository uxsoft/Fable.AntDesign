namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<AutoOpen>]
module Mentions =

    [<StringEnum; RequireQualifiedAccess>]
    type MentionsPlacement =
        | Top
        | Bottom
    
    type MentionsBuilder() =
        inherit ReactBuilder(import "Mentions" "antd")
        
        [<CustomOperation("autofocus")>] member inline _.autofocus (x: DSLElement, v: bool) = x.attr "autofocus" v
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string) = x.attr "defaultValue" v
        [<CustomOperation("filterOption")>] member inline _.filterOption (x: DSLElement, v: Func<string, obj, bool>) = x.attr "filterOption" v
        [<CustomOperation("notFoundContent")>] member inline _.notFoundContent (x: DSLElement, v: ReactElement) = x.attr "notFoundContent" v
        [<CustomOperation("placement")>] member inline _.placement (x: DSLElement, v: MentionsPlacement) = x.attr "placement" v
        [<CustomOperation("prefix")>] member inline _.prefix (x: DSLElement, v: string array) = x.attr "prefix" v
        [<CustomOperation("split")>] member inline _.split (x: DSLElement, v: string) = x.attr "split" v
        [<CustomOperation("validateSearch")>] member inline _.validateSearch (x: DSLElement, v: Func<string, obj, unit>) = x.attr "validateSearch" v
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
        [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, v: Func<obj, string, unit>) = x.attr "onSelect" v
        [<CustomOperation("onSearch")>] member inline _.onSearch (x: DSLElement, v: Func<string, string, unit>) = x.attr "onSearch" v
        [<CustomOperation("onFocus")>] member inline _.onFocus (x: DSLElement, v: unit -> unit) = x.attr "onFocus" v
        [<CustomOperation("onBlur")>] member inline _.onBlur (x: DSLElement, v: unit -> unit) = x.attr "onBlur" v
        [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getPopupContainer" v
    
    type MentionBuilder() =
        inherit ReactBuilder(import "Mentions.Option" "antd")
    
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string) = x.attr "value" v
    