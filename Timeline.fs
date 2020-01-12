namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Timeline =
    
    [<StringEnum; RequireQualifiedAccess>] type AntTimelineMode  = Left | Alternate | Right

    [<StringEnum; RequireQualifiedAccess>] type AntTimelineItemPosition  = Left | Right
    
    [<RequireQualifiedAccess>]
    type AntTimeline  =
        | Pending of bool
        | PendingDot of ReactElement
        | Reverse of bool
        | Mode of AntTimelineMode 
        static member Custom (key: string, value: obj): AntTimeline = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTimeline = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntTimelineItem  =
        | Color of string
        | Dot of ReactElement
        | Position of AntTimelineItemPosition
        static member Custom (key: string, value: obj): AntTimelineItem = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTimelineItem = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antTimeline (props: AntTimeline list) (children: ReactElement list): ReactElement =
       ofImport "Timeline" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline antTimelineItem (props: AntTimelineItem list) (children: ReactElement list): ReactElement =
       ofImport "Timeline.Item" "antd" (keyValueList CaseRules.LowerFirst props) children
    