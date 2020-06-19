namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type TimelineMode  = Left | Alternate | Right

[<StringEnum; RequireQualifiedAccess>] type TimelineItemPosition  = Left | Right

type AntTimeline()  =
  inherit AntElement(ofImport "Timeline" "antd")
  member x.Pending (v: bool) = x.attribute "pending" v
  member x.PendingDot (v: ReactElement) = x.attribute "pendingDot" v 
  member x.Reverse (v: bool) = x.attribute "reverse" v
  member x.Mode (v: TimelineMode) = x.attribute "mode" v  

type AntTimelineItem()  =
  inherit AntElement(ofImport "Timeline.Item" "antd")
  member x.Color (v: string) = x.attribute "color" v 
  member x.Dot (v: ReactElement) = x.attribute "dot" v 
  member x.Position (v: TimelineItemPosition) = x.attribute "position" v 