module Fable.AntDesign.Skeleton

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>] type SkeletonShape = Circle | Square

type SkeletonBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member inline _.active (x: DSLElement, v: bool) = x.attr "active" v
    [<CustomOperation("avatar")>] member inline _.avatar (x: DSLElement, v: bool) = x.attr "avatar" v
    [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v
    [<CustomOperation("paragraph")>] member inline _.paragraph (x: DSLElement, v: bool) = x.attr "paragraph" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: bool) = x.attr "title" v
    [<CustomOperation("round")>] member inline _.round (x: DSLElement, v: bool) = x.attr "round" v

type SkeletonAvatarBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Avatar" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member inline _.active (x: DSLElement, v: bool) = x.attr "active" v
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("shape")>] member inline _.shape (x: DSLElement, v: SkeletonShape) = x.attr "shape" v   

type SkeletonTitleBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Title" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: string) = x.attr "width" v

type SkeletonParagraphBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Paragraph" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("rows")>] member inline _.rows (x: DSLElement, v: int) = x.attr "rows" v
    [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: string) = x.attr "width" v

type SkeletonButtonBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Button" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member inline _.active (x: DSLElement, v: bool) = x.attr "active" v
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("shape")>] member inline _.shape (x: DSLElement, v: SkeletonShape) = x.attr "shape" v

type SkeletonInputBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Input" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member inline _.active (x: DSLElement, v: bool) = x.attr "active" v
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v