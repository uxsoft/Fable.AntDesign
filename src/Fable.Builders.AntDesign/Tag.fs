namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Tag =

    type TagBuilder() =
        inherit ReactBuilder(import "Tag" "antd")
    
        [<CustomOperation("closeable")>] member inline _.closeable (x: DSLElement, v: bool) = x.attr "closeable" v
        [<CustomOperation("color")>] member inline _.color (x: DSLElement, v: string) = x.attr "color" v
        [<CustomOperation("onClose")>] member inline _.onClose (x: DSLElement, v: obj -> unit) = x.attr "onClose" v
        [<CustomOperation("visible")>] member inline _.visible (x: DSLElement, v: bool) = x.attr "visible" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    
    type CheckableTagBuilder() =
        inherit ReactBuilder(import "Tag.CheckableTag" "antd")
    
        [<CustomOperation("isChecked")>] member inline _.isChecked (x: DSLElement, v: bool) = x.attr "checked" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: bool -> unit) = x.attr "onChange" v
    