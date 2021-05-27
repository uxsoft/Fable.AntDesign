module App

open System
open Fable.AntDesign.Ant
open Fable.AntDesign.Examples.Pages
open Fable.AntDesign.Examples.Model
open Fable.AntDesign.Menu
open Fable.AntDesign.Result
open Fable.React.Props
open Elmish
open Elmish.React
open Elmish.HMR

let onPageSelected dispatch (e: ClickParam) = 
    let success, page = Enum.TryParse<Page>(e.key)
    if success then dispatch (Navigate page)

let notFound =
    result {
        status ResultStatus.NotFound
        title (str "Page not found")
        subTitle (str "Try a different one!")
    }

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
                        menuItem {
                            key (string Page.FormPage)
                            str "Form"
                        }
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
                | Page.FormPage -> FormPage.view model
                | _ -> notFound
            }
        }
    }

// App
Program.mkProgram init update view
|> Program.withReactBatched "elmish-app"
|> Program.withConsoleTrace
|> Program.run
