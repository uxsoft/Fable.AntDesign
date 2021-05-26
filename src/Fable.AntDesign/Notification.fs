module Fable.AntDesign.Notification

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

type private IAntNotification =
    abstract success: obj -> unit
    abstract error: obj -> unit
    abstract info: obj -> unit
    abstract warning: obj -> unit
    abstract ``open``: obj -> unit
    abstract close: string -> unit
    abstract destroy: unit -> unit

[<Import("notification", "antd")>]
let private notification : IAntNotification = jsNative

[<RequireQualifiedAccess>]
type NotificationKind = | Success | Error | Info | Warning | Default

[<StringEnum; RequireQualifiedAccess>]
type NotificationPlacement = | TopLeft | TopRight | BottomLeft | BottomRight

type NotificationBuilder() =
    inherit ReactBuilder()
    
    member x.Run(s: DSLElement) =
        let json = (createObj s.Attributes)
        let kind = 
            s.Attributes 
            |> List.tryFind (fun (k, _) -> k = "kind") 
            |> Option.map (fun (_, v) -> v :?> NotificationKind)
            |> Option.defaultValue NotificationKind.Default

        match kind with
        | NotificationKind.Success -> notification.success json
        | NotificationKind.Error -> notification.error json
        | NotificationKind.Info -> notification.info json
        | NotificationKind.Warning -> notification.warning json
        | _ -> notification.``open`` json

    [<CustomOperation("bottom")>] member _.bottom (x: DSLElement, v: int) = x.attr "bottom" v
    [<CustomOperation("btn")>] member _.btn (x: DSLElement, v: ReactElement) = x.attr "btn" v
    [<CustomOperation("duration")>] member _.duration (x: DSLElement, v: float) = x.attr "duration" v
    [<CustomOperation("getContainer")>] member _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("closeIcon")>] member _.closeIcon (x: DSLElement, v: ReactElement) = x.attr "closeIcon" v
    [<CustomOperation("key")>] member _.key (x: DSLElement, v: string) = x.attr "key" v 
    [<CustomOperation("onClose")>] member _.onClose (x: DSLElement, v: unit -> unit) = x.attr "onClose" v
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: unit -> unit) = x.attr "onClick" v
    [<CustomOperation("placement")>] member _.placement (x: DSLElement, v: NotificationPlacement) = x.attr "placement" v
    [<CustomOperation("top")>] member _.top (x: DSLElement, v: int) = x.attr "top" v
    [<CustomOperation("kind")>] member _.kind (x: DSLElement, v: NotificationKind) = x.attr "kind" v
    [<CustomOperation("description")>] member _.description (x: DSLElement, v: string) = x.attr "description" v
    [<CustomOperation("message")>] member _.message (x: DSLElement, v: string) = x.attr "message" v
