module Fable.AntDesign.Examples.Pages.SyntaxPage

open System
open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant
open Fable.Builders.React
open Feliz

let view model =
    div {
        Example {
            name "Variables"
            sourceUrl "Pages/SyntaxPage.fs"
            sourceRange (17, 29)
               
            let var = "variable value"
            div {
                style [
                    style.backgroundColor.red ]
                
                str var
            }
            div {
                str var
                div {
                    str var
                }
            }
        }
        Example {
            name "For"
            sourceUrl "Pages/SyntaxPage.fs"
            sourceRange (36, 37)
            
            for i in 1..5 do
                div { str $"item {i}" }
        }
        Example {
            name "If"
            sourceUrl "Pages/SyntaxPage.fs"
            sourceRange (44, 46)
            
            if Random().NextDouble() > 0.5 then
                div { str "lucky" }
            else div { str "unlucky" }
        }
        Example {
            name "Yield"
            sourceUrl "Pages/SyntaxPage.fs"
            sourceRange (52, 52)
            
            yield! [
                div { str "1" }
                div { str "2" }
            ]
        }
        Example {
            name "Inner HTML"
            sourceUrl "Pages/SyntaxPage.fs"
            sourceRange (62, 65)
            
            div {
                dangerouslySetInnerHTML "<a href=\"#\">dangerous link</a>"
            }
        }
        Example {
            name "Fragment"
            sourceUrl "Pages/SyntaxPage.fs"
            sourceRange (62, 65)
            
            fragment {
                div { str "div 1" }
                div { str "div 2" }
            }
        }
    }