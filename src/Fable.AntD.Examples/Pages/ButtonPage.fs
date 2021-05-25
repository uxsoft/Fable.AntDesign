module Fable.AntD.Examples.Pages.ButtonPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant
open Fable.AntDesign.Button

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