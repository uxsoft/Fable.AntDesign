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

    [<CustomOperation("closable")>] member _.closable (x: DSLElement) = x.attr "closable" true 
    [<CustomOperation("destroyOnClose")>] member _.destroyOnClose (x: DSLElement) = x.attr "destroyOnClose" true
    [<CustomOperation("forceRender")>] member _.forceRender (x: DSLElement) = x.attr "forceRender" true
    [<CustomOperation("getContainer")>] member _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v 
    [<CustomOperation("mask")>] member _.mask (x: DSLElement) = x.attr "mask" true 
    [<CustomOperation("maskClosable")>] member _.maskClosable (x: DSLElement) = x.attr "maskClosable" true
    [<CustomOperation("maskStyle")>] member _.maskStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "maskStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("drawerStyle")>] member _.drawerStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "drawerStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("headerStyle")>] member _.headerStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "headerStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("bodyStyle")>] member _.bodyStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("visible")>] member _.visible (x: DSLElement) = x.attr "visible" true 
    [<CustomOperation("width")>] member _.width (x: DSLElement, v: string) = x.attr "width" v 
    [<CustomOperation("height")>] member _.height (x: DSLElement, v: string) = x.attr "height" v 
    [<CustomOperation("className")>] member _.className (x: DSLElement, v: string) = x.attr "className" v 
    [<CustomOperation("zIndex")>] member _.zIndex (x: DSLElement, v: int) = x.attr "zIndex" v 
    [<CustomOperation("placement")>] member _.placement (x: DSLElement, v: DrawerPlacement) = x.attr "placement" v 
    [<CustomOperation("onClose")>] member _.onClose (x: DSLElement, v: Event -> unit) = x.attr "onClose" v 
    [<CustomOperation("afterVisibleChange")>] member _.afterVisibleChange (x: DSLElement, v: bool -> unit) = x.attr "afterVisibleChange" v 
    [<CustomOperation("keyboard")>] member _.keyboard (x: DSLElement) = x.attr "keyboard" true 
    [<CustomOperation("footer")>] member _.footer (x: DSLElement, v: ReactElement) = x.attr "footer" v
    [<CustomOperation("footerStyle")>] member _.footerStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "footerStyle" (keyValueList CaseRules.LowerFirst css)
