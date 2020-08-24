namespace Fable.AntD

open Fable.Core
open Fable.React
open System

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

type AntCarousel() =
    inherit AntElement<AntCarousel>(ofImport "Carousel" "antd")
    member x.afterChange (v: int -> unit) = x.attribute "afterChange" v
    member x.autoplay (v: bool) = x.attribute "autoplay" v
    member x.beforeChange (v: Func<int, int, unit>) = x.attribute "beforeChange" v
    member x.dotPosition (v: CarouselDotPosition) = x.attribute "dotPosition" v
    member x.dots (v: bool) = x.attribute "dots" v
    member x.easing (v: CarouselEasing) = x.attribute "easing" v
    member x.effect (v: CarouselEffect) = x.attribute "effect" v