module Fable.Builders.React.FragmentBuilder

open Fable.Builders.Common

type FragmentBuilder() =
    inherit ReactBuilder()

    member _.Run(s: DSLElement) =
        Fable.React.Helpers.fragment [] s.Children