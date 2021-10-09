module Fable.AntDesign.Examples.Pages.ButtonPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant
open Fable.Builders.AntDesign.Button

let view model =
    example {
        name "Button Types"
        sourceUrl "Pages/ButtonPage.fs"
        sourceRange (13, 21)
        
        Space {
            Button {
                "Button"
            }
            Button {
                buttonType ButtonType.Primary
                "Primary Button"
            }
        }
    }