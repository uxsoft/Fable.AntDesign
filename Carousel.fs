namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Carousel =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntCarouselEffect = Scrollx | Fade

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntCarouselEasing = Linear

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntCarouselDotPosition = Top | Bottom | Left | Right

    [<RequireQualifiedAccess>]
    type AntCarousel  =
        | AfterChange of (int -> unit)
        | Autoplay of bool
        | BeforeChange of (int -> int -> unit)
        | DotPosition of AntCarouselDotPosition
        | Dots of bool
        | Easing of AntCarouselEasing
        | Effect of AntCarouselEffect
        static member Custom (key: string, value: obj): AntCarousel = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCarousel = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antCarousel (props: AntCarousel list) (children: ReactElement list): ReactElement =
       ofImport "Carousel" "antd" (keyValueList CaseRules.LowerFirst props) children
    