namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Browser.Types

[<AutoOpen>]
module Breadcrumb =
    
    [<RequireQualifiedAccess>]
    type AntBreadcrumb =
        | ItemRender of (string * string * string list * string list -> ReactElement)
        | Params of obj
        | Routes of obj list
        | Separator of ReactElement
        static member Custom (key: string, value: obj): AntBreadcrumb = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntBreadcrumb = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    [<RequireQualifiedAccess>]
    type AntBreadcrumbItem =
        | Href of string
        | Overlay of ReactElement
        | OnClick of (Event -> unit)
        static member Custom (key: string, value: obj): AntBreadcrumbItem = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntBreadcrumbItem = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antBreadcrumb (props: AntBreadcrumb list) (children: ReactElement list): ReactElement =
       ofImport "Breadcrumb" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antBreadcrumbItem (props: AntBreadcrumbItem list) (children: ReactElement list): ReactElement =
        ofImport "Breadcrumb.Item" "antd" (keyValueList CaseRules.LowerFirst props) children
                                                                                                  
    let inline antBreadcrumbSeparator (children: ReactElement list): ReactElement =
       ofImport "Breadcrumb.Separator" "antd" (keyValueList CaseRules.LowerFirst []) children