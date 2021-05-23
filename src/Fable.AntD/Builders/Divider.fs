module Fable.AntD.Builders.Divider

open Fable.AntD.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type DividerOrientation = Left | Right | Center
[<StringEnum; RequireQualifiedAccess>] type DividerType = Horizontal | Vertical
        
type DividerBuilder() =
    inherit ReactBuilder()
    member _.Run(s: DSLElement) = ofImport "Divider" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("dashed")>] member _.dashed (x: DSLElement) = x.attr "dashed" true 
    [<CustomOperation("orientation")>] member _.orientation (x: DSLElement, v: DividerOrientation) = x.attr "orientation" v 
    [<CustomOperation("plain")>] member _.plain (x: DSLElement) = x.attr "plain" true
    [<CustomOperation("dividerType")>] member _.dividerType (x: DSLElement, v: DividerType) = x.attr "type" v
