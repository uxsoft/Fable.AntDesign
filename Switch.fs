namespace Fable.AntD

open Browser.Types
open Fable.React

type AntSwitch() =
    inherit AntElement(ofImport "Switch" "antd")
    member x.AutoFocus
        (v: bool) = x.attribute "autoFocus" v
    member x.Checked
        (v: bool) = x.attribute "checked" v
    member x.CheckedChildren
        (v: ReactElement) = x.attribute "checkedChildren" v
    member x.DefaultChecked
        (v: bool) = x.attribute "defaultChecked" v
    member x.Disabled
        (v: bool) = x.attribute "disabled" v
    member x.Loading
        (v: bool) = x.attribute "loading" v
    member x.Size
        (v: Size) = x.attribute "size" v
    member x.UnCheckedChildren
        (v: ReactElement) = x.attribute "unCheckedChildren" v
    member x.OnChange
        (v: bool -> Event -> unit) =
            let uncurried = System.Func<bool, Event, unit> v
            x.attribute "onChange" uncurried
    member x.OnClick
        (v: bool -> Event -> unit) =
            let uncurried = System.Func<bool, Event, unit> v
            x.attribute "onClick" uncurried
    member x.ClassName
        (v: string) = x.attribute "className" v
