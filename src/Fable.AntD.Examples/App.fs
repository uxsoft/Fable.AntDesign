module App

open Elmish
open Elmish.React
open Fable.AntD.Builders
open Fable.AntD.Builders.Ant
open Fable.AntD.Examples.Controls

// MODEL

type Model = int

type Msg =
    | Increment
    | Decrement

let init () : Model = 0

// UPDATE

let update (msg: Msg) (model: Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1

// VIEW (rendered with React)

let view (model: Model) dispatch =
    layout {
        sider {
            str "sider"
        }
        content {
            ButtonPage.view model
        }
    }

// App
Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
|> Program.withConsoleTrace
|> Program.run
