namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Avatar =

    [<StringEnum;RequireQualifiedAccess>]
    type AvatarShape = Circle | Square
    
    type AvatarBuilder() =
        inherit ReactBuilder(import "Avatar" "antd")
    
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("shape")>] member inline _.shape (x: DSLElement, v: AvatarShape) = x.attr "shape" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
        [<CustomOperation("src")>] member inline _.src (x: DSLElement, v: string) = x.attr "src" v 
        [<CustomOperation("srcSet")>] member inline _.srcSet (x: DSLElement, v: string) = x.attr "srcSet" v 
        [<CustomOperation("alt")>] member inline _.alt (x: DSLElement, v: string) = x.attr "alt" v 
        [<CustomOperation("onError")>] member inline _.onError (x: DSLElement, v: unit -> bool) = x.attr "onError" v
        [<CustomOperation("gap")>] member inline _.gap (x: DSLElement, v: int) = x.attr "gap" v