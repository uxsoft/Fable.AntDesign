module Fable.AntDesign.Examples.Pages.LayoutPage

open Fable.Builders.React
open Fable.Builders.AntDesign
open Fable.AntDesign.Examples.Components.Example
open Feliz

let view model =
    Example {
        name "Basic Layout"
        sourceUrl "Pages/LayoutPage.fs"
        sourceRange (15, 42)
        
        Layout {
            className "layout"
            Header {
                div { className "logo" }
                Menu {
                    theme Theme.Dark
                    mode MenuMode.Horizontal
                    defaultSelectedKeys [| "2" |]
                    
                    for index in 1..15 do
                        MenuItem { key $"{index}"; str $"nav {index}" }
                }
            }
            Content {
                style [ style.padding(0, 50) ]
                Breadcrumb {
                    style [ style.margin(16, 0) ]
                    BreadcrumbItem { str "Home" }
                    BreadcrumbItem { str "List" }
                    BreadcrumbItem { str "App" }
                }
                div { className "site-layout-content"; str "Content" }
            }
            Footer {
                style [ style.textAlign.center ]
                str "Ant Design ©2018 Created by Ant UED"
            }
        }
    }