namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type TypographyType = Secondary | Warning | Danger

type AntText (?partialImport) =
    inherit AntElement(defaultArg partialImport (ofImport "Typography.Text" "antd"))
    member x.Code (v: bool) = x.attribute "code" v 
    member x.Copyable (v: bool) = x.attribute "copyable" v 
    member x.Delete (v: bool) = x.attribute "delete" v 
    member x.Disabled (v: bool) = x.attribute "disabled" v 
    member x.Editable (v: bool) = x.attribute "editable" v 
    member x.Ellipsis (v: bool) = x.attribute "ellipsis" v 
    member x.Mark (v: bool) = x.attribute "mark" v 
    member x.Underline (v: bool) = x.attribute "underline" v 
    member x.OnChange (v: (string -> unit)) = x.attribute "onChange" v 
    member x.Strong (v: bool) = x.attribute "strong" v 
    member x.Type (v: TypographyType) = x.attribute "type" v 

type AntTitle() =
   inherit AntText(ofImport "Typography.Title" "antd")
   member x.Level (v: int) = x.attribute "level" v 

type AntParagraph() =
   inherit AntText(ofImport "Typography.Paragraph" "antd")