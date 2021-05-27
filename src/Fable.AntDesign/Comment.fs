module Fable.AntDesign.Comment

open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type CommentBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Comment" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("actions")>] member _.actions (x: DSLElement, v: ReactElement array) = x.attr "actions" v 
    [<CustomOperation("author")>] member _.author (x: DSLElement, v: ReactElement) = x.attr "author" v 
    [<CustomOperation("avatar")>] member _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v 
    [<CustomOperation("content")>] member _.content (x: DSLElement, v: ReactElement) = x.attr "content" v 
    [<CustomOperation("dateTime")>] member _.dateTime (x: DSLElement, v: ReactElement) = x.attr "datetime" v