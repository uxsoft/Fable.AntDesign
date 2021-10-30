namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module PageHeader =

    type PageHeaderBuilder() =
        inherit ReactBuilder(import "PageHeader" "antd")
    
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
        [<CustomOperation("subTitle")>] member inline _.subTitle (x: DSLElement, v: ReactElement) = x.attr "subTitle" v
        [<CustomOperation("ghost")>] member inline _.ghost (x: DSLElement, v: bool) = x.attr "ghost" v
        [<CustomOperation("avatar")>] member inline _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v
        [<CustomOperation("backIcon")>] member inline _.backIcon (x: DSLElement, v: ReactElement) = x.attr "backIcon" v
        [<CustomOperation("tags")>] member inline _.tags (x: DSLElement, v: ReactElement list) = x.attr "tags" v
        [<CustomOperation("extra")>] member inline _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
        [<CustomOperation("breadcrumb")>] member inline _.breadcrumb (x: DSLElement, v: ReactElement) = x.attr "breadcrumb" v
        [<CustomOperation("footer")>] member inline _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
        [<CustomOperation("onBack")>] member inline _.onBack (x: DSLElement, v: unit -> unit) = x.attr "onBack" v 