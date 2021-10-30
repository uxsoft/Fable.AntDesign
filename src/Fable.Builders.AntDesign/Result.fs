namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Result =

    [<StringEnum; RequireQualifiedAccess>]
    type ResultStatus =
        | Success
        | Error
        | Info
        | Warning
        | [<CompiledName("404")>] NotFound
        | [<CompiledName("403")>] Forbidden
        | [<CompiledName("500")>] InternalServerError 
    
    type ResultBuilder() =
        inherit ReactBuilder(import "Result" "antd")
    
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
        [<CustomOperation("subTitle")>] member inline _.subTitle (x: DSLElement, v: ReactElement) = x.attr "subTitle" v 
        [<CustomOperation("status")>] member inline _.status (x: DSLElement, v: ResultStatus) = x.attr "status" v 
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v 
        [<CustomOperation("extra")>] member inline _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v 