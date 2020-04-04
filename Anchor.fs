namespace Fable.AntD

open Browser.Types
open Fable.React

type Anchor() =
    inherit AntElement("Anchor")
    member x.Affix with set (v: bool) = x.Attribute "affix" v 
    member x.Bounds with set (v: int) = x.Attribute "bounds" v 
    member x.GetContainer with set (v: (unit -> HTMLElement)) = x.Attribute "getContainer" v 
    member x.OffsetBottom with set (v: int) = x.Attribute "offsetBottom" v 
    member x.OffsetTop with set (v: int) = x.Attribute "offsetTop" v 
    member x.ShowInkInFixed with set (v: bool) = x.Attribute "showInkInFixed" v 
    member x.OnClick with set (v: (Event -> obj -> unit)) = x.Attribute "onClick" v 
    member x.GetCurrentAnchor with set (v: (unit -> string)) = x.Attribute "getCurrentAnchor" v 
    member x.TargetOffset with set (v: int) = x.Attribute "targetOffset" v 
    member x.OnChange with set (v: (string -> unit)) = x.Attribute "onChange" v 
   
type AnchorLink() =
    inherit AntElement("Anchor.Link")
    member x.Href with set (v: string) = x.Attribute "href" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.Target with set (v: string) = x.Attribute "target" v 