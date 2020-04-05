namespace Fable.AntD

open Fable.React

    type Collapse() =
        inherit AntElement(ofImport "Collapse" "antd")
        member x.ActiveKey with set (v: string array) = x.Attribute "activeKey" v 
        member x.DefaultActiveKey with set (v: string array) = x.Attribute "defaultActiveKey" v 
        member x.Bordered with set (v: bool) = x.Attribute "bordered" v 
        member x.Accordion with set (v: bool) = x.Attribute "accordion" v 
        member x.OnChange with set (v: (unit -> unit)) = x.Attribute "onChange" v 
        member x.ExpandIcon with set (v: (obj -> ReactElement)) = x.Attribute "expandIcon" v 
        member x.ExpandIconPosition with set (v: string) = x.Attribute "expandIconPosition" v 
        member x.DestroyInactivePanel with set (v: bool) = x.Attribute "destroyInactivePanel" v 

    type CollapsePanel() =
        inherit AntElement(ofImport "Collapse.Panel" "antd")
        member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
        member x.ForceRender with set (v: bool) = x.Attribute "forceRender" v 
        member x.Header with set (v: ReactElement) = x.Attribute "header" v 
        member x.Key with set (v: string) = x.Attribute "key" v 
        member x.ShowArrow with set (v: bool) = x.Attribute "showArrow" v 
        member x.Extra with set (v: ReactElement) = x.Attribute "extra" v 