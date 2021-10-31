module App

open System
open Fable.AntDesign.Examples.Pages
open Fable.AntDesign.Examples.Model
open Fable.Builders.AntDesign
open Fable.Builders.React
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
    
let PageMenuItem (page: Page) (name: string) =
    MenuItem {
        key (string page)
        str name
    }


let view (model: Model) dispatch =
    Layout {
        Header {
            style [
                style.height 66
                style.backgroundColor color.white
                style.boxShadow(0, 1, 4, "rgba(0, 21, 41, 0.08)") ]
                
            Space {
                img {
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
                        PageMenuItem Page.SyntaxPage "Syntax"
                        PageMenuItem Page.ButtonPage "Button"
                        PageMenuItem Page.IconPage "Icon"
                        PageMenuItem Page.TypographyPage "Typography"
                    }
                    MenuItemGroup {
                        title (str "Layout")
                        PageMenuItem Page.DividerPage "Divider"
                        PageMenuItem Page.GridPage  "Grid"
                        PageMenuItem Page.LayoutPage "Layout"
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
                        MenuItem {
                            key (string Page.ProgressPage)
                            str "Progress"
                        }
                    }
                    
                    MenuItemGroup {
                        title (str "Charts")
                    
                        PageMenuItem Page.ChartsPage "Charts"
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
                | Page.GridPage -> GridPage.view model
                | Page.LayoutPage -> LayoutPage.view model
                | Page.StepsPage -> StepsPage.view model
                | Page.FormPage -> FormPage.view model dispatch
                | Page.ListPage -> ListPage.view model
                | Page.NotificationPage -> NotificationPage.view model
                | Page.ProgressPage -> ProgressPage.view model
                | Page.ChartsPage -> ChartsPage.view model
                | _ -> notFound
            }
        }
    }

// App
Program.mkProgram init update view
|> Program.withReactBatched "elmish-app"
|> Program.withConsoleTrace
|> Program.run
