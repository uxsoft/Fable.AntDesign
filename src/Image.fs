namespace Fable.AntD

open Browser.Types
open Fable.React

type AntImage() =
    inherit AntElement<AntImage>(ofImport "Image" "antd")
    member x.alt (v: string) = x.attribute "alt" v 
    member x.fallback (v: string) = x.attribute "fallback" v 
    member x.height (v: int) = x.attribute "height" v 
    member x.placeholder (v: ReactElement) = x.attribute "placeholder" v 
    member x.preview (?v: bool) = x.attribute "preview" (Option.defaultValue true v) 
    member x.src (v: string) = x.attribute "src" v 
    member x.width (v: int) = x.attribute "width" v 
