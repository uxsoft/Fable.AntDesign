namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type DividerOrientation = Left | Right | Center
[<StringEnum; RequireQualifiedAccess>] type DividerType = Horizontal | Vertical
        
type AntDivider() =
    inherit AntElement(ofImport "Divider" "antd")
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.Dashed with set (v: bool) = x.Attribute "dashed" v 
    member x.Orientation with set (v: DividerOrientation) = x.Attribute "orientation" v 
    member x.Type with set (v: DividerType) = x.Attribute "type" v 