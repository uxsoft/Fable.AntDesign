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
    inherit AntElement(ofImport "Menu" "antd")
    member x.DefaultOpenKeys (v: string[]) = x.attribute "defaultOpenKeys" v 
    member x.DefaultSelectedKeys (v: string[]) = x.attribute "defaultSelectedKeys" v 
    member x.ForceSubMenuRender (v: bool) = x.attribute "forceSubMenuRender" v 
    member x.InlineCollapsed (v: bool) = x.attribute "inlineCollapsed" v 
    member x.InlineIndent (v: int) = x.attribute "inlineIndent" v 
    member x.Mode (v: MenuMode) = x.attribute "mode" v 
    member x.Multiple (v: bool) = x.attribute "multiple" v 
    member x.OpenKeys (v: string[]) = x.attribute "openKeys" v 
    member x.Selectable (v: bool) = x.attribute "selectable" v 
    member x.SelectedKeys (v: string[]) = x.attribute "selectedKeys" v 
    member x.SubMenuCloseDelay (v: float) = x.attribute "subMenuCloseDelay" v 
    member x.SubMenuOpenDelay (v: float) = x.attribute "subMenuOpenDelay" v 
    member x.Theme (v: Theme) = x.attribute "theme" v 
    member x.OnClick (v: (ClickParam -> unit)) = x.attribute "onClick" v 
    member x.OnDeselect (v: (SelectParam -> unit)) = x.attribute "onDeselect" v 
    member x.OnOpenChange (v: (string[] -> unit)) = x.attribute "onOpenChange" v 
    member x.OnSelect (v: (SelectParam -> unit)) = x.attribute "onSelect" v 
    member x.OverflowedIndicator (v: ReactElement) = x.attribute "overflowedIndicator" v 

type TitleClickEvent = { key: string; domEvent: Browser.Types.DocumentEvent }

type AntMenuItem() =
    inherit AntElement(ofImport "Menu.Item" "antd")
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Key (v: string) = x.attribute "key" v 
    member x.Title (v: ReactElement) = x.attribute "title" v 
    member x.OnClick (v: (unit -> unit)) = x.attribute "onClick" v 
    
type AntMenuDivider() =
    inherit AntElement(ofImport "Menu.Divider" "antd")

type AntMenuSubMenu() =
    inherit AntElement(ofImport "Menu.SubMenu" "antd")
    member x.PopupClassName (v: string) = x.attribute "popupClassName" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Key (v: string) = x.attribute "key" v 
    member x.Title (v: ReactElement) = x.attribute "title" v 
    member x.OnTitleClick (v: TitleClickEvent) = x.attribute "onTitleClick" v 
    
type AntMenuItemGroup() =
    inherit AntElement(ofImport "Menu.ItemGroup" "antd")
    member x.Title (v: ReactElement) = x.attribute "title" v 