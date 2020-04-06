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
    member x.Actions with set (v: ReactElement array) = x.Attribute "actions" v 
    member x.ActiveTabKey with set (v: string) = x.Attribute "activeTabKey" v 
    member x.Bordered with set (v: bool) = x.Attribute "bordered" v 
    member x.Cover with set (v: ReactElement) = x.Attribute "cover" v 
    member x.DefaultActiveTabKey with set (v: string) = x.Attribute "defaultActiveTabKey" v 
    member x.Extra with set (v: ReactElement) = x.Attribute "extra" v 
    member x.Hoverable with set (v: bool) = x.Attribute "hoverable" v 
    member x.Loading with set (v: bool) = x.Attribute "loading" v 
    member x.TabList with set (v: CardTab array) = x.Attribute "tabList" v 
    member x.TabBarExtraContent with set (v: ReactElement) = x.Attribute "tabBarExtraContent" v 
    member x.Size with set (v: Size) = x.Attribute "size" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 
    member x.Type with set (v: string) = x.Attribute "type" v 
    member x.OnTabChange with set (v: (string -> unit)) = x.Attribute "onTabChange" v 
    member x.HeadStyle (css: Props.CSSProp list) = x.Attribute "headStyle" (keyValueList CaseRules.LowerFirst css)
    member x.BodyStyle (css: Props.CSSProp list) = x.Attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)

type AntCardGrid() =
    inherit AntElement(ofImport "Card.Grid" "antd")
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.Hoverable with set (v: bool) = x.Attribute "hoverable" v 

type AntCardMeta() =
    inherit AntElement(ofImport "Card.Meta" "antd")
    member x.Avatar with set (v: ReactElement) = x.Attribute "avatar" v 
    member x.ClassName with set (v: string) = x.Attribute "className" v 
    member x.Description with set (v: ReactElement) = x.Attribute "description" v 
    member x.Title with set (v: ReactElement) = x.Attribute "title" v 