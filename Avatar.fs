namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Avatar =
        
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AvatarShape = Circle | Square
    
    [<RequireQualifiedAccess>]
    type AntAvatar =
        | Icon of U2<string, ReactElement>
        | Shape of AvatarShape
        | Size of Size
        | Src of string
        | SrcSet of string
        | Alt of string
        | OnError of (unit -> bool)
        static member Custom (key: string, value: obj): AntAvatar = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntAvatar = unbox ("style", keyValueList CaseRules.LowerFirst css)

    let inline antAvatar (props: AntAvatar list) (children: ReactElement list): ReactElement =
       ofImport "Avatar" "antd" (keyValueList CaseRules.LowerFirst props) children