module Fable.AntDesign.Examples.Model

type Page =
    | SyntaxPage = -1
    | ButtonPage = 0
    | IconPage = 1
    | TypographyPage = 2
    | DividerPage = 3
    | GridPage = 4
    | LayoutPage = 5
    | StepsPage = 14
    | FormPage = 19
    | SelectPage = 25
    | ListPage = 42
    | CollapsePage = 37
    | TablePage = 45
    | TimelinePage = 47
    | NotificationPage = 55
    | ProgressPage = 57
    | ChartsPage = 10000

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
                Browser.Dom.console.log $"Logging in with {username}:{password}"
                do! Async.Sleep 2000
                dispatch EndLogin
            } |> Async.StartImmediate ]
    | EndLogin -> { model with IsLoggingIn = false }, []