namespace Fable.Builders.AntDesign

open System
open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser.Types

[<AutoOpen>]
module Modal =

    type ModalBuilder() =
        inherit ReactBuilder(import "Modal" "antd")
    
        [<CustomOperation("afterClose")>] member inline _.afterClose (x: DSLElement, v: unit -> unit) = x.attr "afterClose" v
        [<CustomOperation("bodyStyle")>] member inline _.bodyStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "bodyStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("cancelButtonProps")>] member inline _.cancelButtonProps (x: DSLElement, v: ButtonProp list) = x.attr "cancelButtonProps" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("cancelText")>] member inline _.cancelText (x: DSLElement, v: ReactElement) = x.attr "cancelText" v
        [<CustomOperation("centered")>] member inline _.centered (x: DSLElement, v: bool) = x.attr "centered" v
        [<CustomOperation("closable")>] member inline _.closable (x: DSLElement, v: bool) = x.attr "closable" v
        [<CustomOperation("closeIcon")>] member inline _.closeIcon (x: DSLElement, v: ReactElement) = x.attr "closeIcon" v 
        [<CustomOperation("confirmLoading")>] member inline _.confirmLoading (x: DSLElement, v: bool) = x.attr "confirmLoading" v
        [<CustomOperation("destroyOnClose")>] member inline _.destroyOnClose (x: DSLElement, v: bool) = x.attr "destroyOnClose" v
        [<CustomOperation("footer")>] member inline _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
        [<CustomOperation("forceRender")>] member inline _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v
        [<CustomOperation("focusTriggerAfterClose")>] member inline _.focusTriggerAfterClose (x: DSLElement, v: bool) = x.attr "focusTriggerAfterClose" v
        [<CustomOperation("getContainer")>] member inline _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v
        [<CustomOperation("keyboard")>] member inline _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v
        [<CustomOperation("mask")>] member inline _.mask (x: DSLElement, v: bool) = x.attr "mask" v 
        [<CustomOperation("maskClosable")>] member inline _.maskClosable (x: DSLElement, v: bool) = x.attr "maskClosable" v 
        [<CustomOperation("maskStyle")>] member inline _.maskStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "maskStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("modalRender")>] member inline _.modalRender (x: DSLElement, v: Func<ReactElement, ReactElement>) = x.attr "modalRender" v
        [<CustomOperation("okButtonProps")>] member inline _.okButtonProps (x: DSLElement, v: ButtonProp list) = x.attr "okButtonProps" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("okText")>] member inline _.okText (x: DSLElement, v: ReactElement) = x.attr "okText" v 
        [<CustomOperation("okType")>] member inline _.okType (x: DSLElement, v: string) = x.attr "okType" v 
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
        [<CustomOperation("visible")>] member inline _.visible (x: DSLElement, v: bool) = x.attr "visible" v 
        [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: string) = x.attr "width" v 
        [<CustomOperation("wrapClassName")>] member inline _.wrapClassName (x: DSLElement, v: string) = x.attr "wrapClassName" v 
        [<CustomOperation("zIndex")>] member inline _.zIndex (x: DSLElement, v: int) = x.attr "zIndex" v 
        [<CustomOperation("onCancel")>] member inline _.onCancel (x: DSLElement, v: Event -> unit) = x.attr "onCancel" v 
        [<CustomOperation("onOk")>] member inline _.onOk (x: DSLElement, v: Event -> unit) = x.attr "onOk" v