namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Builders.AntDesign.Progress
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Fable.React
open Browser.Types
open System

[<AutoOpen>]
module Upload =

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
    
    type ShowUploadListProp =
        | ShowPreviewIcon of bool
        | ShowDownloadIcon of bool
        | ShowRemoveIcon of bool
        | RemoveIcon of UploadFile
        | DownloadIcon of UploadFile
    
    type UploadBuilder() =
        inherit ReactBuilder(import "Upload" "antd")
    
        [<CustomOperation("accept")>] member inline _.accept (x: DSLElement, v: string) = x.attr "accept" v
        [<CustomOperation("action")>] member inline _.action (x: DSLElement, v: string) = x.attr "action" v
        [<CustomOperation("beforeUpload")>] member inline _.beforeUpload (x: DSLElement, v: Func<UploadFile, UploadFile array, bool>) = x.attr "beforeUpload" v
        [<CustomOperation("customRequest")>] member inline _.customRequest (x: DSLElement, v: obj -> unit) = x.attr "customRequest" v
        [<CustomOperation("data")>] member inline _.data (x: DSLElement, v: UploadFile -> obj) = x.attr "data" v
        [<CustomOperation("defaultFileList")>] member inline _.defaultFileList (x: DSLElement, v: obj array) = x.attr "defaultFileList" v
        [<CustomOperation("directory")>] member inline _.directory (x: DSLElement, v: bool) = x.attr "directory" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("fileList")>] member inline _.fileList (x: DSLElement, v: obj array) = x.attr "fileList" v
        [<CustomOperation("headers")>] member inline _.headers (x: DSLElement, v: obj) = x.attr "headers" v
        //TODO better type
        [<CustomOperation("iconRender")>] member inline _.iconRender (x: DSLElement, v: Func<UploadFile, UploadListType, ReactElement>) = x.attr "iconRender" v
        [<CustomOperation("isImageUrl")>] member inline _.isImageUrl (x: DSLElement, v: UploadFile -> bool) = x.attr "isImageUrl" v
        [<CustomOperation("itemRender")>] member inline _.itemRender (x: DSLElement, v: Func<ReactElement, UploadFile, UploadFile array, ReactElement>) = x.attr "itemRender" v
        [<CustomOperation("listType")>] member inline _.listType (x: DSLElement, v: UploadListType) = x.attr "listType" v
        [<CustomOperation("method")>] member inline _.method (x: DSLElement, v: string) = x.attr "method" v
        [<CustomOperation("multiple")>] member inline _.multiple (x: DSLElement, v: bool) = x.attr "multiple" v
        [<CustomOperation("name")>] member inline _.name (x: DSLElement, v: string) = x.attr "name" v
        [<CustomOperation("openFileDialogOnClick")>] member inline _.openFileDialogOnClick (x: DSLElement, v: bool) = x.attr "openFileDialogOnClick" v
        [<CustomOperation("previewFile")>] member inline _.previewFile (x: DSLElement, v: UploadFile -> Promise<string>) = x.attr "previewFile" v
        [<CustomOperation("progress")>] member inline _.progress (x: DSLElement, v: ProgressProp list) = x.attr "progress" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("showUploadList")>] member inline _.showUploadList (x: DSLElement, v: bool) = x.attr "showUploadList" v
        [<CustomOperation("showUploadListConfig")>] member inline _.showUploadListConfig (x: DSLElement, v: ShowUploadListProp list) = x.attr "showUploadList" (keyValueList CaseRules.LowerFirst v)
        [<CustomOperation("withCredentials")>] member inline _.withCredentials (x: DSLElement, v: bool) = x.attr "withCredentials" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: {| file: UploadFile; fileList: UploadFile array; event: Event |} -> unit) = x.attr "onChange" v
        [<CustomOperation("onDownload")>] member inline _.onDownload (x: DSLElement, v: UploadFile -> unit) = x.attr "onDownload" v
        [<CustomOperation("onPreview")>] member inline _.onPreview (x: DSLElement, v: UploadFile -> unit) = x.attr "onPreview" v
        [<CustomOperation("onRemove")>] member inline _.onRemove (x: DSLElement, v: UploadFile -> bool) = x.attr "onRemove" v