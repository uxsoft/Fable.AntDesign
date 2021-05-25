module Fable.AntDesign.PageHeader

open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type PageHeaderBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "PageHeader" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("subTitle")>] member _.subTitle (x: DSLElement, v: ReactElement) = x.attr "subTitle" v
    [<CustomOperation("ghost")>] member _.ghost (x: DSLElement) = x.attr "ghost" true
    [<CustomOperation("avatar")>] member _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v
    [<CustomOperation("backIcon")>] member _.backIcon (x: DSLElement, v: ReactElement) = x.attr "backIcon" v
    [<CustomOperation("tags")>] member _.tags (x: DSLElement, v: ReactElement list) = x.attr "tags" v
    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v
    [<CustomOperation("breadcrumb")>] member _.breadcrumb (x: DSLElement, v: ReactElement) = x.attr "breadcrumb" v
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
    [<CustomOperation("onBack")>] member _.onBack (x: DSLElement, v: unit -> unit) = x.attr "onBack" v 