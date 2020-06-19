namespace Fable.AntD

open Fable.React

type AntComment() =
    inherit AntElement(ofImport "Comment" "antd")
    member x.Actions (v: ReactElement array) = x.attribute "actions" v 
    member x.Author (v: ReactElement) = x.attribute "author" v 
    member x.Avatar (v: ReactElement) = x.attribute "avatar" v 
    member x.Content (v: ReactElement) = x.attribute "content" v 
    member x.DateTime (v: ReactElement) = x.attribute "datetime" v 