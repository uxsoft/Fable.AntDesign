module Fable.AntD.Examples.Pages.IconPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/IconPage.fs"
        basicIcon icons.AimOutlined { () }
    }