module Fable.AntDesign.Tag

open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type TagBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Tag" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("closeable")>] member _.closeable (x: DSLElement, v: bool) = x.attr "closeable" v
    [<CustomOperation("color")>] member _.color (x: DSLElement, v: string) = x.attr "color" v
    [<CustomOperation("onClose")>] member _.onClose (x: DSLElement, v: obj -> unit) = x.attr "onClose" v
    [<CustomOperation("visible")>] member _.visible (x: DSLElement, v: bool) = x.attr "visible" v
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v

type CheckableTagBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Tag.CheckableTag" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("isChecked")>] member _.isChecked (x: DSLElement, v: bool) = x.attr "checked" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: bool -> unit) = x.attr "onChange" v
