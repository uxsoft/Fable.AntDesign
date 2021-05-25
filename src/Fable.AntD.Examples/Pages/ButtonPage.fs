module Fable.AntD.Examples.Pages.ButtonPage

open Fable.AntD.Examples.Components.Example
open Fable.AntD.Builders.Ant
open Fable.AntD.Builders.Button

let view model =
    example {
        space {
            button {
                str "Button"
            }
            button {
                buttonType ButtonType.Primary
                str "Primary Button"
            }
        }
    }