module Fable.AntDesign.Composite

open Fable.AntDesign.Common
open Fable.AntDesign.Ant
open Fable.React.Props

type CommentActionBuilder() =
    inherit ReactBuilder()
    
    [<CustomOperation("title")>] member _.title(x: DSLElement, v: string) = x.attr "title" v
    [<CustomOperation("checked")>] member _.checked(x: DSLElement) = x.attr "checked" true
    [<CustomOperation("checkedIcon")>] member _.checkedIcon(x: DSLElement, v: string) = x.attr "checkedIcon" v
    [<CustomOperation("uncheckedIcon")>] member _.uncheckedIcon(x: DSLElement, v: string) = x.attr "uncheckedIcon" v
    
    member _.Run(x: DSLElement) =
        let title = x.getOrDefault "title" ""
        let checkedIcon = x.getOrDefault "checkedIcon" (span { () })
        let uncheckedIcon = x.getOrDefault "uncheckedIcon" (span { () })
        
        tooltip {
            style [
                
            ]
            key ""
            title ""
            span {
                () //onClick (fun _ -> ())
            }
        }
        
//    <Tooltip key="comment-basic-dislike" title="Dislike">
//      <span onClick={dislike}>
//        {React.createElement(action === 'disliked' ? DislikeFilled : DislikeOutlined)}
//        <span className="comment-action">{dislikes}</span>
//      </span>
//    </Tooltip>,
//.comment-action {
//  padding-left: 8px;
//  cursor: 'auto';
//}
//
//[class*='-col-rtl'] .comment-action {
//  padding-right: 8px;
//  padding-left: 0;
//}
let commentAction = CommentActionBuilder()

type IconButton() =
    inherit ReactBuilder()
        
    [<CustomOperation("icon")>] member _.icon(x: DSLElement, v: string) = x.attr "icon" v
    [<CustomOperation("onClick")>] member _.onClick(x: DSLElement, v: unit -> unit) = x.attr "onClick" v

    member _.Run(x: DSLElement) =
        span {
            ()
        }