module Fable.AntDesign.Examples.Pages.NotificationPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant
open Fable.Builders.AntDesign.Notification

let onNotificationRequested k _ =
    Notification {
        message "Success!"
        description "What just happened?"
        kind k
    }

let view model =
    Example {
        sourceUrl "https://github.com/uxsoft/Fable.AntD/blob/master/src/Fable.AntDesign.Examples/Pages/NotificationPage.fs"
        Button {
            onClick (onNotificationRequested NotificationKind.Success)
            str "Show Success"
        }
    }