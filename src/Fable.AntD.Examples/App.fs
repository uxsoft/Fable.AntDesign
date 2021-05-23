module App

open Elmish
open Elmish.React
open Fable.AntD.Builders
open Fable.AntD.Builders.Ant

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
            str (string model)
            
            button {
                str "1"
                attr "name" "plus"
                onClick (fun _ -> dispatch Increment)
                str "3"
                str "4"
                str "+"
                if true then disabled
                
                
            }
            icon icons.AimOutlined {
                () 
            }

            button {
                disabled
                str "-"
                onClick (fun _ -> dispatch Decrement)
            }
            
            text {
                copyableWith {
                    icon (str "S")
                    text "[copy]"
                }
                copyable
                str "Some text here"
            }
            divider { () }
        }
    }

//  div []
//      [ button [ OnClick (fun _ -> dispatch Increment) ] [ str "+sd" ]
//        div [] [ str (string model) ]
//        button [ OnClick (fun _ -> dispatch Decrement) ] [ str "-" ]
//
//      ]

// App
Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
|> Program.withConsoleTrace
|> Program.run
