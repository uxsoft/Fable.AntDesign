namespace Fable.AntD

open Fable.React

type AntTag() =
    inherit AntElement<AntTag>(ofImport "Tag" "antd")
    member x.closeable (?v: bool) = x.attribute "closeable" (Option.defaultValue true v)
    member x.color (v: string) = x.attribute "color" v
    member x.onClose (v: obj -> unit) = x.attribute "onClose" v
    member x.visible (?v: bool) = x.attribute "visible" (Option.defaultValue true v)
    member x.icon (v: ReactElement) = x.attribute "icon" v

type AntCheckableTag() =
    inherit AntElement<AntCheckableTag>(ofImport "Tag.CheckableTag" "antd")
    member x.isChecked (?v: bool) = x.attribute "checked" (Option.defaultValue true v)
    member x.onChange (v: bool -> unit) = x.attribute "onChange" v
