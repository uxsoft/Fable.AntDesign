namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type ResultStatus = Success | Error | Info | Warning | [<CompiledName("404")>] NotFound | [<CompiledName("403")>] Forbidden | [<CompiledName("500")>] InternalServerError 

type Result() =
    inherit AntElement("Result")
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.SubTitle with set (v: ReactElement) = x.Attribute "subTitle" v 
    member x.Status with set (v: ResultStatus) = x.Attribute "status" v 
    member x.Icon with set (v: ReactElement) = x.Attribute "icon" v 
    member x.Extra with set (v: ReactElement) = x.Attribute "extra" v 