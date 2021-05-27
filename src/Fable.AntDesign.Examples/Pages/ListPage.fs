module Fable.AntD.Examples.Pages.ListPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    let items = [| 1..5 |]
    example {
        list {
            dataSource items
            renderItem (fun item -> div {
                str (string item)
            })
        } 
    }