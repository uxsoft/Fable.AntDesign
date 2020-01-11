namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

/// import declarations for `InputNumber` and its nested components.
/// For more information, refer to the [official documentation](https://ant.design/components/input-number/)
[<AutoOpen>]
module InputNumber =
    
    [<RequireQualifiedAccess>]   
    type AntInputNumber  =
        /// get focus when component mounted
        | AutoFocus of bool
        /// initial value	
        | DefaultValue of float
        /// disable the input	
        | Disabled of bool
        /// Specifies the format of the value presented
        | Formatter of (float -> string)
        /// max value
        | Max of float
        /// min value	
        | Min of float
        /// Specifies the value extracted from formatter
        | Parser of (string -> float)
        /// precision of input value
        | Precision of float
        /// width of input box
        | Size of Size
        /// The number to which the current value is increased or decreased. 
        /// It can be an integer or decimal.
        | Step of float
        /// current value
        | Value of float
        /// The callback triggered when the value is changed.
        | OnChange of (float -> unit)
        | OnPressEnter of (Event -> unit)
        static member Custom (key: string, value: obj): AntInputNumber = unbox(key, value)
        static member Style (css: Props.CSSProp list): AntInputNumber = unbox ("style", keyValueList CaseRules.LowerFirst css)

     let inline antInputNumber (props: AntInputNumber list) (children: ReactElement list): ReactElement =
       ofImport "InputNumber" "antd" (keyValueList CaseRules.LowerFirst props) children