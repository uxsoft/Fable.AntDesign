namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type TimelineMode  = Left | Alternate | Right

[<StringEnum; RequireQualifiedAccess>] type TimelineItemPosition  = Left | Right

type Timeline()  =
  inherit AntElement("Timeline")
  member x.Pending with set (v: bool) = x.Attribute "pending" v
  member x.PendingDot with set (v: ReactElement) = x.Attribute "pendingDot" v 
  member x.Reverse with set (v: bool) = x.Attribute "reverse" v
  member x.Mode with set (v: TimelineMode) = x.Attribute "mode" v  

type TimelineItem()  =
  inherit AntElement("Timeline.Item")
  member x.Color with set (v: string) = x.Attribute "color" v 
  member x.Dot with set (v: ReactElement) = x.Attribute "dot" v 
  member x.Position with set (v: TimelineItemPosition) = x.Attribute "position" v 