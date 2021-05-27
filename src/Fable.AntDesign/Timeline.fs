module Fable.AntDesign.Timeline

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type TimelineMode  = Left | Alternate | Right

[<StringEnum; RequireQualifiedAccess>] type TimelineItemPosition  = Left | Right

type TimelineBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Timeline" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("pending")>] member _.pending (x: DSLElement, v: bool) = x.attr "pending" v
    [<CustomOperation("pendingDot")>] member _.pendingDot (x: DSLElement, v: ReactElement) = x.attr "pendingDot" v 
    [<CustomOperation("reverse")>] member _.reverse (x: DSLElement, v: bool) = x.attr "reverse" v
    [<CustomOperation("mode")>] member _.mode (x: DSLElement, v: TimelineMode) = x.attr "mode" v  

type TimelineItemBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Timeline.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("color")>] member _.color (x: DSLElement, v: string) = x.attr "color" v 
    [<CustomOperation("dot")>] member _.dot (x: DSLElement, v: ReactElement) = x.attr "dot" v 
    [<CustomOperation("position")>] member _.position (x: DSLElement, v: TimelineItemPosition) = x.attr "position" v
    [<CustomOperation("label")>] member _.label (x: DSLElement, v: ReactElement) = x.attr "label" v 