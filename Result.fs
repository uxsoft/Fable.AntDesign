namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type ResultStatus = Success | Error | Info | Warning | [<CompiledName("404")>] NotFound | [<CompiledName("403")>] Forbidden | [<CompiledName("500")>] InternalServerError 

type AntResult() =
    inherit AntElement(ofImport "Result" "antd")
    member x.Title (v: ReactElement) = x.attribute "title" v 
    member x.SubTitle (v: ReactElement) = x.attribute "subTitle" v 
    member x.Status (v: ResultStatus) = x.attribute "status" v 
    member x.Icon (v: ReactElement) = x.attribute "icon" v 
    member x.Extra (v: ReactElement) = x.attribute "extra" v 