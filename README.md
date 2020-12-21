# Fable.AntD

Ant Design bindings for Fable F#

<img src="https://buildstats.info/nuget/Fable.AntD" alt="badge"/>

## Usage

### Dependencies

#### Include the bindings from NuGet:

`dotnet package add Fable.AntD`

#### Include the Ant Design React libraries from NPM

In package.json
```json
{
  "dependencies": {
    "antd": "^4.0.0",
    "@ant-design/icons": "^4.0.0"
  }
}
```
#### Reference the styles

In style.scss:
```sass
@import "../../node_modules/antd/dist/antd.css";
```

### Example 

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
                    AntFormRule("This field is mandatory").required() |])
                .[[
                AntInput()
                    .prefix(AntIcons.MailOutlined.style(grayedOut).[[]])
                    .onChange(fun e -> setModel (fun s -> { s with Email = e.Value }))
                    .placeholder("Email")
                    .[[]]
            ]]
            AntFormItem()
                .name("login-password")
                .key("login-password")
                .rules([| AntFormRule("This field is mandatory").required() |])
                .[[
                AntPassword()
                    .prefix(AntIcons.LockOutlined.style(grayedOut).[[]])
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
                    .style([ Width "100%" ]).[[ str "Login" ]]
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
