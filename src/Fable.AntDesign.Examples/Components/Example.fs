module Fable.AntD.Examples.Components.Example

open Fable.AntDesign.Common
open Fable.AntDesign.Ant
open Fable.React.Props

type ExampleBuilder() =
    inherit ReactBuilder()
    
    let mutable sourceUrl = ""
    
    [<CustomOperation("sourceUrl")>] member _.SourceUrl(x: DSLElement, url: string) = sourceUrl <- url; x
    
    member _.Run(x: DSLElement) =
        div {
            style [ Border "1px solid #f0f0f0"
                    BorderRadius "2px"
                    Margin "0 0 16px" ]
            div {
                style [ Padding "42px 24px 50px" ]
                x.Children
            }
            div {
                style [
                    Display DisplayOptions.Flex
                    JustifyContent "center"
                    Opacity 0.7
                    Padding "12px 0"
                    Transition "opacity .3s"
                    BorderTop "1px dashed #f0f0f0"
                ]
                str $"Source: {sourceUrl}"
            }  
        }
        
let example = ExampleBuilder()