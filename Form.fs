namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.Core.JS

//importSideEffects "regenerator-runtime/runtime"

[<StringEnum; RequireQualifiedAccess>]
type FormValidationStatus =
    | Success
    | Warning
    | Error
    | Validating

[<StringEnum; RequireQualifiedAccess>]
type FormLabelAlign =
    | Left
    | Right

[<StringEnum; RequireQualifiedAccess>]
type FormRuleType =
    | String
    | Number
    | Boolean
    | Method
    | Regexp
    | Integer
    | Float
    | Array
    | Object
    | Enum
    | Date
    | Url
    | Hex
    | Email
    | Any

[<StringEnum; RequireQualifiedAccess>]
type FormLayout =
    | Horizontal
    | Vertical
    | Inline

type FormFieldData =
    { touched: bool
      validating: bool
      errors: string array
      name: string array
      value: string }

type AntFormRule() =
    let props = System.Collections.Generic.List<string * obj>()

    member internal x.Build() = createObj props
    member internal x.Attribute name value = props.Add((name, unbox value))

    member x.Enum
        with set (v: string array) = x.Attribute "enum" v
    member x.Len
        with set (v: int) = x.Attribute "len" v
    member x.Max
        with set (v: int) = x.Attribute "max" v
    member x.Message
        with set (v: string) = x.Attribute "message" v
    member x.Min
        with set (v: int) = x.Attribute "min" v
    member x.Pattern
        with set (v: string) = x.Attribute "pattern" v
    member x.Required
        with set (v: bool) = x.Attribute "required" v
    member x.Transform
        with set (v: string -> string) = x.Attribute "transform" v
    member x.Type
        with set (v: string) = x.Attribute "type" v
    member x.Validator
        with set (v: AntFormRule -> string -> Promise<string>) =
            let uncurried = System.Func<AntFormRule, string, Promise<string>> v
            x.Attribute "validator" uncurried
    member x.Whitespace
        with set (v: bool) = x.Attribute "whitespace" v
    member x.ValidateTrigger
        with set (v: string array) = x.Attribute "validateTrigger" v

type AntForm() =
    inherit AntElement(ofImport "Form" "antd")
    member x.Component
        with set (v: ReactElement) = x.Attribute "component" v
    member x.Colon
        with set (v: bool) = x.Attribute "colon" v
    member x.Fields
        with set (v: FormFieldData array) = x.Attribute "fields" v
    member x.Form
        with set (v: ReactElement) = x.Attribute "form" v
    member x.HideRequiredMark
        with set (v: bool) = x.Attribute "hideRequiredMark" v
    member x.InitialValues
        with set (v: obj) = x.Attribute "initialValues" v
    member x.LabelAlign
        with set (v: FormLabelAlign) = x.Attribute "labelAlign" v
    member x.LabelCol
        with set (v: obj) = x.Attribute "labelCol" v
    member x.Layout
        with set (v: FormLayout) = x.Attribute "layout" v
    member x.Name
        with set (v: string) = x.Attribute "name" v
    member x.Size
        with set (v: Size) = x.Attribute "size" v
    member x.ValidateMessages
        with set (v: obj) = x.Attribute "validateMessages" v
    member x.WrapperCol
        with set (v: obj) = x.Attribute "wrapperCol" v
    member x.OnFinish
        with set (v: string array -> unit) = x.Attribute "onFinish" v
    member x.OnFinishFailed
        with set (v: obj -> unit) = x.Attribute "onFinishFailed" v
    member x.OnFieldsChange
        with set (v: string array -> string array -> unit) =
            let uncurried = System.Func<string array, string array, unit> v
            x.Attribute "onFieldsChange" uncurried
    member x.OnValuesChange
        with set (v: string array -> string array -> unit) =
            let uncurried = System.Func<string array, string array, unit> v
            x.Attribute "onValuesChange" uncurried

type AntFormItem() =
    inherit AntElement(ofImport "Form.Item" "antd")
    member x.Key
        with set (v: string) = x.Attribute "key" v
    member x.Colon
        with set (v: bool) = x.Attribute "colon" v
    member x.Dependencies
        with set (v: string array) = x.Attribute "dependencies" v
    member x.Extra
        with set (v: ReactElement) = x.Attribute "extra" v
    member x.HasFeedback
        with set (v: bool) = x.Attribute "hasFeedback" v
    member x.Help
        with set (v: ReactElement) = x.Attribute "help" v
    member x.HtmlFor
        with set (v: string) = x.Attribute "htmlFor" v
    member x.NoStyle
        with set (v: bool) = x.Attribute "noStyle" v
    member x.Label
        with set (v: ReactElement) = x.Attribute "label" v
    member x.LabelAlign
        with set (v: FormLabelAlign) = x.Attribute "labelAlign" v
    member x.LabelCol
        with set (v: obj) = x.Attribute "labelCol" v
    member x.Name
        with set (v: string) = x.Attribute "name" v
    member x.Normalize
        with set (v: string -> string -> string array -> string) =
            let uncurried = System.Func<string, string, string array, string> v
            x.Attribute "normalize" uncurried
    member x.Required
        with set (v: bool) = x.Attribute "required" v
    member x.ShouldUpdate
        with set (v: bool) = x.Attribute "shouldUpdate" v
    member x.Trigger
        with set (v: string) = x.Attribute "trigger" v
    member x.ValidationStatus
        with set (v: FormValidationStatus) = x.Attribute "validationStatus" v
    member x.ValidateTrigger
        with set (v: string array) = x.Attribute "validateTrigger" v
    member x.ValuePropName
        with set (v: string) = x.Attribute "valuePropName" v
    member x.WrapperCol
        with set (v: obj) = x.Attribute "wrapperCol" v
    member x.Rules
        with set (rules: AntFormRule list) =
            x.Attribute "rules"
                (rules
                 |> List.map (fun rule -> rule.Build())
                 |> List.toArray)

type AntFormList() =
    inherit AntElement(ofImport "Form.List" "antd")
    member x.Name
        with set (v: string) = x.Attribute "name" v

type AntFormProvider() =
    inherit AntElement(ofImport "Form.Provider" "antd")
    member x.OnFormChange
        with set (v: string -> obj -> unit) =
            let uncurried = System.Func<string, obj, unit> v
            x.Attribute "onFormChange" uncurried
    member x.OnFormFinish
        with set (v: string -> obj -> unit) =
            let uncurried = System.Func<string, obj, unit> v
            x.Attribute "onFormFinish" uncurried
