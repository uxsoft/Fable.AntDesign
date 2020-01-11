namespace Fable.AntD

open Fable.Core
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Mentions =
       
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntMentionsPlacementOptions = Top | Bottom
    
    [<RequireQualifiedAccess>]
    type AntMentions =
        | Autofocus of bool
        | DefaultValue of string
        | FilterOption of (string -> obj -> bool)
        | NotFoundContent of ReactElement
        | Placement of AntMentionsPlacementOptions
        | Prefix of string array
        | Split of string
        | ValidateSearch of (string -> obj -> unit)
        | Value of string
        | OnChange of (string -> unit)
        | OnSelect of (obj -> string -> unit)
        | OnSearch of (string -> string -> unit)
        | OnFocus of (unit -> unit)
        | OnBlur of (unit -> unit)
        | GetPopupContainer of (unit -> ReactElement)
        static member Custom (key: string, value: obj): AntMentions = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMentions = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntMentionsOption =
        | Value of string
        static member Custom (key: string, value: obj): AntMentions = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntMentions = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antMentions (props: AntMentions list) (children: ReactElement list): ReactElement =
       ofImport "Mentions" "antd" (keyValueList CaseRules.LowerFirst props) children
    
    let inline antMentionsOption (props: AntMentionsOption list) (children: ReactElement list): ReactElement =
       ofImport "Mentions.Option" "antd" (keyValueList CaseRules.LowerFirst props) children