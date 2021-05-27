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
    | BeginLogin
    | EndLogin

let init () : Model =
    { Page = Page.ButtonPage
      IsLoggingIn = false }
    
let update (msg: Msg) (model: Model) =
    match msg with
    | Navigate page -> { model with Page = page }
    | BeginLogin -> { model with IsLoggingIn = true }
    | EndLogin -> { model with IsLoggingIn = false }