# Fable.AntD

To include the package:

In Styles.scss
```sass
@import "../../node_modules/antd/dist/antd.css";
```

In package.json
```
        "antd": "^4.0.0-rc.0",
        "@ant-design/icons": "^4.0.0-alpha.19 ",
```
Usage:

```fsharp
open Fable.AntD

antContent [ ] [
    antPageHeader [ AntPageHeader.Title (str "Login")
                    AntPageHeader.SubTitle (str "Please log-in to enter.") ] []
    
    antForm [ AntForm.Style [ MaxWidth "320px"; Margin "0 auto" ] ] [
        antFormItem [] [
            antInput [ AntInput.Prefix (antIconUserOutlined grayedOut [])
                       AntInput.OnChange (fun e -> dispatch (ChangedEmail e.Value))
                       AntInput.Type "email"
                       AntInput.Placeholder "Email" ] []
        ]
        antFormItem [] [
            antPassword [ AntPassword.Prefix (antIconLockOutlined grayedOut [])
                          AntPassword.OnChange (fun e -> dispatch (ChangedPassword (base64 e.Value)))
                          AntPassword.Placeholder "Password" ] []
        ]
        antFormItem [] [
            if not (String.IsNullOrWhiteSpace(model.ErrorMessage)) then
                antText [ AntText.Type TypographyType.Danger ] [ str model.ErrorMessage ]
                
            antButton [ AntButton.Type AntButtonType.Primary
                        AntButton.Loading model.IsProcessing
                        AntButton.OnClick (fun _ -> dispatch Submit)
                        AntButton.Style [ Width "100%" ]] [ str "Login" ]
            div [] [
                a [ Href "#"
                    Class "btn hover-underline"
                    OnClick (fun _ -> escalate (NavigateTo RegistrationPage)) ]
                    [ str "Register" ]
                a [ Href "#"
                    Class "btn hover-underline"
                    Style [ Float FloatOptions.Right ]
                    OnClick (fun _ -> escalate (NavigateTo ForgotPasswordPage)) ]
                    [ str "Forgot password?" ]
            ]
        ]
    ]
]

```