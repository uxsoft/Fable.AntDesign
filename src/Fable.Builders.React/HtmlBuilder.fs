module Fable.Builders.React.HtmlBuilder

open Browser.Types
open Fable.Builders.Common
open Feliz
open Fable.Core.JsInterop

type HtmlBuilder(tag: string) =
    inherit ReactBuilder()

    member _.Run(s: DSLElement) =
        Interop.reactApi.createElement(tag, (createObj s.Attributes), s.Children)
    
    [<CustomOperation("dangerouslySetInnerHTML")>]
    member inline _.dangerouslySetInnerHTML (x: DSLElement, value: string) = x.attr "dangerouslySetInnerHTML" {| __html = value |}

    [<CustomOperation("accesskey")>]
    member inline _.accesskey (x: DSLElement, v: 'v) = x.attr "accesskey" v

    [<CustomOperation("autocapitalize")>]
    member inline _.autocapitalize (x: DSLElement, v: 'v) = x.attr "autocapitalize" v

    [<CustomOperation("className")>]
    member inline _.className (x: DSLElement, v: 'v) = x.attr "className" v

    [<CustomOperation("contenteditable")>]
    member inline _.contenteditable (x: DSLElement, v: 'v) = x.attr "contenteditable" v

    [<CustomOperation("contextmenu")>]
    member inline _.contextmenu (x: DSLElement, v: 'v) = x.attr "contextmenu" v

    [<CustomOperation("data")>]
    member inline _.data (x: DSLElement, v: 'v) = x.attr "data" v

    [<CustomOperation("dir")>]
    member inline _.dir (x: DSLElement, v: 'v) = x.attr "dir" v

    [<CustomOperation("draggable")>]
    member inline _.draggable (x: DSLElement, v: 'v) = x.attr "draggable" v

    [<CustomOperation("hidden")>]
    member inline _.hidden (x: DSLElement, v: 'v) = x.attr "hidden" v

    [<CustomOperation("id")>]
    member inline _.id (x: DSLElement, v: 'v) = x.attr "id" v

    [<CustomOperation("itemprop")>]
    member inline _.itemprop (x: DSLElement, v: 'v) = x.attr "itemprop" v

    [<CustomOperation("lang")>]
    member inline _.lang (x: DSLElement, v: 'v) = x.attr "lang" v

    [<CustomOperation("slot")>]
    member inline _.slot (x: DSLElement, v: 'v) = x.attr "slot" v

    [<CustomOperation("spellcheck")>]
    member inline _.spellcheck (x: DSLElement, v: 'v) = x.attr "spellcheck" v

    [<CustomOperation("style")>]
    member inline _.style (x: DSLElement, v: 'v) = x.attr "style" v

    [<CustomOperation("tabindex")>]
    member inline _.tabindex (x: DSLElement, v: 'v) = x.attr "tabindex" v

    [<CustomOperation("title")>]
    member inline _.title (x: DSLElement, v: 'v) = x.attr "title" v

    [<CustomOperation("translate")>]
    member inline _.translate (x: DSLElement, v: 'v) = x.attr "translate" v

    [<CustomOperation("onCut")>]
    member inline _.onCut(x: DSLElement, v: ClipboardEvent -> unit) = x.attr "onCut" v
    
    [<CustomOperation("onPaste")>]
    member inline _.onPaste(x: DSLElement, v: ClipboardEvent -> unit) = x.attr "onPaste" v
    
    [<CustomOperation("onCompositionEnd")>]
    member inline _.onCompositionEnd(x: DSLElement, v: CompositionEvent -> unit) = x.attr "onCompositionEnd" v
    
    [<CustomOperation("onCompositionStart")>]
    member inline _.onCompositionStart(x: DSLElement, v: CompositionEvent -> unit) = x.attr "onCompositionStart" v
    
    [<CustomOperation("onCopy")>]
    member inline _.onCopy(x: DSLElement, v: ClipboardEvent -> unit) = x.attr "onCopy" v
    
    [<CustomOperation("onCompositionUpdate")>]
    member inline _.onCompositionUpdate(x: DSLElement, v: CompositionEvent -> unit) = x.attr "onCompositionUpdate" v
    
    [<CustomOperation("onFocus")>]
    member inline _.onFocus(x: DSLElement, v: FocusEvent -> unit) = x.attr "onFocus" v
    
    [<CustomOperation("onBlur")>]
    member inline _.onBlur(x: DSLElement, v: FocusEvent -> unit) = x.attr "onBlur" v
    
    [<CustomOperation("onChange")>]
    member inline _.onChange(x: DSLElement, v: Event -> unit) = x.attr "onChange" v
    
    [<CustomOperation("onInput")>]
    member inline _.onInput(x: DSLElement, v: Event -> unit) = x.attr "onInput" v
    
    [<CustomOperation("onSubmit")>]
    member inline _.onSubmit(x: DSLElement, v: Event -> unit) = x.attr "onSubmit" v
    
    [<CustomOperation("onReset")>]
    member inline _.onReset(x: DSLElement, v: Event -> unit) = x.attr "onReset" v
    
    [<CustomOperation("onLoad")>]
    member inline _.onLoad(x: DSLElement, v: Event -> unit) = x.attr "onLoad" v
    
    [<CustomOperation("onError")>]
    member inline _.onError(x: DSLElement, v: Event -> unit) = x.attr "onError" v
    
    [<CustomOperation("onKeyDown")>]
    member inline _.onKeyDown(x: DSLElement, v: KeyboardEvent -> unit) = x.attr "onKeyDown" v
    
    [<CustomOperation("onKeyPress")>]
    member inline _.onKeyPress(x: DSLElement, v: KeyboardEvent -> unit) = x.attr "onKeyPress" v
    
    [<CustomOperation("onKeyUp")>]
    member inline _.onKeyUp(x: DSLElement, v: KeyboardEvent -> unit) = x.attr "onKeyUp" v
    
    [<CustomOperation("onAbort")>]
    member inline _.onAbort(x: DSLElement, v: Event -> unit) = x.attr "onAbort" v
    
    [<CustomOperation("onCanPlay")>]
    member inline _.onCanPlay(x: DSLElement, v: Event -> unit) = x.attr "onCanPlay" v
    
    [<CustomOperation("onCanPlayThrough")>]
    member inline _.onCanPlayThrough(x: DSLElement, v: Event -> unit) = x.attr "onCanPlayThrough" v
    
    [<CustomOperation("onDurationChange")>]
    member inline _.onDurationChange(x: DSLElement, v: Event -> unit) = x.attr "onDurationChange" v
    
    [<CustomOperation("onEmptied")>]
    member inline _.onEmptied(x: DSLElement, v: Event -> unit) = x.attr "onEmptied" v
    
    [<CustomOperation("onEncrypted")>]
    member inline _.onEncrypted(x: DSLElement, v: Event -> unit) = x.attr "onEncrypted" v
    
    [<CustomOperation("onEnded")>]
    member inline _.onEnded(x: DSLElement, v: Event -> unit) = x.attr "onEnded" v
    
    [<CustomOperation("onLoadedData")>]
    member inline _.onLoadedData(x: DSLElement, v: Event -> unit) = x.attr "onLoadedData" v
    
    [<CustomOperation("onLoadedMetadata")>]
    member inline _.onLoadedMetadata(x: DSLElement, v: Event -> unit) = x.attr "onLoadedMetadata" v
    
    [<CustomOperation("onLoadStart")>]
    member inline _.onLoadStart(x: DSLElement, v: Event -> unit) = x.attr "onLoadStart" v
    
    [<CustomOperation("onPause")>]
    member inline _.onPause(x: DSLElement, v: Event -> unit) = x.attr "onPause" v
    
    [<CustomOperation("onPlay")>]
    member inline _.onPlay(x: DSLElement, v: Event -> unit) = x.attr "onPlay" v
    
    [<CustomOperation("onPlaying")>]
    member inline _.onPlaying(x: DSLElement, v: Event -> unit) = x.attr "onPlaying" v
    
    [<CustomOperation("onProgress")>]
    member inline _.onProgress(x: DSLElement, v: Event -> unit) = x.attr "onProgress" v
    
    [<CustomOperation("onRateChange")>]
    member inline _.onRateChange(x: DSLElement, v: Event -> unit) = x.attr "onRateChange" v
    
    [<CustomOperation("onSeeked")>]
    member inline _.onSeeked(x: DSLElement, v: Event -> unit) = x.attr "onSeeked" v
    
    [<CustomOperation("onSeeking")>]
    member inline _.onSeeking(x: DSLElement, v: Event -> unit) = x.attr "onSeeking" v
    
    [<CustomOperation("onStalled")>]
    member inline _.onStalled(x: DSLElement, v: Event -> unit) = x.attr "onStalled" v
    
    [<CustomOperation("onSuspend")>]
    member inline _.onSuspend(x: DSLElement, v: Event -> unit) = x.attr "onSuspend" v
    
    [<CustomOperation("onTimeUpdate")>]
    member inline _.onTimeUpdate(x: DSLElement, v: Event -> unit) = x.attr "onTimeUpdate" v
    
    [<CustomOperation("onVolumeChange")>]
    member inline _.onVolumeChange(x: DSLElement, v: Event -> unit) = x.attr "onVolumeChange" v
    
    [<CustomOperation("onWaiting")>]
    member inline _.onWaiting(x: DSLElement, v: Event -> unit) = x.attr "onWaiting" v
    
    [<CustomOperation("onClick")>]
    member inline _.onClick(x: DSLElement, v: MouseEvent -> unit) = x.attr "onClick" v
    
    [<CustomOperation("onContextMenu")>]
    member inline _.onContextMenu(x: DSLElement, v: MouseEvent -> unit) = x.attr "onContextMenu" v
    
    [<CustomOperation("onDoubleClick")>]
    member inline _.onDoubleClick(x: DSLElement, v: MouseEvent -> unit) = x.attr "onDoubleClick" v
    
    [<CustomOperation("onDrag")>]
    member inline _.onDrag(x: DSLElement, v: DragEvent -> unit) = x.attr "onDrag" v
    
    [<CustomOperation("onDragEnd")>]
    member inline _.onDragEnd(x: DSLElement, v: DragEvent -> unit) = x.attr "onDragEnd" v
    
    [<CustomOperation("onDragEnter")>]
    member inline _.onDragEnter(x: DSLElement, v: DragEvent -> unit) = x.attr "onDragEnter" v
    
    [<CustomOperation("onDragExit")>]
    member inline _.onDragExit(x: DSLElement, v: DragEvent -> unit) = x.attr "onDragExit" v
    
    [<CustomOperation("onDragLeave")>]
    member inline _.onDragLeave(x: DSLElement, v: DragEvent -> unit) = x.attr "onDragLeave" v
    
    [<CustomOperation("onDragOver")>]
    member inline _.onDragOver(x: DSLElement, v: DragEvent -> unit) = x.attr "onDragOver" v
    
    [<CustomOperation("onDragStart")>]
    member inline _.onDragStart(x: DSLElement, v: DragEvent -> unit) = x.attr "onDragStart" v
    
    [<CustomOperation("onDrop")>]
    member inline _.onDrop(x: DSLElement, v: DragEvent -> unit) = x.attr "onDrop" v
    
    [<CustomOperation("onMouseDown")>]
    member inline _.onMouseDown(x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseDown" v
    
    [<CustomOperation("onMouseEnter")>]
    member inline _.onMouseEnter(x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseEnter" v
    
    [<CustomOperation("onMouseLeave")>]
    member inline _.onMouseLeave(x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseLeave" v
    
    [<CustomOperation("onMouseMove")>]
    member inline _.onMouseMove(x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseMove" v
    
    [<CustomOperation("onMouseOut")>]
    member inline _.onMouseOut(x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseOut" v
    
    [<CustomOperation("onMouseOver")>]
    member inline _.onMouseOver(x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseOver" v
    
    [<CustomOperation("onMouseUp")>]
    member inline _.onMouseUp(x: DSLElement, v: MouseEvent -> unit) = x.attr "onMouseUp" v
    
    [<CustomOperation("onSelect")>]
    member inline _.onSelect(x: DSLElement, v: Event -> unit) = x.attr "onSelect" v
    
    [<CustomOperation("onTouchCancel")>]
    member inline _.onTouchCancel(x: DSLElement, v: TouchEvent -> unit) = x.attr "onTouchCancel" v
    
    [<CustomOperation("onTouchEnd")>]
    member inline _.onTouchEnd(x: DSLElement, v: TouchEvent -> unit) = x.attr "onTouchEnd" v
    
    [<CustomOperation("onTouchMove")>]
    member inline _.onTouchMove(x: DSLElement, v: TouchEvent -> unit) = x.attr "onTouchMove" v
    
    [<CustomOperation("onTouchStart")>]
    member inline _.onTouchStart(x: DSLElement, v: TouchEvent -> unit) = x.attr "onTouchStart" v
    
    [<CustomOperation("onScroll")>]
    member inline _.onScroll(x: DSLElement, v: UIEvent -> unit) = x.attr "onScroll" v
    
    [<CustomOperation("onWheel")>]
    member inline _.onWheel(x: DSLElement, v: WheelEvent -> unit) = x.attr "onWheel" v
    
    [<CustomOperation("onAnimationStart")>]
    member inline _.onAnimationStart(x: DSLElement, v: AnimationEvent -> unit) = x.attr "onAnimationStart" v
    
    [<CustomOperation("onAnimationEnd")>]
    member inline _.onAnimationEnd(x: DSLElement, v: AnimationEvent -> unit) = x.attr "onAnimationEnd" v
    
    [<CustomOperation("onAnimationIteration")>]
    member inline _.onAnimationIteration(x: DSLElement, v: AnimationEvent -> unit) = x.attr "onAnimationIteration" v
    
    [<CustomOperation("onTransitionEnd")>]
    member inline _.onTransitionEnd(x: DSLElement, v: TransitionEvent -> unit) = x.attr "onTransitionEnd" v
    