namespace Fable.AntD

open Browser.Types
open Fable.React

type AntBackTop() =
    inherit AntElement<AntBackTop>(ofImport "BackTop" "antd")
    member x.target (v: (unit -> HTMLElement)) = x.attribute "target" v 
    member x.visibilityHeight (v: int) = x.attribute "visibilityHeight" v 
    member x.onClick (v: (unit -> unit)) = x.attribute "onClick" v 