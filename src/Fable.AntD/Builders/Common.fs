module Fable.AntD.Builders

open Fable.Core
open Fable.React
open Fable.React.Props
open JsInterop

// Attributes: 
// obj list
// createObj (obj list)
// props @ [name ==> value]

// Children: 
// ReactElement seq
// ofImport "" "" attr children
        
type BuilderState = { Attributes: (string * obj) list; Children: ReactElement list }

type BaseBuilder() =
    member x.Zero() = { Attributes = []; Children = [] }
    member x.Delay(f) = f()

    member x.Yield(source: BuilderState, item: 'a) = { Attributes = []; Children = [] }
    member x.Yield(item: 'a) = { Attributes = []; Children = [] }
    member x.Combine(a, b) = { Attributes = []; Children = [] }

    [<CustomOperation("content2")>]
    member x.Content2(source: BuilderState, content: string) =
        source

type ButtonBuilder() =
    inherit BaseBuilder()
    member x.Run(source: BuilderState) = ofImport "Button" "antd" (createObj source.Attributes) source.Children

    [<CustomOperation("disabled")>]
    member x.Disabled(source: BuilderState, value: bool) =
        { source with Attributes = source.Attributes @ [ "disabled", value :> obj ] }

    [<CustomOperation("onClick")>]
    member x.OnClick(source: BuilderState, value: unit -> unit) =
        { source with Attributes = source.Attributes @ [ "onClick", value :> obj ] }

    

let button = ButtonBuilder()

let view = 
    button {
        button {
            str "asd"
        }  
        button {
            str "asd"
        }     
    }