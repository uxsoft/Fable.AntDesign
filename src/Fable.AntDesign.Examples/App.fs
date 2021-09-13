module App

open System
open Fable.AntDesign.Examples.Pages
open Fable.AntDesign.Examples.Model
open Fable.Builders.AntDesign.Ant
open Fable.Builders.React
open Fable.Builders.AntDesign.Menu
open Fable.Builders.AntDesign.Result
open Feliz
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
            style [
                style.height 66
                style.backgroundColor color.white
                style.boxShadow(0, 1, 4, "rgba(0, 21, 41, 0.08)") ]
                
            space {
                Html.img {
                    style [
                        style.float'.left
                        style.margin(12, 0, 0, -32)
                        style.height 40 ]
                    src "https://gw.alipayobjects.com/zos/rmsportal/KDpgvguMpGfqaHPjicRK.svg"
                }
                    
                str "Welcome to Fable.AntDesign, Ant Design bindings for Fable"
            } 
        }
        layout {
            sider {
                style [
                    style.backgroundColor.white ]
                
                menu {
                    selectedKeys [| string model.Page |]
                    onClick (onPageSelected dispatch)
                    menuItemGroup {
                        title (Html.text "General")
                        menuItem {
                            key (string Page.SyntaxPage)
                            str "Syntax"
                        }
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
                style [
                    style.backgroundColor color.white
                    style.padding(8) ]
                match model.Page with
                | Page.SyntaxPage -> SyntaxPage.view model
                | Page.ButtonPage -> ButtonPage.view model
                | Page.IconPage -> IconPage.view model
                | Page.TypographyPage -> TypographyPage.view model
                | Page.DividerPage -> DividerPage.view model
                | Page.StepsPage -> StepsPage.view model
                | Page.ListPage -> ListPage.view model
                | Page.NotificationPage -> NotificationPage.view model
                | Page.FormPage -> FormPage.view model dispatch
                | _ -> notFound
            }
        }
    }

// App
Program.mkProgram init update view
|> Program.withReactBatched "elmish-app"
|> Program.withConsoleTrace
|> Program.run
