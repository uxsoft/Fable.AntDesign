namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Timeline =

    [<StringEnum; RequireQualifiedAccess>] type TimelineMode  = Left | Alternate | Right
    
    [<StringEnum; RequireQualifiedAccess>] type TimelineItemPosition  = Left | Right
    
    type TimelineBuilder()  =
        inherit ReactBuilder(import "Timeline" "antd")
    
        [<CustomOperation("pending")>] member inline _.pending (x: DSLElement, v: bool) = x.attr "pending" v
        [<CustomOperation("pendingDot")>] member inline _.pendingDot (x: DSLElement, v: ReactElement) = x.attr "pendingDot" v 
        [<CustomOperation("reverse")>] member inline _.reverse (x: DSLElement, v: bool) = x.attr "reverse" v
        [<CustomOperation("mode")>] member inline _.mode (x: DSLElement, v: TimelineMode) = x.attr "mode" v  
    
    type TimelineItemBuilder()  =
        inherit ReactBuilder(import "Timeline.Item" "antd")
    
        [<CustomOperation("color")>] member inline _.color (x: DSLElement, v: string) = x.attr "color" v 
        [<CustomOperation("dot")>] member inline _.dot (x: DSLElement, v: ReactElement) = x.attr "dot" v 
        [<CustomOperation("position")>] member inline _.position (x: DSLElement, v: TimelineItemPosition) = x.attr "position" v
        [<CustomOperation("label")>] member inline _.label (x: DSLElement, v: ReactElement) = x.attr "label" v 