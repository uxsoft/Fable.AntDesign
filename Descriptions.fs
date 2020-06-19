namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type DescriptionsLayoutOptions = Horizontal | Vertical

type AntDescriptions() =
    inherit AntElement(ofImport "Descriptions" "antd")
    member x.Title (v: ReactElement) = x.attribute "title" v 
    member x.Bordered (v: bool) = x.attribute "bordered" v 
    member x.Column (v: int) = x.attribute "column" v 
    member x.Size (v: Size) = x.attribute "size" v 
    member x.Layout (v: DescriptionsLayoutOptions) = x.attribute "layout" v 
    member x.Colon (v: bool) = x.attribute "colon" v 
    
type AntDescriptionsItem() =
    inherit AntElement(ofImport "Descriptions.Item" "antd")
    member x.Label (v: ReactElement) = x.attribute "label" v 
    member x.Span (v: int) = x.attribute "span" v 
