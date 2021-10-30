namespace Fable.Builders.AntDesign 

open Browser.Types
open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Affix =

    type AffixBuilder() =
        inherit ReactBuilder(import "Affix" "antd")
    
        [<CustomOperation("offsetBottom")>] member inline _.offsetBottom (x: DSLElement, v: int) = x.attr "offsetBottom" v 
        [<CustomOperation("offsetTop")>] member inline _.offsetTop (x: DSLElement, v: int) = x.attr "offsetTop" v 
        [<CustomOperation("target")>] member inline _.target (x: DSLElement, v: unit -> HTMLElement) = x.attr "target" v 
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: bool -> unit) = x.attr "onChange" v 