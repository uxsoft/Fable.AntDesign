namespace Fable.AntD

open Fable.React

type AntPageHeader() =
    inherit AntElement<AntPageHeader>(ofImport "PageHeader" "antd")
    member x.title (v: ReactElement) = x.attribute "title" v
    member x.subTitle (v: ReactElement) = x.attribute "subTitle" v
    member x.ghost (?v: bool) = x.attribute "ghost" (Option.defaultValue true v)
    member x.avatar (v: ReactElement) = x.attribute "avatar" v
    member x.backIcon (v: ReactElement) = x.attribute "backIcon" v
    member x.tags (v: ReactElement list) = x.attribute "tags" v
    member x.extra (v: ReactElement) = x.attribute "extra" v
    member x.breadcrumb (v: ReactElement) = x.attribute "breadcrumb" v
    member x.footer (v: ReactElement) = x.attribute "footer" v
    member x.onBack (v: (unit -> unit)) = x.attribute "onBack" v 