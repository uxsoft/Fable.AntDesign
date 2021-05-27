module Fable.AntDesign.Examples.Pages.TypographyPage

open Fable.AntDesign.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/TypographyPage.fs"
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