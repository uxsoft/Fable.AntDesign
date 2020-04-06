namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum;RequireQualifiedAccess>]
type AvatarShape = Circle | Square

type AntAvatar() =
    inherit AntElement(ofImport "Avatar" "antd")
    member x.Icon with set (v: ReactElement) = x.Attribute "icon" v
    member x.Shape with set (v: AvatarShape) = x.Attribute "shape" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.Src with set (v: string) = x.Attribute "src" v 
    member x.SrcSet with set (v: string) = x.Attribute "srcSet" v 
    member x.Alt with set (v: string) = x.Attribute "alt" v 
    member x.OnError with set (v: (unit -> bool)) = x.Attribute "onError" v 