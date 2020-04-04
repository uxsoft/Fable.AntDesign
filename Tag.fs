namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Tag =
    
    [<RequireQualifiedAccess>]
    type AntTag =
        | AfterClose of (unit -> unit)
        | Closeable of bool
        | Color of string
        | OnClose of (obj -> unit)
        | Visible of bool
        static member Custom (key: string, value: obj): AntTag = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTag = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntCheckableTag =
        | AfterClose of (unit -> unit)
        | Closeable of bool
        | Color of string
        | OnClose of (obj -> unit)
        | Visible of bool
        | Checked of bool
        | OnChange of (bool -> unit)
        static member Custom (key: string, value: obj): AntCheckableTag = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntCheckableTag = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antTag (props: AntTag list) (children: ReactElement list): ReactElement =
       ofImport "Tag" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antCheckableTag (props: AntCheckableTag list) (children: ReactElement list): ReactElement =
       ofImport "Tag.CheckableTag" "antd" (keyValueList CaseRules.LowerFirst props) children
