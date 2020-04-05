namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type Empty() =
    inherit AntElement(ofImport "Empty" "antd")
    member x.Description with set (v: ReactElement) = x.Attribute "description" v 
    member x.Image with set (v: ReactElement) = x.Attribute "image" v 
    member x.ImageStyle (css: Props.CSSProp list) = x.Attribute "imageStyle" (keyValueList CaseRules.LowerFirst css)
