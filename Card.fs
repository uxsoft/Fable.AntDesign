namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Card =
    
    type AntCardTab = {
        key: string
        tab: ReactElement
    }

    [<RequireQualifiedAccess>]
    type AntCard  =
        | Actions of ReactElement array
        | ActiveTabKey of string
        | Bordered of bool
        | Cover of ReactElement
        | DefaultActiveTabKey of string
        | Extra of ReactElement
        | Hoverable of bool
        | Loading of bool
        | TabList of AntCardTab array
        | TabBarExtraContent of ReactElement
        | Size of Common.Size
        | Title of ReactElement
        | Type of string
        | OnTabChange of (string -> unit)
        static member Custom (key: string, value: obj): AntCard = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCard = unbox ("style", keyValueList CaseRules.LowerFirst css)
        static member HeadStyle (css: Props.CSSProp list): AntCard = unbox ("headStyle", keyValueList CaseRules.LowerFirst css)
        static member BodyStyle (css: Props.CSSProp list): AntCard = unbox ("bodyStyle", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntCardGrid  =
        | ClassName of string
        | Hoverable of bool
        static member Custom (key: string, value: obj): AntCardGrid = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCardGrid = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntCardMeta  =
        | Avatar of ReactElement
        | ClassName of string
        | Description of ReactElement
        | Title of ReactElement
        static member Custom (key: string, value: obj): AntCardMeta = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCardMeta = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antCard (props: AntCard list) (children: ReactElement list): ReactElement =
       ofImport "Card" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antCardGrid (props: AntCardGrid list) (children: ReactElement list): ReactElement =
       ofImport "Card.Grid" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antCardMeta (props: AntCardMeta list) (children: ReactElement list): ReactElement =
       ofImport "Card.Meta" "antd" (keyValueList CaseRules.LowerFirst props) children