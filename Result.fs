namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type ResultStatus = Success | Error | Info | Warning | [<CompiledName("404")>] NotFound | [<CompiledName("403")>] Forbidden | [<CompiledName("500")>] InternalServerError 

type AntResult() =
    inherit AntElement<AntResult>(ofImport "Result" "antd")
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.subTitle (v: ReactElement) = x.attribute "subTitle" v 
    member x.status (v: ResultStatus) = x.attribute "status" v 
    member x.icon (v: ReactElement) = x.attribute "icon" v 
    member x.extra (v: ReactElement) = x.attribute "extra" v 