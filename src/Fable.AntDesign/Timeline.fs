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

    [<CustomOperation("pending")>] member inline _.pending (x: DSLElement, v: bool) = x.attr "pending" v
    [<CustomOperation("pendingDot")>] member inline _.pendingDot (x: DSLElement, v: ReactElement) = x.attr "pendingDot" v 
    [<CustomOperation("reverse")>] member inline _.reverse (x: DSLElement, v: bool) = x.attr "reverse" v
    [<CustomOperation("mode")>] member inline _.mode (x: DSLElement, v: TimelineMode) = x.attr "mode" v  

type TimelineItemBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Timeline.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("color")>] member inline _.color (x: DSLElement, v: string) = x.attr "color" v 
    [<CustomOperation("dot")>] member inline _.dot (x: DSLElement, v: ReactElement) = x.attr "dot" v 
    [<CustomOperation("position")>] member inline _.position (x: DSLElement, v: TimelineItemPosition) = x.attr "position" v
    [<CustomOperation("label")>] member inline _.label (x: DSLElement, v: ReactElement) = x.attr "label" v 