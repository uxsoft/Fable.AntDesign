namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser.Types

[<AutoOpen>]
module Drawer =

    [<StringEnum; RequireQualifiedAccess>] type DrawerPlacement = Top | Right | Bottom | Left
    
    type DrawerBuilder() =
        inherit ReactBuilder(import "Drawer" "antd")
    
        [<CustomOperation("closable")>] member inline _.closable (x: DSLElement, v: bool) = x.attr "closable" v 
        [<CustomOperation("destroyOnClose")>] member inline _.destroyOnClose (x: DSLElement, v: bool) = x.attr "destroyOnClose" v
        [<CustomOperation("forceRender")>] member inline _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v
        [<CustomOperation("getContainer")>] member inline _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v 
        [<CustomOperation("mask")>] member inline _.mask (x: DSLElement, v: bool) = x.attr "mask" v 
        [<CustomOperation("maskClosable")>] member inline _.maskClosable (x: DSLElement, v: bool) = x.attr "maskClosable" v
        [<CustomOperation("maskStyle")>] member inline _.maskStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "maskStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("drawerStyle")>] member inline _.drawerStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "drawerStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("headerStyle")>] member inline _.headerStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "headerStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("bodyStyle")>] member inline _.bodyStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "bodyStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
        [<CustomOperation("visible")>] member inline _.visible (x: DSLElement, v: bool) = x.attr "visible" v 
        [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: string) = x.attr "width" v 
        [<CustomOperation("height")>] member inline _.height (x: DSLElement, v: string) = x.attr "height" v 
        [<CustomOperation("className")>] member inline _.className (x: DSLElement, v: string) = x.attr "className" v 
        [<CustomOperation("zIndex")>] member inline _.zIndex (x: DSLElement, v: int) = x.attr "zIndex" v 
        [<CustomOperation("placement")>] member inline _.placement (x: DSLElement, v: DrawerPlacement) = x.attr "placement" v 
        [<CustomOperation("onClose")>] member inline _.onClose (x: DSLElement, v: Event -> unit) = x.attr "onClose" v 
        [<CustomOperation("afterVisibleChange")>] member inline _.afterVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "afterVisibleChange" v 
        [<CustomOperation("keyboard")>] member inline _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v 
        [<CustomOperation("footer")>] member inline _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
        [<CustomOperation("footerStyle")>] member inline _.footerStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "footerStyle" (keyValueList CaseRules.LowerFirst css)
    