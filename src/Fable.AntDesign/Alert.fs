module Fable.AntDesign.Alert

open Fable.AntDesign.Common
open Fable.Core
open Browser.Types
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>] type AlertType = Success | Info | Warning | Error

type AlertBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Alert" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("action")>] member inline _.action (x: DSLElement, v: ReactElement) = x.attr "action" v
    [<CustomOperation("afterClose")>] member inline _.afterClose (x: DSLElement, v: (unit -> unit)) = x.attr "afterClose" v
    [<CustomOperation("banner")>] member inline _.banner (x: DSLElement, v: bool) = x.attr "banner" v
    [<CustomOperation("closable")>] member inline _.closable (x: DSLElement, v: bool) = x.attr "closable" v
    [<CustomOperation("closeText")>] member inline _.closeText (x: DSLElement, v: ReactElement) = x.attr "closeText" v
    [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: ReactElement) = x.attr "description" v
    [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("message")>] member inline _.message (x: DSLElement, v: ReactElement) = x.attr "message" v
    [<CustomOperation("showIcon")>] member inline _.showIcon (x: DSLElement, v: bool) = x.attr "showIcon" v
    [<CustomOperation("alertType")>] member inline _.alertType (x: DSLElement, v: AlertType) = x.attr "type" v
    [<CustomOperation("onClose")>] member inline _.onClose (x: DSLElement, v: (Event -> unit)) = x.attr "onClose" v

type AlertErrorBoundaryBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Alert.ErrorBoundary" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: ReactElement) = x.attr "description" v
    [<CustomOperation("message")>] member inline _.message (x: DSLElement, v: ReactElement) = x.attr "message" v