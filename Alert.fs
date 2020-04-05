namespace Fable.AntD

open Fable.Core
open Browser.Types
open Fable.React

[<StringEnum; RequireQualifiedAccess>] type AlertType = Success | Info | Warning | Error

type Alert()  =
    inherit AntElement(ofImport "Alert" "antd")
    member x.AfterClose with set (v: (unit -> unit)) = x.Attribute "afterClose" v 
    member x.Banner with set (v: bool) = x.Attribute "banner" v 
    member x.Closable with set (v: bool) = x.Attribute "closable" v 
    member x.CloseText with set (v: ReactElement) = x.Attribute "closeText" v 
    member x.Description with set (v: ReactElement) = x.Attribute "description" v 
    member x.Icon with set (v: ReactElement) = x.Attribute "icon" v 
    member x.Message with set (v: ReactElement) = x.Attribute "message" v 
    member x.ShowIcon with set (v: bool) = x.Attribute "showIcon" v 
    member x.Type with set (v: AlertType) = x.Attribute "type" v 
    member x.OnClose with set (v: (Event -> unit)) = x.Attribute "onClose" v 
