module Fable.AntDesign.Form

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JS
open Fable.Core.JsInterop
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

type IFieldError =
    abstract name: string
    abstract errors: string array

type IFormInstance =
    abstract getFieldError: string -> string array
    abstract getFieldInstance: string -> 'TInstance
    abstract getFieldsError: string array -> IFieldError array
    abstract getFieldsValue: Func<string array,  {| touched: bool; validating: bool |} -> bool> -> 'TValue
    abstract getFieldValue: string -> obj
    abstract isFieldsTouched: Func<string array, bool> -> bool
    abstract isFieldTouched: string -> bool
    abstract isFieldValidating: string -> bool
    abstract resetFields: string array -> unit
    abstract scrollToField: Func<string, 'TScrollOptions, unit> -> unit
    abstract setFields: FormFieldData array -> unit
    abstract setFieldsValue: 'TValue array -> unit
    abstract submit: unit -> unit
    abstract validateFields: string array -> Async<unit>

[<Import("Form.useForm", "antd")>]
let private useFormInternal: unit -> IFormInstance array = jsNative
let useForm () = useFormInternal() |> Array.head

type FormRuleBuilder() =
    inherit ReactBuilder()

    member x.Run(s: DSLElement) = createObj s.Attributes

    [<CustomOperation("enum")>] member _.enum (x: DSLElement, v: string array) = x.attr "enum" v
    [<CustomOperation("len")>] member _.len (x: DSLElement, v: int) = x.attr "len" v
    [<CustomOperation("max")>] member _.max (x: DSLElement, v: int) = x.attr "max" v
    [<CustomOperation("message")>] member _.message (x: DSLElement, v: string) = x.attr "message" v
    [<CustomOperation("min")>] member _.min (x: DSLElement, v: int) = x.attr "min" v
    [<CustomOperation("pattern")>] member _.pattern (x: DSLElement, v: string) = x.attr "pattern" v
    [<CustomOperation("required")>] member _.required (x: DSLElement) = x.attr "required" true
    [<CustomOperation("transform")>] member _.transform (x: DSLElement, v: string -> string) = x.attr "transform" v
    [<CustomOperation("ruleType")>] member _.ruleType (x: DSLElement, v: FormRuleType) = x.attr "type" v
    [<CustomOperation("validator")>] member _.validator (x: DSLElement, v: Func<obj, string, Promise<string>>) = x.attr "validator" v
    [<CustomOperation("whitespace")>] member _.whitespace (x: DSLElement) = x.attr "whitespace" true
    [<CustomOperation("validateTrigger")>] member _.validateTrigger (x: DSLElement, v: string array) = x.attr "validateTrigger" v

