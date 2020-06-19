namespace Fable.AntD

open Fable.Core
open Fable.React

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
    inherit AntElement(ofImport "Carousel" "antd")
    member x.AfterChange
        (v: int -> unit) = x.attribute "afterChange" v
    member x.Autoplay
        (v: bool) = x.attribute "autoplay" v

    member x.BeforeChange
        (v: int -> int -> unit) =
            let uncurried = System.Func<int, int, unit> v
            x.attribute "beforeChange" uncurried

    member x.DotPosition
        (v: CarouselDotPosition) = x.attribute "dotPosition" v
    member x.Dots
        (v: bool) = x.attribute "dots" v
    member x.Easing
        (v: CarouselEasing) = x.attribute "easing" v
    member x.Effect
        (v: CarouselEffect) = x.attribute "effect" v
