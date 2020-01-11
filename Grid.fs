namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Grid =

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type RowAlignment = Top | Middle | Bottom

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type RowJustify =  Start | End | Center | [<CompiledName("space-around")>] SpaceAround | [<CompiledName("space-between")>] SpaceBetween
    
    [<RequireQualifiedAccess>]
    type AntRow =
        | Align of RowAlignment /// the vertical alignment of the flex layout
        | Gutter of int /// spacing between grids, could be a number or a object like { xs: 8, sm: 16, md: 24} number/object
        | Justify of RowJustify /// horizontal arrangement of the flex layout: start end center space-around space-between
        static member Custom (key: string, value: obj): AntRow = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntRow = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntColumn =
      | Flex of string
      | Offset of int
      | Order of int
      | Pull of int
      | Push of int
      | Span of int
      | Xs of int
      | Sm of int
      | Md of int
      | Lg of int
      | Xl of int
      | Xxl of int
      static member Custom (key: string, value: obj): AntColumn = unbox (key, value)
      static member Style (css: Props.CSSProp list): AntColumn = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antRow (props: AntRow list) (children: ReactElement list): ReactElement =
        ofImport "Row" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antColumn (props: AntColumn list) (children: ReactElement list): ReactElement =
        ofImport "Col" "antd" (keyValueList CaseRules.LowerFirst props) children