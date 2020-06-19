namespace Fable.AntD

open Fable.React

    type AntCollapse() =
        inherit AntElement<AntCollapse>(ofImport "Collapse" "antd")
        member x.activeKey (v: string array) = x.attribute "activeKey" v 
        member x.defaultActiveKey (v: string array) = x.attribute "defaultActiveKey" v 
        member x.bordered (v: bool) = x.attribute "bordered" v 
        member x.accordion (v: bool) = x.attribute "accordion" v 
        member x.onChange (v: (unit -> unit)) = x.attribute "onChange" v 
        member x.expandIcon (v: (obj -> ReactElement)) = x.attribute "expandIcon" v 
        member x.expandIconPosition (v: string) = x.attribute "expandIconPosition" v 
        member x.destroyInactivePanel (v: bool) = x.attribute "destroyInactivePanel" v 

    type AntCollapsePanel() =
        inherit AntElement<AntCollapsePanel>(ofImport "Collapse.Panel" "antd")
        member x.disabled (v: bool) = x.attribute "disabled" v 
        member x.forceRender (v: bool) = x.attribute "forceRender" v 
        member x.header (v: ReactElement) = x.attribute "header" v 
        member x.ley (v: string) = x.attribute "key" v 
        member x.showArrow (v: bool) = x.attribute "showArrow" v 
        member x.extra (v: ReactElement) = x.attribute "extra" v 