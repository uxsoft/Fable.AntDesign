namespace Fable.AntD

open Browser.Types
open Fable.React

type AntBackTop() =
    inherit AntElement(ofImport "BackTop" "antd")
    member x.Target (v: (unit -> HTMLElement)) = x.attribute "target" v 
    member x.VisibilityHeight (v: int) = x.attribute "visibilityHeight" v 
    member x.OnClick (v: (unit -> unit)) = x.attribute "onClick" v 