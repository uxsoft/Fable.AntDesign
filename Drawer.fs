namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<AutoOpen>]
module Drawer =
    
    [<StringEnum; RequireQualifiedAccess>] type AntDrawerPlacement = Top | Right | Bottom | Left
    
    [<RequireQualifiedAccess>]
    type AntDrawer  =
        | Closable of bool
        | DestroyOnClose of bool
        | GetContainer of (unit -> ReactElement)
        | Mask of bool
        | MaskClosable of bool
        | Title of ReactElement
        | Visible of bool
        | Width of int
        | Height of int
        | ClassName of string
        | ZIndex of int
        | Placement of AntDrawerPlacement
        | OnClose of (Event -> unit)
        | AfterVisibleChange of (bool -> unit)
        | Keyboard of bool
        static member Custom (key: string, value: obj): AntDrawer = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntDrawer = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member MaskStyle (css: Props.CSSProp list): AntDrawer = unbox ("maskStyle", keyValueList CaseRules.LowerFirst css)
        static member DrawerStyle (css: Props.CSSProp list): AntDrawer = unbox ("drawerStyle", keyValueList CaseRules.LowerFirst css)
        static member HeaderStyle (css: Props.CSSProp list): AntDrawer = unbox ("headerStyle", keyValueList CaseRules.LowerFirst css)
        static member BodyStyle (css: Props.CSSProp list): AntDrawer = unbox ("bodyStyle", keyValueList CaseRules.LowerFirst css)

            
    let inline antDrawer (props: AntDrawer list) (children: ReactElement list): ReactElement =
       ofImport "Drawer" "antd" (keyValueList CaseRules.LowerFirst props) children
