module Fable.AntDesign.Examples.Pages.ChartsPage

open Fable.Builders.AntDesign
open Fable.Builders.AntDesignCharts
open Fable.AntDesign.Examples.Components.Example
    
let view model =
    Example {
        name "Column Chart"
        sourceUrl "Pages/ChartsPage.fs"
        sourceRange (13, 37)
        
        let plotData =
            [| 
                {| Id = ""
                   Name = "Toyota"
                   Count = 38 |}
                {| Id = ""
                   Name = "Volkswagen"
                   Count = 27 |}
                {| Id = ""
                   Name = "Opel"
                   Count = 5 |}
                {| Id = ""
                   Name = "BMW"
                   Count = 16 |}
            |]
        
        Column {
            height 128
            autoFit true
            data plotData
            xField "Name"
            yField "Count"
            seriesField "Name"
        }
    }