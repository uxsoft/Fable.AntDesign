namespace Fable.AntD

open Fable.React

type AntTagBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.afterClose(v: unit -> unit) = x.attribute "afterClose" v
    member x.closeable(v: bool) = x.attribute "closeable" v
    member x.color(v: string) = x.attribute "color" v
    member x.onClose(v: obj -> unit) = x.attribute "onClose" v
    member x.visible(v: bool) = x.attribute "visible" v

type AntTag() =
    inherit AntTagBase<AntTag>(ofImport "Tag" "antd")

type AntCheckableTag() =
    inherit AntTagBase<AntCheckableTag>(ofImport "Tag.CheckableTag" "antd")
    member x.isChecked(v: bool) = x.attribute "checked" v
    member x.onChange(v: bool -> unit) = x.attribute "onChange" v
