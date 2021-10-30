module Fable.AntDesign.Examples.Pages.ProgressPage

open Fable.Builders.AntDesign
open Fable.AntDesign.Examples.Components.Example

let view model =
    Example {
        name "Basic Usage"
        sourceUrl "Pages/ProgressPage.fs"
        sourceRange (6, 16)
        
        Progress { percent 30 }
        Progress { percent 50; status ProgressStatus.Active }
        Progress { percent 70; status ProgressStatus.Exception }
        Progress { percent 100 }
        Progress { percent 50; showInfo false }
    }