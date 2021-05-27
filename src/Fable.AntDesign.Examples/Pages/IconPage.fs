module Fable.AntD.Examples.Pages.IconPage

open Fable.AntD.Examples.Components.Example
open Fable.AntDesign.Ant

let view model =
    example {
        icon icons.AimOutlined { () }
    }