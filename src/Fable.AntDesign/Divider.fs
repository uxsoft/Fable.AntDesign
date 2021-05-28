module Fable.AntDesign.Divider

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type DividerOrientation = Left | Right | Center
[<StringEnum; RequireQualifiedAccess>] type DividerType = Horizontal | Vertical
        
type DividerBuilder() =
    inherit ReactBuilder()
    member _.Run(s: DSLElement) = ofImport "Divider" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("dashed")>] member inline _.dashed (x: DSLElement, v: bool) = x.attr "dashed" v 
    [<CustomOperation("orientation")>] member inline _.orientation (x: DSLElement, v: DividerOrientation) = x.attr "orientation" v 
    [<CustomOperation("plain")>] member inline _.plain (x: DSLElement, v: bool) = x.attr "plain" v
    [<CustomOperation("dividerType")>] member inline _.dividerType (x: DSLElement, v: DividerType) = x.attr "type" v
