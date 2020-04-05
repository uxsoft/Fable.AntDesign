namespace Fable.AntD

open Fable.React

type Affix() =
    inherit AntElement(ofImport "Affix" "antd")
    member x.OffsetBottom with set (v: float) = x.Attribute "offsetBottom" v 
    member x.OffsetTop with set (v: float) = x.Attribute "offsetTop" v 
    member x.Target with set (v: (unit -> ReactElement)) = x.Attribute "target" v 
    member x.OnChange with set (v: (ReactElement -> unit)) = x.Attribute "onChange" v 