module Fable.AntDesign.Result

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>] type ResultStatus = Success | Error | Info | Warning | [<CompiledName("404")>] NotFound | [<CompiledName("403")>] Forbidden | [<CompiledName("500")>] InternalServerError 

type ResultBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Result" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("subTitle")>] member _.subTitle (x: DSLElement, v: ReactElement) = x.attr "subTitle" v 
    [<CustomOperation("status")>] member _.status (x: DSLElement, v: ResultStatus) = x.attr "status" v 
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v 
    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v 