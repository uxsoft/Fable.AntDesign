namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type CollapseCollapsible = Header | Disabled

[<StringEnum; RequireQualifiedAccess>]
type CollapseExpandIconPosition = Left | Right

type AntCollapse() =
    inherit AntElement<AntCollapse>(ofImport "Collapse" "antd")
    member x.accordion (?v: bool) = x.attribute "accordion" (Option.defaultValue true v) 
    member x.activeKey (v: string array) = x.attribute "activeKey" v 
    member x.bordered (?v: bool) = x.attribute "bordered" (Option.defaultValue true v) 
    member x.collapsible (v: CollapseCollapsible) = x.attribute "collapsible" v
    member x.defaultActiveKey (v: string array) = x.attribute "defaultActiveKey" v 
    member x.destroyInactivePanel (?v: bool) = x.attribute "destroyInactivePanel" (Option.defaultValue true v)
    member x.expandIcon (v: (obj -> ReactElement)) = x.attribute "expandIcon" v 
    member x.expandIconPosition (v: CollapseExpandIconPosition) = x.attribute "expandIconPosition" v 
    member x.ghost (?v: bool) = x.attribute "ghost" (Option.defaultValue true v)        
    member x.onChange (v: (unit -> unit)) = x.attribute "onChange" v 

type AntCollapsePanel() =
    inherit AntElement<AntCollapsePanel>(ofImport "Collapse.Panel" "antd")
    member x.collapsible (v: CollapseCollapsible) = x.attribute "collapsible" v
    member x.extra (v: ReactElement) = x.attribute "extra" v
    member x.forceRender (?v: bool) = x.attribute "forceRender" (Option.defaultValue true v) 
    member x.header (v: ReactElement) = x.attribute "header" v
    member x.showArrow (?v: bool) = x.attribute "showArrow" (Option.defaultValue true v)
