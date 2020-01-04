namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Breadcrumb =
    
    [<RequireQualifiedAccess>]
    type AntBreadcrumb =
        | ItemRender of (string * string * string list * string list -> ReactElement)
        | Params of obj
        | Routes of obj list
        | Separator of U2<string, ReactElement>
        
    [<RequireQualifiedAccess>]
    type AntBreadcrumbItem =
        | Overlay of ReactElement
    
    let inline antBreadcrumb (props: AntBreadcrumb list) (children: ReactElement list): ReactElement =
       ofImport "Breadcrumb" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antBreadcrumbItem (props: AntBreadcrumbItem list) (children: ReactElement list): ReactElement =
       ofImport "Breadcrumb.Item" "antd" (keyValueList CaseRules.LowerFirst props) children