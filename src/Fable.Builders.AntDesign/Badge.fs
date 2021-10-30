namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Badge =

    [<StringEnum; RequireQualifiedAccess>]
    type BadgeStatus = Success | Processing | Default | Error | Warning
    
    type BadgeBuilder() =
        inherit ReactBuilder(import "Badge" "antd")
    
        [<CustomOperation("color")>] member inline _.color (x: DSLElement, v: string) = x.attr "color" v 
        [<CustomOperation("count")>] member inline _.count (x: DSLElement, v: ReactElement) = x.attr "count" v 
        [<CustomOperation("dot")>] member inline _.dot (x: DSLElement, v: bool) = x.attr "dot" v
        [<CustomOperation("offset")>] member inline _.offset (x: DSLElement, v: float array) = x.attr "offset" v 
        [<CustomOperation("overflowCount")>] member inline _.overflowCount (x: DSLElement, v: int) = x.attr "overflowCount" v 
        [<CustomOperation("showZero")>] member inline _.showZero (x: DSLElement, v: bool) = x.attr "showZero" v 
        [<CustomOperation("status")>] member inline _.status (x: DSLElement, v: BadgeStatus) = x.attr "status" v 
        [<CustomOperation("text")>] member inline _.text (x: DSLElement, v: string) = x.attr "text" v 
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: string) = x.attr "title" v