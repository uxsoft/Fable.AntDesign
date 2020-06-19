namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type BadgeStatus = Success | Processing | Default | Error | Warning

type AntBadge() =
    inherit AntElement(ofImport "Badge" "antd")
    member x.Color (v: string) = x.attribute "color" v 
    member x.Count (v: ReactElement) = x.attribute "count" v 
    member x.Dot (v: bool) = x.attribute "dot" v 
    member x.Offset (v: float array) = x.attribute "offset" v 
    member x.OverflowCount (v: int) = x.attribute "overflowCount" v 
    member x.ShowZero (v: bool) = x.attribute "showZero" v 
    member x.Status (v: BadgeStatus) = x.attribute "status" v 
    member x.Text (v: string) = x.attribute "text" v 
    member x.Title (v: string) = x.attribute "title" v