namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Description =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type DescriptionsLayoutOptions = Horizontal | Vertical
    
    [<RequireQualifiedAccess>]
    type AntDescriptions =
        | Title of ReactElement
        | Bordered of bool
        | Column of int
        | Size of Size
        | Layout of DescriptionsLayoutOptions
        | Colon of bool
        static member Custom (key: string, value: obj): AntDescriptions = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntDescriptions = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntDescriptionsItem =
        | Label of ReactElement
        | Span of int
        static member Custom (key: string, value: obj): AntDescriptionsItem = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntDescriptionsItem = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antDescriptions (props: AntDescriptions list) (children: ReactElement list): ReactElement =
       ofImport "Descriptions" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antDescriptionsItem (props: AntDescriptionsItem list) (children: ReactElement list): ReactElement =
       ofImport "Descriptions.Item" "antd" (keyValueList CaseRules.LowerFirst props) children