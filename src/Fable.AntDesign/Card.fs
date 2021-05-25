module Fable.AntDesign.Card

open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type CardTab = {
    key: string
    tab: ReactElement
}

[<StringEnum; RequireQualifiedAccess>]
type CardType = Inner

type CardBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Card" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("actions")>] member _.actions (x: DSLElement, v: ReactElement array) = x.attr "actions" v 
    [<CustomOperation("activeTabKey")>] member _.activeTabKey (x: DSLElement, v: string) = x.attr "activeTabKey" v 
    [<CustomOperation("headStyle")>] member _.headStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "headStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("bodyStyle")>] member _.bodyStyle (x: DSLElement, css: Props.CSSProp list) = x.attr "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("bordered")>] member _.bordered (x: DSLElement) = x.attr "bordered" true 
    [<CustomOperation("cover")>] member _.cover (x: DSLElement, v: ReactElement) = x.attr "cover" v 
    [<CustomOperation("defaultActiveTabKey")>] member _.defaultActiveTabKey (x: DSLElement, v: string) = x.attr "defaultActiveTabKey" v 
    [<CustomOperation("extra")>] member _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v 
    [<CustomOperation("hoverable")>] member _.hoverable (x: DSLElement) = x.attr "hoverable" true 
    [<CustomOperation("loading")>] member _.loading (x: DSLElement) = x.attr "loading" true 
    [<CustomOperation("tabList")>] member _.tabList (x: DSLElement, v: CardTab array) = x.attr "tabList" v 
    [<CustomOperation("tabBarExtraContent")>] member _.tabBarExtraContent (x: DSLElement, v: ReactElement) = x.attr "tabBarExtraContent" v 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("cardType")>] member _.cardType (x: DSLElement, v: CardType) = x.attr "type" v
    [<CustomOperation("onTabChange")>] member _.onTabChange (x: DSLElement, v: (string -> unit)) = x.attr "onTabChange" v
    [<CustomOperation("tabProps")>] member _.tabProps (x: DSLElement, v: obj) = x.attr "tabProps" v

type CardGridBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Card.Grid" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("className")>] member _.className (x: DSLElement, v: string) = x.attr "className" v 
    [<CustomOperation("hoverable")>] member _.hoverable (x: DSLElement) = x.attr "hoverable" true 

type CardMetaBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Card.Meta" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("avatar")>] member _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v 
    [<CustomOperation("className")>] member _.className (x: DSLElement, v: string) = x.attr "className" v 
    [<CustomOperation("description")>] member _.description (x: DSLElement, v: ReactElement) = x.attr "description" v 
    [<CustomOperation("title")>] member _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 