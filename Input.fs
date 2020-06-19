namespace Fable.AntD

open Browser.Types
open Fable.React
open System

type AntInput() =
    inherit AntElement<AntInput>(ofImport "Input" "antd")
    member x.addonAfter (v: ReactElement) = x.attribute "addonAfter" v 
    member x.addonBefore (v: ReactElement) = x.attribute "addonBefore" v 
    member x.defaultValue (v: string) = x.attribute "defaultValue" v 
    member x.disabled (v: bool) = x.attribute "disabled" v 
    member x.id (v: string) = x.attribute "id" v 
    member x.maxLength (v: int) = x.attribute "maxLength" v 
    member x.prefix (v: ReactElement) = x.attribute "prefix" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.suffix (v: ReactElement) = x.attribute "suffix" v 
    member x.htmlType (v: string) = x.attribute "type" v 
    member x.tabIndex (v: int) = x.attribute "tabIndex" v 
    member x.value (v: string) = x.attribute "value" v 
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.onPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 
    member x.allowClear (v: bool) = x.attribute "allowClear" v 
    member x.placeholder (v: string) = x.attribute "placeholder" v 

type AutoSizeType = { minRows: int option; maxRows: int option }

type AntTextArea() =
    inherit AntElement<AntTextArea>(ofImport "Input.TextArea" "antd")
    member x.autoSize (v: bool) = x.attribute "autoSize" v
    member x.autoSizeType (v: AutoSizeType) = x.attribute "autoSize" v
    member x.defaultValue (v: string) = x.attribute "defaultValue" v 
    member x.value (v: string) = x.attribute "value" v 
    member x.onPressEnter (v: (KeyboardEvent -> unit)) = x.attribute "onPressEnter" v 
    member x.allowClear (v: bool) = x.attribute "allowClear" v
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 
   
type AntSearch() =
    inherit AntElement<AntSearch>(ofImport "Input.Search" "antd")
    member x.addonAfter (v: ReactElement) = x.attribute "addonAfter" v 
    member x.addonBefore (v: ReactElement) = x.attribute "addonBefore" v 
    member x.defaultValue (v: string) = x.attribute "defaultValue" v 
    member x.disabled (v: bool) = x.attribute "disabled" v 
    member x.id (v: string) = x.attribute "id" v 
    member x.maxLength (v: int) = x.attribute "maxLength" v 
    member x.prefix (v: ReactElement) = x.attribute "prefix" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.suffix (v: ReactElement) = x.attribute "suffix" v 
    member x.htmlType (v: string) = x.attribute "type" v 
    member x.tabIndex (v: int) = x.attribute "tabIndex" v 
    member x.value (v: string) = x.attribute "value" v 
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.onPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 
    member x.allowClear (v: bool) = x.attribute "allowClear" v 
    member x.placeholder (v: string) = x.attribute "placeholder" v 
    member x.enterButton (v: bool) = x.attribute "enterButton" v
    member x.showEnterButton (v: ReactElement) = x.attribute "enterButton" v
    member x.loading (v: bool) = x.attribute "loading" v 
    member x.onSearch (v: (Func<string, Event, unit>)) = x.attribute "onSearch" v 

type AntInputGroup() =
    inherit AntElement<AntInputGroup>(ofImport "Input.Group" "antd")
    member x.compact (v: bool) = x.attribute "compact" v 
    member x.size (v: Size) = x.attribute "size" v 

type AntPassword() =
    inherit AntElement<AntPassword>(ofImport "Input.Password" "antd")
    member x.addonAfter (v: ReactElement) = x.attribute "addonAfter" v 
    member x.addonBefore (v: ReactElement) = x.attribute "addonBefore" v 
    member x.defaultValue (v: string) = x.attribute "defaultValue" v 
    member x.disabled (v: bool) = x.attribute "disabled" v 
    member x.id (v: string) = x.attribute "id" v 
    member x.maxLength (v: int) = x.attribute "maxLength" v 
    member x.prefix (v: ReactElement) = x.attribute "prefix" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.suffix (v: ReactElement) = x.attribute "suffix" v 
    member x.htmlType (v: string) = x.attribute "type" v 
    member x.tabIndex (v: int) = x.attribute "tabIndex" v 
    member x.value (v: string) = x.attribute "value" v 
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.onPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 
    member x.allowClear (v: bool) = x.attribute "allowClear" v 
    member x.placeholder (v: string) = x.attribute "placeholder" v     
    member x.visibilityToggle (v: bool) = x.attribute "visibilityToggle" v 