namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

type AntModal() =
    inherit AntElement(ofImport "Modal" "antd")
    member x.AfterClose (v: (unit -> unit)) = x.attribute "afterClose" v 
    member x.CancelText (v: ReactElement) = x.attribute "cancelText" v 
    member x.Centered (v: bool) = x.attribute "centered" v 
    member x.Closable (v: bool) = x.attribute "closable" v 
    member x.CloseIcon (v: ReactElement) = x.attribute "closeIcon" v 
    member x.ConfirmLoading (v: bool) = x.attribute "confirmLoading" v 
    member x.DestroyOnClose (v: bool) = x.attribute "destroyOnClose" v 
    member x.Footer (v: ReactElement) = x.attribute "footer" v 
    member x.ForceRender (v: bool) = x.attribute "forceRender" v 
    member x.GetContainer (v: (unit -> ReactElement)) = x.attribute "getContainer" v 
    member x.Mask (v: bool) = x.attribute "mask" v 
    member x.MaskClosable (v: bool) = x.attribute "maskClosable" v 
    member x.OkText (v: ReactElement) = x.attribute "okText" v 
    member x.OkType (v: string) = x.attribute "okType" v 
    member x.Title (v: ReactElement) = x.attribute "title" v 
    member x.Visible (v: bool) = x.attribute "visible" v 
    member x.Width (v: string) = x.attribute "width" v 
    member x.WrapClassName (v: string) = x.attribute "wrapClassName" v 
    member x.ZIndex (v: int) = x.attribute "zIndex" v 
    member x.OnCancel (v: (Event -> unit)) = x.attribute "onCancel" v 
    member x.OnOk (v: (Event -> unit)) = x.attribute "onOk" v 
    member x.BodyStyle (css: Props.CSSProp list) = x.attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    member x.MaskStyle (css: Props.CSSProp list) = x.attribute "maskStyle" (keyValueList CaseRules.LowerFirst css)
    member x.OkButtonProps (props: AntButton list) = x.attribute "okButtonProps" (keyValueList CaseRules.LowerFirst props)
    member x.CancelButtonProps (props: AntButton list) = x.attribute "cancelButtonProps" (keyValueList CaseRules.LowerFirst props)
