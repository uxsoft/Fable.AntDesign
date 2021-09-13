module Fable.AntDesign.Examples.Components.Example

open Fable.Builders.AntDesign
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
        
let fullExampleUrl (url: string) =
    if url.StartsWith("https://") then url
    else $"https://raw.githubusercontent.com/uxsoft/Fable.AntDesign/master/src/Fable.AntDesign.Examples/{url}"

let private imageButtonStyle =
    [ style.height 16
      style.width 16
      style.marginLeft 16 
      style.cursor.pointer ]

[<ReactComponent>]
let imageButton url tip inPressed =
    tooltip {
        title (str tip)
        
        Html.span {
            onClick (ignore >> inPressed)
            Html.img {
                style imageButtonStyle
                src url
            }
        }
    }
    
[<ReactComponent>]
let imageToggleButton urlOn urlOff tip onChanged =
    let isPressed, setIsPressed = React.useState false
    
    tooltip {
        title (str tip)
        
        Html.span {
            onClick (fun _ ->
                setIsPressed (not isPressed)
                onChanged (not isPressed))
            
            if isPressed then
                Html.img {
                    style imageButtonStyle
                    src urlOn
                }
            else 
                Html.img {
                    style imageButtonStyle
                    src urlOff
                }
        }
    }
    
let goToSourceButton =
    imageButton
        "https://raw.githubusercontent.com/gilbarbara/logos/master/logos/github-icon.svg"
        
let showSourceCodeButton =
    imageToggleButton
        "https://gw.alipayobjects.com/zos/antfincdn/4zAaozCvUH/unexpand.svg"
        "https://gw.alipayobjects.com/zos/antfincdn/Z5c7kzvi30/expand.svg"

[<ReactComponent>]
let ExampleComponent (url: string) (startIndex: int) (endIndex: int) (exampleName: string) (children: Fable.React.ReactElement list) = 
    let isCodeVisible, setCodeVisible = React.useState false
    let sourceCode, setSourceCode = React.useState ""

    React.useEffect((fun _ ->
        promise {
            let! response = fetch url []
            let! text = response.text()            
            let part = subLines text startIndex endIndex
            setSourceCode part
        }
        |> Promise.catch (fun e -> printfn $"Error retrieving source code: {e}")
        |> Promise.start 
    ), [||])
    
    Html.div {        
        style [
            style.border(1, borderStyle.solid, "#f0f0f0")
            style.borderRadius(2)
            style.margin(0, 0, 16) ]
        
        // Example itself
        Html.section {
            style [ style.padding(42, 24, 50) ]
            children
        }
        // Description
        Html.section {
            style [ style.padding 6 ] 
            exampleName
        }
        // Buttons
        Html.section {
            style [
                style.display.flex
                style.justifyContent.center
                style.opacity 0.7
                style.padding(12, 0)
                style.custom("transition", "opacity .3s")
                style.borderTop(1, borderStyle.dashed, "#f0f0f0")
                style.borderBottom(1, borderStyle.dashed, "#f0f0f0") ]

            goToSourceButton "Go to source" (fun _ -> Browser.Dom.window.location.assign url)
            showSourceCodeButton "Show/hide code" (setCodeVisible) 
        }
        
        // Source code
        Html.div {
            style [
                style.padding 4 ]
           
            if isCodeVisible then
                Html.pre {
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
        let startIndex, endIndex = x.getOrDefault<int * int> "sourceRange" (0, 0)
        
        ExampleComponent
            (x.getOrDefault<string> "sourceUrl" "" |> fullExampleUrl)
            startIndex
            endIndex
            (x.getOrDefault<string> "name" "")
            x.Children
        
let example = ExampleBuilder()