module Fable.AntDesign.Empty

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type EmptyBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Empty" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: ReactElement) = x.attr "description" v 
    [<CustomOperation("image")>] member inline _.image (x: DSLElement, v: ReactElement) = x.attr "image" v 
    [<CustomOperation("imageStyle")>] member inline _.imageStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "imageStyle" (keyValueList CaseRules.LowerFirst css)
