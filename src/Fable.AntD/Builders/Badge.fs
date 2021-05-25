module Fable.AntD.Builders.Badge

open Fable.AntD.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type BadgeStatus = Success | Processing | Default | Error | Warning

type BadgeBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Badge" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("color")>] member _.color (x: DSLElement, v: string) = x.attr "color" v 
    [<CustomOperation("count")>] member _.count (x: DSLElement, v: ReactElement) = x.attr "count" v 
    [<CustomOperation("dot")>] member _.dot (x: DSLElement) = x.attr "dot" true
    [<CustomOperation("offset")>] member _.offset (x: DSLElement, v: float array) = x.attr "offset" v 
    [<CustomOperation("overflowCount")>] member _.overflowCount (x: DSLElement, v: int) = x.attr "overflowCount" v 
    [<CustomOperation("showZero")>] member _.showZero (x: DSLElement) = x.attr "showZero" true 
    [<CustomOperation("status")>] member _.status (x: DSLElement, v: BadgeStatus) = x.attr "status" v 
    [<CustomOperation("text")>] member _.text (x: DSLElement, v: string) = x.attr "text" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: string) = x.attr "title" v