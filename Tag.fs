namespace Fable.AntD

type Tag(?importName: string) =
  inherit AntElement(defaultArg importName "Tag")
  member x.AfterClose with set (v: (unit -> unit)) = x.Attribute "afterClose" v 
  member x.Closeable with set (v: bool) = x.Attribute "closeable" v
  member x.Color with set (v: string) = x.Attribute "color" v 
  member x.OnClose with set (v: (obj -> unit)) = x.Attribute "onClose" v 
  member x.Visible with set (v: bool) = x.Attribute "visible" v
  
type CheckableTag() =
  inherit Tag("Tag.CheckableTag")
  member x.Checked with set (v: bool) = x.Attribute "checked" v 
  member x.OnChange with set (v: (bool -> unit)) = x.Attribute "onChange" v 