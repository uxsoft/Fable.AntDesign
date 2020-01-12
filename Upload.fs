namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<AutoOpen>]
module Upload =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntUploadStatus = Uploading | Done | Error | Removed

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntUploadListType = Text | Picture | [<CompiledName("picture-card")>] PictureCard

    type AntUploadFile = {
        uid: string
        name: string
        status: AntUploadStatus
        response: string
        linkProps: string
        xhr: XMLHttpRequest
        url: string option
    }

    [<RequireQualifiedAccess>]
    type AntUpload  =
        | Accept of string
        | Action of string
        | Method of string
        | Directory of bool
        | BeforeUpload of (AntUploadFile -> AntUploadFile array -> bool)
        | CustomRequest of (obj -> unit)
        | Data of (AntUploadFile -> obj)
        | DefaultFileList of obj array
        | Disabled of bool 
        | FileList of obj array
        | Headers of obj
        | ListType of AntUploadListType
        | Multiple of bool
        | Name of string
        | PreviewFile of (AntUploadFile -> Promise<string>)
        | ShowUploadList of bool
        | SupportServerRender of bool
        | WithCredentials of bool
        | OpenFileDialogOnClick of bool
        | OnChange of (unit -> unit)
        | OnPreview of (AntUploadFile -> unit)
        | OnRemove of (AntUploadFile -> bool)
        | OnDownload of (AntUploadFile -> unit)
        | TransformFile of (AntUploadFile -> AntUploadFile)
        | IconRender of (AntUploadFile -> AntUploadListType -> ReactElement)
        static member Custom (key: string, value: obj): AntUpload = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntUpload = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antUpload (props: AntAffix list) (children: ReactElement list): ReactElement =
       ofImport "Upload" "antd" (keyValueList CaseRules.LowerFirst props) children
    