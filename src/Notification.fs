namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

[<AutoOpen>]
module AntNotification =
    [<StringEnum; RequireQualifiedAccess>]
    type NotificationPlacement =
        | TopLeft | TopRight | BottomLeft | BottomRight
    
    type AntNotification(message: ReactElement, description: ReactElement) as this =
        inherit AntObject<AntNotification>()
        do
            this.attribute "message" message |> ignore
            this.attribute "description" description |> ignore
        
        member x.bottom (v: int) = x.attribute "bottom" v
        member x.btn (v: ReactElement) = x.attribute "btn" v
        member x.className (v: string) = x.attribute "className" v
        member x.duration (v: float) = x.attribute "duration" v
        member x.getContainer (v: unit -> HTMLElement) = x.attribute "getContainer" v
        member x.icon (v: ReactElement) = x.attribute "icon" v
        member x.closeIcon (v: ReactElement) = x.attribute "closeIcon" v
        member x.key (v: string) = x.attribute "key" v 
        member x.onClose (v: unit -> unit) = x.attribute "onClose" v
        member x.onClick (v: unit -> unit) = x.attribute "onClick" v
        member x.placement (v: NotificationPlacement) = x.attribute "placement" v
        member x.style (css: CSSProp list) = x.attribute "style" (keyValueList CaseRules.LowerFirst css)
        member x.top (v: int) = x.attribute "top" v
        
    
    type IAntNotification =
        abstract success: obj -> unit
        abstract error: obj -> unit
        abstract info: obj -> unit
        abstract warning: obj -> unit
        abstract ``open``: obj -> unit
        abstract close: string -> unit
        abstract destroy: unit -> unit
    
    [<Import("notification", "antd")>]
    let notification : IAntNotification = jsNative