module Fable.AntDesign.Space

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

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

type SpaceBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Space" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("align")>] member _.align (x: DSLElement, v: SpaceAlign) = x.attr "align" v
    [<CustomOperation("direction")>] member _.direction (x: DSLElement, v: SpaceDirection) = x.attr "direction" v
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("sizeExact")>] member _.sizeExact (x: DSLElement, v: int) = x.attr "size" v
    [<CustomOperation("split")>] member _.split (x: DSLElement, v: ReactElement) = x.attr "split" v
    [<CustomOperation("wrap")>] member _.wrap (x: DSLElement) = x.attr "wrap" true