namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type BadgeStatus = Success | Processing | Default | Error | Warning

type AntBadge() =
    inherit AntElement<AntBadge>(ofImport "Badge" "antd")
    member x.color (v: string) = x.attribute "color" v 
    member x.count (v: ReactElement) = x.attribute "count" v 
    member x.dot (?v: bool) = x.attribute "dot" (Option.defaultValue true v) 
    member x.offset (v: float array) = x.attribute "offset" v 
    member x.overflowCount (v: int) = x.attribute "overflowCount" v 
    member x.showZero (?v: bool) = x.attribute "showZero" (Option.defaultValue true v) 
    member x.status (v: BadgeStatus) = x.attribute "status" v 
    member x.text (v: string) = x.attribute "text" v 
    member x.title (v: string) = x.attribute "title" v