namespace Fable.AntD

open Browser.Types
open Fable.React
open System

type AntInputBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.addonAfter (v: ReactElement) = x.attribute "addonAfter" v 
    member x.addonBefore (v: ReactElement) = x.attribute "addonBefore" v 
    member x.allowClear (?v: bool) = x.attribute "allowClear" (Option.defaultValue true v) 
    member x.bordered (?v: bool) = x.attribute "bordered" (Option.defaultValue true v) 
    member x.defaultValue (v: string) = x.attribute "defaultValue" v 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.id (v: string) = x.attribute "id" v 
    member x.maxLength (v: int) = x.attribute "maxLength" v 
    member x.prefix (v: ReactElement) = x.attribute "prefix" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.suffix (v: ReactElement) = x.attribute "suffix" v 
    member x.htmlType (v: string) = x.attribute "type" v 
    member x.value (v: string) = x.attribute "value" v 
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.onPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 

    // Inherited from html input
    member x.tabIndex (v: int) = x.attribute "tabIndex" v 
    member x.placeholder (v: string) = x.attribute "placeholder" v 

type AntInput() =
    inherit AntInputBase<AntInput>(ofImport "Input" "antd")

type AutoSizeType = { minRows: int option; maxRows: int option }

type AntTextArea() =
    inherit AntElement<AntTextArea>(ofImport "Input.TextArea" "antd")
    member x.allowClear (?v: bool) = x.attribute "allowClear" (Option.defaultValue true v)
    member x.autoSize (?v: bool) = x.attribute "autoSize" (Option.defaultValue true v)
    member x.autoSizeType (v: AutoSizeType) = x.attribute "autoSize" v
    member x.bordered (?v: bool) = x.attribute "bordered" (Option.defaultValue true v)
    member x.defaultValue (v: string) = x.attribute "defaultValue" v 
    member x.maxLength (v: int) = x.attribute "maxLength" v
    member x.value (v: string) = x.attribute "value" v 
    member x.onPressEnter (v: (KeyboardEvent -> unit)) = x.attribute "onPressEnter" v 
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.onResize (v: Func<{| width: float; height: float |}, unit>) = x.attribute "onResize"  v  

type AntSearch() =
    inherit AntInputBase<AntSearch>(ofImport "Input.Search" "antd")
    member x.showEnterButton (?v: bool) = x.attribute "enterButton" (Option.defaultValue true v)
    member x.enterButton (v: ReactElement) = x.attribute "enterButton" v
    member x.loading (?v: bool) = x.attribute "loading" (Option.defaultValue true v) 
    member x.onSearch (v: (Func<string, Event, unit>)) = x.attribute "onSearch" v 

type AntInputGroup() =
    inherit AntElement<AntInputGroup>(ofImport "Input.Group" "antd")
    member x.compact (?v: bool) = x.attribute "compact" (Option.defaultValue true v) 
    member x.size (v: Size) = x.attribute "size" v 

type AntPassword() =
    inherit AntInputBase<AntPassword>(ofImport "Input.Password" "antd")
    member x.iconRender (v: bool -> ReactElement) = x.attribute "iconRender" v 
    member x.visibilityToggle (?v: bool) = x.attribute "visibilityToggle" (Option.defaultValue true v) 