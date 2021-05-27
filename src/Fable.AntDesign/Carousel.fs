module Fable.AntDesign.Carousel

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type CarouselEffect =
    | [<CompiledName("scrollx")>] ScrollX
    | Fade

[<StringEnum; RequireQualifiedAccess>]
type CarouselEasing = Linear

[<StringEnum; RequireQualifiedAccess>]
type CarouselDotPosition =
    | Top
    | Bottom
    | Left
    | Right

type CarouselBuilder() =
    inherit ReactBuilder()
    
    member x.Run(s: DSLElement) = ofImport "Carousel" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("afterChange")>] member _.afterChange (x: DSLElement, v: int -> unit) = x.attr "afterChange" v
    [<CustomOperation("autoplay")>] member _.autoplay (x: DSLElement, v: bool) = x.attr "autoplay" v
    [<CustomOperation("beforeChange")>] member _.beforeChange (x: DSLElement, v: Func<int, int, unit>) = x.attr "beforeChange" v
    [<CustomOperation("dotPosition")>] member _.dotPosition (x: DSLElement, v: CarouselDotPosition) = x.attr "dotPosition" v
    [<CustomOperation("dots")>] member _.dots (x: DSLElement, v: bool) = x.attr "dots" v
    [<CustomOperation("easing")>] member _.easing (x: DSLElement, v: CarouselEasing) = x.attr "easing" v
    [<CustomOperation("effect")>] member _.effect (x: DSLElement, v: CarouselEffect) = x.attr "effect" v