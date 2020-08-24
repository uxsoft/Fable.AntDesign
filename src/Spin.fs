namespace Fable.AntD

open Fable.React

type AntSpin()  =
    inherit AntElement<AntSpin>(ofImport "Spin" "antd")
    member x.delay (v: int) = x.attribute "delay" v
    member x.indicator (v: ReactElement) = x.attribute "indicator" v
    member x.size (v: Size) = x.attribute "size" v
    member x.spinning (v: bool) = x.attribute "spinning" v
    member x.tip (v: string) = x.attribute "tip" v
    member x.wrapperClassName (v: string ) = x.attribute "wrapperClassName" v
    