type FormBuilder<'T>() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Form" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("colon")>] member _.colon (x: DSLElement) = x.attr "colon" true
    [<CustomOperation("component")>] member _.``component`` (x: DSLElement, v: ReactElement) = x.attr "component" v
    [<CustomOperation("fields")>] member _.fields (x: DSLElement, v: FormFieldData array) = x.attr "fields" v
    [<CustomOperation("form")>] member _.form (x: DSLElement, v: IFormInstance) = x.attr "form" v
    [<CustomOperation("initialValues")>] member _.initialValues (x: DSLElement, v: 'T) = x.attr "initialValues" v
    [<CustomOperation("labelAlign")>] member _.labelAlign (x: DSLElement, v: FormLabelAlign) = x.attr "labelAlign" v
    [<CustomOperation("labelCol")>] member _.labelCol (x: DSLElement, v: obj) = x.attr "labelCol" 
    [<CustomOperation("layout")>] member _.layout (x: DSLElement, v: FormLayout) = x.attr "layout" v
    [<CustomOperation("name")>] member _.name (x: DSLElement, v: string) = x.attr "name" v
    [<CustomOperation("preserve")>] member _.preserve (x: DSLElement) = x.attr "preserve" true
    [<CustomOperation("requiredMark")>] member _.requiredMark (x: DSLElement) = x.attr "requiredMark" true
    [<CustomOperation("scrollToFirstError")>] member _.scrollToFirstError (x: DSLElement, v: bool) = x.attr "scrollToFirstError" v
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("validateMessages")>] member _.validateMessages (x: DSLElement, v: obj) = x.attr "validateMessages" v
    [<CustomOperation("validateTrigger")>] member _.validateTrigger (x: DSLElement, v: string array) = x.attr "validateTrigger" v
    [<CustomOperation("wrapperCol")>] member _.wrapperCol (x: DSLElement, v: obj) = x.attr "wrapperCol"
    [<CustomOperation("onFieldsChange")>] member _.onFieldsChange (x: DSLElement, v: Func<string array, string array, unit>) = x.attr "onFieldsChange" v
    [<CustomOperation("onFinish")>] member _.onFinish (x: DSLElement, v: 'T -> unit) = x.attr "onFinish" v
    [<CustomOperation("onFinishFailed")>] member _.onFinishFailed (x: DSLElement, v: {| values: 'T; errorFields: string array; outOfDate: string array |} -> unit) = x.attr "onFinishFailed" v
    [<CustomOperation("onValuesChange")>] member _.onValuesChange (x: DSLElement, v: Func<string array, string array, unit>) = x.attr "onValuesChange" v

type FormItemBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Form.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("colon")>] member _.colon (x: DSLElement) = x.attr "colon" true
    [<CustomOperation("dependencies")>] member _.dependencies (x: DSLElement, v: string array) = x.attr "dependencies" v
    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
    [<CustomOperation("getValueFromEvent")>] member _.getValueFromEvent (x: DSLElement, v: Func<obj array, obj>) = x.attr "getValueFromEvent" v
    [<CustomOperation("getValueProps")>] member _.getValueProps (x: DSLElement, v: Func<obj, obj>) = x.attr "getValueProps" v
    [<CustomOperation("hasFeedback")>] member _.hasFeedback (x: DSLElement, v: bool) = x.attr "hasFeedback" v
    [<CustomOperation("help")>] member _.help (x: DSLElement, v: ReactElement) = x.attr "help" v
    [<CustomOperation("hidden")>] member _.hidden (x: DSLElement) = x.attr "hidden" true
    [<CustomOperation("htmlFor")>] member _.htmlFor (x: DSLElement, v: string) = x.attr "htmlFor" v
    [<CustomOperation("initialValue")>] member _.initialValue (x: DSLElement, v: string) = x.attr "initialValue" v 
    [<CustomOperation("label")>] member _.label (x: DSLElement, v: ReactElement) = x.attr "label" v
    [<CustomOperation("labelAlign")>] member _.labelAlign (x: DSLElement, v: FormLabelAlign) = x.attr "labelAlign" v
    [<CustomOperation("labelCol")>] member _.labelCol (x: DSLElement, v: obj) = x.attr "labelCol" v
    [<CustomOperation("messageVariables")>] member _.messageVariables (x: DSLElement, v) = x.attr "messageVariables" v
    [<CustomOperation("name")>] member _.name (x: DSLElement, v: string) = x.attr "name" v
    [<CustomOperation("normalize")>] member _.normalize (x: DSLElement, v: Func<string, string, string array, string>) = x.attr "normalize" v
    [<CustomOperation("noStyle")>] member _.noStyle (x: DSLElement) = x.attr "noStyle" true
    [<CustomOperation("preserve")>] member _.preserve (x: DSLElement) = x.attr "preserve" true
    [<CustomOperation("required")>] member _.required (x: DSLElement) = x.attr "required" true
    [<CustomOperation("rules")>] member _.rules (x: DSLElement, v: obj array) = x.attr "rules" v
    [<CustomOperation("shouldUpdate")>] member _.shouldUpdate (x: DSLElement, v: Func<string, string, bool>) = x.attr "shouldUpdate" v
    [<CustomOperation("trigger")>] member _.trigger (x: DSLElement, v: string) = x.attr "trigger" v
    [<CustomOperation("validateFirst")>] member _.validateFirst (x: DSLElement) = x.attr "validateFirst" true
    [<CustomOperation("validateStatus")>] member _.validateStatus (x: DSLElement, v: FormValidationStatus) = x.attr "validateStatus" v
    [<CustomOperation("validateTrigger")>] member _.validateTrigger (x: DSLElement, v: string array) = x.attr "validateTrigger" v
    [<CustomOperation("valuePropName")>] member _.valuePropName (x: DSLElement, v: string) = x.attr "valuePropName" v
    [<CustomOperation("wrapperCol")>] member _.wrapperCol (x: DSLElement, v: obj) = x.attr "wrapperCol" v

type FormListBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Form.List" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("initialValue")>] member _.initialValue (x: DSLElement, v: string) = x.attr "initialValue" v 
    [<CustomOperation("name")>] member _.name (x: DSLElement, v: string) = x.attr "name" v
    [<CustomOperation("rules")>] member _.rules (x: DSLElement, v: obj array) = x.attr "rules" v

type FormErrorListBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Form.ErrorList" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("errors")>] member _.errors (x: DSLElement, v: ReactElement array) = x.attr "errors" v

type FormProviderBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Form.Provider" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("onFormChange")>] member _.onFormChange (x: DSLElement, v: Func<string, obj, unit>) = x.attr "onFormChange" v
    [<CustomOperation("onFormFinish")>] member _.onFormFinish (x: DSLElement, v: Func<string, obj, unit>) = x.attr "onFormFinish" v
