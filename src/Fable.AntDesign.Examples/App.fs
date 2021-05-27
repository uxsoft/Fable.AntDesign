module App

open System
open Fable.AntDesign.Ant
open Fable.AntD.Examples.Pages
open Fable.AntDesign.Menu
open Fable.React.Props
open Elmish
open Elmish.React
open Elmish.HMR

type Page =
    | ButtonPage = 0
    | IconPage = 1
    | TypographyPage = 2
    | DividerPage = 3
    | StepsPage = 14
    | ListPage = 42
    | NotificationPage = 55

type Model = { Page: Page }

type Msg =
    | Navigate of Page

let init () : Model = { Page = Page.ButtonPage }

// UPDATE

let update (msg: Msg) (model: Model) =
    match msg with
    | Navigate page -> { model with Page = page }

let onPageSelected dispatch (e: ClickParam) = 
    let success, page = Enum.TryParse<Page>(e.key)
    if success then dispatch (Navigate page)

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
                    onClick (onPageSelected dispatch)
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
                    menuItemGroup {
                        title (str "Layout")
                        menuItem {
                            key (string Page.DividerPage)
                            str "Divider"
                        }
                    }
                    menuItemGroup {
                        title (str "Navigation")
                        menuItem {
                            key (string Page.StepsPage)
                            str "Steps"
                        }
                    }
                    menuItemGroup {
                        title (str "Data Entry")
                    }
                    menuItemGroup {
                        title (str "Data Display")
                        menuItem {
                            key (string Page.ListPage)
                            str "List"
                        }
                    }
                    menuItemGroup {
                        title (str "Feedback")
                        menuItem {
                            key (string Page.NotificationPage)
                            str "Notification"
                        }
                    }
                }
            }

            content {
                style [ BackgroundColor "white"
                        Padding "8px" ]
                match model.Page with
                | Page.ButtonPage -> ButtonPage.view model
                | Page.IconPage -> IconPage.view model
                | Page.TypographyPage -> TypographyPage.view model
                | Page.DividerPage -> DividerPage.view model
                | Page.StepsPage -> StepsPage.view model
                | Page.ListPage -> ListPage.view model
                | Page.NotificationPage -> NotificationPage.view model
            }
        }
    }

// App
Program.mkSimple init update view
|> Program.withReactBatched "elmish-app"
|> Program.withConsoleTrace
|> Program.run
