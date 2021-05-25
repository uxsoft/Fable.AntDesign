module Fable.AntD.Examples.Pages.DividerPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    example {
        sourceUrl "TODO Github url"
        str "Before Divider"
        divider { () }
        str "After Divider"
    }