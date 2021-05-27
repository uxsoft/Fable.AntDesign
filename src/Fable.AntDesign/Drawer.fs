module Fable.AntDesign.Drawer

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>] type DrawerPlacement = Top | Right | Bottom | Left

type DrawerBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Drawer" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("closable")>] member _.closable (x: DSLElement, v: bool) = x.attr "closable" v 
    [<CustomOperation("destroyOnClose")>] member _.destroyOnClose (x: DSLElement, v: bool) = x.attr "destroyOnClose" v
    [<CustomOperation("forceRender")>] member _.forceRender (x: DSLElement, v: bool) = x.attr "forceRender" v
    [<CustomOperation("getContainer")>] member _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v 
    [<CustomOperation("mask")>] member _.mask (x: DSLElement, v: bool) = x.attr "mask" v 
    [<CustomOperation("maskClosable")>] member _.maskClosable (x: DSLElement, v: bool) = x.attr "maskClosable" v
    [<CustomOperation("maskStyle")>] member _.maskStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "maskStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("drawerStyle")>] member _.drawerStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "drawerStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("headerStyle")>] member _.headerStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "headerStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("bodyStyle")>] member _.bodyStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("visible")>] member _.visible (x: DSLElement, v: bool) = x.attr "visible" v 
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v 
    [<CustomOperation("height")>] member _.height (x: DSLElement, v: string) = x.attr "height" v 
    [<CustomOperation("className")>] member _.className (x: DSLElement, v: string) = x.attr "className" v 
    [<CustomOperation("zIndex")>] member _.zIndex (x: DSLElement, v: int) = x.attr "zIndex" v 
    [<CustomOperation("placement")>] member _.placement (x: DSLElement, v: DrawerPlacement) = x.attr "placement" v 
    [<CustomOperation("onClose")>] member _.onClose (x: DSLElement, v: Event -> unit) = x.attr "onClose" v 
    [<CustomOperation("afterVisibleChange")>] member _.afterVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "afterVisibleChange" v 
    [<CustomOperation("keyboard")>] member _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v 
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
    [<CustomOperation("footerStyle")>] member _.footerStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "footerStyle" (keyValueList CaseRules.LowerFirst css)
