module Fable.AntDesign.Examples.Pages.SyntaxPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant
open Fable.Builders.AntDesign.Button
open Fable.Builders.React.Html
open Feliz

let view model =
    example {
        name "Variables"
        sourceUrl "Pages/SyntaxPage.fs"
        
        let state, setState = React.useState ""
        div {
            style [
                style.backgroundColor.red ]
            
            str state
        }
        div {
            str state
            div {
                str state
            }
        }
    }