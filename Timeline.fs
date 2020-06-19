namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type TimelineMode  = Left | Alternate | Right

[<StringEnum; RequireQualifiedAccess>] type TimelineItemPosition  = Left | Right

type AntTimeline()  =
  inherit AntElement<AntTimeline>(ofImport "Timeline" "antd")
  member x.pending (v: bool) = x.attribute "pending" v
  member x.pendingDot (v: ReactElement) = x.attribute "pendingDot" v 
  member x.reverse (v: bool) = x.attribute "reverse" v
  member x.mode (v: TimelineMode) = x.attribute "mode" v  

type AntTimelineItem()  =
  inherit AntElement<AntTimelineItem>(ofImport "Timeline.Item" "antd")
  member x.color (v: string) = x.attribute "color" v 
  member x.dot (v: ReactElement) = x.attribute "dot" v 
  member x.position (v: TimelineItemPosition) = x.attribute "position" v 