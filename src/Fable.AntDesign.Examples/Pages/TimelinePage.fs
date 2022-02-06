module Fable.AntDesign.Examples.Pages.TimelinePage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign

let view model =
    Example {
        name "Basic Usage"
        sourceUrl "Pages/TimelinePage.fs"
        sourceRange (13, 19)
        
        Space {
            Timeline {
                TimelineItem {
                    str "Item 1"           
                }
                TimelineItem {
                    str "Item 1"           
                }
            }
        }
    }