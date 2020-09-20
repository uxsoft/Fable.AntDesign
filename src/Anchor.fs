namespace Fable.AntD

open Browser.Types
open Fable.React

type AntAnchor() =
    inherit AntElement<AntAnchor>(ofImport "Anchor" "antd")
    member x.affix (?v: bool) = x.attribute "affix" (Option.defaultValue true v) 
    member x.bounds (v: int) = x.attribute "bounds" v 
    member x.getContainer (v: (unit -> HTMLElement)) = x.attribute "getContainer" v 
    member x.offsetBottom (v: int) = x.attribute "offsetBottom" v 
    member x.offsetTop (v: int) = x.attribute "offsetTop" v 
    member x.showInkInFixed (v: bool) = x.attribute "showInkInFixed" v 
    member x.onClick (v: (Event -> obj -> unit)) = x.attribute "onClick" v 
    member x.getCurrentAnchor (v: (unit -> string)) = x.attribute "getCurrentAnchor" v 
    member x.targetOffset (v: int) = x.attribute "targetOffset" v 
    member x.onChange (v: (string -> unit)) = x.attribute "onChange" v 
   
type AntAnchorLink() =
    inherit AntElement<AntAnchorLink>(ofImport "Anchor.Link" "antd")
    member x.href (v: string) = x.attribute "href" v 
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.target (v: string) = x.attribute "target" v 