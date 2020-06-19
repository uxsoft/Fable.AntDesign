namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type DividerOrientation = Left | Right | Center
[<StringEnum; RequireQualifiedAccess>] type DividerType = Horizontal | Vertical
        
type AntDivider() =
    inherit AntElement(ofImport "Divider" "antd")
    member x.ClassName (v: string) = x.attribute "className" v 
    member x.Dashed (v: bool) = x.attribute "dashed" v 
    member x.Orientation (v: DividerOrientation) = x.attribute "orientation" v 
    member x.Type (v: DividerType) = x.attribute "type" v 