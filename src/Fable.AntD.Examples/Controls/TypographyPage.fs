module Fable.AntD.Examples.Controls.TypographyPage

open Fable.AntD.Builders.Ant

let view model =
    space {
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