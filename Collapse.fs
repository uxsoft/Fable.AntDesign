namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Collapse =
    
    [<RequireQualifiedAccess>]
    type AntCollapse  =
        | ActiveKey of string array
        | DefaultActiveKey of string array
        | Bordered of bool
        | Accordion of bool
        | OnChange of (unit -> unit)
        | ExpandIcon of (obj -> ReactElement)
        | ExpandIconPosition of string
        | DestroyInactivePanel of bool
        static member Custom (key: string, value: obj): AntCollapse = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCollapse = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntCollapsePanel  =
        | Disabled of bool
        | ForceRender of bool
        | Header of ReactElement
        | Key of string
        | ShowArrow of bool
        | Extra of ReactElement
        static member Custom (key: string, value: obj): AntCollapsePanel = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCollapsePanel = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antCollapse (props: AntCollapse list) (children: ReactElement list): ReactElement =
       ofImport "Collapse" "antd" (keyValueList CaseRules.LowerFirst props) children


    let inline antCollapsePanel (props: AntCollapsePanel list) (children: ReactElement list): ReactElement =
       ofImport "Collapse.Panel" "antd" (keyValueList CaseRules.LowerFirst props) children
    