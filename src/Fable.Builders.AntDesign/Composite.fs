namespace Fable.Builders.AntDesign

open Fable.Builders.Common
open Fable.Builders.AntDesign.Ant
open Fable.React.Props
open Feliz

[<AutoOpen>]
module Composite =

    type CommentActionBuilder() =
        inherit ReactBuilder()
        
        [<CustomOperation("title")>] member inline _.title(x: DSLElement, v: string) = x.attr "title" v
        [<CustomOperation("isChecked")>] member inline _.Checked(x: DSLElement, v: bool) = x.attr "isChecked" v
        [<CustomOperation("checkedIcon")>] member inline _.checkedIcon(x: DSLElement, v: string) = x.attr "checkedIcon" v
        [<CustomOperation("uncheckedIcon")>] member inline _.uncheckedIcon(x: DSLElement, v: string) = x.attr "uncheckedIcon" v
        
        member _.Run(x: DSLElement, v: bool) =
            let title = x.getOrDefault "title" ""
            let checkedIcon = x.getOrDefault "checkedIcon" (Html.none)
            let uncheckedIcon = x.getOrDefault "uncheckedIcon" (Html.none)
            
            Tooltip {
                style [
                    
                ]
                key ""
                title (str "")
                Html.span ""
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
    let CommentAction = CommentActionBuilder()
    
    type IconButton() =
        inherit ReactBuilder()
            
        [<CustomOperation("icon")>] member inline _.icon(x: DSLElement, v: string) = x.attr "icon" v
        [<CustomOperation("onClick")>] member inline _.onClick(x: DSLElement, v: unit -> unit) = x.attr "onClick" v
    
        member _.Run(x: DSLElement, v: bool) =
            Html.span ""