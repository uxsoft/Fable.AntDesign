namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Result =
    
    [<StringEnum; RequireQualifiedAccess>] type AntResultStatus = Success | Error | Info | Warning | [<CompiledName("404")>] NotFound | [<CompiledName("403")>] Forbidden | [<CompiledName("500")>] InternalServerError 
    
    [<RequireQualifiedAccess>]
    type AntResult  =
        | Title of ReactElement
        | SubTitle of ReactElement
        | Status of AntResultStatus
        | Icon of ReactElement
        | Extra of ReactElement
        static member Custom (key: string, value: obj): AntResult = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntResult = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antResult (props: AntResult list) (children: ReactElement list): ReactElement =
       ofImport "Result" "antd" (keyValueList CaseRules.LowerFirst props) children
    