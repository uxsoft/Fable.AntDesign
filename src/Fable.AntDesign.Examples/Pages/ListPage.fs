module Fable.AntDesign.Examples.Pages.ListPage

open Fable.AntDesign.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    let items = [| 1..5 |]
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ListPage.fs"
        list {
            dataSource items
            renderItem (fun item -> div {
                str (string item)
            })
        } 
    }