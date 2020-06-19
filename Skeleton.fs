namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type SkeletonShape = Circle | Square

type AntSkeleton() =
    inherit AntElement<AntSkeleton>(ofImport "Skeleton" "antd")
    member x.active (v: bool) = x.attribute "active" v
    member x.avatar (v: bool) = x.attribute "avatar" v
    member x.loading (v: bool) = x.attribute "loading" v
    member x.paragraph (v: bool) = x.attribute "paragraph" v
    member x.title (v: bool) = x.attribute "title" v

type AntSkeletonAvatar() =
    inherit AntElement<AntSkeletonAvatar>(ofImport "Skeleton.Avatar" "antd")
    member x.active (v: bool) = x.attribute "active" v
    member x.size (v: Size) = x.attribute "size" v
    member x.shape (v: SkeletonShape) = x.attribute "shape" v   

type AntSkeletonTitle() =
    inherit AntElement<AntSkeletonTitle>(ofImport "Skeleton.Title" "antd")
    member x.width (v: string) = x.attribute "width" v

type AntSkeletonParagraph() =
    inherit AntElement<AntSkeletonParagraph>(ofImport "Skeleton.Paragraph" "antd")
    member x.rows (v: int) = x.attribute "rows" v
    member x.width (v: string) = x.attribute "width" v

type AntSkeletonButton() =
    inherit AntElement<AntSkeletonButton>(ofImport "Skeleton.Button" "antd")
    member x.active (v: bool) = x.attribute "active" v
    member x.size (v: Size) = x.attribute "size" v
    member x.shape (v: SkeletonShape) = x.attribute "shape" v

type AntSkeletonInput() =
    inherit AntElement<AntSkeletonInput>(ofImport "Skeleton.Input" "antd")
    member x.active (v: bool) = x.attribute "active" v
    member x.size (v: Size) = x.attribute "size" v