namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen>]
module Empty =

    type EmptyBuilder() =
        inherit ReactBuilder(import "Empty" "antd")
    
        [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: ReactElement) = x.attr "description" v 
        [<CustomOperation("image")>] member inline _.image (x: DSLElement, v: ReactElement) = x.attr "image" v 
        [<CustomOperation("imageStyle")>] member inline _.imageStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "imageStyle" (keyValueList CaseRules.LowerFirst css)
    