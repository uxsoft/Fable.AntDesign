namespace Fable.AntD

open Fable.React
open Browser.Types
open System

type BreadcrumbRoute = {
    path: string
    breadcrumbName: string
    children: BreadcrumbRoute array
}

type AntBreadcrumb() =
    inherit AntElement<AntBreadcrumb>(ofImport "Breadcrumb" "antd")
    member x.itemRender (v: Func<string, string, string list, string list, ReactElement>) = x.attribute "itemRender" v 
    member x.params (v: obj) = x.attribute "params" v 
    member x.routes (v: BreadcrumbRoute array) = x.attribute "routes" v 
    member x.separator (v: ReactElement) = x.attribute "separator" v 

type AntBreadcrumbItem() =
    inherit AntElement<AntBreadcrumbItem>(ofImport "Breadcrumb.Item" "antd")
    member x.href (v: string) = x.attribute "href" v 
    member x.overlay (v: ReactElement) = x.attribute "overlay" v 
    member x.onClick (v: (Func<Event, unit>)) = x.attribute "onClick" v 
    member x.dropdownProps (v: AntDropdown) = x.attribute "dropdownProps" v.JSON
    
type AntBreadcrumbSeparator() =
    inherit AntElement<AntBreadcrumbSeparator>(ofImport "Breadcrumb.Separator" "antd")