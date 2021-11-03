namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<AutoOpen>]
module Typography =

    [<StringEnum; RequireQualifiedAccess>]
    type TypographyType =
        | Secondary
        | Success
        | Warning
        | Danger 

    type EllipsisConfigBuilder() =
        inherit ReactBuilder()
        
        member x.Run(s: DSLElement) = { Name = "ellipsis";  Value = (createObj s.Attributes) }
    
        [<CustomOperation("rows")>] member inline _.rows (x: DSLElement, v: int) = x.attr "rows" v
        [<CustomOperation("expandable")>] member inline _.expandable (x: DSLElement, v: bool) = x.attr "expandable" v
        [<CustomOperation("suffix")>] member inline _.suffix (x: DSLElement, v: string) = x.attr "suffix" v
        [<CustomOperation("symbol")>] member inline _.symbol (x: DSLElement, v: ReactElement) = x.attr "symbol" v
        [<CustomOperation("onExpand")>] member inline _.onExpand (x: DSLElement, v: Browser.Types.Event -> unit) = x.attr "onExpand" v
        [<CustomOperation("onEllipsis")>] member inline _.onEllipsis (x: DSLElement, v: bool -> unit) = x.attr "onEllipsis" v
    
    type EditableConfigBuilder() =
        inherit ReactBuilder()
        
        member x.Run(s: DSLElement) = { Name = "editable";  Value = (createObj s.Attributes) }
        
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("tooltip")>] member inline _.tooltip (x: DSLElement, v: ReactElement) = x.attr "tooltip" v
        [<CustomOperation("editing")>] member inline _.editing (x: DSLElement, v: bool) = x.attr "editing" v
        [<CustomOperation("maxLength")>] member inline _.maxLength (x: DSLElement, v: int) = x.attr "maxLength" v
        [<CustomOperation("autoSize")>] member inline _.autoSize (x: DSLElement, v: bool) = x.attr "autoSize" v
        [<CustomOperation("onStart")>] member inline _.onStart (x: DSLElement, v: unit -> unit) = x.attr "onStart" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v
    
    type CopyableConfigBuilder() =
        inherit ReactBuilder()
        
        member x.Run(s: DSLElement) = { Name = "copyable";  Value = (createObj s.Attributes) }
    
        [<CustomOperation("text")>] member inline _.text (x: DSLElement, v: string) = x.attr "text" v
        [<CustomOperation("onCopy")>] member inline _.onCopy (x: DSLElement, v: unit -> unit) = x.attr "onCopy" v
        [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
        [<CustomOperation("tooltips")>] member inline _.tooltips (x: DSLElement, v: bool) = x.attr "tooltips" v
    
    type TypographyBuilder() =
        inherit ReactBuilder()
        
        [<CustomOperation("code")>] member inline _.code (x: DSLElement, v: bool) = x.attr "code" v
        [<CustomOperation("copyable")>] member inline _.copyable (x: DSLElement, v: bool) = x.attr "copyable" v
        [<CustomOperation("delete")>] member inline _.delete (x: DSLElement, v: bool) = x.attr "delete" v 
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
        [<CustomOperation("editable")>] member inline _.editable (x: DSLElement, v: bool) = x.attr "editable" v
        [<CustomOperation("mark")>] member inline _.mark (x: DSLElement, v: bool) = x.attr "mark" v
        [<CustomOperation("underline")>] member inline _.underline (x: DSLElement, v: bool) = x.attr "underline" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v 
        [<CustomOperation("strong")>] member inline _.strong (x: DSLElement, v: bool) = x.attr "strong" v
        [<CustomOperation("type'")>] member inline _.type' (x: DSLElement, v: TypographyType) = x.attr "type" v
        [<CustomOperation("ellipsis")>] member inline _.ellipsis (x: DSLElement, v: bool) = x.attr "ellipsis" v 
    
      
    type TextBuilder() =
        inherit TypographyBuilder()
        
        member x.Run(s: DSLElement) = ofImport "Typography.Text" "antd" (createObj s.Attributes) s.Children
        
        [<CustomOperation("keyboard")>] member inline _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v
    
    type TitleBuilder() =
        inherit TypographyBuilder()
        
        member x.Run(s: DSLElement) = ofImport "Typography.Title" "antd" (createObj s.Attributes) s.Children
        
        [<CustomOperation("level")>] member inline _.level (x: DSLElement, v: int) = x.attr "level" v
    
    
    type ParagraphBuilder() =
        inherit TypographyBuilder()
        
        member x.Run(s: DSLElement) = ofImport "Typography.Paragraph" "antd" (createObj s.Attributes) s.Children
        
    
    type LinkBuilder() =
        inherit TypographyBuilder()
        
        member x.Run(s: DSLElement) = ofImport "Typography.Link" "antd" (createObj s.Attributes) s.Children
        
        [<CustomOperation("keyboard")>] member inline _.keyboard (x: DSLElement, v: bool) = x.attr "keyboard" v
        [<CustomOperation("href")>] member inline _.href (x: DSLElement, v: string) = x.attr "href" v
        [<CustomOperation("target")>] member inline _.target (x: DSLElement, v: string) = x.attr "target" v