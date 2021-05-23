namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

[<AutoOpen>]
module AntMessage =
    type private IAntMessage =
        abstract success: obj -> unit
        abstract error: obj -> unit
        abstract info: obj -> unit
        abstract warning: obj -> unit
        abstract loading: obj -> unit
    
    [<Import("message", "antd")>]
    let private message : IAntMessage = jsNative
    
    [<RequireQualifiedAccess>]
    type MessageType = | Success | Error | Info | Warning | Loading
    
    type AntMessage(content: ReactElement) as this =
        inherit AntObject<AntMessage>()
        do this.attribute "content" content |> ignore
        
        member x.className (v: string) = x.attribute "className" v
        member x.duration (v: float) = x.attribute "duration" v
        member x.icon (v: ReactElement) = x.attribute "icon" v
        member x.key (v: string) = x.attribute "key" v 
        member x.onClose (v: unit -> unit) = x.attribute "onClose" v
        member x.style (css: CSSProp list) = x.attribute "style" (keyValueList CaseRules.LowerFirst css)
    
        member x.show (messageType: MessageType) =
            match messageType with
            | MessageType.Success -> message.success x.JSON
            | MessageType.Error -> message.error x.JSON
            | MessageType.Info -> message.info x.JSON
            | MessageType.Warning -> message.warning x.JSON
            | MessageType.Loading -> message.loading x.JSON