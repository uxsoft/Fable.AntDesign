module Fable.AntDesign.Modal

open System
open Fable.AntDesign.Button
open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

type ModalBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Modal" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("afterClose")>] member _.afterClose (x: DSLElement, v: unit -> unit) = x.attr "afterClose" v
    [<CustomOperation("bodyStyle")>] member _.bodyStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("cancelButtonProps")>] member _.cancelButtonProps (x: DSLElement, v: ButtonProp list) = x.attr "cancelButtonProps" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("cancelText")>] member _.cancelText (x: DSLElement, v: ReactElement) = x.attr "cancelText" v
    [<CustomOperation("centered")>] member _.centered (x: DSLElement) = x.attr "centered" true
    [<CustomOperation("closable")>] member _.closable (x: DSLElement) = x.attr "closable" true
    [<CustomOperation("closeIcon")>] member _.closeIcon (x: DSLElement, v: ReactElement) = x.attr "closeIcon" v 
    [<CustomOperation("confirmLoading")>] member _.confirmLoading (x: DSLElement) = x.attr "confirmLoading" true
    [<CustomOperation("destroyOnClose")>] member _.destroyOnClose (x: DSLElement) = x.attr "destroyOnClose" true
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
    [<CustomOperation("forceRender")>] member _.forceRender (x: DSLElement) = x.attr "forceRender" true
    [<CustomOperation("focusTriggerAfterClose")>] member _.focusTriggerAfterClose (x: DSLElement) = x.attr "focusTriggerAfterClose" true
    [<CustomOperation("getContainer")>] member _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v
    [<CustomOperation("keyboard")>] member _.keyboard (x: DSLElement) = x.attr "keyboard" true
    [<CustomOperation("mask")>] member _.mask (x: DSLElement) = x.attr "mask" true 
    [<CustomOperation("maskClosable")>] member _.maskClosable (x: DSLElement) = x.attr "maskClosable" true 
    [<CustomOperation("maskStyle")>] member _.maskStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "maskStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("modalRender")>] member _.modalRender (x: DSLElement, v: Func<ReactElement, ReactElement>) = x.attr "modalRender" v
    [<CustomOperation("okButtonProps")>] member _.okButtonProps (x: DSLElement, v: ButtonProp list) = x.attr "okButtonProps" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("okText")>] member _.okText (x: DSLElement, v: ReactElement) = x.attr "okText" v 
    [<CustomOperation("okType")>] member _.okType (x: DSLElement, v: string) = x.attr "okType" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("visible")>] member _.visible (x: DSLElement) = x.attr "visible" true 
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v 
    [<CustomOperation("wrapClassName")>] member _.wrapClassName (x: DSLElement, v: string) = x.attr "wrapClassName" v 
    [<CustomOperation("zIndex")>] member _.zIndex (x: DSLElement, v: int) = x.attr "zIndex" v 
    [<CustomOperation("onCancel")>] member _.onCancel (x: DSLElement, v: Event -> unit) = x.attr "onCancel" v 
    [<CustomOperation("onOk")>] member _.onOk (x: DSLElement, v: Event -> unit) = x.attr "onOk" v