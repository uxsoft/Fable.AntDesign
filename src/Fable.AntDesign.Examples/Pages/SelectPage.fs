module Fable.AntDesign.Examples.Pages.SelectPage

open Fable.Builders.React
open Fable.Builders.AntDesign
open Fable.AntDesign.Examples.Components.Example
open Fable.Import
open Feliz

type SelectOption =
    { label: string; value: string }

let view model =
    Space {
        Example {
            name "Data"
            sourceUrl "Pages/SelectPage.fs"
            sourceRange (16, 24)
            
            let items =
                [| { label = "Czechia"; value = "CZ" }
                   { label = "Germany"; value = "DE" } |]
            
            Select {
                options items
                defaultValue "CZ"
                onChange (fun item -> Browser.Dom.console.log item)
            }
        }
        Example {
            name "Children"
            sourceUrl "Pages/SelectPage.fs"
            sourceRange (31, 43)
            
            let items =
                [| { label = "Czechia"; value = "CZ" }
                   { label = "Germany"; value = "DE" } |]
            
            Select {
                defaultValue "CZ"
                onChange (fun item -> Browser.Dom.console.log item)
                
                for item in items do
                    SelectOption {
                        title item.label
                        value item.value
                    }
            }
        }    
    }