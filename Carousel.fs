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
type CarouselDotPosition = Top | Bottom | Left | Right

type AntCarousel() =
    inherit AntElement(ofImport "Carousel" "antd")
    member x.AfterChange with set (v: (int -> unit)) = x.Attribute "afterChange" v 
    member x.Autoplay with set (v: bool) = x.Attribute "autoplay" v 
    member x.BeforeChange with set (v: (int -> int -> unit)) = x.Attribute "beforeChange" v 
    member x.DotPosition with set (v: CarouselDotPosition) = x.Attribute "dotPosition" v 
    member x.Dots with set (v: bool) = x.Attribute "dots" v 
    member x.Easing with set (v: CarouselEasing) = x.Attribute "easing" v 
    member x.Effect with set (v: CarouselEffect) = x.Attribute "effect" v 