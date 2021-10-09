module Fable.AntDesign.Examples.Pages.TypographyPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant

let view model =
    example {
        sourceUrl "Pages/TypographyPage.fs"
        sourceRange (11, 19)
        
        Title {
            str "Title"
        }
        Text {
            str "Text"
        }
        Paragraph {
            str "Paragraph"
        }
    }