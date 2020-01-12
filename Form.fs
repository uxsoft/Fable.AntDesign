namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Browser.Types
open Fable.Core.JS

/// import declarations for `Form` and its nested components.
/// For more information, refer to the [official documentation](https://ant.design/components/form/)
[<AutoOpen>]
module Form =

    importSideEffects "regenerator-runtime/runtime"

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ValidationStatus = Success | Warning | Error | Validating

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntFormLabelAlign = Left | Right
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntFormRuleType = String | Number | Boolean | Method | Regexp | Integer | Float | Array | Object | Enum | Date | Url | Hex | Email | Any
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type FormLayout = Horizontal | Vertical | Inline
    
    type AntFormFieldData = {
        touched: bool
        validating: bool
        errors: string array
        name: string array
        value: string
    }
    
    [<RequireQualifiedAccess>]
    type AntFormRule = 
        | Enum of string array
        | Len of int
        | Max of int
        | Message of string
        | Min of int
        | Pattern of string
        | Required of bool
        | Transform of (string -> string)
        | Type of string
        | Validator of (AntFormRule -> string -> Promise<string>)
        | Whitespace of bool
        | ValidateTrigger of string array
    
    [<RequireQualifiedAccess>]
    type AntForm =
      | Component of ReactElement
      | Colon of bool
      | Fields of AntFormFieldData array
      | Form of ReactElement
      | HideRequiredMark of bool
      | InitialValues of obj
      | LabelAlign of AntFormLabelAlign
      | LabelCol of obj
      | Layout of FormLayout
      | Name of string
      | Size of Common.Size
      | ValidateMessages of obj
      | WrapperCol of obj
      | OnFinish of (string array -> unit)
      | OnFinishFailed of (obj -> unit)
      | OnFieldsChange of (string array -> string array -> unit)
      | OnValuesChange of (string array -> string array -> unit)
      static member Custom (key: string, value: obj): AntForm = unbox (key, value)
      static member Style (css: Props.CSSProp list): AntForm = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    [<RequireQualifiedAccess>]
    type AntFormItem =
      | Key of string
      | Colon of bool
      | Dependencies of string array
      | Extra of ReactElement
      | HasFeedback of bool
      | Help of ReactElement
      | HtmlFor of string
      | NoStyle of bool
      | Label of ReactElement
      | LabelAlign of AntFormLabelAlign
      | LabelCol of obj
      | Name of string
      | Normalize of (string -> string -> string array -> string)
      | Required of bool
      | ShouldUpdate of bool 
      | Trigger of string
      | ValidationStatus of ValidationStatus
      | ValidateTrigger of string array
      | ValuePropName of string
      | WrapperCol of obj
      static member Custom (key: string, value: obj): AntFormItem = unbox (key, value)
      static member Style (css: Props.CSSProp list): AntFormItem = unbox ("style", keyValueList CaseRules.LowerFirst css)
      /// Don't forget to give the item a name otherwise it won't validate
      static member Rules (rules: AntFormRule list list): AntFormItem = unbox ("rules", rules |> List.map (fun rule -> keyValueList CaseRules.LowerFirst rule) |> List.toArray)

    [<RequireQualifiedAccess>]
    type AntFormList =
      | Name of string
      static member Custom (key: string, value: obj): AntFormList = unbox (key, value)
      static member Style (css: Props.CSSProp list): AntFormList = unbox ("style", keyValueList CaseRules.LowerFirst css)
      
    [<RequireQualifiedAccess>]
    type AntFormProvider =
      | OnFormChange of (string -> obj -> unit)
      | OnFormFinish of (string -> obj -> unit)
      static member Custom (key: string, value: obj): AntFormProvider = unbox (key, value)
      static member Style (css: Props.CSSProp list): AntFormProvider = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antForm (props: AntForm list) (children: ReactElement list): ReactElement =
       ofImport "Form" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    let inline antFormItem (props: AntFormItem list) (children: ReactElement list): ReactElement =
       ofImport "Form.Item" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antFormList (props: AntFormList list) (children: ReactElement list): ReactElement =
       ofImport "Form.List" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antFormProvider (props: AntFormProvider list) (children: ReactElement list): ReactElement =
       ofImport "Form.Provider" "antd" (keyValueList CaseRules.LowerFirst props) children