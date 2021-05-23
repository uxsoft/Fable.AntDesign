namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type SkeletonShape = Circle | Square

type AntSkeleton() =
    inherit AntElement<AntSkeleton>(ofImport "Skeleton" "antd")
    member x.active (?v: bool) = x.attribute "active" (Option.defaultValue true v)
    member x.avatar (?v: bool) = x.attribute "avatar" (Option.defaultValue true v)
    member x.loading (?v: bool) = x.attribute "loading" (Option.defaultValue true v)
    member x.paragraph (?v: bool) = x.attribute "paragraph" (Option.defaultValue true v)
    member x.title (?v: bool) = x.attribute "title" (Option.defaultValue true v)
    member x.round (?v: bool) = x.attribute "round" (Option.defaultValue true v)

type AntSkeletonAvatar() =
    inherit AntElement<AntSkeletonAvatar>(ofImport "Skeleton.Avatar" "antd")
    member x.active (?v: bool) = x.attribute "active" (Option.defaultValue true v)
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
    member x.active (?v: bool) = x.attribute "active" (Option.defaultValue true v)
    member x.size (v: Size) = x.attribute "size" v
    member x.shape (v: SkeletonShape) = x.attribute "shape" v

type AntSkeletonInput() =
    inherit AntElement<AntSkeletonInput>(ofImport "Skeleton.Input" "antd")
    member x.active (?v: bool) = x.attribute "active" (Option.defaultValue true v)
    member x.size (v: Size) = x.attribute "size" v