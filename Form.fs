namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.Core.JS
open System

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

type FormFieldData = {
    touched: bool
    validating: bool
    errors: string array
    name: string array
    value: string
}

type AntFormRule() =
    inherit AntObject<AntFormRule>()
    member x.enum (v: string array) = x.attribute "enum" v
    member x.len (v: int) = x.attribute "len" v
    member x.max (v: int) = x.attribute "max" v
    member x.message (v: string) = x.attribute "message" v
    member x.min (v: int) = x.attribute "min" v
    member x.pattern (v: string) = x.attribute "pattern" v
    member x.required (v: bool) = x.attribute "required" v
    member x.transform (v: string -> string) = x.attribute "transform" v
    member x.objectType (v: string) = x.attribute "type" v
    member x.validator (v: Func<AntFormRule, string, Promise<string>>) = x.attribute "validator" v
    member x.whitespace (v: bool) = x.attribute "whitespace" v
    member x.validateTrigger (v: string array) = x.attribute "validateTrigger" v

type AntForm() =
    inherit AntElement<AntForm>(ofImport "Form" "antd")
    member x.component (v: ReactElement) = x.attribute "component" v
    member x.colon (v: bool) = x.attribute "colon" v
    member x.fields (v: FormFieldData array) = x.attribute "fields" v
    member x.form (v: ReactElement) = x.attribute "form" v
    member x.hideRequiredMark (v: bool) = x.attribute "hideRequiredMark" v
    member x.initialValues (v: obj) = x.attribute "initialValues" v
    member x.labelAlign (v: FormLabelAlign) = x.attribute "labelAlign" v
    member x.labelCol (v: AntColumn) = x.attribute "labelCol" v.JSON
    member x.layout (v: FormLayout) = x.attribute "layout" v
    member x.name (v: string) = x.attribute "name" v
    member x.scrollToFirstError (v: bool) = x.attribute "scrollToFirstError" v
    member x.size (v: Size) = x.attribute "size" v
    member x.validateMessages (v: obj) = x.attribute "validateMessages" v
    member x.wrapperCol (v: AntColumn) = x.attribute "wrapperCol" v.JSON
    member x.onFinish (v: string array -> unit) = x.attribute "onFinish" v
    member x.onFinishFailed (v: obj -> unit) = x.attribute "onFinishFailed" v
    member x.onFieldsChange (v: Func<string array, string array, unit>) = x.attribute "onFieldsChange" v
    member x.onValuesChange (v: Func<string array, string array, unit>) = x.attribute "onValuesChange" v

type AntFormItem() =
    inherit AntElement<AntFormItem>(ofImport "Form.Item" "antd")
    member x.colon (v: bool) = x.attribute "colon" v
    member x.dependencies (v: string array) = x.attribute "dependencies" v
    member x.extra (v: ReactElement) = x.attribute "extra" v
    member x.getValueFromEvent (v: Func<obj array, obj>) = x.attribute "getValueFromEvent" v
    member x.getValueProps (v: Func<obj, obj>) = x.attribute "getValueProps" v
    member x.hasFeedback (v: bool) = x.attribute "hasFeedback" v
    member x.help (v: ReactElement) = x.attribute "help" v
    member x.htmlFor (v: string) = x.attribute "htmlFor" v
    member x.initialValue (v: string) = x.attribute "initialValue" v 
    member x.noStyle (v: bool) = x.attribute "noStyle" v
    member x.label (v: ReactElement) = x.attribute "label" v
    member x.labelAlign (v: FormLabelAlign) = x.attribute "labelAlign" v
    member x.labelCol (v: AntColumn) = x.attribute "labelCol" v.JSON
    member x.name (v: string) = x.attribute "name" v
    member x.normalize (v: Func<string, string, string array, string>) = x.attribute "normalize" v
    member x.required (v: bool) = x.attribute "required" v
    member x.rules (rules: AntFormRule array) = x.attribute "rules" (rules |> Array.map (fun rule -> rule.JSON))
    member x.shouldUpdate (v: Func<string, string, bool>) = x.attribute "shouldUpdate" v
    member x.trigger (v: string) = x.attribute "trigger" v
    member x.validateFirst (v: bool) = x.attribute "validateFirst" v
    member x.validationStatus (v: FormValidationStatus) = x.attribute "validationStatus" v
    member x.validateTrigger (v: string array) = x.attribute "validateTrigger" v
    member x.valuePropName (v: string) = x.attribute "valuePropName" v
    member x.wrapperCol (v: AntColumn) = x.attribute "wrapperCol" v.JSON

type AntFormList() =
    inherit AntElement<AntFormList>(ofImport "Form.List" "antd")
    member x.name (v: string) = x.attribute "name" v

type AntFormProvider() =
    inherit AntElement<AntFormProvider>(ofImport "Form.Provider" "antd")
    member x.onFormChange (v: Func<string, obj, unit>) = x.attribute "onFormChange" v
    member x.onFormFinish (v: Func<string, obj, unit>) = x.attribute "onFormFinish" v
