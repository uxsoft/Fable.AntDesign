namespace Fable.AntD

open Browser.Types
open Fable.React

type AntBackTop() =
    inherit AntElement(ofImport "BackTop" "antd")
    member x.Target with set (v: (unit -> HTMLElement)) = x.Attribute "target" v 
    member x.VisibilityHeight with set (v: int) = x.Attribute "visibilityHeight" v 
    member x.OnClick with set (v: (unit -> unit)) = x.Attribute "onClick" v 