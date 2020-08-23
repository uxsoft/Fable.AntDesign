# Fable.AntD

Ant Design for Fable F#

To include the package:

In Styles.scss
```sass
@import "../../node_modules/antd/dist/antd.css";
```

In package.json
```json
{
  "dependencies": {
    "antd": "^4.0.0",
    "@ant-design/icons": "^4.0.0"
  }
}
```
Usage:

```fsharp
open Fable.AntD

    AntContent()
        .[[
        AntPageHeader()
            .title(str "Login")
            .subTitle(str "Please log-in to enter.")
            .[[]]
        
        AntForm()
            .onFinish(fun _ -> handleSubmit ctx |> Async.StartImmediate)
            .style([ Props.MaxWidth "320px"; Props.Margin "0 auto" ])
            .[[
            AntFormItem()
                .name("login-email")
                .key("login-email")
                .rules([|
                    AntFormRule("This isn't a valid email").ruleType(FormRuleType.Email)
                    AntFormRule("This field is mandatory").required(true) |])
                .[[
                AntInput()
                    .prefix(AntIcon(AntIcon.MailOutlined).style(grayedOut).[[]])
                    .onChange(fun e -> setModel (fun s -> { s with Email = e.Value }))
                    .placeholder("Email")
                    .[[]]
            ]]
            AntFormItem()
                .name("login-password")
                .key("login-password")
                .rules([| AntFormRule().required(true).message("This field is mandatory") |])
                .[[
                AntPassword()
                    .prefix(AntIcon(AntIcon.LockOutlined).style(grayedOut).[[]])
                    .onChange(fun e -> setModel (fun s -> { s with Password = base64 e.Value }))
                    .placeholder("Password")
                    .[[]]
            ]]
            AntFormItem()
                .key("login-submit")
                .[[
                match model.Error with
                | None -> ()
                | Some error ->
                    div [ Class "fn-error-message" ] [
                        AntText()
                            .typographyType(TypographyType.Danger)
                            .[[ renderErrorMessage error ]]
                    ]
                AntButton()
                    .buttonType(ButtonType.Primary)
                    .loading(model.IsProcessing)
                    .htmlType(ButtonHtmlType.Submit)
                    .style([ Props.CSSProp.Width "100%" ]).[[ str "Login" ]]
            ]]
            AntFormItem()
                .key("login-links")
                .[[
                AntButton()
                    .buttonType(ButtonType.Link)
                    .onClick(fun _ -> ctx.navigate RegistrationPage)
                    .[[ str "Register" ]]
                AntButton()
                    .buttonType(ButtonType.Link)
                    .style([ Float FloatOptions.Right ])
                    .onClick(fun _ -> ctx.navigate ForgotPasswordPage)
                    .[[ str "Forgot password?" ]]
            ]]
        ]]
    ]]
```

FAQ:

- When supplying `AntFormItem.Rules`, make sure the form item has a Name otherwise the validations won't work
- Use AntFormItem.Key to make sure the form item is recreated if switching between forms
