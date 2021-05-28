module Fable.AntDesign.BackTop

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type BackTopBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "BackTop" "antd" (createObj s.Attributes) s.Children
    
    [<CustomOperation("target")>] member inline _.target (x: DSLElement, v: unit -> HTMLElement) = x.attr "target" v 
    [<CustomOperation("visibilityHeight")>] member inline _.visibilityHeight (x: DSLElement, v: int) = x.attr "visibilityHeight" v 
    [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: unit -> unit) = x.attr "onClick" v 