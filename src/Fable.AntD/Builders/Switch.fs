module Fable.AntD.Builders.Switch

open Browser.Types
open Fable.AntD.Builders.Common
open Fable.React
open Fable.Core.JsInterop
open System

type SwitchBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Switch" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement) = x.attr "autoFocus" true
    [<CustomOperation("isChecked")>] member _.isChecked (x: DSLElement) = x.attr "checked" true
    [<CustomOperation("checkedChildren")>] member _.checkedChildren (x: DSLElement, v: ReactElement) = x.attr "checkedChildren" v
    [<CustomOperation("defaultChecked")>] member _.defaultChecked (x: DSLElement) = x.attr "defaultChecked" true
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement) = x.attr "disabled" true
    [<CustomOperation("loading")>] member _.loading (x: DSLElement) = x.attr "loading" true
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("unCheckedChildren")>] member _.unCheckedChildren (x: DSLElement, v: ReactElement) = x.attr "unCheckedChildren" v
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Func<bool, Event, unit>) = x.attr "onChange" v
    [<CustomOperation("onClick")>] member _.onClick (x: DSLElement, v: Func<bool, Event, unit>) = x.attr "onClick" v
