module Fable.AntDesign.Skeleton

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>] type SkeletonShape = Circle | Square

type SkeletonBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member _.active (x: DSLElement) = x.attr "active" true
    [<CustomOperation("avatar")>] member _.avatar (x: DSLElement) = x.attr "avatar" true
    [<CustomOperation("loading")>] member _.loading (x: DSLElement) = x.attr "loading" true
    [<CustomOperation("paragraph")>] member _.paragraph (x: DSLElement) = x.attr "paragraph" true
    [<CustomOperation("title")>] member _.title (x: DSLElement) = x.attr "title" true
    [<CustomOperation("round")>] member _.round (x: DSLElement) = x.attr "round" true

type SkeletonAvatarBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Avatar" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member _.active (x: DSLElement) = x.attr "active" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("shape")>] member _.shape (x: DSLElement, v: SkeletonShape) = x.attr "shape" v   

type SkeletonTitleBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Title" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v

type SkeletonParagraphBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Paragraph" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("rows")>] member _.rows (x: DSLElement, v: int) = x.attr "rows" v
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v

type SkeletonButtonBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Button" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member _.active (x: DSLElement) = x.attr "active" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("shape")>] member _.shape (x: DSLElement, v: SkeletonShape) = x.attr "shape" v

type SkeletonInputBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Skeleton.Input" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("active")>] member _.active (x: DSLElement) = x.attr "active" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v