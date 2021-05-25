module Fable.AntDesign.Upload

open Fable.AntDesign.Common
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

type ShowUploadListBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = { Name = "showUploadList"; Value = createObj s.Attributes }

    [<CustomOperation("showPreviewIcon")>] member _.showPreviewIcon (x: DSLElement) = x.attr "showPreviewIcon" true
    [<CustomOperation("showDownloadIcon")>] member _.showDownloadIcon (x: DSLElement) = x.attr "showDownloadIcon" true
    [<CustomOperation("showRemoveIcon")>] member _.showRemoveIcon (x: DSLElement) = x.attr "showRemoveIcon" true
    [<CustomOperation("removeIcon")>] member _.removeIcon (x: DSLElement, v: UploadFile -> ReactElement) = x.attr "removeIcon" v
    [<CustomOperation("downloadIcon")>] member _.downloadIcon (x: DSLElement, v: UploadFile -> ReactElement) = x.attr "downloadIcon" v

type UploadBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Upload" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("accept")>] member _.accept (x: DSLElement, v: string) = x.attr "accept" v
    [<CustomOperation("action")>] member _.action (x: DSLElement, v: string) = x.attr "action" v
    [<CustomOperation("beforeUpload")>] member _.beforeUpload (x: DSLElement, v: Func<UploadFile, UploadFile array, bool>) = x.attr "beforeUpload" v
    [<CustomOperation("customRequest")>] member _.customRequest (x: DSLElement, v: obj -> unit) = x.attr "customRequest" v
    [<CustomOperation("data")>] member _.data (x: DSLElement, v: UploadFile -> obj) = x.attr "data" v
    [<CustomOperation("defaultFileList")>] member _.defaultFileList (x: DSLElement, v: obj array) = x.attr "defaultFileList" v
    [<CustomOperation("directory")>] member _.directory (x: DSLElement) = x.attr "directory" true
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("fileList")>] member _.fileList (x: DSLElement, v: obj array) = x.attr "fileList" v
    [<CustomOperation("headers")>] member _.headers (x: DSLElement, v: obj) = x.attr "headers" v
    [<CustomOperation("iconRender")>] member _.iconRender (x: DSLElement, v: Func<UploadFile, UploadListType, ReactElement>) = x.attr "iconRender" v
    [<CustomOperation("isImageUrl")>] member _.isImageUrl (x: DSLElement, v: UploadFile -> bool) = x.attr "isImageUrl" v
    [<CustomOperation("itemRender")>] member _.itemRender (x: DSLElement, v: Func<ReactElement, UploadFile, UploadFile array, ReactElement>) = x.attr "itemRender" v
    [<CustomOperation("listType")>] member _.listType (x: DSLElement, v: UploadListType) = x.attr "listType" v
    [<CustomOperation("method")>] member _.method (x: DSLElement, v: string) = x.attr "method" v
    [<CustomOperation("multiple")>] member _.multiple (x: DSLElement) = x.attr "multiple" true
    [<CustomOperation("name")>] member _.name (x: DSLElement, v: string) = x.attr "name" v
    [<CustomOperation("openFileDialogOnClick")>] member _.openFileDialogOnClick (x: DSLElement) = x.attr "openFileDialogOnClick" true
    [<CustomOperation("previewFile")>] member _.previewFile (x: DSLElement, v: UploadFile -> Promise<string>) = x.attr "previewFile" v
    [<CustomOperation("progress")>] member _.progress (x: DSLElement, v: obj) = x.attr "progress" v
    [<CustomOperation("showUploadList")>] member _.showUploadList (x: DSLElement) = x.attr "showUploadList" true
    [<CustomOperation("showUploadListConfig")>] member _.showUploadListConfig (x: DSLElement, v: obj) = x.attr "showUploadList" v
    [<CustomOperation("withCredentials")>] member _.withCredentials (x: DSLElement) = x.attr "withCredentials" true
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: {| file: UploadFile; fileList: UploadFile array; event: Event |} -> unit) = x.attr "onChange" v
    [<CustomOperation("onDownload")>] member _.onDownload (x: DSLElement, v: UploadFile -> unit) = x.attr "onDownload" v
    [<CustomOperation("onPreview")>] member _.onPreview (x: DSLElement, v: UploadFile -> unit) = x.attr "onPreview" v
    [<CustomOperation("onRemove")>] member _.onRemove (x: DSLElement, v: UploadFile -> bool) = x.attr "onRemove" v