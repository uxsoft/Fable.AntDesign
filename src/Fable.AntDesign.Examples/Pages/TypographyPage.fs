module Fable.AntDesign.Examples.Pages.TypographyPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign

let view model =
    Example {
        sourceUrl "Pages/TypographyPage.fs"
        sourceRange (11, 19)
        
        Title {
            str "Title"
        }
        
        Text {
            str "Text"
        }
        
        Paragraph {
            type' TypographyType.Warning
            str "Paragraph"
        }
        
        Text {
            editable true
            str "edit me"
        }
    }