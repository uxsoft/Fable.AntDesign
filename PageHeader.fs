namespace Fable.AntD


open Fable.React

    type PageHeader() =
        inherit AntElement("PageHeader")
        member x.Title with set (v: ReactElement) = x.Attribute "title" v
        member x.SubTitle with set (v: ReactElement) = x.Attribute "subTitle" v
        member x.Ghost with set (v: bool) = x.Attribute "ghost" v
        member x.Avatar with set (v: ReactElement) = x.Attribute "avatar" v
        member x.BackIcon with set (v: ReactElement) = x.Attribute "backIcon" v
        member x.Tags with set (v: ReactElement list) = x.Attribute "tags" v
        member x.Extra with set (v: ReactElement) = x.Attribute "extra" v
        member x.Breadcrumb with set (v: ReactElement) = x.Attribute "breadcrumb" v
        member x.Footer with set (v: ReactElement) = x.Attribute "footer" v
        member x.OnBack with set (v: (unit -> unit)) = x.Attribute "onBack" v 
