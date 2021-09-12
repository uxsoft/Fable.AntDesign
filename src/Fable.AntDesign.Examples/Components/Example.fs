module Fable.AntDesign.Examples.Components.Example

open Fable.Builders.AntDesign.Button
open Fable.Builders.AntDesign.Ant
open Fable.Builders.Common
open Fable.Builders.React
open Fetch
open Feliz

let subLines (text: string) (startIndex: int) (endIndex: int) =
    text.Split('\n')
        |> Seq.skip startIndex
        |> Seq.take (endIndex - startIndex)
        |> (fun items -> System.String.Join("\n", items))

[<ReactComponent>]
let ExampleComponent (props: {| Url: string; Range: int * int; Name: string; Children: Fable.React.ReactElement list |}) = 
    Html.div {        
        style [
            style.border(1, borderStyle.solid, "#f0f0f0")
            style.borderRadius(2)
            style.margin(0, 0, 16) ]
        
        // Example itself
        Html.div {
            style [ style.padding(42, 24, 50) ]
            props.Children
        }
        // Description
        Html.div {
            props.Name
        }
        // Buttons
        Html.div {
            style [
                style.display.flex
                style.justifyContent.center
                style.opacity 0.7
                style.padding(12, 0)
                style.custom("transition", "opacity .3s")
                style.borderTop(1, borderStyle.dashed, "#f0f0f0") ]
            button {
                buttonType ButtonType.Text
                icon (basicIcon icons.CodeOutlined { () })
//                icon (customIcon "https://gw.alipayobjects.com/zos/antfincdn/4zAaozCvUH/unexpand.svg")
                href props.Url
            }
        }
        
        // Source code
        Html.div {
            str "Source Code:"
            Html.pre {
                let sourceCode, setSourceCode = React.useState ""

                React.useEffect((fun _ ->
                    promise {
                        let! response = fetch props.Url []
                        let! text = response.text()
                        let startIndex, endIndex = props.Range
                        let part = subLines text startIndex endIndex
                        setSourceCode part
                    } |> Promise.start
                ), [||])
                str sourceCode
            }
        }
    }
    
type ExampleBuilder() =
    inherit ReactBuilder()
    
    [<CustomOperation("sourceUrl")>]
    member _.SourceUrl(x: DSLElement, v: string) = x.attr "sourceUrl" v
    
    [<CustomOperation("sourceRange")>]
    member _.SourceRange(x: DSLElement, v: int * int) = x.attr "sourceRange" v

    [<CustomOperation("name")>]
    member _.Name(x: DSLElement, v: string) = x.attr "name" v
          
    member _.Run(x: DSLElement) =
        let url = x.getOrDefault<string> "sourceUrl" ""
        let range = x.getOrDefault<int * int> "sourceRange" (0, 0)
        let name = x.getOrDefault<string> "name" ""
       
        let fullUrl = 
            if url.StartsWith("https://") then url
            else $"https://raw.githubusercontent.com/uxsoft/Fable.AntDesign/master/src/Fable.AntDesign.Examples/{url}"
            
        ExampleComponent
            {| Url = fullUrl
               Range = range
               Name = name
               Children = x.Children |}
        
let example = ExampleBuilder()