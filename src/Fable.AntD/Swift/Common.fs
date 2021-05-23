namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.Core.JsInterop
open Fable.React.Props

[<StringEnum; RequireQualifiedAccess>]
type Size = Large | Default | Small

[<StringEnum; RequireQualifiedAccess>]
type Theme = Dark | Light

type AntObject<'T when 'T :> AntObject<'T>>() = 
    let mutable props = []

    member x.JSON = createObj props
    member internal x.attribute name value =
        props <- props @ [name ==> value]
        x :?> 'T
        
type AntElement<'T when 'T :> AntElement<'T>> (partialImport: obj -> ReactElement seq -> ReactElement) =
    inherit AntObject<'T>()
    
    member x.Item
        with get(children: ReactElement list) = partialImport x.JSON children
    
    member x.children (children: ReactElement list) =
        partialImport x.JSON children
        
    member x.build () =
        partialImport x.JSON []
        
    // Common Attributes
    member x.set (v: string * 'TValue) = match v with (name, value) -> x.attribute name value
    member x.style (css: CSSProp list) = x.attribute "style" (keyValueList CaseRules.LowerFirst css)
    member x.id (v: string) = x.attribute "id" v
    member x.key (v: string) = x.attribute "key" v