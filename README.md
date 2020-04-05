# Fable.AntD

Ant Design for Fable f#

To include the package:

In Styles.scss
```sass
@import "../../node_modules/antd/dist/antd.css";
```

In package.json
```
        "antd": "^4.0.0",
        "@ant-design/icons": "^4.0.0",
        "regenerator-runtime": "^0.13.3"
```
Usage:

```fsharp
open Fable.AntD

Content().With [
        PageHeader(Title = (str "Login"),
                   SubTitle = (str "Please log-in to enter.")).Empty
        
        Form(OnFinish = (fun _ -> dispatch Submit),
             Style = [ Props.MaxWidth "320px"; Props.Margin "0 auto" ]).With [
            FormItem(Name = "login-email",
                     Custom = ("key", unbox "login-email"),
                     Rules = [ FormRule(Type = "email", Message = "This isn't a valid email")
                               FormRule(Required = true, Message = "This field is mandatory")]).With [
                Input(Prefix = (Icon(Icon.UserOutlined, Style = grayedOut).Empty),
                      OnChange = (fun e -> dispatch (ChangedEmail e.Value)),
                      Placeholder = "Email").Empty
            ]
            FormItem(Name = "login-password",
                     Key =  "login-password",
                     Rules = [ FormRule(Required = true, Message = "This field is mandatory") ]).With [
                Password(Prefix = (Icon(Icon.LockOutlined, Style = grayedOut).Empty),
                         OnChange = (fun e -> dispatch (ChangedPassword (base64 e.Value))),
                         Placeholder = "Password").Empty
            ]
            FormItem(Key = "login-submit").With [
                if not (System.String.IsNullOrWhiteSpace model.ErrorMessage) then
                    AntD.Text(Type = TypographyType.Danger).With [ str model.ErrorMessage ]
                    
                Button(Type = ButtonType.Primary,
                       Loading = model.IsProcessing,
                       HtmlType = "submit",
                       Style = [ Props.CSSProp.Width "100%" ]).With [ str "Login" ]
            ]
            FormItem(Key = "login-links").With [
                Button(Type = ButtonType.Link,
                       OnClick = (fun _ -> escalate (NavigateTo RegistrationPage))).With
                       [ str "Register" ]
                Button(Type = ButtonType.Link,
                       Style = [ Props.Float Props.FloatOptions.Right ],
                       OnClick = (fun _ -> escalate (NavigateTo ForgotPasswordPage))).With
                       [ str "Forgot password?" ]
            ]
        ]
    ]

```

FAQ:

- When supplying `AntFormItem.Rules`, make sure the form item has a Name otherwise the validations won't work
- Use AntFormItem.Key to make sure the form item is recreated if switching between forms
