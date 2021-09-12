module Fable.AntDesign.Examples.Pages.IconPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant

let view model =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/IconPage.fs"
        basicIcon icons.AimOutlined { () }
    }