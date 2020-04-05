namespace Fable.AntD

open Fable.React

type Spin()  =
    inherit AntElement(ofImport "Spin" "antd")
    member x.Delay with set (v: int) = x.Attribute "delay" v
    member x.Indicator with set (v: ReactElement) = x.Attribute "indicator" v
    member x.Size with set (v: Size) = x.Attribute "size" v
    member x.Spinning with set (v: bool) = x.Attribute "spinning" v
    member x.Tip with set (v: string) = x.Attribute "tip" v
    member x.WrapperClassName with set (v: string ) = x.Attribute "wrapperClassName" v
    