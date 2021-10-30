namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

[<AutoOpen>]
module Carousel =
    
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
        inherit ReactBuilder(import "Carousel" "antd")
        
        [<CustomOperation("afterChange")>] member inline _.afterChange (x: DSLElement, v: int -> unit) = x.attr "afterChange" v
        [<CustomOperation("autoplay")>] member inline _.autoplay (x: DSLElement, v: bool) = x.attr "autoplay" v
        [<CustomOperation("beforeChange")>] member inline _.beforeChange (x: DSLElement, v: Func<int, int, unit>) = x.attr "beforeChange" v
        [<CustomOperation("dotPosition")>] member inline _.dotPosition (x: DSLElement, v: CarouselDotPosition) = x.attr "dotPosition" v
        [<CustomOperation("dots")>] member inline _.dots (x: DSLElement, v: bool) = x.attr "dots" v
        [<CustomOperation("easing")>] member inline _.easing (x: DSLElement, v: CarouselEasing) = x.attr "easing" v
        [<CustomOperation("effect")>] member inline _.effect (x: DSLElement, v: CarouselEffect) = x.attr "effect" v