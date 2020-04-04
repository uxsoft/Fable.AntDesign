namespace Fable.AntD

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>]
type UploadStatus = Uploading | Done | Error | Removed

[<StringEnum; RequireQualifiedAccess>]
type UploadListType = Text | Picture | [<CompiledName("picture-card")>] PictureCard

type UploadFile = {
    uid: string
    name: string
    status: UploadStatus
    response: string
    linkProps: string
    xhr: XMLHttpRequest
    url: string option
}

type Upload() =
    inherit AntElement("Upload")
    member x.Accept with set (v: string) = x.Attribute "accept" v 
    member x.Action with set (v: string) = x.Attribute "action" v 
    member x.Method with set (v: string) = x.Attribute "method" v 
    member x.Directory with set (v: bool) = x.Attribute "directory" v 
    member x.BeforeUpload with set (v: (UploadFile -> UploadFile array -> bool)) = x.Attribute "beforeUpload" v 
    member x.CustomRequest with set (v: (obj -> unit)) = x.Attribute "customRequest" v
    member x.Data with set (v: (UploadFile -> obj)) = x.Attribute "data" v 
    member x.DefaultFileList with set (v: obj array) = x.Attribute "defaultFileList" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v  
    member x.FileList with set (v: obj array) = x.Attribute "fileList" v 
    member x.Headers with set (v: obj) = x.Attribute "headers" v 
    member x.ListType with set (v: UploadListType) = x.Attribute "listType" v 
    member x.Multiple with set (v: bool) = x.Attribute "multiple" v
    member x.Name with set (v: string) = x.Attribute "name" v 
    member x.PreviewFile with set (v: (UploadFile -> Promise<string>)) = x.Attribute "previewFile" v 
    member x.ShowUploadList with set (v: bool) = x.Attribute "showUploadList" v 
    member x.SupportServerRender with set (v: bool) = x.Attribute "supportServerRender" v 
    member x.WithCredentials with set (v: bool) = x.Attribute "withCredentials" v 
    member x.OpenFileDialogOnClick with set (v: bool) = x.Attribute "openFileDialogOnClick" v 
    member x.OnChange with set (v: (unit -> unit)) = x.Attribute "onChange" v 
    member x.OnPreview with set (v: (UploadFile -> unit)) = x.Attribute "onPreview" v 
    member x.OnRemove with set (v: (UploadFile -> bool)) = x.Attribute "onRemove" v 
    member x.OnDownload with set (v: (UploadFile -> unit)) = x.Attribute "onDownload" v 
    member x.TransformFile with set (v: (UploadFile -> UploadFile)) = x.Attribute "transformFile" v 
    member x.IconRender with set (v: (UploadFile -> UploadListType -> ReactElement)) = x.Attribute "iconRender" v 