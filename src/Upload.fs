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
    ``type``: string
    size: int
}

type AntUploadListConfig() =
    inherit AntObject<AntUploadListConfig>()
    member x.showPreviewIcon (v: bool) = x.attribute "showPreviewIcon" v
    member x.showDownloadIcon (v: bool) = x.attribute "showDownloadIcon" v
    member x.showRemoveIcon (v: bool) = x.attribute "showRemoveIcon" v
    member x.removeIcon (v: UploadFile -> ReactElement) = x.attribute "removeIcon" v
    member x.downloadIcon (v: UploadFile -> ReactElement) = x.attribute "downloadIcon" v

type AntUpload() =
    inherit AntElement<AntUpload>(ofImport "Upload" "antd")
    member x.accept (v: string) = x.attribute "accept" v
    member x.action (v: string) = x.attribute "action" v
    member x.beforeUpload (v: Func<UploadFile, UploadFile array, bool>) = x.attribute "beforeUpload" v
    member x.customRequest (v: obj -> unit) = x.attribute "customRequest" v
    member x.data (v: UploadFile -> obj) = x.attribute "data" v
    member x.defaultFileList (v: obj array) = x.attribute "defaultFileList" v
    member x.directory (?v: bool) = x.attribute "directory" (Option.defaultValue true v)
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.fileList (v: obj array) = x.attribute "fileList" v
    member x.headers (v: obj) = x.attribute "headers" v
    member x.iconRender (v: Func<UploadFile, UploadListType, ReactElement>) = x.attribute "iconRender" v
    member x.isImageUrl (v: UploadFile -> bool) = x.attribute "isImageUrl" v
    member x.itemRender (v: Func<ReactElement, UploadFile, UploadFile array, ReactElement>) = x.attribute "itemRender" v
    member x.listType (v: UploadListType) = x.attribute "listType" v
    member x.method (v: string) = x.attribute "method" v
    member x.multiple (?v: bool) = x.attribute "multiple" (Option.defaultValue true v)
    member x.name (v: string) = x.attribute "name" v
    member x.openFileDialogOnClick (?v: bool) = x.attribute "openFileDialogOnClick" (Option.defaultValue true v)
    member x.previewFile (v: UploadFile -> Promise<string>) = x.attribute "previewFile" v
    member x.progress (v: AntProgress) = x.attribute "progress" v.JSON
    member x.showUploadList (?v: bool) = x.attribute "showUploadList" (Option.defaultValue true v)
    member x.showUploadListConfig (v: AntUploadListConfig) = x.attribute "showUploadList" v.JSON
    member x.withCredentials (?v: bool) = x.attribute "withCredentials" (Option.defaultValue true v)
    member x.onChange (v: {| file: UploadFile; fileList: UploadFile array; event: Event |} -> unit) = x.attribute "onChange" v
    member x.onDownload (v: UploadFile -> unit) = x.attribute "onDownload" v
    member x.onPreview (v: UploadFile -> unit) = x.attribute "onPreview" v
    member x.onRemove (v: UploadFile -> bool) = x.attribute "onRemove" v