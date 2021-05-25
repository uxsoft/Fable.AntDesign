module Fable.AntDesign.Calendar

open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.MomentJs
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type CalendarMode = Month | Year

type CalendarBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Calendar" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("dateCellRender")>] member _.dateCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "dateCellRender" v 
    [<CustomOperation("dateFullCellRender")>] member _.dateFullCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "dateFullCellRender" v 
    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v 
    [<CustomOperation("disabledDate")>] member _.disabledDate (x: DSLElement, v: Moment -> bool) = x.attr "disabledDate" v 
    [<CustomOperation("fullscreen")>] member _.fullscreen (x: DSLElement) = x.attr "fullscreen" true
    [<CustomOperation("locale")>] member _.locale (x: DSLElement, v: obj) = x.attr "locale" v 
    [<CustomOperation("mode")>] member _.mode (x: DSLElement, v: CalendarMode) = x.attr "mode" v 
    [<CustomOperation("monthCellRender")>] member _.monthCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "monthCellRender" v 
    [<CustomOperation("monthFullCellRender")>] member _.monthFullCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "monthFullCellRender" v 
    [<CustomOperation("validRange")>] member _.validRange (x: DSLElement, v: Moment array) = x.attr "validRange" v 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: Moment) = x.attr "value" v 
    [<CustomOperation("onPanelChange")>] member _.onPanelChange (x: DSLElement, v: Moment -> string -> unit) = x.attr "onPanelChange" v 
    [<CustomOperation("onSelect")>] member _.onSelect (x: DSLElement, v: Moment -> unit) = x.attr "onSelect" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Moment -> unit) = x.attr "onChange" v 
    [<CustomOperation("headerRender")>] member _.headerRender (x: DSLElement, v: obj -> ReactElement) = x.attr "headerRender" v 