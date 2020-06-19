namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>] type DrawerPlacement = Top | Right | Bottom | Left

type AntDrawer() =
    inherit AntElement(ofImport "Drawer" "antd")
    member x.Closable (v: bool) = x.attribute "closable" v 
    member x.DestroyOnClose (v: bool) = x.attribute "destroyOnClose" v 
    member x.GetContainer (v: (unit -> ReactElement)) = x.attribute "getContainer" v 
    member x.Mask (v: bool) = x.attribute "mask" v 
    member x.MaskClosable (v: bool) = x.attribute "maskClosable" v 
    member x.Title (v: ReactElement) = x.attribute "title" v 
    member x.Visible (v: bool) = x.attribute "visible" v 
    member x.Width (v: string) = x.attribute "width" v 
    member x.Height (v: string) = x.attribute "height" v 
    member x.ClassName (v: string) = x.attribute "className" v 
    member x.ZIndex (v: int) = x.attribute "zIndex" v 
    member x.Placement (v: DrawerPlacement) = x.attribute "placement" v 
    member x.OnClose (v: (Event -> unit)) = x.attribute "onClose" v 
    member x.AfterVisibleChange (v: (bool -> unit)) = x.attribute "afterVisibleChange" v 
    member x.Keyboard (v: bool) = x.attribute "keyboard" v 
    member x.MaskStyle (css: Props.CSSProp list) = x.attribute "maskStyle" (keyValueList CaseRules.LowerFirst css)
    member x.DrawerStyle (css: Props.CSSProp list) = x.attribute "drawerStyle" (keyValueList CaseRules.LowerFirst css)
    member x.HeaderStyle (css: Props.CSSProp list) = x.attribute "headerStyle" (keyValueList CaseRules.LowerFirst css)
    member x.BodyStyle (css: Props.CSSProp list) = x.attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)
