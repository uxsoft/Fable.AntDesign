namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>] type DrawerPlacement = Top | Right | Bottom | Left

type Drawer() =
    inherit AntElement("Drawer")
    member x.Closable with set (v: bool) = x.Attribute "closable" v 
    member x.DestroyOnClose with set (v: bool) = x.Attribute "destroyOnClose" v 
    member x.GetContainer with set (v: (unit -> ReactElement)) = x.Attribute "getContainer" v 
    member x.Mask with set (v: bool) = x.Attribute "mask" v 
    member x.MaskClosable with set (v: bool) = x.Attribute "maskClosable" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.Visible with set (v: bool) = x.Attribute "visible" v 
    member x.Width with set (v: string) = x.Attribute "width" v 
    member x.Height with set (v: string) = x.Attribute "height" v 
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.ZIndex with set (v: int) = x.Attribute "zIndex" v 
    member x.Placement with set (v: DrawerPlacement) = x.Attribute "placement" v 
    member x.OnClose with set (v: (Event -> unit)) = x.Attribute "onClose" v 
    member x.AfterVisibleChange with set (v: (bool -> unit)) = x.Attribute "afterVisibleChange" v 
    member x.Keyboard with set (v: bool) = x.Attribute "keyboard" v 
    member x.MaskStyle (css: Props.CSSProp list) = x.Attribute "maskStyle" (keyValueList CaseRules.LowerFirst css)
    member x.DrawerStyle (css: Props.CSSProp list) = x.Attribute "drawerStyle" (keyValueList CaseRules.LowerFirst css)
    member x.HeaderStyle (css: Props.CSSProp list) = x.Attribute "headerStyle" (keyValueList CaseRules.LowerFirst css)
    member x.BodyStyle (css: Props.CSSProp list) = x.Attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)
