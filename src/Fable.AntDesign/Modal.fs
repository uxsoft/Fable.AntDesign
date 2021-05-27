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
    [<CustomOperation("centered")>] member _.centered (x: DSLElement, v: bool) = x.attr "centered" v
    [<CustomOperation("closable")>] member _.closable (x: DSLElement, v: bool) = x.attr "closable" v
    [<CustomOperation("closeIcon")>] member _.closeIcon (x: DSLElement, v: ReactElement) = x.attr "closeIcon" v 
    [<CustomOperation("confirmLoading")>] member _.confirmLoading (x: DSLElement, v: bool) = x.attr "confirmLoading" v
    [<CustomOperation("destroyOnClose")>] member _.destroyOnClose (x: DSLElement, v: bool) = x.attr "destroyOnClose" v
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
    [<CustomOperation("forceRender")>] member _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v
    [<CustomOperation("focusTriggerAfterClose")>] member _.focusTriggerAfterClose (x: DSLElement, v: bool) = x.attr "focusTriggerAfterClose" v
    [<CustomOperation("getContainer")>] member _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v
    [<CustomOperation("keyboard")>] member _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v
    [<CustomOperation("mask")>] member _.mask (x: DSLElement, v: bool) = x.attr "mask" v 
    [<CustomOperation("maskClosable")>] member _.maskClosable (x: DSLElement, v: bool) = x.attr "maskClosable" v 
    [<CustomOperation("maskStyle")>] member _.maskStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "maskStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("modalRender")>] member _.modalRender (x: DSLElement, v: Func<ReactElement, ReactElement>) = x.attr "modalRender" v
    [<CustomOperation("okButtonProps")>] member _.okButtonProps (x: DSLElement, v: ButtonProp list) = x.attr "okButtonProps" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("okText")>] member _.okText (x: DSLElement, v: ReactElement) = x.attr "okText" v 
    [<CustomOperation("okType")>] member _.okType (x: DSLElement, v: string) = x.attr "okType" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("visible")>] member _.visible (x: DSLElement, v: bool) = x.attr "visible" v 
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v 
    [<CustomOperation("wrapClassName")>] member _.wrapClassName (x: DSLElement, v: string) = x.attr "wrapClassName" v 
    [<CustomOperation("zIndex")>] member _.zIndex (x: DSLElement, v: int) = x.attr "zIndex" v 
    [<CustomOperation("onCancel")>] member _.onCancel (x: DSLElement, v: Event -> unit) = x.attr "onCancel" v 
    [<CustomOperation("onOk")>] member _.onOk (x: DSLElement, v: Event -> unit) = x.attr "onOk" v