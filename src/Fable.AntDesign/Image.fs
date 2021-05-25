module Fable.AntDesign.Image

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open System
open Fable.Core.JsInterop

type ImagePreviewSettings =
    | Visible of bool
    | OnVisibleChange of (bool * bool -> unit)
    | GetContainer of string // V4.8.0
    | Src of string // V4.10.0
    | Mask of ReactElement // V4.9.0
    | MaskClassName of string // V4.11.0
    | Current of int // V4.12.0 Only support PreviewGroup.

type ImagePreviewGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Image.PreviewGroup" "antd" (createObj s.Attributes) s.Children


type ImageBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Image" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("alt")>] member _.alt (x: DSLElement, v: string) = x.attr "alt" v 
    [<CustomOperation("fallback")>] member _.fallback (x: DSLElement, v: string) = x.attr "fallback" v 
    [<CustomOperation("height")>] member _.height (x: DSLElement, v: int) = x.attr "height" v 
    [<CustomOperation("placeholder")>] member _.placeholder (x: DSLElement, v: ReactElement) = x.attr "placeholder" v 
    [<CustomOperation("preview")>] member _.preview (x: DSLElement) = x.attr "preview" true
    [<CustomOperation("previewConfig")>] member _.previewConfig (x: DSLElement, v: ImagePreviewSettings list) = x.attr "preview" (keyValueList CaseRules.LowerFirst v)
    [<CustomOperation("src")>] member _.src (x: DSLElement, v: string) = x.attr "src" v 
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: int) = x.attr "width" v 
