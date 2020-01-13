namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Message =
    
    type IAntNotification =
        abstract success: obj -> unit
        abstract error: obj -> unit
        abstract info: obj -> unit
        abstract warning: obj -> unit
        abstract ``open``: obj -> unit
        abstract close: string -> unit
        abstract destroy: unit -> unit
    
    [<Import("notification", "antd")>]
    let antNotification : IAntNotification = jsNative