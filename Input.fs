namespace Fable.AntD

open Browser.Types
open Fable.React

type Input() =
    inherit AntElement("Input")
    member x.AddonAfter with set (v: ReactElement) = x.Attribute "addonAfter" v 
    member x.AddonBefore with set (v: ReactElement) = x.Attribute "addonBefore" v 
    member x.DefaultValue with set (v: string) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Id with set (v: string) = x.Attribute "id" v 
    member x.MaxLength with set (v: int) = x.Attribute "maxLength" v 
    member x.Prefix with set (v: ReactElement) = x.Attribute "prefix" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.Suffix with set (v: ReactElement) = x.Attribute "suffix" v 
    member x.Type with set (v: string) = x.Attribute "type" v 
    member x.TabIndex with set (v: int) = x.Attribute "tabIndex" v 
    member x.Value with set (v: string) = x.Attribute "value" v 
    member x.OnChange with set (v: (Event -> unit)) = x.Attribute "onChange" v 
    member x.OnPressEnter with set (v: (Event -> unit)) = x.Attribute "onPressEnter" v 
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
    member x.Placeholder with set (v: string) = x.Attribute "placeholder" v 

type AutoSizeType = { minRows: int option; maxRows: int option }

type TextArea() =
    inherit AntElement("Input.TextArea")
    member x.AutoSize with set (v: bool) = x.Attribute "autoSize" v
    member x.AutoSizeType with set (v: AutoSizeType) = x.Attribute "autoSize" v
    member x.DefaultValue with set (v: string) = x.Attribute "defaultValue" v 
    member x.Value with set (v: string) = x.Attribute "value" v 
    member x.OnPressEnter with set (v: (KeyboardEvent -> unit)) = x.Attribute "onPressEnter" v 
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
   
type Search() =
    inherit AntElement("Input.Search")
    member x.AddonAfter with set (v: ReactElement) = x.Attribute "addonAfter" v 
    member x.AddonBefore with set (v: ReactElement) = x.Attribute "addonBefore" v 
    member x.DefaultValue with set (v: string) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Id with set (v: string) = x.Attribute "id" v 
    member x.MaxLength with set (v: int) = x.Attribute "maxLength" v 
    member x.Prefix with set (v: ReactElement) = x.Attribute "prefix" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.Suffix with set (v: ReactElement) = x.Attribute "suffix" v 
    member x.Type with set (v: string) = x.Attribute "type" v 
    member x.TabIndex with set (v: int) = x.Attribute "tabIndex" v 
    member x.Value with set (v: string) = x.Attribute "value" v 
    member x.OnChange with set (v: (Event -> unit)) = x.Attribute "onChange" v 
    member x.OnPressEnter with set (v: (Event -> unit)) = x.Attribute "onPressEnter" v 
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
    member x.Placeholder with set (v: string) = x.Attribute "placeholder" v 
    member x.EnterButton with set (v: bool) = x.Attribute "enterButton" v
    member x.ShowEnterButton with set (v: ReactElement) = x.Attribute "enterButton" v
    member x.Loading with set (v: bool) = x.Attribute "loading" v 
    member x.OnSearch with set (v: (string * Event -> unit)) = x.Attribute "onSearch" v 

type InputGroup() =
    inherit AntElement("Input.Group")
    member x.Compact with set (v: bool) = x.Attribute "compact" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 

type Password() =
    inherit AntElement("Input.Password")
    member x.AddonAfter with set (v: ReactElement) = x.Attribute "addonAfter" v 
    member x.AddonBefore with set (v: ReactElement) = x.Attribute "addonBefore" v 
    member x.DefaultValue with set (v: string) = x.Attribute "defaultValue" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Id with set (v: string) = x.Attribute "id" v 
    member x.MaxLength with set (v: int) = x.Attribute "maxLength" v 
    member x.Prefix with set (v: ReactElement) = x.Attribute "prefix" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.Suffix with set (v: ReactElement) = x.Attribute "suffix" v 
    member x.Type with set (v: string) = x.Attribute "type" v 
    member x.TabIndex with set (v: int) = x.Attribute "tabIndex" v 
    member x.Value with set (v: string) = x.Attribute "value" v 
    member x.OnChange with set (v: (Event -> unit)) = x.Attribute "onChange" v 
    member x.OnPressEnter with set (v: (Event -> unit)) = x.Attribute "onPressEnter" v 
    member x.AllowClear with set (v: bool) = x.Attribute "allowClear" v 
    member x.Placeholder with set (v: string) = x.Attribute "placeholder" v     
    member x.VisibilityToggle with set (v: bool) = x.Attribute "visibilityToggle" v 