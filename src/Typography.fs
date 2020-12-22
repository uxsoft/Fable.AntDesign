namespace Fable.AntD

open Fable.AntD
open Fable.Core
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>]
type TypographyType = Secondary | Success | Warning | Danger 

type AntTypographyEllipsis() =
    inherit AntObject<AntTypographyEllipsis>()
    member x.rows (v: int) = x.attribute "rows" v
    member x.expandable (?v: bool) = x.attribute "expandable" (Option.defaultValue true v)
    member x.suffix (v: string) = x.attribute "suffix" v
    member x.symbol (v: ReactElement) = x.attribute "symbol" v
    member x.onExpand (v: Event -> unit) = x.attribute "onExpand" v
    member x.onEllipsis (v: bool -> unit) = x.attribute "onEllipsis" v

type AntTypographyEditable() =
    inherit AntObject<AntTypographyEllipsis>()
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.tooltip (v: ReactElement) = x.attribute "tooltip" v
    member x.editing (?v: bool) = x.attribute "editing" (Option.defaultValue true v)
    member x.maxLength (v: int) = x.attribute "maxLength" v
    member x.autoSize (?v: bool) = x.attribute "autoSize" (Option.defaultValue true v)
    member x.onStart (v: unit -> unit) = x.attribute "onStart" v
    member x.onChange (v: string -> unit) = x.attribute "onChange" v

type AntTypographyCopyable() =
    inherit AntObject<AntTypographyCopyable>()
    member x.text (v: string) = x.attribute "text" v
    member x.onCopy (v: unit -> unit) = x.attribute "onCopy" v
    member x.icon (v: ReactElement) = x.attribute "icon" v
    member x.tooltips (?v: bool) = x.attribute "tooltips" v

type AntTypographyBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.code (?v: bool) = x.attribute "code" (Option.defaultValue true v) 
    member x.copyable (v: AntTypographyCopyable) = x.attribute "copyable" v.JSON
    member x.delete (?v: bool) = x.attribute "delete" (Option.defaultValue true v) 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.editable (v: AntTypographyEditable) = x.attribute "editable" v.JSON 
    member x.mark (?v: bool) = x.attribute "mark" (Option.defaultValue true v)
    member x.underline (?v: bool) = x.attribute "underline" (Option.defaultValue true v)
    member x.onChange (v: string -> unit) = x.attribute "onChange" v 
    member x.strong (?v: bool) = x.attribute "strong" (Option.defaultValue true v)
    member x.typographyType (v: TypographyType) = x.attribute "type" v
  
type AntText() =
    inherit AntTypographyBase<AntText>(ofImport "Typography.Text" "antd")
    member x.keyboard (?v: bool) = x.attribute "keyboard" (Option.defaultValue true v)
    member x.ellipsis (?v: bool) = x.attribute "ellipsis" (Option.defaultValue true v) 

type AntTitle() =
    inherit AntTypographyBase<AntTitle>(ofImport "Typography.Title" "antd")
    member x.level (v: int) = x.attribute "level" v
    member x.ellipsis (v: AntTypographyEllipsis) = x.attribute "ellipsis" v.JSON 


type AntParagraph() =
    inherit AntTypographyBase<AntParagraph>(ofImport "Typography.Paragraph" "antd")
    member x.ellipsis (v: AntTypographyEllipsis) = x.attribute "ellipsis" v.JSON 
