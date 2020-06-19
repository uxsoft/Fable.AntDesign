namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntEmpty() =
    inherit AntElement(ofImport "Empty" "antd")
    member x.Description (v: ReactElement) = x.attribute "description" v 
    member x.Image (v: ReactElement) = x.attribute "image" v 
    member x.ImageStyle (css: Props.CSSProp list) = x.attribute "imageStyle" (keyValueList CaseRules.LowerFirst css)
