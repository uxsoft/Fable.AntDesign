namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.MomentJs

[<StringEnum; RequireQualifiedAccess>]
type CalendarMode = Month | Year

type AntCalendar() =
    inherit AntElement(ofImport "Calendar" "antd")
    member x.DateCellRender with set (v: (Moment -> ReactElement)) = x.Attribute "dateCellRender" v 
    member x.DateFullCellRender with set (v: (Moment -> ReactElement)) = x.Attribute "dateFullCellRender" v 
    member x.DefaultValue with set (v: Moment) = x.Attribute "defaultValue" v 
    member x.DisabledDate with set (v: (Moment -> bool)) = x.Attribute "disabledDate" v 
    member x.Fullscreen with set (v: bool) = x.Attribute "fullscreen" v 
    member x.Locale with set (v: obj) = x.Attribute "locale" v 
    member x.Mode with set (v: CalendarMode) = x.Attribute "mode" v 
    member x.MonthCellRender with set (v: (Moment -> ReactElement)) = x.Attribute "monthCellRender" v 
    member x.MonthFullCellRender with set (v: (Moment -> ReactElement)) = x.Attribute "monthFullCellRender" v 
    member x.ValidRange with set (v: Moment array) = x.Attribute "validRange" v 
    member x.Value with set (v: Moment) = x.Attribute "value" v 
    member x.OnPanelChange with set (v: (Moment -> string -> unit)) = x.Attribute "onPanelChange" v 
    member x.OnSelect with set (v: (Moment -> unit)) = x.Attribute "onSelect" v 
    member x.OnChange with set (v: (Moment -> unit)) = x.Attribute "onChange" v 
    member x.HeaderRender with set (v: (obj -> ReactElement)) = x.Attribute "headerRender" v 