module Fable.AntDesign.Html

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

type DomElementBuilder(tag) =
    inherit ReactBuilder()

    member _.Run(s: DSLElement) = 
        ReactBindings.React.createElement(tag, createObj s.Attributes, s.Children)
    
type VoidElementBuilder(tag) =
    inherit ReactBuilder()

    member x.Run(s: DSLElement) = 
        ReactBindings.React.createElement(tag, createObj s.Attributes, [])

type SvgBuilder(tag) =
    inherit ReactBuilder()

    member x.Run(s: DSLElement) = 
            ReactBindings.React.createElement(tag, createObj s.Attributes, s.Children)


type FragmentBuilder() =
    inherit ReactBuilder()

    member x.Run(s: DSLElement) = 
        ReactBindings.React.createElement(ReactBindings.React.Fragment, createObj s.Attributes, s.Children)
