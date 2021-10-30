namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Core
open Fable.React
open Fable.MomentJs
open Fable.Core.JsInterop

[<AutoOpen>]
module Calendar =

    [<StringEnum; RequireQualifiedAccess>]
    type CalendarMode = Month | Year
    
    type CalendarBuilder() =
        inherit ReactBuilder(import "Calendar" "antd")
    
        [<CustomOperation("dateCellRender")>] member inline _.dateCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "dateCellRender" v 
        [<CustomOperation("dateFullCellRender")>] member inline _.dateFullCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "dateFullCellRender" v 
        [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v 
        [<CustomOperation("disabledDate")>] member inline _.disabledDate (x: DSLElement, v: Moment -> bool) = x.attr "disabledDate" v 
        [<CustomOperation("fullscreen")>] member inline _.fullscreen (x: DSLElement, v: bool) = x.attr "fullscreen" v
        [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: obj) = x.attr "locale" v 
        [<CustomOperation("mode")>] member inline _.mode (x: DSLElement, v: CalendarMode) = x.attr "mode" v 
        [<CustomOperation("monthCellRender")>] member inline _.monthCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "monthCellRender" v 
        [<CustomOperation("monthFullCellRender")>] member inline _.monthFullCellRender (x: DSLElement, v: Moment -> ReactElement) = x.attr "monthFullCellRender" v 
        [<CustomOperation("validRange")>] member inline _.validRange (x: DSLElement, v: Moment array) = x.attr "validRange" v 
        [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v 
        [<CustomOperation("onPanelChange")>] member inline _.onPanelChange (x: DSLElement, v: Moment -> string -> unit) = x.attr "onPanelChange" v 
        [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, v: Moment -> unit) = x.attr "onSelect" v 
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Moment -> unit) = x.attr "onChange" v 
        [<CustomOperation("headerRender")>] member inline _.headerRender (x: DSLElement, v: obj -> ReactElement) = x.attr "headerRender" v 