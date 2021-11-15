module Fable.AntDesign.Examples.Pages.CollapsePage

open Fable.Builders.React
open Fable.Builders.AntDesign
open Fable.AntDesign.Examples.Components.Example
open Fable.Import
open Feliz

let view model =
    Example {
        name "Basic Usage"
        sourceUrl "Pages/CollapsePage.fs"
        sourceRange (15, 40)
        
        let callback key' = Browser.Dom.console.log key'
        let text = """
  A dog is a type of domesticated animal.
  Known for its loyalty and faithfulness,
  it can be found as a welcome guest in many households across the world.
"""
        
        Collapse {
            defaultActiveKey [| "1" |]
            onChange callback
            CollapsePanel {
                header (str "This is panel header 1")
                key "1"
                Text { str text }
            }
            CollapsePanel {
                header (str "This is panel header 2")
                key "2"
                Text { str text }
            }
            CollapsePanel {
                header (str "This is panel header 3")
                key "3"
                Text { text }
            }
        }
    }