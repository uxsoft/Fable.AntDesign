namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.Core.JS

//importSideEffects "regenerator-runtime/runtime"

[<StringEnum; RequireQualifiedAccess>]
type FormValidationStatus = Success | Warning | Error | Validating

[<StringEnum; RequireQualifiedAccess>]
type FormLabelAlign = Left | Right

[<StringEnum; RequireQualifiedAccess>]
type FormRuleType = String | Number | Boolean | Method | Regexp | Integer | Float | Array | Object | Enum | Date | Url | Hex | Email | Any

[<StringEnum; RequireQualifiedAccess>]
type FormLayout = Horizontal | Vertical | Inline

type FormFieldData = {
    touched: bool
    validating: bool
    errors: string array
    name: string array
    value: string
}

type FormRule() =
    let props = System.Collections.Generic.List<string * obj>()

    member x.Rule = createObj props
    member internal x.Attribute name value = props.Add((name, unbox value))
     
    member x.Enum with set (v: string array) = x.Attribute "enum" v 
    member x.Len with set (v: int) = x.Attribute "len" v 
    member x.Max with set (v: int) = x.Attribute "max" v 
    member x.Message with set (v: string) = x.Attribute "message" v 
    member x.Min with set (v: int) = x.Attribute "min" v 
    member x.Pattern with set (v: string) = x.Attribute "pattern" v 
    member x.Required with set (v: bool) = x.Attribute "required" v 
    member x.Transform with set (v: (string -> string)) = x.Attribute "transform" v 
    member x.Type with set (v: string) = x.Attribute "type" v 
    member x.Validator with set (v: (FormRule -> string -> Promise<string>)) = x.Attribute "validator" v 
    member x.Whitespace with set (v: bool) = x.Attribute "whitespace" v 
    member x.ValidateTrigger with set (v: string array) = x.Attribute "validateTrigger" v 

type Form() =
    inherit AntElement("Form")
    member x.Component with set (v: ReactElement) = x.Attribute "component" v 
    member x.Colon with set (v: bool) = x.Attribute "colon" v 
    member x.Fields with set (v: FormFieldData array) = x.Attribute "fields" v 
    member x.Form with set (v: ReactElement) = x.Attribute "form" v 
    member x.HideRequiredMark with set (v: bool) = x.Attribute "hideRequiredMark" v 
    member x.InitialValues with set (v: obj) = x.Attribute "initialValues" v 
    member x.LabelAlign with set (v: FormLabelAlign) = x.Attribute "labelAlign" v 
    member x.LabelCol with set (v: obj) = x.Attribute "labelCol" v 
    member x.Layout with set (v: FormLayout) = x.Attribute "layout" v 
    member x.Name with set (v: string) = x.Attribute "name" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.ValidateMessages with set (v: obj) = x.Attribute "validateMessages" v 
    member x.WrapperCol with set (v: obj) = x.Attribute "wrapperCol" v 
    member x.OnFinish with set (v: (string array -> unit)) = x.Attribute "onFinish" v 
    member x.OnFinishFailed with set (v: (obj -> unit)) = x.Attribute "onFinishFailed" v 
    member x.OnFieldsChange with set (v: (string array -> string array -> unit)) = x.Attribute "onFieldsChange" v 
    member x.OnValuesChange with set (v: (string array -> string array -> unit)) = x.Attribute "onValuesChange" v 

type FormItem() =
  inherit AntElement("Form.Item")
  member x.Key with set (v: string) = x.Attribute "key" v 
  member x.Colon with set (v: bool) = x.Attribute "colon" v 
  member x.Dependencies with set (v: string array) = x.Attribute "dependencies" v 
  member x.Extra with set (v: ReactElement) = x.Attribute "extra" v 
  member x.HasFeedback with set (v: bool) = x.Attribute "hasFeedback" v 
  member x.Help with set (v: ReactElement) = x.Attribute "help" v 
  member x.HtmlFor with set (v: string) = x.Attribute "htmlFor" v 
  member x.NoStyle with set (v: bool) = x.Attribute "noStyle" v 
  member x.Label with set (v: ReactElement) = x.Attribute "label" v 
  member x.LabelAlign with set (v: FormLabelAlign) = x.Attribute "labelAlign" v 
  member x.LabelCol with set (v: obj) = x.Attribute "labelCol" v 
  member x.Name with set (v: string) = x.Attribute "name" v 
  member x.Normalize with set (v: (string -> string -> string array -> string)) = x.Attribute "normalize" v
  member x.Required with set (v: bool) = x.Attribute "required" v 
  member x.ShouldUpdate with set (v: bool) = x.Attribute "shouldUpdate" v  
  member x.Trigger with set (v: string) = x.Attribute "trigger" v 
  member x.ValidationStatus with set (v: FormValidationStatus) = x.Attribute "validationStatus" v 
  member x.ValidateTrigger with set (v: string array) = x.Attribute "validateTrigger" v 
  member x.ValuePropName with set (v: string) = x.Attribute "valuePropName" v 
  member x.WrapperCol with set (v: obj) = x.Attribute "wrapperCol" v 
  member x.Rules with set (rules: FormRule list list) = x.Attribute "rules" (rules |> List.map (fun rule -> keyValueList CaseRules.LowerFirst rule) |> List.toArray)

type FormList() =
  inherit AntElement("Form.List")
  member x.Name with set (v: string) = x.Attribute "name" v
  
type FormProvider() =
  inherit AntElement("Form.Provider")
  member x.OnFormChange with set (v: (string -> obj -> unit)) = x.Attribute "onFormChange" v 
  member x.OnFormFinish with set (v: (string -> obj -> unit)) = x.Attribute "onFormFinish" v 
