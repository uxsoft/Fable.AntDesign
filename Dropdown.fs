namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Dropdown =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntDropdownPlacement = BottomLeft | BottomCenter | BottomRight | TopLeft | TopCenter | TopRight
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntDropdownTrigger = Click | Hover | ContextMenu
    
    [<RequireQualifiedAccess>]
    type AntDropdown  =
        | Disabled of bool
        | GetPopupContainer of (unit -> HTMLElement)
        | Overlay of ReactElement
        | OverlayClassName of string
        | Placement of AntDropdownPlacement
        | Trigger of AntDropdownTrigger array
        | Visible of bool
        | OnVisibleChange of (bool -> unit)
        static member Custom (key: string, value: obj): AntDropdown = unbox (key, value)
        static member OverlayStyle (css: Props.CSSProp list): AntDropdown = unbox ("overlayStyle", keyValueList CaseRules.LowerFirst css)
        static member Style (css: Props.CSSProp list): AntDropdown = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntDropdownButton  =
        | Disabled of bool
        | GetPopupContainer of (unit -> ReactElement)
        | Overlay of ReactElement
        | OverlayClassName of string
        | Placement of AntDropdownPlacement
        | Trigger of AntDropdownTrigger array
        | Visible of bool
        | OnVisibleChange of (bool -> unit)
        static member Custom (key: string, value: obj): AntDropdownButton = unbox (key, value)
        static member OverlayStyle (css: Props.CSSProp list): AntDropdownButton = unbox ("overlayStyle", keyValueList CaseRules.LowerFirst css)
        static member Style (css: Props.CSSProp list): AntDropdownButton = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antDropdown (props: AntDropdown list) (children: ReactElement list): ReactElement =
       ofImport "Dropdown" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antDropdownButton (props: AntDropdownButton list) (children: ReactElement list): ReactElement =
       ofImport "Dropdown.Button" "antd" (keyValueList CaseRules.LowerFirst props) children
