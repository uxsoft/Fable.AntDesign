namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum;RequireQualifiedAccess>]
type AvatarShape = Circle | Square

type AntAvatar() =
    inherit AntElement<AntAvatar>(ofImport "Avatar" "antd")
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.shape (v: AvatarShape) = x.attribute "shape" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.src (v: string) = x.attribute "src" v 
    member x.srcSet (v: string) = x.attribute "srcSet" v 
    member x.alt (v: string) = x.attribute "alt" v 
    member x.onError (v: (unit -> bool)) = x.attribute "onError" v
    member x.gap (v: int) = x.attribute "gap" v