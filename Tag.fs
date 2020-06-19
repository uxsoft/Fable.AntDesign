namespace Fable.AntD

open Fable.React

type AntTag(?partialImport) =
  inherit AntElement(defaultArg partialImport (ofImport "Tag" "antd"))
  member x.AfterClose (v: (unit -> unit)) = x.attribute "afterClose" v 
  member x.Closeable (v: bool) = x.attribute "closeable" v
  member x.Color (v: string) = x.attribute "color" v 
  member x.OnClose (v: (obj -> unit)) = x.attribute "onClose" v 
  member x.Visible (v: bool) = x.attribute "visible" v
  
type AntCheckableTag() =
  inherit AntTag(ofImport "Tag.CheckableTag" "antd")
  member x.Checked (v: bool) = x.attribute "checked" v 
  member x.OnChange (v: (bool -> unit)) = x.attribute "onChange" v 