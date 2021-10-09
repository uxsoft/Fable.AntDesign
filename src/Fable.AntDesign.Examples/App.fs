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
    Result {
        status ResultStatus.NotFound
        title (str "Page not found")
        subTitle (str "Try a different one!")
    }

let view (model: Model) dispatch =
    Layout {
        Header {
            style [
                style.height 66
                style.backgroundColor color.white
                style.boxShadow(0, 1, 4, "rgba(0, 21, 41, 0.08)") ]
                
            Space {
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
        Layout {
            Sider {
                style [
                    style.backgroundColor.white ]
                
                Menu {
                    selectedKeys [| string model.Page |]
                    onClick (onPageSelected dispatch)
                    MenuItemGroup {
                        title (Html.text "General")
                        MenuItem {
                            key (string Page.SyntaxPage)
                            str "Syntax"
                        }
                        MenuItem {
                            key (string Page.ButtonPage)
                            str "Button"
                        }
                        MenuItem {
                            key (string Page.IconPage)
                            str "Icon"
                        }
                        MenuItem {
                            key (string Page.TypographyPage)
                            str "Typography"
                        }
                    }
                    MenuItemGroup {
                        title (str "Layout")
                        MenuItem {
                            key (string Page.DividerPage)
                            str "Divider"
                        }
                    }
                    MenuItemGroup {
                        title (str "Navigation")
                        MenuItem {
                            key (string Page.StepsPage)
                            str "Steps"
                        }
                    }
                    MenuItemGroup {
                        title (str "Data Entry")
                        MenuItem {
                            key (string Page.FormPage)
                            str "Form"
                        }
                    }
                    MenuItemGroup {
                        title (str "Data Display")
                        MenuItem {
                            key (string Page.ListPage)
                            str "List"
                        }
                    }

                    
                    MenuItemGroup {
                        title (str "Feedback")
                        MenuItem {
                            key (string Page.NotificationPage)
                            str "Notification"
                        }
                    }
                } 
            }
            Content {
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
