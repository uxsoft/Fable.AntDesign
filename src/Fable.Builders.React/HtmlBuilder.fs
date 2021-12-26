module Fable.Builders.React.HtmlBuilder

open Browser.Types
open Fable.Builders.Common
open Feliz
open Fable.Core.JsInterop

type HtmlBuilder(tag: string) =
    inherit ReactBuilder()

    [<CustomOperation("dangerouslySetInnerHTML")>]
    member inline _.dangerouslySetInnerHTML (x: DSLElement, value: string) = x.attr "dangerouslySetInnerHTML" {| __html = value |}

    [<CustomOperation("accesskey")>]
    member inline _.accesskey (x: DSLElement, v: 'v) = x.attr "accesskey" v

    [<CustomOperation("autocapitalize")>]
    member inline _.autocapitalize (x: DSLElement, v: 'v) = x.attr "autocapitalize" v

    [<CustomOperation("className")>]
    member inline _.className (x: DSLElement, v: 'v) = x.attr "className" v

    [<CustomOperation("contenteditable")>]
    member inline _.contenteditable (x: DSLElement, v: 'v) = x.attr "contenteditable" v

    [<CustomOperation("contextmenu")>]
    member inline _.contextmenu (x: DSLElement, v: 'v) = x.attr "contextmenu" v

    [<CustomOperation("data")>]
    member inline _.data (x: DSLElement, v: 'v) = x.attr "data" v

    [<CustomOperation("dir")>]
    member inline _.dir (x: DSLElement, v: 'v) = x.attr "dir" v

    [<CustomOperation("draggable")>]
    member inline _.draggable (x: DSLElement, v: 'v) = x.attr "draggable" v

    [<CustomOperation("hidden")>]
    member inline _.hidden (x: DSLElement, v: 'v) = x.attr "hidden" v

    [<CustomOperation("id")>]
    member inline _.id (x: DSLElement, v: 'v) = x.attr "id" v

    [<CustomOperation("itemprop")>]
    member inline _.itemprop (x: DSLElement, v: 'v) = x.attr "itemprop" v

    [<CustomOperation("lang")>]
    member inline _.lang (x: DSLElement, v: 'v) = x.attr "lang" v

    [<CustomOperation("slot")>]
    member inline _.slot (x: DSLElement, v: 'v) = x.attr "slot" v

    [<CustomOperation("spellcheck")>]
    member inline _.spellcheck (x: DSLElement, v: 'v) = x.attr "spellcheck" v

    [<CustomOperation("style")>]
    member inline _.style (x: DSLElement, v: 'v) = x.attr "style" v

    [<CustomOperation("tabindex")>]
    member inline _.tabindex (x: DSLElement, v: 'v) = x.attr "tabindex" v

    [<CustomOperation("title")>]
    member inline _.title (x: DSLElement, v: 'v) = x.attr "title" v

    [<CustomOperation("translate")>]
    member inline _.translate (x: DSLElement, v: 'v) = x.attr "translate" v

    member _.Run(s: DSLElement) =
        Interop.reactApi.createElement(tag, (createObj s.Attributes), s.Children)
