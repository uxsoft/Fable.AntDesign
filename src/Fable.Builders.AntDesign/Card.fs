namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen>]
module Card =

    type CardTab = {
        key: string
        tab: ReactElement
    }
    
    [<StringEnum; RequireQualifiedAccess>]
    type CardType = Inner
    
    type CardBuilder() =
        inherit ReactBuilder(import "Card" "antd")
    
        [<CustomOperation("actions")>] member inline _.actions (x: DSLElement, v: ReactElement array) = x.attr "actions" v 
        [<CustomOperation("activeTabKey")>] member inline _.activeTabKey (x: DSLElement, v: string) = x.attr "activeTabKey" v 
        [<CustomOperation("headStyle")>] member inline _.headStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "headStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("bodyStyle")>] member inline _.bodyStyle (x: DSLElement, css: IStyleAttribute list) = x.attr "bodyStyle" (keyValueList CaseRules.LowerFirst css)
        [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v 
        [<CustomOperation("cover")>] member inline _.cover (x: DSLElement, v: ReactElement) = x.attr "cover" v 
        [<CustomOperation("defaultActiveTabKey")>] member inline _.defaultActiveTabKey (x: DSLElement, v: string) = x.attr "defaultActiveTabKey" v 
        [<CustomOperation("extra")>] member inline _.extra (x: DSLElement, v: ReactElement) = x.attr "extra" v 
        [<CustomOperation("hoverable")>] member inline _.hoverable (x: DSLElement, v: bool) = x.attr "hoverable" v 
        [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v 
        [<CustomOperation("tabList")>] member inline _.tabList (x: DSLElement, v: CardTab array) = x.attr "tabList" v 
        [<CustomOperation("tabBarExtraContent")>] member inline _.tabBarExtraContent (x: DSLElement, v: ReactElement) = x.attr "tabBarExtraContent" v 
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v 
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
        [<CustomOperation("cardType")>] member inline _.cardType (x: DSLElement, v: CardType) = x.attr "type" v
        [<CustomOperation("onTabChange")>] member inline _.onTabChange (x: DSLElement, v: (string -> unit)) = x.attr "onTabChange" v
        [<CustomOperation("tabProps")>] member inline _.tabProps (x: DSLElement, v: obj) = x.attr "tabProps" v
        //TODO Better type
    
    type CardGridBuilder() =
        inherit ReactBuilder(import "Card.Grid" "antd")
    
        [<CustomOperation("hoverable")>] member inline _.hoverable (x: DSLElement, v: bool) = x.attr "hoverable" v 
    
    type CardMetaBuilder() =
        inherit ReactBuilder(import "Card.Meta" "antd")
    
        [<CustomOperation("avatar")>] member inline _.avatar (x: DSLElement, v: ReactElement) = x.attr "avatar" v 
        [<CustomOperation("description")>] member inline _.description (x: DSLElement, v: ReactElement) = x.attr "description" v 
        [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 