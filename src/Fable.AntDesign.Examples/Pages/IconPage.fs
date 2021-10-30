module Fable.AntDesign.Examples.Pages.IconPage

open Fable.AntDesign.Examples.Components.Example
open Fable.Builders.AntDesign.Ant

let view model =
    Example {
        name "Basic Usage"
        sourceUrl "Pages/IconPage.fs"
        sourceRange (12, 12)
        
        BasicIcon Icons.AimOutlined { () }
    }