namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type TypographyType = Secondary | Warning | Danger

type AntTypographyBase<'T when 'T :> AntElement<'T>>(partialImport) =
    inherit AntElement<'T>(partialImport)
    member x.code (?v: bool) = x.attribute "code" (Option.defaultValue true v) 
    member x.copyable (?v: bool) = x.attribute "copyable" (Option.defaultValue true v) 
    member x.delete (?v: bool) = x.attribute "delete" (Option.defaultValue true v) 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.editable (?v: bool) = x.attribute "editable" (Option.defaultValue true v) 
    member x.ellipsis (?v: bool) = x.attribute "ellipsis" (Option.defaultValue true v) 
    member x.mark (?v: bool) = x.attribute "mark" (Option.defaultValue true v)
    member x.underline (?v: bool) = x.attribute "underline" (Option.defaultValue true v)
    member x.onChange (v: (string -> unit)) = x.attribute "onChange" v 
    member x.strong (?v: bool) = x.attribute "strong" (Option.defaultValue true v)
    member x.typographyType (v: TypographyType) = x.attribute "type" v

type AntText() =
    inherit AntTypographyBase<AntText>(ofImport "Typography.Text" "antd")
    member x.keyboard (?v: bool) = x.attribute "keyboard" (Option.defaultValue true v) 

type AntTitle() =
   inherit AntTypographyBase<AntTitle>(ofImport "Typography.Title" "antd")
   member x.level (v: int) = x.attribute "level" v 

type AntParagraph() =
   inherit AntTypographyBase<AntParagraph>(ofImport "Typography.Paragraph" "antd")