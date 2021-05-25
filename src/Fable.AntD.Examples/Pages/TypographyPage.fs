module Fable.AntD.Examples.Pages.TypographyPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    example {
        title {
            str "Title"
        }
        text {
            str "Text"
        }
        paragraph {
            str "Paragraph"
        }
    }