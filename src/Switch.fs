namespace Fable.AntD

open Browser.Types
open Fable.React
open System

type AntSwitch() =
    inherit AntElement<AntSwitch>(ofImport "Switch" "antd")
    member x.autoFocus (?v: bool) = x.attribute "autoFocus" (Option.defaultValue true v)
    member x.checked (?v: bool) = x.attribute "checked" (Option.defaultValue true v)
    member x.checkedChildren (v: ReactElement) = x.attribute "checkedChildren" v
    member x.defaultChecked (?v: bool) = x.attribute "defaultChecked" (Option.defaultValue true v)
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)
    member x.loading (?v: bool) = x.attribute "loading" (Option.defaultValue true v)
    member x.size (v: Size) = x.attribute "size" v
    member x.unCheckedChildren (v: ReactElement) = x.attribute "unCheckedChildren" v
    member x.onChange (v: Func<bool, Event, unit>) = x.attribute "onChange" v
    member x.onClick (v: Func<bool, Event, unit>) = x.attribute "onClick" v
    member x.className (v: string) = x.attribute "className" v
