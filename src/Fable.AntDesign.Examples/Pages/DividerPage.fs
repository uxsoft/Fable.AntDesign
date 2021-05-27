module Fable.AntD.Examples.Pages.DividerPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/DividerPage.fs"
        str "Before Divider"
        divider { () }
        str "After Divider"
    }