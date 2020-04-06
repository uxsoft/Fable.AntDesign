namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

type AntModal() =
    inherit AntElement(ofImport "Modal" "antd")
    member x.AfterClose with set (v: (unit -> unit)) = x.Attribute "afterClose" v 
    member x.CancelText with set (v: ReactElement) = x.Attribute "cancelText" v 
    member x.Centered with set (v: bool) = x.Attribute "centered" v 
    member x.Closable with set (v: bool) = x.Attribute "closable" v 
    member x.CloseIcon with set (v: ReactElement) = x.Attribute "closeIcon" v 
    member x.ConfirmLoading with set (v: bool) = x.Attribute "confirmLoading" v 
    member x.DestroyOnClose with set (v: bool) = x.Attribute "destroyOnClose" v 
    member x.Footer with set (v: ReactElement) = x.Attribute "footer" v 
    member x.ForceRender with set (v: bool) = x.Attribute "forceRender" v 
    member x.GetContainer with set (v: (unit -> ReactElement)) = x.Attribute "getContainer" v 
    member x.Mask with set (v: bool) = x.Attribute "mask" v 
    member x.MaskClosable with set (v: bool) = x.Attribute "maskClosable" v 
    member x.OkText with set (v: ReactElement) = x.Attribute "okText" v 
    member x.OkType with set (v: string) = x.Attribute "okType" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.Visible with set (v: bool) = x.Attribute "visible" v 
    member x.Width with set (v: string) = x.Attribute "width" v 
    member x.WrapClassName with set (v: string) = x.Attribute "wrapClassName" v 
    member x.ZIndex with set (v: int) = x.Attribute "zIndex" v 
    member x.OnCancel with set (v: (Event -> unit)) = x.Attribute "onCancel" v 
    member x.OnOk with set (v: (Event -> unit)) = x.Attribute "onOk" v 
    member x.BodyStyle (css: Props.CSSProp list) = x.Attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    member x.MaskStyle (css: Props.CSSProp list) = x.Attribute "maskStyle" (keyValueList CaseRules.LowerFirst css)
    member x.OkButtonProps (props: AntButton list) = x.Attribute "okButtonProps" (keyValueList CaseRules.LowerFirst props)
    member x.CancelButtonProps (props: AntButton list) = x.Attribute "cancelButtonProps" (keyValueList CaseRules.LowerFirst props)
