namespace Fable.AntD

open Browser.Types
open Fable.React

type AntInput() =
    inherit AntElement(ofImport "Input" "antd")
    member x.AddonAfter (v: ReactElement) = x.attribute "addonAfter" v 
    member x.AddonBefore (v: ReactElement) = x.attribute "addonBefore" v 
    member x.DefaultValue (v: string) = x.attribute "defaultValue" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Id (v: string) = x.attribute "id" v 
    member x.MaxLength (v: int) = x.attribute "maxLength" v 
    member x.Prefix (v: ReactElement) = x.attribute "prefix" v 
    member x.Size (v: Size) = x.attribute "size" v 
    member x.Suffix (v: ReactElement) = x.attribute "suffix" v 
    member x.Type (v: string) = x.attribute "type" v 
    member x.TabIndex (v: int) = x.attribute "tabIndex" v 
    member x.Value (v: string) = x.attribute "value" v 
    member x.OnChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.OnPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 
    member x.AllowClear (v: bool) = x.attribute "allowClear" v 
    member x.Placeholder (v: string) = x.attribute "placeholder" v 

type AutoSizeType = { minRows: int option; maxRows: int option }

type AntTextArea() =
    inherit AntElement(ofImport "Input.TextArea" "antd")
    member x.AutoSize (v: bool) = x.attribute "autoSize" v
    member x.AutoSizeType (v: AutoSizeType) = x.attribute "autoSize" v
    member x.DefaultValue (v: string) = x.attribute "defaultValue" v 
    member x.Value (v: string) = x.attribute "value" v 
    member x.OnPressEnter (v: (KeyboardEvent -> unit)) = x.attribute "onPressEnter" v 
    member x.AllowClear (v: bool) = x.attribute "allowClear" v
    
    member x.OnChange (v: (Event -> unit)) = x.attribute "onChange" v 

   
type AntSearch() =
    inherit AntElement(ofImport "Input.Search" "antd")
    member x.AddonAfter (v: ReactElement) = x.attribute "addonAfter" v 
    member x.AddonBefore (v: ReactElement) = x.attribute "addonBefore" v 
    member x.DefaultValue (v: string) = x.attribute "defaultValue" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Id (v: string) = x.attribute "id" v 
    member x.MaxLength (v: int) = x.attribute "maxLength" v 
    member x.Prefix (v: ReactElement) = x.attribute "prefix" v 
    member x.Size (v: Size) = x.attribute "size" v 
    member x.Suffix (v: ReactElement) = x.attribute "suffix" v 
    member x.Type (v: string) = x.attribute "type" v 
    member x.TabIndex (v: int) = x.attribute "tabIndex" v 
    member x.Value (v: string) = x.attribute "value" v 
    member x.OnChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.OnPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 
    member x.AllowClear (v: bool) = x.attribute "allowClear" v 
    member x.Placeholder (v: string) = x.attribute "placeholder" v 
    member x.EnterButton (v: bool) = x.attribute "enterButton" v
    member x.ShowEnterButton (v: ReactElement) = x.attribute "enterButton" v
    member x.Loading (v: bool) = x.attribute "loading" v 
    member x.OnSearch (v: (string * Event -> unit)) = x.attribute "onSearch" v 

type AntInputGroup() =
    inherit AntElement(ofImport "Input.Group" "antd")
    member x.Compact (v: bool) = x.attribute "compact" v 
    member x.Size (v: Size) = x.attribute "size" v 

type AntPassword() =
    inherit AntElement(ofImport "Input.Password" "antd")
    member x.AddonAfter (v: ReactElement) = x.attribute "addonAfter" v 
    member x.AddonBefore (v: ReactElement) = x.attribute "addonBefore" v 
    member x.DefaultValue (v: string) = x.attribute "defaultValue" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Id (v: string) = x.attribute "id" v 
    member x.MaxLength (v: int) = x.attribute "maxLength" v 
    member x.Prefix (v: ReactElement) = x.attribute "prefix" v 
    member x.Size (v: Size) = x.attribute "size" v 
    member x.Suffix (v: ReactElement) = x.attribute "suffix" v 
    member x.Type (v: string) = x.attribute "type" v 
    member x.TabIndex (v: int) = x.attribute "tabIndex" v 
    member x.Value (v: string) = x.attribute "value" v 
    member x.OnChange (v: (Event -> unit)) = x.attribute "onChange" v 
    member x.OnPressEnter (v: (Event -> unit)) = x.attribute "onPressEnter" v 
    member x.AllowClear (v: bool) = x.attribute "allowClear" v 
    member x.Placeholder (v: string) = x.attribute "placeholder" v     
    member x.VisibilityToggle (v: bool) = x.attribute "visibilityToggle" v 