module App

open System
open Fable.AntD.Builders.Ant
open Fable.AntD.Examples.Controls
open Fable.React.Props
open Elmish
open Elmish.React
open Elmish.HMR

type Page =
    | ButtonPage = 0
    | IconPage = 1
    | TypographyPage = 2

type Model = { Page: Page }

type Msg =
    | Navigate of Page

let init () : Model = { Page = Page.ButtonPage }

// UPDATE

let update (msg: Msg) (model: Model) =
    match msg with
    | Navigate page -> { model with Page = page }

let view (model: Model) dispatch =
    layout {
        header {
            style [ BackgroundColor "white" ]
            str "Welcome to Fable.AntD, Ant Design bindings for Fable"
        }

        layout {
            sider {
                menu {
                    selectedKeys [| string model.Page |]
                    onClick (fun e ->
                        let success, page = Enum.TryParse<Page>(e.key)
                        if success then dispatch (Navigate page))
                    menuItemGroup {
                        title (str "General")
                        menuItem {
                            key (string Page.ButtonPage)
                            str "Button"
                        }
                        menuItem {
                            key (string Page.IconPage)
                            str "Icon"
                        }
                        menuItem {
                            key (string Page.TypographyPage)
                            str "Typography"
                        }
                    }
                }
            }

            content {
                match model.Page with
                | Page.ButtonPage -> ButtonPage.view model
                | Page.IconPage -> IconPage.view model
                | Page.TypographyPage -> TypographyPage.view model
            }
        }
    }

// App
Program.mkSimple init update view
|> Program.withReactBatched "elmish-app"
|> Program.withConsoleTrace
|> Program.run
