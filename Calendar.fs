namespace Fable.AntD

open Fable.Core
open Fable.React
open Fable.MomentJs

[<StringEnum; RequireQualifiedAccess>]
type CalendarMode = Month | Year

type AntCalendar() =
    inherit AntElement(ofImport "Calendar" "antd")
    member x.DateCellRender (v: (Moment -> ReactElement)) = x.attribute "dateCellRender" v 
    member x.DateFullCellRender (v: (Moment -> ReactElement)) = x.attribute "dateFullCellRender" v 
    member x.DefaultValue (v: Moment) = x.attribute "defaultValue" v 
    member x.DisabledDate (v: (Moment -> bool)) = x.attribute "disabledDate" v 
    member x.Fullscreen (v: bool) = x.attribute "fullscreen" v 
    member x.Locale (v: obj) = x.attribute "locale" v 
    member x.Mode (v: CalendarMode) = x.attribute "mode" v 
    member x.MonthCellRender (v: (Moment -> ReactElement)) = x.attribute "monthCellRender" v 
    member x.MonthFullCellRender (v: (Moment -> ReactElement)) = x.attribute "monthFullCellRender" v 
    member x.ValidRange (v: Moment array) = x.attribute "validRange" v 
    member x.Value (v: Moment) = x.attribute "value" v 
    member x.OnPanelChange (v: (Moment -> string -> unit)) = x.attribute "onPanelChange" v 
    member x.OnSelect (v: (Moment -> unit)) = x.attribute "onSelect" v 
    member x.OnChange (v: (Moment -> unit)) = x.attribute "onChange" v 
    member x.HeaderRender (v: (obj -> ReactElement)) = x.attribute "headerRender" v 