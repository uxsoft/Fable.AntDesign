module Fable.AntDesign.Examples.Model

type Page =
    | ButtonPage = 0
    | IconPage = 1
    | TypographyPage = 2
    | DividerPage = 3
    | StepsPage = 14
    | FormPage = 19
    | ListPage = 42
    | NotificationPage = 55

type Model =
    { Page: Page
      IsLoggingIn: bool }

type Msg =
    | Navigate of Page
    | BeginLogin of string * string
    | EndLogin

let init () =
    { Page = Page.ButtonPage
      IsLoggingIn = false }, []
    
let update (msg: Msg) (model: Model) =
    match msg with
    | Navigate page -> { model with Page = page }, []
    | BeginLogin (username, password) ->
        { model with IsLoggingIn = true },
        [ fun dispatch ->
            async {
                do! Async.Sleep 2000
                dispatch EndLogin
            } ]
    | EndLogin -> { model with IsLoggingIn = false }, []