namespace Fable.AntD

open Fable.React

type AntAffix() =
    inherit AntElement<AntAffix>(ofImport "Affix" "antd")
    member x.offsetBottom (v: float) = x.attribute "offsetBottom" v 
    member x.offsetTop (v: float) = x.attribute "offsetTop" v 
    member x.target (v: (unit -> ReactElement)) = x.attribute "target" v 
    member x.onChange (v: (ReactElement -> unit)) = x.attribute "onChange" v 