module Fable.AntDesign.Breadcrumb

open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop
open Browser.Types
open System

type BreadcrumbRoute = {
    path: string
    breadcrumbName: string
    children: BreadcrumbRoute array
}

type BreadcrumbBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Breadcrumb" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("itemRender")>] member inline _.itemRender (x: DSLElement, v: Func<string, string, string list, string list, ReactElement>) = x.attr "itemRender" v 
    [<CustomOperation("params")>] member inline _.parameters (x: DSLElement, v: obj) = x.attr "params" v 
    [<CustomOperation("routes")>] member inline _.routes (x: DSLElement, v: BreadcrumbRoute array) = x.attr "routes" v 
    [<CustomOperation("separator")>] member inline _.separator (x: DSLElement, v: ReactElement) = x.attr "separator" v 

type BreadcrumbItemBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Breadcrumb.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("dropdownProps")>] member inline _.dropdownProps (x: DSLElement, v: obj) = x.attr "dropdownProps" v //TODO better AntDropdown props
    [<CustomOperation("href")>] member inline _.href (x: DSLElement, v: string) = x.attr "href" v 
    [<CustomOperation("overlay")>] member inline _.overlay (x: DSLElement, v: ReactElement) = x.attr "overlay" v 
    [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: Func<Event, unit>) = x.attr "onClick" v 
    
type BreadcrumbSeparatorBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Breadcrumb.Separator" "antd" (createObj s.Attributes) s.Children
