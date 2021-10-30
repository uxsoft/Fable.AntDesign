namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module BackTop =

    type BackTopBuilder() =
        inherit ReactBuilder(import "BackTop" "antd")
        
        [<CustomOperation("target")>] member inline _.target (x: DSLElement, v: unit -> HTMLElement) = x.attr "target" v 
        [<CustomOperation("visibilityHeight")>] member inline _.visibilityHeight (x: DSLElement, v: int) = x.attr "visibilityHeight" v 
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: unit -> unit) = x.attr "onClick" v 