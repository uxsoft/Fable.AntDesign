module Fable.AntD.Builders.Breadcrumb

open Fable.AntD.Builders.Common
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

    [<CustomOperation("itemRender")>] member _.itemRender (x: DSLElement, v: Func<string, string, string list, string list, ReactElement>) = x.attr "itemRender" v 
    [<CustomOperation("params")>] member _.parameters (x: DSLElement, v: obj) = x.attr "params" v 
    [<CustomOperation("routes")>] member _.routes (x: DSLElement, v: BreadcrumbRoute array) = x.attr "routes" v 
    [<CustomOperation("separator")>] member _.separator (x: DSLElement, v: ReactElement) = x.attr "separator" v 

type BreadcrumbItemBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Breadcrumb.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("dropdownProps")>] member _.dropdownProps (x: DSLElement, v: obj) = x.attr "dropdownProps" v //TODO better AntDropdown props
    [<CustomOperation("href")>] member _.href (x: DSLElement, v: string) = x.attr "href" v 
    [<CustomOperation("overlay")>] member _.overlay (x: DSLElement, v: ReactElement) = x.attr "overlay" v 
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: (Func<Event, unit>)) = x.attr "onClick" v 
    
type BreadcrumbSeparatorBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Breadcrumb.Separator" "antd" (createObj s.Attributes) s.Children
