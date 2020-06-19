namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type AntEmpty() =
    inherit AntElement<AntEmpty>(ofImport "Empty" "antd")
    member x.description (v: ReactElement) = x.attribute "description" v 
    member x.image (v: ReactElement) = x.attribute "image" v 
    member x.imageStyle (css: Props.CSSProp list) = x.attribute "imageStyle" (keyValueList CaseRules.LowerFirst css)
