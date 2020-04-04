namespace Fable.AntD

open Fable.Core
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type DescriptionsLayoutOptions = Horizontal | Vertical

type Descriptions() =
    inherit AntElement("Descriptions")
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.Bordered with set (v: bool) = x.Attribute "bordered" v 
    member x.Column with set (v: int) = x.Attribute "column" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.Layout with set (v: DescriptionsLayoutOptions) = x.Attribute "layout" v 
    member x.Colon with set (v: bool) = x.Attribute "colon" v 
    
type DescriptionsItem() =
    inherit AntElement("Descriptions.Item")
    member x.Label with set (v: ReactElement) = x.Attribute "label" v 
    member x.Span with set (v: int) = x.Attribute "span" v 
