namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.Import
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Menu =

    [<StringEnum; RequireQualifiedAccess>]
    type MenuMode = 
        | Vertical 
        | Horizontal 
        | Inline
    
    type SelectParam = {
        key: string
        keyPath: string array
        item: ReactElement
        domEvent: DocumentEvent
        selectedKeys: string array
    }
    
    type ClickParam  = { 
        key: string
        keyPath: string
        item: ReactElement 
        domEvent: DocumentEvent 
    }
    
    type MenuBuilder() =
        inherit ReactBuilder(import "Menu" "antd")
    
        [<CustomOperation("defaultOpenKeys")>] member inline _.defaultOpenKeys (x: DSLElement, v: string array) = x.attr "defaultOpenKeys" v 
        [<CustomOperation("defaultSelectedKeys")>] member inline _.defaultSelectedKeys (x: DSLElement, v: string array) = x.attr "defaultSelectedKeys" v 
        [<CustomOperation("expandIcon")>] member inline _.expandIcon (x: DSLElement, v: ReactElement) = x.attr "expandIcon" v
        [<CustomOperation("forceSubMenuRender")>] member inline _.forceSubMenuRender (x: DSLElement, v: bool) = x.attr "forceSubMenuRender" v 
        [<CustomOperation("inlineCollapsed")>] member inline _.inlineCollapsed (x: DSLElement, v: bool) = x.attr "inlineCollapsed" v 
        [<CustomOperation("inlineIndent")>] member inline _.inlineIndent (x: DSLElement, v: int) = x.attr "inlineIndent" v 
        [<CustomOperation("mode")>] member inline _.mode (x: DSLElement, v: MenuMode) = x.attr "mode" v 
        [<CustomOperation("multiple")>] member inline _.multiple (x: DSLElement, v: bool) = x.attr "multiple" v
        [<CustomOperation("openKeys")>] member inline _.openKeys (x: DSLElement, v: string array) = x.attr "openKeys" v 
        [<CustomOperation("overflowedIndicator")>] member inline _.overflowedIndicator (x: DSLElement, v: ReactElement) = x.attr "overflowedIndicator" v 
        [<CustomOperation("selectable")>] member inline _.selectable (x: DSLElement, v: bool) = x.attr "selectable" v 
        [<CustomOperation("selectedKeys")>] member inline _.selectedKeys (x: DSLElement, v: string array) = x.attr "selectedKeys" v 
        [<CustomOperation("subMenuCloseDelay")>] member inline _.subMenuCloseDelay (x: DSLElement, v: float) = x.attr "subMenuCloseDelay" v 
        [<CustomOperation("subMenuOpenDelay")>] member inline _.subMenuOpenDelay (x: DSLElement, v: float) = x.attr "subMenuOpenDelay" v 
        [<CustomOperation("theme")>] member inline _.theme (x: DSLElement, v: Theme) = x.attr "theme" v 
        [<CustomOperation("triggerSubMenuAction")>] member inline _.triggerSubMenuAction (x: DSLElement, v: string) = x.attr "triggerSubMenuAction" v
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: ClickParam -> unit) = x.attr "onClick" v 
        [<CustomOperation("onDeselect")>] member inline _.onDeselect (x: DSLElement, v: SelectParam -> unit) = x.attr "onDeselect" v 
        [<CustomOperation("onOpenChange")>] member inline _.onOpenChange (x: DSLElement, v: string array -> unit) = x.attr "onOpenChange" v 
        [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, v: SelectParam -> unit) = x.attr "onSelect" v 
    
    type TitleClickEvent = { key: string; domEvent: DocumentEvent }
    
    type MenuItemBuilder() =
        inherit ReactBuilder(import "Menu.Item" "antd")
    
        [<CustomOperation("danger")>] member inline _.danger (x: DSLElement, v: bool) = x.attr "danger" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: unit -> unit) = x.attr "onClick" v
    
    type MenuSubMenuBuilder() =
        inherit ReactBuilder(import "Menu.SubMenu" "antd")
    
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("popupClassName")>] member inline _.popupClassName (x: DSLElement, v: string) = x.attr "popupClassName" v 
        [<CustomOperation("popupOffset")>] member inline _.popupOffset (x: DSLElement, v: float array) = x.attr "popupOffset" v
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
        [<CustomOperation("onTitleClick")>] member inline _.onTitleClick (x: DSLElement, v: TitleClickEvent) = x.attr "onTitleClick" v 
        
    type MenuItemGroupBuilder() =
        inherit ReactBuilder(import "Menu.ItemGroup" "antd")
    
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
        
    type MenuDividerBuilder() =
        inherit ReactBuilder(import "Menu.Divider" "antd")
    