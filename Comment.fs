namespace Fable.AntD

open Fable.React

type Comment() =
    inherit AntElement(ofImport "Comment" "antd")
    member x.Actions with set (v: ReactElement array) = x.Attribute "actions" v 
    member x.Author with set (v: ReactElement) = x.Attribute "author" v 
    member x.Avatar with set (v: ReactElement) = x.Attribute "avatar" v 
    member x.Content with set (v: ReactElement) = x.Attribute "content" v 
    member x.DateTime with set (v: ReactElement) = x.Attribute "datetime" v 