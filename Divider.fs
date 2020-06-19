namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type DividerOrientation = Left | Right | Center
[<StringEnum; RequireQualifiedAccess>] type DividerType = Horizontal | Vertical
        
type AntDivider() =
    inherit AntElement<AntDivider>(ofImport "Divider" "antd")
    member x.className (v: string) = x.attribute "className" v 
    member x.dashed (v: bool) = x.attribute "dashed" v 
    member x.orientation (v: DividerOrientation) = x.attribute "orientation" v 
    member x.dividerType (v: DividerType) = x.attribute "type" v 