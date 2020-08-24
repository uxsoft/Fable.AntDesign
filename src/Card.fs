namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type CardTab = {
    key: string
    tab: ReactElement
}

[<StringEnum; RequireQualifiedAccess>]
type CardType = Inner

type AntCard() =
    inherit AntElement<AntCard>(ofImport "Card" "antd")
    member x.actions (v: ReactElement array) = x.attribute "actions" v 
    member x.activeTabKey (v: string) = x.attribute "activeTabKey" v 
    member x.headStyle (css: Props.CSSProp list) = x.attribute "headStyle" (keyValueList CaseRules.LowerFirst css)
    member x.bodyStyle (css: Props.CSSProp list) = x.attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    member x.bordered (v: bool) = x.attribute "bordered" v 
    member x.cover (v: ReactElement) = x.attribute "cover" v 
    member x.defaultActiveTabKey (v: string) = x.attribute "defaultActiveTabKey" v 
    member x.extra (v: ReactElement) = x.attribute "extra" v 
    member x.hoverable (v: bool) = x.attribute "hoverable" v 
    member x.loading (v: bool) = x.attribute "loading" v 
    member x.tabList (v: CardTab array) = x.attribute "tabList" v 
    member x.tabBarExtraContent (v: ReactElement) = x.attribute "tabBarExtraContent" v 
    member x.size (v: Size) = x.attribute "size" v 
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.cardType (v: CardType) = x.attribute "type" v
    member x.onTabChange (v: (string -> unit)) = x.attribute "onTabChange" v
    member x.tabProps (v: AntTabs) = x.attribute "tabProps" v.JSON

type AntCardGrid() =
    inherit AntElement<AntCardGrid>(ofImport "Card.Grid" "antd")
    member x.className (v: string) = x.attribute "className" v 
    member x.hoverable (v: bool) = x.attribute "hoverable" v 

type AntCardMeta() =
    inherit AntElement<AntCardMeta>(ofImport "Card.Meta" "antd")
    member x.avatar (v: ReactElement) = x.attribute "avatar" v 
    member x.className (v: string) = x.attribute "className" v 
    member x.description (v: ReactElement) = x.attribute "description" v 
    member x.title (v: ReactElement) = x.attribute "title" v 