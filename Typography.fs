namespace Fable.AntD

open Fable.Core

[<StringEnum; RequireQualifiedAccess>]
type TypographyType = Secondary | Warning | Danger

type Text (?name: string) =
    inherit AntElement(defaultArg name "Typography.Text")
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

type Title () =
   inherit Text("Typography.Title")
   member x.Level with set (v: int) = x.Attribute "level" v 

type Paragraph () =
   inherit Text("Typography.Paragraph")