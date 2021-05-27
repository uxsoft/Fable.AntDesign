module Fable.AntDesign.Examples.Pages.FormPage

open Fable.AntDesign.Examples.Components.Example
open Fable.AntDesign.Examples.Model
open Fable.AntDesign.Button
open Fable.AntDesign.Form
open Fable.AntDesign.Ant
open Fable.React.Props
open Fable.Core.DynamicExtensions


let view (model: Model) dispatch =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/FormPage.fs"

        pageHeader {
            title (str "Login")
            subTitle (str "Please log-in to enter.")
        }
        
        form {
            style [ MaxWidth "320px"; Margin "0 auto" ]
            onFinish (fun values -> dispatch (BeginLogin(string values.["username"], string values.["password"])))

            formItem {
                name "email"
                key "login-email"
                rules [
                    [ FormRule.RuleType FormRuleType.Email 
                      FormRule.Message "This isn't a valid email" ]
                    [ FormRule.Required true
                      FormRule.Message "This field is mandatory" ] ]
                input {
                    prefix (basicIcon icons.MailOutlined { style [ Color "lightgray" ] })
                    placeholder "Email"
                }
            }
            
            formItem {
                name "password"
                key "login-password"
                rules [
                    [ FormRule.Required true
                      FormRule.Message "This field is mandatory" ] ]
                password {
                    prefix (basicIcon icons.LockOutlined { style [ Color "lightgray" ] })
                }
            }
            
            formItem {
                key "login-submit"
                button {
                    style [ Width "100%" ]
                    buttonType ButtonType.Primary
                    loading model.IsLoggingIn
                    htmlType ButtonHtmlType.Submit 
                    
                    str "Login"
                }
            }
            
            formItem {
                key "login-links"
                button {
                    buttonType ButtonType.Link
                    str "Register"
                }
                button {
                    style [ Float FloatOptions.Right ]
                    buttonType ButtonType.Link
                    str "Forgot password?"
                }
            }
        }
    }