namespace Fable.AntD

open Browser.Types
open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Menu =

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type MenuMode = 
        | Vertical 
        | [<CompiledName("vertical-left")>] VerticalLeft 
        | [<CompiledName("vertical-right")>] VerticalRight 
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
        | Id of string
        | Theme of Theme
        | Mode of MenuMode 
        | Selectable of bool
        | SelectedKeys of string[]
        | DefaultSelectedKeys of string[]
        | OpenKeys of string[]
        | DefaultOpenKeys of string[]
        | OnOpenChange of (string[] -> unit)
        | OnSelect of (SelectParam -> unit)
        | OnDeselect of (SelectParam -> unit)
        | OnClick of (ClickParam -> unit)
        | OpenAnimation of string
        | OpenTransitionName of string
        | ClassName of string
        | PrefixCls of string
        | Multiple of bool
        | InlineIndent of int
        | InlineCollapsed of bool
        | SubMenuCloseDelay of float
        | SubMenuOpenDelay of float
        | GetPopupContainer of (Browser.Types.Element -> Browser.Types.HTMLElement)
        static member Custom (key: string, value: obj): AntMenu = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenu = unbox ("style", keyValueList CaseRules.LowerFirst css)

    type TitleClickEvent = { key: string; domEvent: Browser.Types.DocumentEvent }

    [<RequireQualifiedAccess>]
    type AntMenuSubMenu =
        | Disabled of bool
        | Key of string
        | Title of ReactElement
        | OnTitleClick of TitleClickEvent
        static member Custom (key: string, value: obj): AntMenuSubMenu = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenuSubMenu = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntMenuItemGroup =
        static member Custom (key: string, value: obj): AntMenuSubMenu = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMenuSubMenu = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antMenu (props: AntMenu list) (children: ReactElement list): ReactElement =
       ofImport "Menu" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antMenuItem (props: AntMenu list) (children: ReactElement list): ReactElement =
       ofImport "Menu.Item" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antMenuDivider (props: AntMenu list): ReactElement =
       ofImport "Menu.Divider" "antd" (keyValueList CaseRules.LowerFirst props) []
   
    let inline antMenuSubMenu (props: AntMenuSubMenu list) (children: ReactElement list): ReactElement =
       ofImport "Menu.SubMenu" "antd" (keyValueList CaseRules.LowerFirst props) children
   
    let inline antMenuItemGroup (props: AntMenuItemGroup list) (children: ReactElement list): ReactElement =
       ofImport "Menu.ItemGroup" "antd" (keyValueList CaseRules.LowerFirst props) children
