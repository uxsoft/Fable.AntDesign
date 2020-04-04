namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Skeleton =
    
    [<StringEnum; RequireQualifiedAccess>] type AntSkeletonShape = Circle | Square
    
    [<RequireQualifiedAccess>]
    type AntSkeleton =
        | Active of bool
        | Avatar of bool
        | Loading of bool
        | Paragraph of bool
        | Title of bool
        static member Custom (key: string, value: obj): AntSkeleton = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSkeleton = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntSkeletonAvatar =
        | Active of bool
        | Size of Size
        | Shape of AntSkeletonShape
        static member Custom (key: string, value: obj): AntSkeletonAvatar = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSkeletonAvatar = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntSkeletonTitle =
        | Width of string
        static member Custom (key: string, value: obj): AntSkeletonTitle = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSkeletonTitle = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntSkeletonParagraph =
        | Rows of int
        | Width of string
        static member Custom (key: string, value: obj): AntSkeletonParagraph = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSkeletonParagraph = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntSkeletonButton =
        | Active of bool
        | Size of Size
        | Shape of AntSkeletonShape
        static member Custom (key: string, value: obj): AntSkeletonButton = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSkeletonButton = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntSkeletonInput =
        | Active of bool
        | Size of Size
        static member Custom (key: string, value: obj): AntSkeletonInput = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSkeletonInput = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antSkeleton (props: Affix list) (children: ReactElement list): ReactElement =
       ofImport "Skeleton" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    let inline antSkeletonAvatar (props: AntSkeletonAvatar list) (children: ReactElement list): ReactElement =
       ofImport "Skeleton.Avatar" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antSkeletonTitle (props: AntSkeletonTitle list) (children: ReactElement list): ReactElement =
       ofImport "Skeleton.Title" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antSkeletonParagraph (props: AntSkeletonParagraph list) (children: ReactElement list): ReactElement =
       ofImport "Skeleton.Paragraph" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antSkeletonButton (props: AntSkeletonButton list) (children: ReactElement list): ReactElement =
       ofImport "Skeleton.Button" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antSkeletonInput (props: AntSkeletonInput list) (children: ReactElement list): ReactElement =
       ofImport "Skeleton.Input" "antd" (keyValueList CaseRules.LowerFirst props) children