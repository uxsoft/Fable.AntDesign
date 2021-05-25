module Fable.AntDesign.Anchor

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type AnchorBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Anchor" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("affix")>] member _.affix (x: DSLElement) = x.attr "affix" true
    [<CustomOperation("bounds")>] member _.bounds (x: DSLElement, v: int) = x.attr "bounds" v 
    [<CustomOperation("getContainer")>] member _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v 
    [<CustomOperation("offsetBottom")>] member _.offsetBottom (x: DSLElement, v: int) = x.attr "offsetBottom" v 
    [<CustomOperation("offsetTop")>] member _.offsetTop (x: DSLElement, v: int) = x.attr "offsetTop" v 
    [<CustomOperation("showInkInFixed")>] member _.showInkInFixed (x: DSLElement) = x.attr "showInkInFixed" true
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: Event -> obj -> unit) = x.attr "onClick" v 
    [<CustomOperation("getCurrentAnchor")>] member _.getCurrentAnchor (x: DSLElement, v: unit -> string) = x.attr "getCurrentAnchor" v 
    [<CustomOperation("targetOffset")>] member _.targetOffset (x: DSLElement, v: int) = x.attr "targetOffset" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v 
   
type AnchorLinkBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Anchor.Link" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("href")>] member _.href (x: DSLElement, v: string) = x.attr "href" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("target")>] member _.target (x: DSLElement, v: string) = x.attr "target" v 