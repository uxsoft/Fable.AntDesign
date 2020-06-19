namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type CardTab = {
    key: string
    tab: ReactElement
}

type AntCard() =
    inherit AntElement(ofImport "Card" "antd")
    member x.Actions (v: ReactElement array) = x.attribute "actions" v 
    member x.ActiveTabKey (v: string) = x.attribute "activeTabKey" v 
    member x.Bordered (v: bool) = x.attribute "bordered" v 
    member x.Cover (v: ReactElement) = x.attribute "cover" v 
    member x.DefaultActiveTabKey (v: string) = x.attribute "defaultActiveTabKey" v 
    member x.Extra (v: ReactElement) = x.attribute "extra" v 
    member x.Hoverable (v: bool) = x.attribute "hoverable" v 
    member x.Loading (v: bool) = x.attribute "loading" v 
    member x.TabList (v: CardTab array) = x.attribute "tabList" v 
    member x.TabBarExtraContent (v: ReactElement) = x.attribute "tabBarExtraContent" v 
    member x.Size (v: Size) = x.attribute "size" v 
    member x.Title (v: ReactElement) = x.attribute "title" v 
    member x.Type (v: string) = x.attribute "type" v 
    member x.OnTabChange (v: (string -> unit)) = x.attribute "onTabChange" v 
    member x.HeadStyle (css: Props.CSSProp list) = x.attribute "headStyle" (keyValueList CaseRules.LowerFirst css)
    member x.BodyStyle (css: Props.CSSProp list) = x.attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)

type AntCardGrid() =
    inherit AntElement(ofImport "Card.Grid" "antd")
    member x.ClassName (v: string) = x.attribute "className" v 
    member x.Hoverable (v: bool) = x.attribute "hoverable" v 

type AntCardMeta() =
    inherit AntElement(ofImport "Card.Meta" "antd")
    member x.Avatar (v: ReactElement) = x.attribute "avatar" v 
    member x.ClassName (v: string) = x.attribute "className" v 
    member x.Description (v: ReactElement) = x.attribute "description" v 
    member x.Title (v: ReactElement) = x.attribute "title" v 