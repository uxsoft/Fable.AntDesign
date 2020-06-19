namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum;RequireQualifiedAccess>]
type AvatarShape = Circle | Square

type AntAvatar() =
    inherit AntElement(ofImport "Avatar" "antd")
    member x.Icon (v: ReactElement) = x.attribute "icon" v
    member x.Shape (v: AvatarShape) = x.attribute "shape" v 
    member x.Size (v: Size) = x.attribute "size" v 
    member x.Src (v: string) = x.attribute "src" v 
    member x.SrcSet (v: string) = x.attribute "srcSet" v 
    member x.Alt (v: string) = x.attribute "alt" v 
    member x.OnError (v: (unit -> bool)) = x.attribute "onError" v 