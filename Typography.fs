namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type TypographyType = Secondary | Warning | Danger

type AntText (?partialImport) =
    inherit AntElement(defaultArg partialImport (ofImport "Typography.Text" "antd"))
    member x.Code with set (v: bool) = x.Attribute "code" v 
    member x.Copyable with set (v: bool) = x.Attribute "copyable" v 
    member x.Delete with set (v: bool) = x.Attribute "delete" v 
    member x.Disabled with set (v: bool) = x.Attribute "disabled" v 
    member x.Editable with set (v: bool) = x.Attribute "editable" v 
    member x.Ellipsis with set (v: bool) = x.Attribute "ellipsis" v 
    member x.Mark with set (v: bool) = x.Attribute "mark" v 
    member x.Underline with set (v: bool) = x.Attribute "underline" v 
    member x.OnChange with set (v: (string -> unit)) = x.Attribute "onChange" v 
    member x.Strong with set (v: bool) = x.Attribute "strong" v 
    member x.Type with set (v: TypographyType) = x.Attribute "type" v 

type AntTitle() =
   inherit AntText(ofImport "Typography.Title" "antd")
   member x.Level with set (v: int) = x.Attribute "level" v 

type AntParagraph() =
   inherit AntText(ofImport "Typography.Paragraph" "antd")