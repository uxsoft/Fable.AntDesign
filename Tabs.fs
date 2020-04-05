namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

[<StringEnum; RequireQualifiedAccess>] type TabsPosition = Top | Right | Bottom | Left

[<StringEnum; RequireQualifiedAccess>] type TabsType = Line | Card | [<CompiledName("editable-card")>] EditableCard

type Tabs()  =
  inherit AntElement(ofImport "Tabs" "antd")
  member x.ActiveKey with set (v: string) = x.Attribute "activeKey" v 
  member x.Animated with set (v: bool) = x.Attribute "animated" v
  member x.RenderTabBar with set (v: (obj -> obj -> ReactElement)) = x.Attribute "renderTabBar" v 
  member x.DefaultActiveKey with set (v: string) = x.Attribute "defaultActiveKey" v 
  member x.HideAdd with set (v: bool) = x.Attribute "hideAdd" v
  member x.Size with set (v: Size) = x.Attribute "size" v 
  member x.TabBarExtraContent with set (v: ReactElement) = x.Attribute "tabBarExtraContent" v 
  member x.TabBarGutter with set (v: float) = x.Attribute "tabBarGutter" v 
  member x.TabPosition with set (v: TabsPosition) = x.Attribute "tabPosition" v 
  member x.Type with set (v: TabsType) = x.Attribute "type" v 
  member x.OnChange with set (v: (string -> unit)) = x.Attribute "onChange" v 
  member x.OnEdit with set (v: (string -> string -> unit)) = x.Attribute "onEdit" v 
  member x.OnNextClick with set (v: (unit -> unit)) = x.Attribute "onNextClick" v 
  member x.OnPrevClick with set (v: (unit -> unit)) = x.Attribute "onPrevClick" v
  member x.OnTabClick with set (v: (string -> Event -> unit)) = x.Attribute "onTabClick" v 
  member x.TabBarStyle (css: Props.CSSProp list) = x.Attribute "tabBarStyle" (keyValueList CaseRules.LowerFirst css)

type TabsPane()  =
  inherit AntElement(ofImport "Tabs.TabPane" "antd")
  member x.ForceRender with set (v: bool) = x.Attribute "forceRender" v
  member x.Key with set (v: string) = x.Attribute "key" v 
  member x.Tab with set (v: ReactElement) = x.Attribute "tab" v 