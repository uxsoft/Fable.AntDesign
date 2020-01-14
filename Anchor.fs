namespace Fable.AntD

open Browser
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Anchor =
    [<RequireQualifiedAccess>]
    type AntAnchor  =
        | Affix of bool
        | Bounds of int
        | GetContainer of (unit -> HTMLElement)
        | OffsetBottom of int
        | OffsetTop of int
        | ShowInkInFixed of bool
        | OnClick of (Event -> obj -> unit)
        | GetCurrentAnchor of (unit -> string)
        | TargetOffset of int
        | OnChange of (string -> unit)
        static member Custom (key: string, value: obj): AntAnchor = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntAnchor = unbox ("style", keyValueList CaseRules.LowerFirst css)
       
    [<RequireQualifiedAccess>]
    type AntAnchorLink  =
        | Href of string
        | Title of ReactElement
        | Target of string
        static member Custom (key: string, value: obj): AntAnchorLink = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntAnchorLink = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antAnchor (props: AntAnchor list) (children: ReactElement list): ReactElement =
       ofImport "Anchor" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antAnchorLink (props: AntAnchorLink list) (children: ReactElement list): ReactElement =
       ofImport "Anchor.Link" "antd" (keyValueList CaseRules.LowerFirst props) children
    