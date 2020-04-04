namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type BadgeStatus = Success | Processing | Default | Error | Warning

type Badge() =
    inherit AntElement("Badge")
    member x.Color with set (v: string) = x.Attribute "color" v 
    member x.Count with set (v: ReactElement) = x.Attribute "count" v 
    member x.Dot with set (v: bool) = x.Attribute "dot" v 
    member x.Offset with set (v: float array) = x.Attribute "offset" v 
    member x.OverflowCount with set (v: int) = x.Attribute "overflowCount" v 
    member x.ShowZero with set (v: bool) = x.Attribute "showZero" v 
    member x.Status with set (v: BadgeStatus) = x.Attribute "status" v 
    member x.Text with set (v: string) = x.Attribute "text" v 
    member x.Title with set (v: string) = x.Attribute "title" v