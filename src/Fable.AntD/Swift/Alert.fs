namespace Fable.AntD

open Fable.Core
open Browser.Types
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type AlertType = Success | Info | Warning | Error

type AntAlert()  =
    inherit AntElement<AntAlert>(ofImport "Alert" "antd")
    member x.action (v: ReactElement) = x.attribute "action" v
    member x.afterClose (v: (unit -> unit)) = x.attribute "afterClose" v
    member x.banner (?v: bool) = x.attribute "banner" (Option.defaultValue true v)
    member x.closable (?v: bool) = x.attribute "closable" (Option.defaultValue true v)
    member x.closeText (v: ReactElement) = x.attribute "closeText" v
    member x.description (v: ReactElement) = x.attribute "description" v
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.message (v: ReactElement) = x.attribute "message" v
    member x.showIcon (?v: bool) = x.attribute "showIcon" (Option.defaultValue true v)
    member x.alertType (v: AlertType) = x.attribute "type" v
    member x.onClose (v: (Event -> unit)) = x.attribute "onClose" v

type AntAlertErrorBoundary()  =
    inherit AntElement<AntAlertErrorBoundary>(ofImport "Alert.ErrorBoundary" "antd")
    member x.description (v: ReactElement) = x.attribute "description" v
    member x.message (v: ReactElement) = x.attribute "message" v