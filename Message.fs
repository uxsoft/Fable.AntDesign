namespace Fable.AntD

open Fable.Core
open Fable.React

[<AutoOpen>]
module Message =
    
    type IAntMessage =
        abstract success: ReactElement -> int -> (unit -> unit) -> unit
        abstract error: ReactElement -> int -> (unit -> unit) -> unit
        abstract info: ReactElement -> int -> (unit -> unit) -> unit
        abstract warning: ReactElement -> int -> (unit -> unit) -> unit
        abstract loading: ReactElement -> int -> (unit -> unit) -> unit
    
    [<Import("message", "antd")>]
    let Message : IAntMessage = jsNative