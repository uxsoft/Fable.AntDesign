namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<AutoOpen>]
module Modal =
    
    [<RequireQualifiedAccess>]
    type AntModal =
        | AfterClose of (unit -> unit)
        | CancelText of ReactElement
        | Centered of bool
        | Closable of bool
        | CloseIcon of ReactElement
        | ConfirmLoading of bool
        | DestroyOnClose of bool
        | Footer of ReactElement
        | ForceRender of bool
        | GetContainer of (unit -> ReactElement)
        | Mask of bool
        | MaskClosable of bool
        | OkText of ReactElement
        | OkType of string
        | Title of ReactElement
        | Visible of bool
        | Width of int
        | WrapClassName of string
        | ZIndex of int
        | OnCancel of (Event -> unit)
        | OnOk of (Event -> unit)
        static member Custom (key: string, value: obj): AntModal = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntModal = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member BodyStyle (css: Props.CSSProp list): AntModal = unbox ("bodyStyle", keyValueList CaseRules.LowerFirst css)
        static member MaskStyle (css: Props.CSSProp list): AntModal = unbox ("maskStyle", keyValueList CaseRules.LowerFirst css)
        static member OkButtonProps (props: AntButton list): AntModal = unbox ("okButtonProps", keyValueList CaseRules.LowerFirst props)
        static member CancelButtonProps (props: AntButton list): AntModal = unbox ("cancelButtonProps", keyValueList CaseRules.LowerFirst props)

        
    let inline antModal (props: AntAffix list) (children: ReactElement list): ReactElement =
       ofImport "Modal" "antd" (keyValueList CaseRules.LowerFirst props) children
    