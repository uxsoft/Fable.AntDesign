namespace Fable.AntD

open Browser.Types
open Fable.Import
open Fable.Core
open Fable.React

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
    item: ReactElement // any ?
    domEvent: DocumentEvent // any ?
}

type AntMenu() =
    inherit AntElement<AntMenu>(ofImport "Menu" "antd")
    member x.defaultOpenKeys (v: string[]) = x.attribute "defaultOpenKeys" v 
    member x.defaultSelectedKeys (v: string[]) = x.attribute "defaultSelectedKeys" v 
    member x.expandIcon (v: ReactElement) = x.attribute "expandIcon" v
    member x.forceSubMenuRender (?v: bool) = x.attribute "forceSubMenuRender" (Option.defaultValue true v) 
    member x.inlineCollapsed (?v: bool) = x.attribute "inlineCollapsed" (Option.defaultValue true v) 
    member x.inlineIndent (v: int) = x.attribute "inlineIndent" v 
    member x.mode (v: MenuMode) = x.attribute "mode" v 
    member x.multiple (v: bool) = x.attribute "multiple" v 
    member x.openKeys (v: string[]) = x.attribute "openKeys" v 
    member x.overflowedIndicator (v: ReactElement) = x.attribute "overflowedIndicator" v 
    member x.selectable (?v: bool) = x.attribute "selectable" (Option.defaultValue true v) 
    member x.selectedKeys (v: string[]) = x.attribute "selectedKeys" v 
    member x.subMenuCloseDelay (v: float) = x.attribute "subMenuCloseDelay" v 
    member x.subMenuOpenDelay (v: float) = x.attribute "subMenuOpenDelay" v 
    member x.theme (v: Theme) = x.attribute "theme" v 
    member x.triggerSubMenuAction (v: string) = x.attribute "triggerSubMenuAction" v
    member x.onClick (v: (ClickParam -> unit)) = x.attribute "onClick" v 
    member x.onDeselect (v: (SelectParam -> unit)) = x.attribute "onDeselect" v 
    member x.onOpenChange (v: (string[] -> unit)) = x.attribute "onOpenChange" v 
    member x.onSelect (v: (SelectParam -> unit)) = x.attribute "onSelect" v 

type TitleClickEvent = { key: string; domEvent: Browser.Types.DocumentEvent }

type AntMenuItem() =
    inherit AntElement<AntMenuItem>(ofImport "Menu.Item" "antd")
    member x.danger (?v: bool) = x.attribute "danger" (Option.defaultValue true v) 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.onClick (v: (unit -> unit)) = x.attribute "onClick" v

type AntMenuSubMenu() =
    inherit AntElement<AntMenuSubMenu>(ofImport "Menu.SubMenu" "antd")
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.popupClassName (v: string) = x.attribute "popupClassName" v 
    member x.popupOffset (v: float array) = x.attribute "popupOffset" v
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.onTitleClick (v: TitleClickEvent) = x.attribute "onTitleClick" v 
    
type AntMenuItemGroup() =
    inherit AntElement<AntMenuItemGroup>(ofImport "Menu.ItemGroup" "antd")
    member x.title (v: ReactElement) = x.attribute "title" v
    
type AntMenuDivider() =
    inherit AntElement<AntMenuDivider>(ofImport "Menu.Divider" "antd")