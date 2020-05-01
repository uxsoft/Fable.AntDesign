# Fable.AntD

Ant Design for Fable f#

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

AntContent().[[
        AntPageHeader(
            Title = (str "Login"),
            SubTitle = (str "Please log-in to enter.")).[[]]
        
        AntForm(
            OnFinish = (fun _ -> handleSubmit ctx |> Async.StartImmediate),
            Style = [ Props.MaxWidth "320px"; Props.Margin "0 auto" ]).[[
            AntFormItem(
                Name = "login-email",
                Custom = ("key", unbox "login-email"),
                Rules = [ AntFormRule(Type = "email", Message = "This isn't a valid email")
                          AntFormRule(Required = true, Message = "This field is mandatory")]).[[
                AntInput(
                    Prefix = (AntIcon(AntIcon.MailOutlined, Style = grayedOut).[[]]),
                    OnChange = (fun e -> setModel (fun s -> { s with Email = e.Value })),
                    Placeholder = "Email").[[]]
            ]]
            AntFormItem(
                Name = "login-password",
                Key =  "login-password",
                Rules = [ AntFormRule(Required = true, Message = "This field is mandatory") ]).[[
                AntPassword(
                    Prefix = (AntIcon(AntIcon.LockOutlined, Style = grayedOut).Empty),
                    OnChange = (fun e -> setModel (fun s -> { s with Password = base64 e.Value })),
                    Placeholder = "Password").[[]]
            ]]
            AntFormItem(
                Key = "login-submit").[[
                match model.Error with
                | None -> ()
                | Some error ->
                    div [ Class "fn-error-message" ] [
                        AntText(Type = TypographyType.Danger).[[
                           renderErrorMessage error
                        ]]
                    ]
                
                AntButton(
                    Type = ButtonType.Primary,
                    Loading = model.IsProcessing,
                    HtmlType = "submit",
                    Style = [ Props.CSSProp.Width "100%" ]).With [ str "Login" ]
            ]]
            AntFormItem(Key = "login-links").[[
                AntButton(
                    Type = ButtonType.Link,
                    OnClick = (fun _ -> ctx.navigate RegistrationPage)).[[
                    str "Register"
                ]]
                AntButton(Type = ButtonType.Link,
                    Style = [ Props.Float Props.FloatOptions.Right ],
                    OnClick = (fun _ -> ctx.navigate ForgotPasswordPage)).[[
                    str "Forgot password?"
                ]]
            ]]
        ]]
    ]]
```

FAQ:

- When supplying `AntFormItem.Rules`, make sure the form item has a Name otherwise the validations won't work
- Use AntFormItem.Key to make sure the form item is recreated if switching between forms
