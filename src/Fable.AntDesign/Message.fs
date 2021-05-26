module Fable.AntDesign.Message

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

type private IAntMessage =
    abstract success: obj -> unit
    abstract error: obj -> unit
    abstract info: obj -> unit
    abstract warning: obj -> unit
    abstract loading: obj -> unit

[<Import("message", "antd")>]
let private message : IAntMessage = jsNative

[<RequireQualifiedAccess>]
type MessageKind = | Success | Error | Info | Warning | Loading

type MessageBuilder() =
    inherit ReactBuilder()
    
    member x.Run(s: DSLElement) =
        let json = (createObj s.Attributes)
        let kind = 
            s.Attributes 
            |> List.tryFind (fun (k, _) -> k = "kind") 
            |> Option.map (fun (_, v) -> v :?> MessageKind)
            |> Option.defaultValue MessageKind.Info

        match kind with
        | MessageKind.Success -> message.success json
        | MessageKind.Error -> message.error json
        | MessageKind.Info -> message.info json
        | MessageKind.Warning -> message.warning json
        | MessageKind.Loading -> message.loading json
    
    [<CustomOperation("content")>] member _.content (x: DSLElement, v: ReactElement) = x.attr "content" v
    [<CustomOperation("duration")>] member _.duration (x: DSLElement, v: float) = x.attr "duration" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("key")>] member _.key (x: DSLElement, v: string) = x.attr "key" v 
    [<CustomOperation("onClose")>] member _.onClose (x: DSLElement, v: unit -> unit) = x.attr "onClose" v
    [<CustomOperation("kind")>] member _.kind (x: DSLElement, v: MessageKind) = x.attr "kind" v
