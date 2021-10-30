module Fable.AntDesign.Examples.Pages.ListPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign
open Fable.Builders.AntDesign.Ant
open Fable.Builders.AntDesign.Pagination
open Fable.Builders.React

let view model =
    div {
        Example {
            sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ListPage.fs"
            
            List {
                dataSource [| 1..5 |]
                renderItem (fun item -> div {
                    str (string item)
                })
            } 
        }
        Example {
            sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/ListPage.fs"
            
            List {
                dataSource [| 1..50 |]
                renderItem (fun item ->
                    ListItem {
                        Ant.str (string item)
                    })
                pagination [
                    PaginationProp.PageSize 5 ]
            }
        }
    }