module Fable.AntDesign.Avatar

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum;RequireQualifiedAccess>]
type AvatarShape = Circle | Square

type AvatarBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Avatar" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("shape")>] member _.shape (x: DSLElement, v: AvatarShape) = x.attr "shape" v 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("src")>] member _.src (x: DSLElement, v: string) = x.attr "src" v 
    [<CustomOperation("srcSet")>] member _.srcSet (x: DSLElement, v: string) = x.attr "srcSet" v 
    [<CustomOperation("alt")>] member _.alt (x: DSLElement, v: string) = x.attr "alt" v 
    [<CustomOperation("onError")>] member _.onError (x: DSLElement, v: unit -> bool) = x.attr "onError" v
    [<CustomOperation("gap")>] member _.gap (x: DSLElement, v: int) = x.attr "gap" v