namespace Fable.AntD

open Browser.Types
open Fable.React
open System

type AntPreview() =
    inherit AntObject<AntPreview>()
    
    member x.visible (?v: bool) = x.attribute "visible" (Option.defaultValue true v)
    member x.onVisibleChange (v: Func<bool, bool, unit>) = x.attribute "onVisibleChange" v
    member x.getContainer (v: unit -> HTMLElement) = x.attribute "getContainer" v 

type AntImagePreviewGroup() =
    inherit AntElement<AntImagePreviewGroup>(ofImport "Image.PreviewGroup" "antd")

type AntImage() =
    inherit AntElement<AntImage>(ofImport "Image" "antd")
    member x.alt (v: string) = x.attribute "alt" v 
    member x.fallback (v: string) = x.attribute "fallback" v 
    member x.height (v: int) = x.attribute "height" v 
    member x.placeholder (v: ReactElement) = x.attribute "placeholder" v 
    member x.preview (?v: bool) = x.attribute "preview" (Option.defaultValue true v) 
    member x.previewConfig (v: AntPreview) = x.attribute "preview" v.JSON
    member x.src (v: string) = x.attribute "src" v 
    member x.width (v: int) = x.attribute "width" v 
