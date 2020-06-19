namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type DescriptionsLayoutOptions = Horizontal | Vertical

type AntDescriptions() =
    inherit AntElement<AntDescriptions>(ofImport "Descriptions" "antd")
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.bordered (v: bool) = x.attribute "bordered" v 
    member x.column (v: int) = x.attribute "column" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.layout (v: DescriptionsLayoutOptions) = x.attribute "layout" v 
    member x.colon (v: bool) = x.attribute "colon" v 
    
type AntDescriptionsItem() =
    inherit AntElement<AntDescriptionsItem>(ofImport "Descriptions.Item" "antd")
    member x.label (v: ReactElement) = x.attribute "label" v 
    member x.span (v: int) = x.attribute "span" v 
