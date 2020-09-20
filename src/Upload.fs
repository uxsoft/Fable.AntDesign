namespace Fable.AntD

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Fable.React
open Browser.Types
open System

[<StringEnum; RequireQualifiedAccess>]
type UploadStatus =
    | Uploading
    | Done
    | Error
    | Removed

[<StringEnum; RequireQualifiedAccess>]
type UploadListType =
    | Text
    | Picture
    | [<CompiledName("picture-card")>] PictureCard

type UploadFile = {
    uid: string
    name: string
    status: UploadStatus
    response: string
    linkProps: string
    xhr: XMLHttpRequest
    url: string option
}

type AntUpload() =
    inherit AntElement<AntUpload>(ofImport "Upload" "antd")
    member x.accept (v: string) = x.attribute "accept" v
    member x.action (v: string) = x.attribute "action" v
    member x.method (v: string) = x.attribute "method" v
    member x.directory (?v: bool) = x.attribute "directory" (Option.defaultValue true v)
    member x.beforeUpload (v: Func<UploadFile, UploadFile array, bool>) = x.attribute "beforeUpload" v
    member x.customRequest (v: obj -> unit) = x.attribute "customRequest" v
    member x.data (v: UploadFile -> obj) = x.attribute "data" v
    member x.defaultFileList (v: obj array) = x.attribute "defaultFileList" v
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.fileList (v: obj array) = x.attribute "fileList" v
    member x.headers (v: obj) = x.attribute "headers" v
    member x.listType (v: UploadListType) = x.attribute "listType" v
    member x.multiple (?v: bool) = x.attribute "multiple" (Option.defaultValue true v)
    member x.name (v: string) = x.attribute "name" v
    member x.previewFile (v: UploadFile -> Promise<string>) = x.attribute "previewFile" v
    member x.isImageUrl (v: UploadFile -> bool) = x.attribute "isImageUrl" v
    member x.showUploadList (?v: bool) = x.attribute "showUploadList" (Option.defaultValue true v)
    member x.withCredentials (?v: bool) = x.attribute "withCredentials" (Option.defaultValue true v)
    member x.openFileDialogOnClick (?v: bool) = x.attribute "openFileDialogOnClick" (Option.defaultValue true v)
    member x.onChange (v: unit -> unit) = x.attribute "onChange" v
    member x.onPreview (v: UploadFile -> unit) = x.attribute "onPreview" v
    member x.onRemove (v: UploadFile -> bool) = x.attribute "onRemove" v
    member x.onDownload (v: UploadFile -> unit) = x.attribute "onDownload" v
    member x.transformFile (v: UploadFile -> UploadFile) = x.attribute "transformFile" v
    member x.iconRender (v: Func<UploadFile, UploadListType, ReactElement>) = x.attribute "iconRender" v
    member x.progress (v: AntProgress) = x.attribute "progress" v.JSON