namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type SkeletonShape = Circle | Square

type AntSkeleton() =
    inherit AntElement(ofImport "Skeleton" "antd")
    member x.Active (v: bool) = x.attribute "active" v
    member x.Avatar (v: bool) = x.attribute "avatar" v
    member x.Loading (v: bool) = x.attribute "loading" v
    member x.Paragraph (v: bool) = x.attribute "paragraph" v
    member x.Title (v: bool) = x.attribute "title" v

type AntSkeletonAvatar() =
    inherit AntElement(ofImport "Skeleton.Avatar" "antd")
    member x.Active (v: bool) = x.attribute "active" v
    member x.Size (v: Size) = x.attribute "size" v
    member x.Shape (v: SkeletonShape) = x.attribute "shape" v   

type AntSkeletonTitle() =
    inherit AntElement(ofImport "Skeleton.Title" "antd")
    member x.Width (v: string) = x.attribute "width" v

type AntSkeletonParagraph() =
    inherit AntElement(ofImport "Skeleton.Paragraph" "antd")
    member x.Rows (v: int) = x.attribute "rows" v
    member x.Width (v: string) = x.attribute "width" v

type AntSkeletonButton() =
    inherit AntElement(ofImport "Skeleton.Button" "antd")
    member x.Active (v: bool) = x.attribute "active" v
    member x.Size (v: Size) = x.attribute "size" v
    member x.Shape (v: SkeletonShape) = x.attribute "shape" v

type AntSkeletonInput() =
    inherit AntElement(ofImport "Skeleton.Input" "antd")
    member x.Active (v: bool) = x.attribute "active" v
    member x.Size (v: Size) = x.attribute "size" v