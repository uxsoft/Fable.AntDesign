module Fable.AntD.Examples.Components.Example

open Fable.AntDesign.Button
open Fable.AntDesign.Common
open Fable.AntDesign.Ant
open Fable.React.Props

type ExampleBuilder() =
    inherit ReactBuilder()
    
    [<CustomOperation("sourceUrl")>] member _.SourceUrl(x: DSLElement, v: string) = x.attr "sourceUrl" v
    
    member _.Run(x: DSLElement) =
        let sourceUrl = x.getOrDefault<string> "sourceUrl" ""
        
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
                button {
                    buttonType ButtonType.Text
                    icon (basicIcon icons.CodeOutlined { () })
                    href sourceUrl
                }
            }  
        }
        
let example = ExampleBuilder()