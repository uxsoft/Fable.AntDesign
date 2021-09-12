module Fable.AntDesign.Examples.Pages.ListPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant
open Fable.Builders.AntDesign.Pagination
open Fable.Builders.React.Html

let view model =
    div {
        example {
            sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ListPage.fs"
            
            list {
                dataSource [| 1..5 |]
                renderItem (fun item -> div {
                    str (string item)
                })
            } 
        }
        example {
            sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ListPage.fs"
            
            list {
                dataSource [| 1..50 |]
                renderItem (fun item ->
                    listItem {
                        str (string item)
                    })
                pagination [
                    PaginationProp.PageSize 5 ]
            }
        }
    }