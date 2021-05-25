module Fable.AntDesign.Menu

open Browser.Types
open Fable.AntDesign.Common
open Fable.Import
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type MenuMode = 
    | Vertical 
    | Horizontal 
    | Inline

type SelectParam = {
    key: string
    keyPath: string[]
    item: ReactElement // any ?
    domEvent: DocumentEvent // any ?
    selectedKeys: string[]
}

type ClickParam  = { 
    key: string
    keyPath: string
    item: ReactElement 
    domEvent: DocumentEvent 
}

type MenuBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Menu" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultOpenKeys")>] member _.defaultOpenKeys (x: DSLElement, v: string[]) = x.attr "defaultOpenKeys" v 
    [<CustomOperation("defaultSelectedKeys")>] member _.defaultSelectedKeys (x: DSLElement, v: string[]) = x.attr "defaultSelectedKeys" v 
    [<CustomOperation("expandIcon")>] member _.expandIcon (x: DSLElement, v: ReactElement) = x.attr "expandIcon" v
    [<CustomOperation("forceSubMenuRender")>] member _.forceSubMenuRender (x: DSLElement) = x.attr "forceSubMenuRender" true 
    [<CustomOperation("inlineCollapsed")>] member _.inlineCollapsed (x: DSLElement) = x.attr "inlineCollapsed" true 
    [<CustomOperation("inlineIndent")>] member _.inlineIndent (x: DSLElement, v: int) = x.attr "inlineIndent" v 
    [<CustomOperation("mode")>] member _.mode (x: DSLElement, v: MenuMode) = x.attr "mode" v 
    [<CustomOperation("multiple")>] member _.multiple (x: DSLElement) = x.attr "multiple" true
    [<CustomOperation("openKeys")>] member _.openKeys (x: DSLElement, v: string[]) = x.attr "openKeys" v 
    [<CustomOperation("overflowedIndicator")>] member _.overflowedIndicator (x: DSLElement, v: ReactElement) = x.attr "overflowedIndicator" v 
    [<CustomOperation("selectable")>] member _.selectable (x: DSLElement) = x.attr "selectable" true 
    [<CustomOperation("selectedKeys")>] member _.selectedKeys (x: DSLElement, v: string[]) = x.attr "selectedKeys" v 
    [<CustomOperation("subMenuCloseDelay")>] member _.subMenuCloseDelay (x: DSLElement, v: float) = x.attr "subMenuCloseDelay" v 
    [<CustomOperation("subMenuOpenDelay")>] member _.subMenuOpenDelay (x: DSLElement, v: float) = x.attr "subMenuOpenDelay" v 
    [<CustomOperation("theme")>] member _.theme (x: DSLElement, v: Theme) = x.attr "theme" v 
    [<CustomOperation("triggerSubMenuAction")>] member _.triggerSubMenuAction (x: DSLElement, v: string) = x.attr "triggerSubMenuAction" v
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: (ClickParam -> unit)) = x.attr "onClick" v 
    [<CustomOperation("onDeselect")>] member _.onDeselect (x: DSLElement, v: (SelectParam -> unit)) = x.attr "onDeselect" v 
    [<CustomOperation("onOpenChange")>] member _.onOpenChange (x: DSLElement, v: (string[] -> unit)) = x.attr "onOpenChange" v 
    [<CustomOperation("onSelect")>] member _.onSelect (x: DSLElement, v: (SelectParam -> unit)) = x.attr "onSelect" v 

type TitleClickEvent = { key: string; domEvent: DocumentEvent }

type MenuItemBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Menu.Item" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("danger")>] member _.danger (x: DSLElement) = x.attr "danger" true 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true 
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: (unit -> unit)) = x.attr "onClick" v

type MenuSubMenuBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Menu.SubMenu" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("icon")>] member _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    [<CustomOperation("popupClassName")>] member _.popupClassName (x: DSLElement, v: string) = x.attr "popupClassName" v 
    [<CustomOperation("popupOffset")>] member _.popupOffset (x: DSLElement, v: float array) = x.attr "popupOffset" v
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("onTitleClick")>] member _.onTitleClick (x: DSLElement, v: TitleClickEvent) = x.attr "onTitleClick" v 
    
type MenuItemGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Menu.ItemGroup" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    
type MenuDividerBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Menu.Divider" "antd" (createObj s.Attributes) s.Children
