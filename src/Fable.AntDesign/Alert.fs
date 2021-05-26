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

    [<CustomOperation("action")>] member _.action (x: DSLElement, v: ReactElement) = x.attr "action" v
    [<CustomOperation("afterClose")>] member _.afterClose (x: DSLElement, v: (unit -> unit)) = x.attr "afterClose" v
    [<CustomOperation("banner")>] member _.banner (x: DSLElement) = x.attr "banner" true
    [<CustomOperation("closable")>] member _.closable (x: DSLElement) = x.attr "closable" true
    [<CustomOperation("closeText")>] member _.closeText (x: DSLElement, v: ReactElement) = x.attr "closeText" v
    [<CustomOperation("description")>] member _.description (x: DSLElement, v: ReactElement) = x.attr "description" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("message")>] member _.message (x: DSLElement, v: ReactElement) = x.attr "message" v
    [<CustomOperation("showIcon")>] member _.showIcon (x: DSLElement) = x.attr "showIcon" true
    [<CustomOperation("alertType")>] member _.alertType (x: DSLElement, v: AlertType) = x.attr "type" v
    [<CustomOperation("onClose")>] member _.onClose (x: DSLElement, v: (Event -> unit)) = x.attr "onClose" v

type AlertErrorBoundaryBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Alert.ErrorBoundary" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("description")>] member _.description (x: DSLElement, v: ReactElement) = x.attr "description" v
    [<CustomOperation("message")>] member _.message (x: DSLElement, v: ReactElement) = x.attr "message" v