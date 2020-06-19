namespace Fable.AntD

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

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

type UploadFile =
    { uid: string
      name: string
      status: UploadStatus
      response: string
      linkProps: string
      xhr: XMLHttpRequest
      url: string option }

type AntUpload() =
    inherit AntElement(ofImport "Upload" "antd")
    member x.Accept
        (v: string) = x.attribute "accept" v
    member x.Action
        (v: string) = x.attribute "action" v
    member x.Method
        (v: string) = x.attribute "method" v
    member x.Directory
        (v: bool) = x.attribute "directory" v

    member x.BeforeUpload
        (v: UploadFile -> UploadFile array -> bool) =
            let uncurried = System.Func<UploadFile, UploadFile array, bool> v
            x.attribute "beforeUpload" uncurried

    member x.CustomRequest
        (v: obj -> unit) = x.attribute "customRequest" v
    member x.Data
        (v: UploadFile -> obj) = x.attribute "data" v
    member x.DefaultFileList
        (v: obj array) = x.attribute "defaultFileList" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.FileList
        (v: obj array) = x.attribute "fileList" v
    member x.Headers
        (v: obj) = x.attribute "headers" v
    member x.ListType
        (v: UploadListType) = x.attribute "listType" v
    member x.Multiple
        (v: bool) = x.attribute "multiple" v
    member x.Name
        (v: string) = x.attribute "name" v
    member x.PreviewFile
        (v: UploadFile -> Promise<string>) = x.attribute "previewFile" v
    member x.ShowUploadList
        (v: bool) = x.attribute "showUploadList" v
    member x.SupportServerRender
        (v: bool) = x.attribute "supportServerRender" v
    member x.WithCredentials
        (v: bool) = x.attribute "withCredentials" v
    member x.OpenFileDialogOnClick
        (v: bool) = x.attribute "openFileDialogOnClick" v
    member x.OnChange
        (v: unit -> unit) = x.attribute "onChange" v
    member x.OnPreview
        (v: UploadFile -> unit) = x.attribute "onPreview" v
    member x.OnRemove
        (v: UploadFile -> bool) = x.attribute "onRemove" v
    member x.OnDownload
        (v: UploadFile -> unit) = x.attribute "onDownload" v
    member x.TransformFile
        (v: UploadFile -> UploadFile) = x.attribute "transformFile" v
    member x.IconRender
        (v: UploadFile -> UploadListType -> ReactElement) =
            let uncurried = System.Func<UploadFile, UploadListType, ReactElement> v
            x.attribute "iconRender" uncurried
