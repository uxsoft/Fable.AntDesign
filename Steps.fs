namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<AutoOpen>]
module Steps =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntStepsType = Default | Navigation
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntStepsOrientation = Horizontal | Vertical
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type AntStepsStatus = Process | Wait | Error | Finish
    
    [<RequireQualifiedAccess>]
    type AntSteps  =
        | ClassName of string
        | Type of AntStepsType
        | Current of int
        | Direction of AntStepsOrientation
        | LabelPlacement of AntStepsOrientation
        | ProgressDot of bool
        | Size of Size
        | Status of AntStepsStatus
        | Initial of int
        | OnChange of (int -> unit)
        static member Custom (key: string, value: obj): AntSteps = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntSteps = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntStepsItem  =
        | Description of ReactElement
        | Icon of ReactElement
        | Status of AntStepsStatus
        | Title of ReactElement
        | SubTitle of ReactElement
        | Disabled of bool
        
        static member Custom (key: string, value: obj): AntStepsItem = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntStepsItem = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    let inline antSteps (props: AntSteps list) (children: ReactElement list): ReactElement =
       ofImport "Steps" "antd" (keyValueList CaseRules.LowerFirst props) children

        
    let inline antStepsItem (props: AntStepsItem list) (children: ReactElement list): ReactElement =
       ofImport "Steps.Step" "antd" (keyValueList CaseRules.LowerFirst props) children
