namespace Fable.AntD

open Browser.Types
open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Menu =

    [<StringEnum>]
    [<RequireQualifiedAccess>]
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

    [<RequireQualifiedAccess>]
    type AntMenu =
        | DefaultOpenKeys of string[]
        | DefaultSelectedKeys of string[]
        | ForceSubMenuRender of bool
        | InlineCollapsed of bool
        | InlineIndent of int
        | Mode of MenuMode
        | Multiple of bool
        | OpenKeys of string[]
        | Selectable of bool
        | SelectedKeys of string[]
        | SubMenuCloseDelay of float
        | SubMenuOpenDelay of float
        | Theme of Theme
        | OnClick of (ClickParam -> unit)
        | OnDeselect of (SelectParam -> unit)
        | OnOpenChange of (string[] -> unit)
        | OnSelect of (SelectParam -> unit)
        | OverflowedIndicator of ReactElement
        static member Custom (key: string, value: obj): AntMenu = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenu = unbox ("style", keyValueList CaseRules.LowerFirst css)

    type TitleClickEvent = { key: string; domEvent: Browser.Types.DocumentEvent }

    [<RequireQualifiedAccess>]
    type AntMenuItem =
        | Disabled of bool
        | Key of string
        | Title of ReactElement
        | OnClick of (unit -> unit)
        static member Custom (key: string, value: obj): AntMenuItem = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenuItem = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntMenuDivider =
        static member Custom (key: string, value: obj): AntMenuItem = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenuItem = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    [<RequireQualifiedAccess>]
    type AntMenuSubMenu =
        | PopupClassName of string
        | Disabled of bool
        | Key of string
        | Title of ReactElement
        | OnTitleClick of TitleClickEvent
        static member Custom (key: string, value: obj): AntMenuSubMenu = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenuSubMenu = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntMenuItemGroup =
        | Title of ReactElement
        static member Custom (key: string, value: obj): AntMenuSubMenu = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenuSubMenu = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antMenu (props: AntMenu list) (children: ReactElement list): ReactElement =
       ofImport "Menu" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antMenuItem (props: AntMenuItem list) (children: ReactElement list): ReactElement =
       ofImport "Menu.Item" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antMenuDivider (props: AntMenuDivider list): ReactElement =
       ofImport "Menu.Divider" "antd" (keyValueList CaseRules.LowerFirst props) []
   
    let inline antMenuSubMenu (props: AntMenuSubMenu list) (children: ReactElement list): ReactElement =
       ofImport "Menu.SubMenu" "antd" (keyValueList CaseRules.LowerFirst props) children
   
    let inline antMenuItemGroup (props: AntMenuItemGroup list) (children: ReactElement list): ReactElement =
       ofImport "Menu.ItemGroup" "antd" (keyValueList CaseRules.LowerFirst props) children
