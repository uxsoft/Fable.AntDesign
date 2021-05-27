module Fable.AntD.Examples.Pages.ButtonPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant
open Fable.AntDesign.Button

let view model =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ButtonPage.fs"
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