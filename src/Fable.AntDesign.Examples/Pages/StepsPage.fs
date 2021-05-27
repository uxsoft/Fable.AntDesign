module Fable.AntD.Examples.Pages.StepsPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    let items = [| 1..5 |]
    example {
        steps {
            for i in items do
                step {
                    title (str $"Step {i}")
                }
        } 
    }   