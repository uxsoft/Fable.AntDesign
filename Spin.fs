namespace Fable.AntD

open Fable.React

type AntSpin()  =
    inherit AntElement(ofImport "Spin" "antd")
    member x.Delay (v: int) = x.attribute "delay" v
    member x.Indicator (v: ReactElement) = x.attribute "indicator" v
    member x.Size (v: Size) = x.attribute "size" v
    member x.Spinning (v: bool) = x.attribute "spinning" v
    member x.Tip (v: string) = x.attribute "tip" v
    member x.WrapperClassName (v: string ) = x.attribute "wrapperClassName" v
    