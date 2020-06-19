namespace Fable.AntD

open Fable.React

    type AntCollapse() =
        inherit AntElement(ofImport "Collapse" "antd")
        member x.ActiveKey (v: string array) = x.attribute "activeKey" v 
        member x.DefaultActiveKey (v: string array) = x.attribute "defaultActiveKey" v 
        member x.Bordered (v: bool) = x.attribute "bordered" v 
        member x.Accordion (v: bool) = x.attribute "accordion" v 
        member x.OnChange (v: (unit -> unit)) = x.attribute "onChange" v 
        member x.ExpandIcon (v: (obj -> ReactElement)) = x.attribute "expandIcon" v 
        member x.ExpandIconPosition (v: string) = x.attribute "expandIconPosition" v 
        member x.DestroyInactivePanel (v: bool) = x.attribute "destroyInactivePanel" v 

    type AntCollapsePanel() =
        inherit AntElement(ofImport "Collapse.Panel" "antd")
        member x.Disabled (v: bool) = x.attribute "disabled" v 
        member x.ForceRender (v: bool) = x.attribute "forceRender" v 
        member x.Header (v: ReactElement) = x.attribute "header" v 
        member x.Key (v: string) = x.attribute "key" v 
        member x.ShowArrow (v: bool) = x.attribute "showArrow" v 
        member x.Extra (v: ReactElement) = x.attribute "extra" v 