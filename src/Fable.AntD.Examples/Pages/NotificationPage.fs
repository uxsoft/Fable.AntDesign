module Fable.AntD.Examples.Pages.NotificationPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant
open Fable.AntDesign.Notification

let onNotificationRequested k _ =
    notification {
        message "Success!"
        description "What just happened?"
        kind k
    }

let view model =
    example {
        sourceUrl $"https://github.com/uxsoft/Fable.AntD/blob/master/src/Fable.AntD.Examples/Pages/NotificationPage.fs"
        button {
            onClick (onNotificationRequested NotificationKind.Success)
            str "Show Success"
        }
    }