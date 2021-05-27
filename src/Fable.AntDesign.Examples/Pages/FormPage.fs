module Fable.AntD.Examples.Pages.FormPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant
open Fable.React.Props

let view model =
    example {
        sourceUrl "https://github.com/uxsoft/Fable.AntDesign/blob/master/src/Fable.AntDesign.Examples/Pages/FormPage.fs"

        pageHeader {
            title (str "Login")
            subTitle (str "Please log-in to enter.")
        }
        
        form {
            style [ MaxWidth "320px"; Margin "0 auto" ]
            onFinish (fun values -> ())

            formItem {
                name "login-email"
                key "login-email"
                // TODO rules
                //                .rules([|
//                    AntFormRule("This isn't a valid email").ruleType(FormRuleType.Email)
//                    AntFormRule("This field is mandatory").required() |])
//                .[[
                
                input {
                    prefix (basicIcon icons.MailOutlined { style [ Color "lightgray" ] })
                    placeholder "Email"
                }
            }
            
            formItem {
                name "login-password"
                key "login-password"
                //                .rules([| AntFormRule("This field is mandatory").required() |])
                password {
                    prefix (basicIcon icons.LockOutlined { style [ Color "lightgray" ] })
                }
            }
        }


//            AntFormItem()
//                .name("login-password")
//                .key("login-password")
//                .rules([| AntFormRule("This field is mandatory").required() |])
//                .[[
//                AntPassword()
//                    .prefix(AntIcons.LockOutlined.style(grayedOut).[[]])
//                    .onChange(fun e -> setModel (fun s -> { s with Password = base64 e.Value }))
//                    .placeholder("Password")
//                    .[[]]
//            ]]
//            AntFormItem()
//                .key("login-submit")
//                .[[
//                match model.Error with
//                | None -> ()
//                | Some error ->
//                    div [ Class "fn-error-message" ] [
//                        AntText()
//                            .typographyType(TypographyType.Danger)
//                            .[[ renderErrorMessage error ]]
//                    ]
//                AntButton()
//                    .buttonType(ButtonType.Primary)
//                    .loading(model.IsProcessing)
//                    .htmlType(ButtonHtmlType.Submit)
//                    .style([ Width "100%" ]).[[ str "Login" ]]
//            ]]
//            AntFormItem()
//                .key("login-links")
//                .[[
//                AntButton()
//                    .buttonType(ButtonType.Link)
//                    .onClick(fun _ -> ctx.navigate RegistrationPage)
//                    .[[ str "Register" ]]
//                AntButton()
//                    .buttonType(ButtonType.Link)
//                    .style([ Float FloatOptions.Right ])
//                    .onClick(fun _ -> ctx.navigate ForgotPasswordPage)
//                    .[[ str "Forgot password?" ]]
//            ]]
//        ]]
//    ]]
    }