module Fable.AntDesign.Examples.Pages.GridPage

open Fable.Builders.AntDesign
open Fable.Builders.React.Html
open Fable.AntDesign.Examples.Components.Example
open Feliz

let lightCol =
    [ style.backgroundColor "rgba(0,146,255,.75)"
      style.padding(16, 0)
      style.textAlign.center ]
    
let darkCol =
    [ style.backgroundColor "rgb(0, 146, 255)"
      style.padding(16, 0)
      style.textAlign.center ]

let view model =
    Example {
        name "Basic Usage"
        sourceUrl "Pages/ProgressPage.fs"
        sourceRange (6, 16)
        
        Divider { orientation DividerOrientation.Left; str "Percentage columns" }
        Row {
            Col { style lightCol; flex "2"; str "2 / 5" }
            Col { style darkCol; flex "3"; str "3 / 5" }
        }
        Divider { orientation DividerOrientation.Left; str "Fill rest" }
        Row {
            Col { style lightCol; flex "100px"; str "100px" }
            Col { style darkCol; flex "auto"; str "Fill Rest" }
        }
        Divider { orientation DividerOrientation.Left; str "Raw flex style" }
        Row {
            Col { style lightCol; flex "1 1 200px"; str "1 1 200px" }
            Col { style darkCol; flex "0 1 300px"; str "0 1 300px" }
        }
    
        Row {
            wrap false
            Col {
                style lightCol;
                flex "none"
                div { style [ style.padding(0, length.px 16) ]; str "none" }
            }
            Col { style darkCol; flex "auto"; str "auto with no-wrap" }
        }
    }