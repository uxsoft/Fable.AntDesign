module Fable.AntDesign.Examples.Pages.DividerPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant

let view model =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/DividerPage.fs"
        str "Before Divider"
        divider { () }
        str "After Divider"
    }