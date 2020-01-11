namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Pagination =

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type PaginationType = 
        | Page 
        | Prev 
        | Next 
        | [<CompiledName("jump-prev")>] JumpPrev 
        | [<CompiledName("jump-next")>] JumpNext
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type PaginationSize = 
        | Small 
        | Default
        
    type QuickJumperType = { goButton: ReactElement }

    [<RequireQualifiedAccess>]
    type AntPagination =
        | Current of int
        | DefaultCurrent of int
        | DefaultPageSize of int
        | Disabled of bool
        | HideOnSinglePage of bool
        | ItemRender of (int -> PaginationType -> ReactElement -> ReactElement)
        | PageSize of int
        | PageSizeOptions of string[]
        | ShowLessItems of bool
        | ShowQuickJumper of U2<bool, QuickJumperType>
        | ShowSizeChanger of bool
        | ShowTitle of bool
        | ShowTotal of (int -> int * int -> ReactElement)
        | Simple of bool
        | Size of PaginationSize
        | Total of int
        | OnChange of (int -> int -> unit)
        | OnShowSizeChange of (int -> int -> unit) 
        static member Custom (key: string, value: obj): AntPagination = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntPagination = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antPagination (props: AntPagination list) (children: ReactElement list): ReactElement =
       ofImport "Pagination" "antd" (keyValueList CaseRules.LowerFirst props) children