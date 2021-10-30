namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop
open Browser.Types
open System

[<AutoOpen>]
module Breadcrumb =

    type BreadcrumbRoute = {
        path: string
        breadcrumbName: string
        children: BreadcrumbRoute array
    }
    
    type BreadcrumbBuilder() =
        inherit ReactBuilder(import "Breadcrumb" "antd")
    
        [<CustomOperation("itemRender")>] member inline _.itemRender (x: DSLElement, v: Func<string, string, string list, string list, ReactElement>) = x.attr "itemRender" v 
        [<CustomOperation("params")>] member inline _.parameters (x: DSLElement, v: obj) = x.attr "params" v 
        [<CustomOperation("routes")>] member inline _.routes (x: DSLElement, v: BreadcrumbRoute array) = x.attr "routes" v 
        [<CustomOperation("separator")>] member inline _.separator (x: DSLElement, v: ReactElement) = x.attr "separator" v 
    
    type BreadcrumbItemBuilder() =
        inherit ReactBuilder(import "Breadcrumb.Item" "antd")
    
        [<CustomOperation("dropdownProps")>] member inline _.dropdownProps (x: DSLElement, v: obj) = x.attr "dropdownProps" v //TODO better AntDropdown props
        [<CustomOperation("href")>] member inline _.href (x: DSLElement, v: string) = x.attr "href" v 
        [<CustomOperation("overlay")>] member inline _.overlay (x: DSLElement, v: ReactElement) = x.attr "overlay" v 
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: Func<Event, unit>) = x.attr "onClick" v 
        
    type BreadcrumbSeparatorBuilder() =
        inherit ReactBuilder(import "Breadcrumb.Separator" "antd")
    