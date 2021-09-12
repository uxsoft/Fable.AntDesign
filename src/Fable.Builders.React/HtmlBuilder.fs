module Fable.Builders.React.HtmlBuilder

open Fable.Builders.Common
open Feliz
open Fable.Core.JsInterop

type HtmlBuilder(tag: string) =
    inherit ReactBuilder()
    
    [<CustomOperation("src")>]
    member _.Src(s: DSLElement, v: string) = s.attr "src" v
    
    member _.Run(s: DSLElement) =
        Interop.reactApi.createElement(tag, (createObj s.Attributes), s.Children)