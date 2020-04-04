namespace Fable.AntD

open Fable.Core

[<StringEnum; RequireQualifiedAccess>] type SkeletonShape = Circle | Square

type Skeleton() =
    inherit AntElement("Skeleton")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Avatar with set (v: bool) = x.Attribute "avatar" v
    member x.Loading with set (v: bool) = x.Attribute "loading" v
    member x.Paragraph with set (v: bool) = x.Attribute "paragraph" v
    member x.Title with set (v: bool) = x.Attribute "title" v

type SkeletonAvatar() =
    inherit AntElement("Skeleton.Avatar")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Shape with set (v: SkeletonShape) = x.Attribute "shape" v   

type SkeletonTitle() =
    inherit AntElement("Skeleton.Title")
    member x.Width with set (v: string) = x.Attribute "width" v

type SkeletonParagraph() =
    inherit AntElement("Skeleton.Paragraph")
    member x.Rows with set (v: int) = x.Attribute "rows" v
    member x.Width with set (v: string) = x.Attribute "width" v

type SkeletonButton() =
    inherit AntElement("Skeleton.Button")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Shape with set (v: SkeletonShape) = x.Attribute "shape" v

type SkeletonInput() =
    inherit AntElement("Skeleton.Input")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Size with set (v: Size) = x.Attribute "size" v