# Fable.AntDesign

| __Fable.AntD__ | __SwiftUI style (class based) bindings__ | <img src="https://buildstats.info/nuget/Fable.AntD" alt="badge"/> |
| :--- | :--- | :--- |
| __Fable.AntDesign__ [EXPERIMENTAL]  | __F# computation expression based bindings__ | <img src="https://buildstats.info/nuget/Fable.AntDesign" alt="badge"/>  |


### Getting Started

- Include the bindings from NuGet:


`dotnet package add Fable.AntDesign`

- Include the Ant Design React libraries from NPM

package.json:
```json
{
  "dependencies": {
    "antd": "^4.0.0",
    "@ant-design/icons": "^4.0.0"
  }
}
```
- Reference the styles

style.scss:
```sass
@import "../../node_modules/antd/dist/antd.min.css";
```

### Example 

Live: [https://fable-antdesign.uxsoft.cz/](https://fable-antdesign.uxsoft.cz/)

```fsharp
open Fable.AntDesign.Ant

let view model dispatch =
    Content {
        PageHeader {
            title (str "Login")
            subTitle (str "Please log-in to enter.")
        }
        
        Form {
            style [ MaxWidth "320px"; Margin "0 auto" ]
            onFinish (fun values -> dispatch (BeginLogin(string values.["username"], string values.["password"])))

            FormItem {
                name "email"
                key "login-email"
                rules [
                    [ FormRule.RuleType FormRuleType.Email 
                      FormRule.Message "This isn't a valid email" ]
                    [ FormRule.Required true
                      FormRule.Message "This field is mandatory" ] ]
                Input {
                    prefix (basicIcon icons.MailOutlined { style [ Color "lightgray" ] })
                    placeholder "Email"
                }
            }
            
            FormItem {
                name "password"
                key "login-password"
                rules [
                    [ FormRule.Required true
                      FormRule.Message "This field is mandatory" ] ]
                Password {
                    prefix (basicIcon icons.LockOutlined { style [ Color "lightgray" ] })
                }
            }
            
            FormItem {
                key "login-submit"
                Button {
                    style [ Width "100%" ]
                    buttonType ButtonType.Primary
                    loading model.IsLoggingIn
                    htmlType ButtonHtmlType.Submit 
                    
                    str "Login"
                }
            }
            
            FormItem {
                key "login-links"
                button {
                    buttonType ButtonType.Link
                    str "Register"
                }
                Button {
                    style [ Float FloatOptions.Right ]
                    buttonType ButtonType.Link
                    str "Forgot password?"
                }
            }
        }
    }
```

### FAQ
- When supplying `formItem.rules`, make sure the form item has a Name otherwise the validations won't work
- Use `formItem.key` to make sure the form item is recreated if switching between forms
