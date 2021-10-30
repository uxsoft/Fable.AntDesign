namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

[<AutoOpen>]
module Notification =

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
    
        [<CustomOperation("bottom")>] member inline _.bottom (x: DSLElement, v: int) = x.attr "bottom" v
        [<CustomOperation("btn")>] member inline _.btn (x: DSLElement, v: ReactElement) = x.attr "btn" v
        [<CustomOperation("duration")>] member inline _.duration (x: DSLElement, v: float) = x.attr "duration" v
        [<CustomOperation("getContainer")>] member inline _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("closeIcon")>] member inline _.closeIcon (x: DSLElement, v: ReactElement) = x.attr "closeIcon" v
        [<CustomOperation("key")>] member inline _.key (x: DSLElement, v: string) = x.attr "key" v 
        [<CustomOperation("onClose")>] member inline _.onClose (x: DSLElement, v: unit -> unit) = x.attr "onClose" v
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: unit -> unit) = x.attr "onClick" v
        [<CustomOperation("placement")>] member inline _.placement (x: DSLElement, v: NotificationPlacement) = x.attr "placement" v
        [<CustomOperation("top")>] member inline _.top (x: DSLElement, v: int) = x.attr "top" v
        [<CustomOperation("kind")>] member inline _.kind (x: DSLElement, v: NotificationKind) = x.attr "kind" v
        [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: string) = x.attr "description" v
        [<CustomOperation("message")>] member inline _.message (x: DSLElement, v: string) = x.attr "message" v
    