namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Comment =

    type CommentBuilder() =
        inherit ReactBuilder(import "Comment" "antd")
    
        [<CustomOperation("actions")>] member inline _.actions (x: DSLElement, v: ReactElement array) = x.attr "actions" v 
        [<CustomOperation("author")>] member inline _.author (x: DSLElement, v: ReactElement) = x.attr "author" v 
        [<CustomOperation("avatar")>] member inline _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v 
        [<CustomOperation("content")>] member inline _.content (x: DSLElement, v: ReactElement) = x.attr "content" v 
        [<CustomOperation("dateTime")>] member inline _.dateTime (x: DSLElement, v: ReactElement) = x.attr "datetime" v