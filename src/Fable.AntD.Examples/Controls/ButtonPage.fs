module Fable.AntD.Examples.Controls.ButtonPage

open Fable.AntD.Builders.Ant
open Fable.AntD.Builders.Button

let view model =
    space {
        button {
            str "Button"
        }
        button {
            buttonType ButtonType.Primary
            str "Primary Button"
        }
    }