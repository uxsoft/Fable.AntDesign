namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>] type DrawerPlacement = Top | Right | Bottom | Left

type AntDrawer() =
    inherit AntElement<AntDrawer>(ofImport "Drawer" "antd")
    member x.closable (v: bool) = x.attribute "closable" v 
    member x.destroyOnClose (v: bool) = x.attribute "destroyOnClose" v
    member x.forceRender (v: bool) = x.attribute "forceRender" v
    member x.getContainer (v: (unit -> HTMLElement)) = x.attribute "getContainer" v 
    member x.mask (v: bool) = x.attribute "mask" v 
    member x.maskClosable (v: bool) = x.attribute "maskClosable" v
    member x.maskStyle (css: Props.CSSProp list) = x.attribute "maskStyle" (keyValueList CaseRules.LowerFirst css)
    member x.drawerStyle (css: Props.CSSProp list) = x.attribute "drawerStyle" (keyValueList CaseRules.LowerFirst css)
    member x.headerStyle (css: Props.CSSProp list) = x.attribute "headerStyle" (keyValueList CaseRules.LowerFirst css)
    member x.bodyStyle (css: Props.CSSProp list) = x.attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.visible (v: bool) = x.attribute "visible" v 
    member x.width (v: string) = x.attribute "width" v 
    member x.height (v: string) = x.attribute "height" v 
    member x.className (v: string) = x.attribute "className" v 
    member x.zIndex (v: int) = x.attribute "zIndex" v 
    member x.placement (v: DrawerPlacement) = x.attribute "placement" v 
    member x.onClose (v: (Event -> unit)) = x.attribute "onClose" v 
    member x.afterVisibleChange (v: (bool -> unit)) = x.attribute "afterVisibleChange" v 
    member x.keyboard (v: bool) = x.attribute "keyboard" v 
    member x.footer (v: ReactElement) = x.attribute "footer" v
    member x.footerStyle (css: Props.CSSProp list) = x.attribute "footerStyle" (keyValueList CaseRules.LowerFirst css)
