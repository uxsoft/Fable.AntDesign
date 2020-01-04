namespace Fable.AntD

open Fable.Core
    
[<AutoOpen>]
module Common =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type Size = Large | Default | Small
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type Theme = Dark | Light
