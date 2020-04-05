namespace Fable.AntD

open Fable.React
open Browser.Types

type Breadcrumb() =
    inherit AntElement(ofImport "Breadcrumb" "antd")
    member x.ItemRender with set (v: (string * string * string list * string list -> ReactElement)) = x.Attribute "itemRender" v 
    member x.Params with set (v: obj) = x.Attribute "params" v 
    member x.Routes with set (v: obj list) = x.Attribute "routes" v 
    member x.Separator with set (v: ReactElement) = x.Attribute "separator" v 

type BreadcrumbItem() =
    inherit AntElement(ofImport "Breadcrumb.Item" "antd")
    member x.Href with set (v: string) = x.Attribute "href" v 
    member x.Overlay with set (v: ReactElement) = x.Attribute "overlay" v 
    member x.OnClick with set (v: (Event -> unit)) = x.Attribute "onClick" v 
    
type BreadcrumbSeparator() =
    inherit AntElement(ofImport "Breadcrumb.Separator" "antd")