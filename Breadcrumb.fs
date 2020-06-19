namespace Fable.AntD

open Fable.React
open Browser.Types

type AntBreadcrumb() =
    inherit AntElement(ofImport "Breadcrumb" "antd")
    member x.ItemRender (v: (string * string * string list * string list -> ReactElement)) = x.attribute "itemRender" v 
    member x.Params (v: obj) = x.attribute "params" v 
    member x.Routes (v: obj list) = x.attribute "routes" v 
    member x.Separator (v: ReactElement) = x.attribute "separator" v 

type AntBreadcrumbItem() =
    inherit AntElement(ofImport "Breadcrumb.Item" "antd")
    member x.Href (v: string) = x.attribute "href" v 
    member x.Overlay (v: ReactElement) = x.attribute "overlay" v 
    member x.OnClick (v: (Event -> unit)) = x.attribute "onClick" v 
    
type AntBreadcrumbSeparator() =
    inherit AntElement(ofImport "Breadcrumb.Separator" "antd")