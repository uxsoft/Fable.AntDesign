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

type Menu() =
    inherit AntElement("Menu")
    member x.DefaultOpenKeys with set (v: string[]) = x.Attribute "defaultOpenKeys" v 
    member x.DefaultSelectedKeys with set (v: string[]) = x.Attribute "defaultSelectedKeys" v 
    member x.ForceSubMenuRender with set (v: bool) = x.Attribute "forceSubMenuRender" v 
    member x.InlineCollapsed with set (v: bool) = x.Attribute "inlineCollapsed" v 
    member x.InlineIndent with set (v: int) = x.Attribute "inlineIndent" v 
    member x.Mode with set (v: MenuMode) = x.Attribute "mode" v 
    member x.Multiple with set (v: bool) = x.Attribute "multiple" v 
    member x.OpenKeys with set (v: string[]) = x.Attribute "openKeys" v 
    member x.Selectable with set (v: bool) = x.Attribute "selectable" v 
    member x.SelectedKeys with set (v: string[]) = x.Attribute "selectedKeys" v 
    member x.SubMenuCloseDelay with set (v: float) = x.Attribute "subMenuCloseDelay" v 
    member x.SubMenuOpenDelay with set (v: float) = x.Attribute "subMenuOpenDelay" v 
    member x.Theme with set (v: Theme) = x.Attribute "theme" v 
    member x.OnClick with set (v: (ClickParam -> unit)) = x.Attribute "onClick" v 
    member x.OnDeselect with set (v: (SelectParam -> unit)) = x.Attribute "onDeselect" v 
    member x.OnOpenChange with set (v: (string[] -> unit)) = x.Attribute "onOpenChange" v 
    member x.OnSelect with set (v: (SelectParam -> unit)) = x.Attribute "onSelect" v 
    member x.OverflowedIndicator with set (v: ReactElement) = x.Attribute "overflowedIndicator" v 

type TitleClickEvent = { key: string; domEvent: Browser.Types.DocumentEvent }

type MenuItem() =
    inherit AntElement("Menu.Item")
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Key with set (v: string) = x.Attribute "key" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.OnClick with set (v: (unit -> unit)) = x.Attribute "onClick" v 
    
type MenuDivider() =
    inherit AntElement("Menu.Divider")

type MenuSubMenu() =
    inherit AntElement("Menu.SubMenu")
    member x.PopupClassName with set (v: string) = x.Attribute "popupClassName" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Key with set (v: string) = x.Attribute "key" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.OnTitleClick with set (v: TitleClickEvent) = x.Attribute "onTitleClick" v 
    
type MenuItemGroup() =
    inherit AntElement("Menu.ItemGroup")
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 