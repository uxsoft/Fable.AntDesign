module Fable.AntDesign.Examples.Pages.FormPage

open Fable.AntDesign.Examples.Components.Example
open Fable.AntDesign.Examples.Model
open Fable.Builders.AntDesign
open Fable.Core.DynamicExtensions
open Feliz

let view (model: Model) dispatch =
    Example {
        sourceUrl "Pages/FormPage.fs"

        PageHeader {
            title (str "Login")
            subTitle (str "Please log-in to enter.")
        }

        Form {
            style [ style.maxWidth 320
                    style.margin (0, length.auto) ]

            initialValues
                {| email = ""
                   password = "" |}
            
            onFinish (fun values ->
                dispatch (BeginLogin(values.email, values.password)))

            FormItem {
                name "email"
                key "login-email"

                rules [ [ FormRule.RuleType FormRuleType.Email
                          FormRule.Message "This isn't a valid email" ]
                        [ FormRule.Required true
                          FormRule.Message "This field is mandatory" ] ]

                Input {
                    prefix (BasicIcon Icons.MailOutlined { style [ style.color color.lightGray ] })
                    placeholder "Email"
                }
            }

            FormItem {
                name "password"
                key "login-password"

                rules [ [ FormRule.Required true
                          FormRule.Message "This field is mandatory" ] ]

                Password {
                    prefix (BasicIcon Icons.LockOutlined { style [ style.color color.lightGray ] })
                }
            }

            FormItem {
                key "login-submit"

                Button {
                    style [ style.width (length.percent (100)) ]
                    buttonType ButtonType.Primary
                    loading model.IsLoggingIn
                    htmlType ButtonHtmlType.Submit

                    str "Login"
                }
            }

            FormItem {
                key "login-links"

                Button {
                    buttonType ButtonType.Link
                    str "Register"
                }

                Button {
                    style [ style.float'.right ]
                    buttonType ButtonType.Link
                    str "Forgot password?"
                }
            }
        }
    }
