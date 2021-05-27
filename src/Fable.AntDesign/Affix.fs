module Fable.AntDesign.Affix

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type AffixBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Affix" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("offsetBottom")>] member _.offsetBottom (x: DSLElement, v: int) = x.attr "offsetBottom" v 
    [<CustomOperation("offsetTop")>] member _.offsetTop (x: DSLElement, v: int) = x.attr "offsetTop" v 
    [<CustomOperation("target")>] member _.target (x: DSLElement, v: unit -> HTMLElement) = x.attr "target" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: bool -> unit) = x.attr "onChange" v 