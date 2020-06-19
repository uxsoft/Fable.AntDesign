namespace Fable.AntD

open Fable.React

type AntPageHeader() =
    inherit AntElement(ofImport "PageHeader" "antd")
    member x.Title (v: ReactElement) = x.attribute "title" v
    member x.SubTitle (v: ReactElement) = x.attribute "subTitle" v
    member x.Ghost (v: bool) = x.attribute "ghost" v
    member x.Avatar (v: ReactElement) = x.attribute "avatar" v
    member x.BackIcon (v: ReactElement) = x.attribute "backIcon" v
    member x.Tags (v: ReactElement list) = x.attribute "tags" v
    member x.Extra (v: ReactElement) = x.attribute "extra" v
    member x.Breadcrumb (v: ReactElement) = x.attribute "breadcrumb" v
    member x.Footer (v: ReactElement) = x.attribute "footer" v
    member x.OnBack (v: (unit -> unit)) = x.attribute "onBack" v 