# Fable.AntD

Ant Design bindings for F# powered by Fable React.

<img src="https://buildstats.info/nuget/Fable.AntDesign" alt="badge"/>

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

Live: https://wonderful-pond-0cff0e203.azurestaticapps.net/

```fsharp
open Fable.AntDesign.Ant

let view model dispatch =
    content {
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
```

FAQ:
- When supplying `AntFormItem.Rules`, make sure the form item has a Name otherwise the validations won't work
- Use AntFormItem.Key to make sure the form item is recreated if switching between forms