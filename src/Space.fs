namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type SpaceAlign =
    | Start
    | End
    | Center
    | Baseline

[<StringEnum; RequireQualifiedAccess>]
type SpaceDirection =
    | Vertical
    | Horizontal

type AntSpace() =
    inherit AntElement<AntSpace>(ofImport "Space" "antd")
    member x.align (v: SpaceAlign) = x.attribute "align" v
    member x.direction (v: SpaceDirection) = x.attribute "direction" v
    member x.size (v: Size) = x.attribute "size" v
    member x.sizeNumber (v: int) = x.attribute "size" v