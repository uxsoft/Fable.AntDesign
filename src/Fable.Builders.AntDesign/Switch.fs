namespace Fable.Builders.AntDesign

open Browser.Types
open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop
open System

[<AutoOpen>]
module Switch =

    type SwitchBuilder() =
        inherit ReactBuilder(import "Switch" "antd")
    
        [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
        [<CustomOperation("isChecked")>] member inline _.isChecked (x: DSLElement, v: bool) = x.attr "checked" v
        [<CustomOperation("checkedChildren")>] member inline _.checkedChildren (x: DSLElement, v: ReactElement) = x.attr "checkedChildren" v
        [<CustomOperation("defaultChecked")>] member inline _.defaultChecked (x: DSLElement, v: bool) = x.attr "defaultChecked" v
        [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
        [<CustomOperation("loading")>] member inline _.loading (x: DSLElement, v: bool) = x.attr "loading" v
        [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
        [<CustomOperation("unCheckedChildren")>] member inline _.unCheckedChildren (x: DSLElement, v: ReactElement) = x.attr "unCheckedChildren" v
        [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<bool, Event, unit>) = x.attr "onChange" v
        [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: Func<bool, Event, unit>) = x.attr "onClick" v
    