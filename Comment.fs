namespace Fable.AntD

open Fable.React

type AntComment() =
    inherit AntElement<AntComment>(ofImport "Comment" "antd")
    member x.actions (v: ReactElement array) = x.attribute "actions" v 
    member x.author (v: ReactElement) = x.attribute "author" v 
    member x.avatar (v: ReactElement) = x.attribute "avatar" v 
    member x.content (v: ReactElement) = x.attribute "content" v 
    member x.dateTime (v: ReactElement) = x.attribute "datetime" v 