module Fable.AntDesign.Examples.Pages.ButtonPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant
open Fable.Builders.AntDesign.Button

let view model =
    example {
        sourceUrl "Pages/ButtonPage.fs"
        sourceRange (11, 19)
        space {
            button {
                "Button"
            }
            button {
                buttonType ButtonType.Primary
                "Primary Button"
            }
        }
    }