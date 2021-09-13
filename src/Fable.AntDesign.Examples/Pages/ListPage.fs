module Fable.AntDesign.Examples.Pages.ListPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign
open Fable.Builders.AntDesign.Pagination
open Fable.Builders.React

let view model =
    Html.div {
        example {
            sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ListPage.fs"
            
            Ant.list {
                dataSource [| 1..5 |]
                renderItem (fun item -> Html.div {
                    Ant.str (string item)
                })
            } 
        }
        example {
            sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ListPage.fs"
            
            Ant.list {
                dataSource [| 1..50 |]
                renderItem (fun item ->
                    Ant.listItem {
                        Ant.str (string item)
                    })
                pagination [
                    PaginationProp.PageSize 5 ]
            }
        }
    }