module Fable.AntDesign.Examples.Pages.StepsPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant

let view model =
    let items = [| 1..5 |]
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/StepsPage.fs"
        steps {
            for i in items do
                step {
                    title (str $"Step {i}")
                }
        } 
    }   