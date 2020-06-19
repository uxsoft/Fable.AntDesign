namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.MomentJs

[<StringEnum; RequireQualifiedAccess>]
type CalendarMode = Month | Year

type AntCalendar() =
    inherit AntElement<AntCalendar>(ofImport "Calendar" "antd")
    member x.dateCellRender (v: (Moment -> ReactElement)) = x.attribute "dateCellRender" v 
    member x.dateFullCellRender (v: (Moment -> ReactElement)) = x.attribute "dateFullCellRender" v 
    member x.defaultValue (v: Moment) = x.attribute "defaultValue" v 
    member x.disabledDate (v: (Moment -> bool)) = x.attribute "disabledDate" v 
    member x.fullscreen (v: bool) = x.attribute "fullscreen" v 
    member x.locale (v: obj) = x.attribute "locale" v 
    member x.mode (v: CalendarMode) = x.attribute "mode" v 
    member x.monthCellRender (v: (Moment -> ReactElement)) = x.attribute "monthCellRender" v 
    member x.monthFullCellRender (v: (Moment -> ReactElement)) = x.attribute "monthFullCellRender" v 
    member x.validRange (v: Moment array) = x.attribute "validRange" v 
    member x.value (v: Moment) = x.attribute "value" v 
    member x.onPanelChange (v: (Moment -> string -> unit)) = x.attribute "onPanelChange" v 
    member x.onSelect (v: (Moment -> unit)) = x.attribute "onSelect" v 
    member x.onChange (v: (Moment -> unit)) = x.attribute "onChange" v 
    member x.headerRender (v: (obj -> ReactElement)) = x.attribute "headerRender" v 