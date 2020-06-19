namespace Fable.AntD

open Browser.Types
open Fable.React

type AntAffix() =
    inherit AntElement<AntAffix>(ofImport "Affix" "antd")
    member x.offsetBottom (v: int) = x.attribute "offsetBottom" v 
    member x.offsetTop (v: int) = x.attribute "offsetTop" v 
    member x.target (v: (unit -> HTMLElement)) = x.attribute "target" v 
    member x.onChange (v: (bool -> unit)) = x.attribute "onChange" v 