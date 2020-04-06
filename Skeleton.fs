namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type SkeletonShape = Circle | Square

type AntSkeleton() =
    inherit AntElement(ofImport "Skeleton" "antd")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Avatar with set (v: bool) = x.Attribute "avatar" v
    member x.Loading with set (v: bool) = x.Attribute "loading" v
    member x.Paragraph with set (v: bool) = x.Attribute "paragraph" v
    member x.Title with set (v: bool) = x.Attribute "title" v

type AntSkeletonAvatar() =
    inherit AntElement(ofImport "Skeleton.Avatar" "antd")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Shape with set (v: SkeletonShape) = x.Attribute "shape" v   

type AntSkeletonTitle() =
    inherit AntElement(ofImport "Skeleton.Title" "antd")
    member x.Width with set (v: string) = x.Attribute "width" v

type AntSkeletonParagraph() =
    inherit AntElement(ofImport "Skeleton.Paragraph" "antd")
    member x.Rows with set (v: int) = x.Attribute "rows" v
    member x.Width with set (v: string) = x.Attribute "width" v

type AntSkeletonButton() =
    inherit AntElement(ofImport "Skeleton.Button" "antd")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Shape with set (v: SkeletonShape) = x.Attribute "shape" v

type AntSkeletonInput() =
    inherit AntElement(ofImport "Skeleton.Input" "antd")
    member x.Active with set (v: bool) = x.Attribute "active" v
    member x.Size with set (v: Size) = x.Attribute "size" v