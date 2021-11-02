module Fable.Builders.React.HtmlBuilder

open Browser.Types
open Fable.Builders.Common
open Feliz
open Fable.Core.JsInterop

type HtmlBuilder(tag: string) =
    inherit ReactBuilder()
    
    [<CustomOperation("dangerouslySetInnerHTML")>] member inline _.dangerouslySetInnerHTML (x: DSLElement, value: string) = x.attr "dangerouslySetInnerHTML" {| __html = value |}

    
    // Events
    [<CustomOperation("onAbort")>] member inline _.onAbort (x: DSLElement, handler: Event -> unit) = x.attr "onAbort" handler

    /// Fires when animation is aborted.
    [<CustomOperation("onAnimationCancel")>] member inline _.onAnimationCancel (x: DSLElement, handler: AnimationEvent -> unit) = x.attr "onAnimationCancel" handler

    /// Fires when animation ends.
    [<CustomOperation("onAnimationEnd")>] member inline _.onAnimationEnd (x: DSLElement, handler: AnimationEvent -> unit) = x.attr "onAnimationEnd" handler

    /// Fires when animation iterates.
    [<CustomOperation("onAnimationIteration")>] member inline _.onAnimationIteration (x: DSLElement, handler: AnimationEvent -> unit) = x.attr "onAnimationIteration" handler

    /// Fires when animation starts.
    [<CustomOperation("onAnimationStart")>] member inline _.onAnimationStart (x: DSLElement, handler: AnimationEvent -> unit) = x.attr "onAnimationStart" handler

    /// Fires the moment that the element loses focus.
    [<CustomOperation("onBlur")>] member inline _.onBlur (x: DSLElement, handler: FocusEvent -> unit) = x.attr "onBlur" handler

    /// Fires when a user dismisses the current open dialog
    [<CustomOperation("onCancel")>] member inline _.onCancel (x: DSLElement, handler: Event -> unit) = x.attr "onCancel" handler

    /// Fires when a file is ready to start playing (when it has buffered enough to begin).
    [<CustomOperation("onCanPlay")>] member inline _.onCanPlay (x: DSLElement, handler: Event -> unit) = x.attr "onCanPlay" handler

    /// Fires when a file can be played all the way to the end without pausing for buffering
    [<CustomOperation("onCanPlayThrough")>] member inline _.onCanPlayThrough (x: DSLElement, handler: Event -> unit) = x.attr "onCanPlayThrough" handler

    /// Fires the moment when the value of the element is changed
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, handler: Event -> unit) = x.attr "onChange" handler
    /// Same as `onChange` that takes an event as input but instead lets you deal with the selected file directly from the `input` element when it is defined as a checkbox with `prop.type'.file`.

    /// Same as `onChange` but let's you deal with the `checked` value that has changed from the `input` element directly instead of extracting it from the event arguments.
    [<CustomOperation("onCheckedChange")>] member inline _.onCheckedChange (x: DSLElement, handler: bool -> unit) = x.attr "checked" handler

    /// Fires on a mouse click on the element.
    [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onClick" handler

    /// Fires when composition ends.
    [<CustomOperation("onCompositionEnd")>] member inline _.onCompositionEnd (x: DSLElement, handler: CompositionEvent -> unit) = x.attr "onCompositionEnd" handler

    /// Fires when composition starts.
    [<CustomOperation("onCompositionStart")>] member inline _.onCompositionStart (x: DSLElement, handler: CompositionEvent -> unit) = x.attr "onCompositionStart" handler

    /// Fires when composition changes.
    [<CustomOperation("onCompositionUpdate")>] member inline _.onCompositionUpdate (x: DSLElement, handler: CompositionEvent -> unit) = x.attr "onCompositionUpdate" handler

    /// Fires when a context menu is triggered.
    [<CustomOperation("onContextMenu")>] member inline _.onContextMenu (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onContextMenu" handler

    /// Fires when a TextTrack has changed the currently displaying cues.
    [<CustomOperation("onCueChange")>] member inline _.onCueChange (x: DSLElement, handler: Event -> unit) = x.attr "onCueChange" handler

        /// Fires when the user copies the content of an element.
    [<CustomOperation("onCopy")>] member inline _.onCopy (x: DSLElement, handler: ClipboardEvent -> unit) = x.attr "onCopy" handler

    /// Fires when the user cuts the content of an element.
    [<CustomOperation("onCut")>] member inline _.onCut (x: DSLElement, handler: ClipboardEvent -> unit) = x.attr "onCut" handler

    /// Fires when a mouse is double clicked on the element.
    [<CustomOperation("onDoubleClick")>] member inline _.onDoubleClick (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onDoubleClick" handler

    /// Fires when an element is dragged.
    [<CustomOperation("onDrag")>] member inline _.onDrag (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDrag" handler

    /// Fires when the a drag operation has ended.
    [<CustomOperation("onDragEnd")>] member inline _.onDragEnd (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDragEnd" handler

    /// Fires when an element has been dragged to a valid drop target.
    [<CustomOperation("onDragEnter")>] member inline _.onDragEnter (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDragEnter" handler

    [<CustomOperation("onDragExit")>] member inline _.onDragExit (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDragExit" handler

    /// Fires when an element leaves a valid drop target.
    [<CustomOperation("onDragLeave")>] member inline _.onDragLeave (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDragLeave" handler

    /// Fires when an element is being dragged over a valid drop target.
    [<CustomOperation("onDragOver")>] member inline _.onDragOver (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDragOver" handler

    /// Fires when the a drag operation has begun.
    [<CustomOperation("onDragStart")>] member inline _.onDragStart (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDragStart" handler

    /// Fires when dragged element is being dropped.
    [<CustomOperation("onDrop")>] member inline _.onDrop (x: DSLElement, handler: DragEvent -> unit) = x.attr "onDrop" handler

    /// Fires when the length of the media changes.
    [<CustomOperation("onDurationChange")>] member inline _.onDurationChange (x: DSLElement, handler: Event -> unit) = x.attr "onDurationChange" handler

    /// Fires when something bad happens and the file is suddenly unavailable (like unexpectedly disconnects).
    [<CustomOperation("onEmptied")>] member inline _.onEmptied (x: DSLElement, handler: Event -> unit) = x.attr "onEmptied" handler

    [<CustomOperation("onEncrypted")>] member inline _.onEncrypted (x: DSLElement, handler: Event -> unit) = x.attr "onEncrypted" handler

    /// Fires when the media has reached the end (a useful event for messages like "thanks for listening").
    [<CustomOperation("onEnded")>] member inline _.onEnded (x: DSLElement, handler: Event -> unit) = x.attr "onEnded" handler

    /// Fires when an error occurs.
    [<CustomOperation("onError")>] member inline _.onError (x: DSLElement, handler: Event -> unit) = x.attr "onError" handler

    /// Fires when an error occurs.
    [<CustomOperation("onError")>] member inline _.onError (x: DSLElement, handler: UIEvent -> unit) = x.attr "onError" handler

    /// Fires the moment when the element gets focus.
    [<CustomOperation("onFocus")>] member inline _.onFocus (x: DSLElement, handler: FocusEvent -> unit) = x.attr "onFocus" handler

    /// Fires when an element captures a pointer.
    [<CustomOperation("onGotPointerCapture")>] member inline _.onGotPointerCapture (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onGotPointerCapture" handler

    /// Fires when an element gets user input.
    [<CustomOperation("onInput")>] member inline _.onInput (x: DSLElement, handler: Event -> unit) = x.attr "onInput" handler

    /// Fires when a submittable element has been checked for validaty and doesn't satisfy its constraints.
    [<CustomOperation("onInvalid")>] member inline _.onInvalid (x: DSLElement, handler: Event -> unit) = x.attr "onInvalid" handler

    /// Fires when a user presses a key.
    [<CustomOperation("onKeyDown")>] member inline _.onKeyDown (x: DSLElement, handler: KeyboardEvent -> unit) = x.attr "onKeyDown" handler

    /// Fires when a user presses a key.
    [<CustomOperation("onKeyPress")>] member inline _.onKeyPress (x: DSLElement, handler: KeyboardEvent -> unit) = x.attr "onKeyPress" handler

    /// Fires when a user releases a key.
    [<CustomOperation("onKeyUp")>] member inline _.onKeyUp (x: DSLElement, handler: KeyboardEvent -> unit) = x.attr "onKeyUp" handler

    /// Fires after the page is finished loading.
    [<CustomOperation("onLoad")>] member inline _.onLoad (x: DSLElement, handler: Event -> unit) = x.attr "onLoad" handler

    /// Fires when media data is loaded.
    [<CustomOperation("onLoadedData")>] member inline _.onLoadedData (x: DSLElement, handler: Event -> unit) = x.attr "onLoadedData" handler

    /// Fires when meta data (like dimensions and duration) are loaded.
    [<CustomOperation("onLoadedMetadata")>] member inline _.onLoadedMetadata (x: DSLElement, handler: Event -> unit) = x.attr "onLoadedMetadata" handler

    /// Fires when a request has completed, irrespective of its success.
    [<CustomOperation("onLoadEnd")>] member inline _.onLoadEnd (x: DSLElement, handler: Event -> unit) = x.attr "onLoadEnd" handler

    /// Fires when the file begins to load before anything is actually loaded.
    [<CustomOperation("onLoadStart")>] member inline _.onLoadStart (x: DSLElement, handler: Event -> unit) = x.attr "onLoadStart" handler

    /// Fires when a captured pointer is released.
    [<CustomOperation("onLostPointerCapture")>] member inline _.onLostPointerCapture (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onLostPointerCapture" handler

    /// Fires when a mouse button is pressed down on an element.
    [<CustomOperation("onMouseDown")>] member inline _.onMouseDown (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onMouseDown" handler

    /// Fires when a pointer enters an element.
    [<CustomOperation("onMouseEnter")>] member inline _.onMouseEnter (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onMouseEnter" handler

    /// Fires when a pointer leaves an element.
    [<CustomOperation("onMouseLeave")>] member inline _.onMouseLeave (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onMouseLeave" handler

    /// Fires when the mouse pointer is moving while it is over an element.
    [<CustomOperation("onMouseMove")>] member inline _.onMouseMove (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onMouseMove" handler

    /// Fires when the mouse pointer moves out of an element.
    [<CustomOperation("onMouseOut")>] member inline _.onMouseOut (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onMouseOut" handler

    /// Fires when the mouse pointer moves over an element.
    [<CustomOperation("onMouseOver")>] member inline _.onMouseOver (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onMouseOver" handler

    /// Fires when a mouse button is released while it is over an element.
    [<CustomOperation("onMouseUp")>] member inline _.onMouseUp (x: DSLElement, handler: MouseEvent -> unit) = x.attr "onMouseUp" handler

    /// Fires when the user pastes some content in an element.
    [<CustomOperation("onPaste")>] member inline _.onPaste (x: DSLElement, handler: ClipboardEvent -> unit) = x.attr "onPaste" handler

    /// Fires when the media is paused either by the user or programmatically.
    [<CustomOperation("onPause")>] member inline _.onPause (x: DSLElement, handler: Event -> unit) = x.attr "onPause" handler

    /// Fires when the media is ready to start playing.
    [<CustomOperation("onPlay")>] member inline _.onPlay (x: DSLElement, handler: Event -> unit) = x.attr "onPlay" handler

    /// Fires when the media actually has started playing
    [<CustomOperation("onPlaying")>] member inline _.onPlaying (x: DSLElement, handler: Event -> unit) = x.attr "onPlaying" handler

    /// Fires when there are no more pointer events.
    [<CustomOperation("onPointerCancel")>] member inline _.onPointerCancel (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerCancel" handler

    /// Fires when a pointer becomes active.
    [<CustomOperation("onPointerDown")>] member inline _.onPointerDown (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerDown" handler

    /// Fires when a pointer is moved into an elements boundaries or one of its descendants.
    [<CustomOperation("onPointerEnter")>] member inline _.onPointerEnter (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerEnter" handler

    /// Fires when a pointer is moved out of an elements boundaries.
    [<CustomOperation("onPointerLeave")>] member inline _.onPointerLeave (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerLeave" handler

    /// Fires when a pointer moves.
    [<CustomOperation("onPointerMove")>] member inline _.onPointerMove (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerMove" handler

    /// Fires when a pointer is no longer in an elements boundaries, such as moving it, or after a `pointerUp` or `pointerCancel` event.
    [<CustomOperation("onPointerOut")>] member inline _.onPointerOut (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerOut" handler

    /// Fires when a pointer is moved into an elements boundaries.
    [<CustomOperation("onPointerOver")>] member inline _.onPointerOver (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerOver" handler

    /// Fires when a pointer is no longer active.
    [<CustomOperation("onPointerUp")>] member inline _.onPointerUp (x: DSLElement, handler: PointerEvent -> unit) = x.attr "onPointerUp" handler

    /// Fires when the browser is in the process of getting the media data.
    [<CustomOperation("onProgress")>] member inline _.onProgress (x: DSLElement, handler: Event -> unit) = x.attr "onProgress" handler

    /// Fires when the playback rate changes (like when a user switches to a slow motion or fast forward mode).
    [<CustomOperation("onRateChange")>] member inline _.onRateChange (x: DSLElement, handler: Event -> unit) = x.attr "onRateChange" handler

    /// Fires when the Reset button in a form is clicked.
    [<CustomOperation("onReset")>] member inline _.onReset (x: DSLElement, handler: Event -> unit) = x.attr "onReset" handler

    /// Fires when the window has been resized.
    [<CustomOperation("onResize")>] member inline _.onResize (x: DSLElement, handler: UIEvent -> unit) = x.attr "onResize" handler

    /// Fires when an element's scrollbar is being scrolled.
    [<CustomOperation("onScroll")>] member inline _.onScroll (x: DSLElement, handler: Event -> unit) = x.attr "onScroll" handler

    /// Fires when the seeking attribute is set to false indicating that seeking has ended.
    [<CustomOperation("onSeeked")>] member inline _.onSeeked (x: DSLElement, handler: Event -> unit) = x.attr "onSeeked" handler

    /// Fires when the seeking attribute is set to true indicating that seeking is active.
    [<CustomOperation("onSeeking")>] member inline _.onSeeking (x: DSLElement, handler: Event -> unit) = x.attr "onSeeking" handler

    /// Fires after some text has been selected in an element.
    [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, handler: Event -> unit) = x.attr "onSelect" handler

    /// Fires after some text has been selected in the user interface.
    [<CustomOperation("onSelect")>] member inline _.onSelect (x: DSLElement, handler: UIEvent -> unit) = x.attr "onSelect" handler

    /// Fires when the browser is unable to fetch the media data for whatever reason.
    [<CustomOperation("onStalled")>] member inline _.onStalled (x: DSLElement, handler: Event -> unit) = x.attr "onStalled" handler

    /// Fires when fetching the media data is stopped before it is completely loaded for whatever reason.
    [<CustomOperation("onSuspend")>] member inline _.onSuspend (x: DSLElement, handler: Event -> unit) = x.attr "onSuspend" handler

    /// Fires when a form is submitted.
    [<CustomOperation("onSubmit")>] member inline _.onSubmit (x: DSLElement, handler: Event -> unit) = x.attr "onSubmit" handler

    /// Fires when the playing position has changed (like when the user fast forwards to a different point in the media).
    [<CustomOperation("onTimeUpdate")>] member inline _.onTimeUpdate (x: DSLElement, handler: Event -> unit) = x.attr "onTimeUpdate" handler

    [<CustomOperation("onTouchCancel")>] member inline _.onTouchCancel (x: DSLElement, handler: TouchEvent -> unit) = x.attr "onTouchCancel" handler

    [<CustomOperation("onTouchEnd")>] member inline _.onTouchEnd (x: DSLElement, handler: TouchEvent -> unit) = x.attr "onTouchEnd" handler

    [<CustomOperation("onTouchMove")>] member inline _.onTouchMove (x: DSLElement, handler: TouchEvent -> unit) = x.attr "onTouchMove" handler

    [<CustomOperation("onTouchStart")>] member inline _.onTouchStart (x: DSLElement, handler: TouchEvent -> unit) = x.attr "onTouchStart" handler

    [<CustomOperation("onTransitionEnd")>] member inline _.onTransitionEnd (x: DSLElement, handler: TransitionEvent -> unit) = x.attr "onTransitionEnd" handler

    /// Fires when the volume is changed which (includes setting the volume to "mute").
    [<CustomOperation("onVolumeChange")>] member inline _.onVolumeChange (x: DSLElement, handler: Event -> unit) = x.attr "onVolumeChange" handler

    /// Fires when the media has paused but is expected to resume (like when the media pauses to buffer more data).
    [<CustomOperation("onWaiting")>] member inline _.onWaiting (x: DSLElement, handler: Event -> unit) = x.attr "onWaiting" handler

    /// Fires when the mouse wheel rolls up or down over an element.
    [<CustomOperation("onWheel")>] member inline _.onWheel (x: DSLElement, handler: WheelEvent -> unit) = x.attr "onWheel" handler
    
    // Attributes
    [<CustomOperation("accept")>] member inline _.accept(x: DSLElement, v) = x.attr "accept" v
    [<CustomOperation("acceptCharset")>] member inline _.acceptCharset(x: DSLElement, v) = x.attr "acceptCharset" v
    [<CustomOperation("accessKey")>] member inline _.accessKey(x: DSLElement, v) = x.attr "accessKey" v
    [<CustomOperation("action")>] member inline _.action(x: DSLElement, v) = x.attr "action" v
    [<CustomOperation("allowFullScreen")>] member inline _.allowFullScreen(x: DSLElement, v) = x.attr "allowFullScreen" v
    [<CustomOperation("alt")>] member inline _.alt(x: DSLElement, v) = x.attr "alt" v
    [<CustomOperation("async")>] member inline _.async(x: DSLElement, v) = x.attr "async" v
    [<CustomOperation("autoComplete")>] member inline _.autoComplete(x: DSLElement, v) = x.attr "autoComplete" v
    [<CustomOperation("autoFocus")>] member inline _.autoFocus(x: DSLElement, v) = x.attr "autoFocus" v
    [<CustomOperation("autoPlay")>] member inline _.autoPlay(x: DSLElement, v) = x.attr "autoPlay" v
    [<CustomOperation("capture")>] member inline _.capture(x: DSLElement, v) = x.attr "capture" v
    [<CustomOperation("cellPadding")>] member inline _.cellPadding(x: DSLElement, v) = x.attr "cellPadding" v
    [<CustomOperation("cellSpacing")>] member inline _.cellSpacing(x: DSLElement, v) = x.attr "cellSpacing" v
    [<CustomOperation("challenge")>] member inline _.challenge(x: DSLElement, v) = x.attr "challenge" v
    [<CustomOperation("charSet")>] member inline _.charSet(x: DSLElement, v) = x.attr "charSet" v
    [<CustomOperation("checked")>] member inline _.checked'(x: DSLElement, v) = x.attr "checked" v
    [<CustomOperation("cite")>] member inline _.cite(x: DSLElement, v) = x.attr "cite" v
    [<CustomOperation("classID")>] member inline _.classID(x: DSLElement, v) = x.attr "classID" v
    // Common already has className
    //[<CustomOperation("className")>] member inline _.className(x: DSLElement, v) = x.attr "className" v
    [<CustomOperation("colSpan")>] member inline _.colSpan(x: DSLElement, v) = x.attr "colSpan" v
    [<CustomOperation("cols")>] member inline _.cols(x: DSLElement, v) = x.attr "cols" v
    [<CustomOperation("content")>] member inline _.content(x: DSLElement, v) = x.attr "content" v
    [<CustomOperation("contentEditable")>] member inline _.contentEditable(x: DSLElement, v) = x.attr "contentEditable" v
    [<CustomOperation("contextMenu")>] member inline _.contextMenu(x: DSLElement, v) = x.attr "contextMenu" v
    [<CustomOperation("controls")>] member inline _.controls(x: DSLElement, v) = x.attr "controls" v
    [<CustomOperation("controlsList")>] member inline _.controlsList(x: DSLElement, v) = x.attr "controlsList" v
    [<CustomOperation("coords")>] member inline _.coords(x: DSLElement, v) = x.attr "coords" v
    [<CustomOperation("crossOrigin")>] member inline _.crossOrigin(x: DSLElement, v) = x.attr "crossOrigin" v
    [<CustomOperation("data")>] member inline _.data(x: DSLElement, v) = x.attr "data" v
    [<CustomOperation("dateTime")>] member inline _.dateTime(x: DSLElement, v) = x.attr "dateTime" v
    [<CustomOperation("default")>] member inline _.default'(x: DSLElement, v) = x.attr "default" v
    [<CustomOperation("defer")>] member inline _.defer(x: DSLElement, v) = x.attr "defer" v
    [<CustomOperation("dir")>] member inline _.dir(x: DSLElement, v) = x.attr "dir" v
    [<CustomOperation("disabled")>] member inline _.disabled(x: DSLElement, v) = x.attr "disabled" v
    [<CustomOperation("download")>] member inline _.download(x: DSLElement, v) = x.attr "download" v
    [<CustomOperation("draggable")>] member inline _.draggable(x: DSLElement, v) = x.attr "draggable" v
    [<CustomOperation("encType")>] member inline _.encType(x: DSLElement, v) = x.attr "encType" v
    [<CustomOperation("form")>] member inline _.form(x: DSLElement, v) = x.attr "form" v
    [<CustomOperation("formAction")>] member inline _.formAction(x: DSLElement, v) = x.attr "formAction" v
    [<CustomOperation("formEncType")>] member inline _.formEncType(x: DSLElement, v) = x.attr "formEncType" v
    [<CustomOperation("formMethod")>] member inline _.formMethod(x: DSLElement, v) = x.attr "formMethod" v
    [<CustomOperation("formNoValidate")>] member inline _.formNoValidate(x: DSLElement, v) = x.attr "formNoValidate" v
    [<CustomOperation("formTarget")>] member inline _.formTarget(x: DSLElement, v) = x.attr "formTarget" v
    [<CustomOperation("frameBorder")>] member inline _.frameBorder(x: DSLElement, v) = x.attr "frameBorder" v
    [<CustomOperation("headers")>] member inline _.headers(x: DSLElement, v) = x.attr "headers" v
    [<CustomOperation("height")>] member inline _.height(x: DSLElement, v) = x.attr "height" v
    [<CustomOperation("hidden")>] member inline _.hidden(x: DSLElement, v) = x.attr "hidden" v
    [<CustomOperation("high")>] member inline _.high(x: DSLElement, v) = x.attr "high" v
    [<CustomOperation("href")>] member inline _.href(x: DSLElement, v) = x.attr "href" v
    [<CustomOperation("hrefLang")>] member inline _.hrefLang(x: DSLElement, v) = x.attr "hrefLang" v
    [<CustomOperation("htmlFor")>] member inline _.htmlFor(x: DSLElement, v) = x.attr "htmlFor" v
    [<CustomOperation("httpEquiv")>] member inline _.httpEquiv(x: DSLElement, v) = x.attr "httpEquiv" v
    [<CustomOperation("icon")>] member inline _.icon(x: DSLElement, v) = x.attr "icon" v
    [<CustomOperation("inputMode")>] member inline _.inputMode(x: DSLElement, v) = x.attr "inputMode" v
    [<CustomOperation("integrity")>] member inline _.integrity(x: DSLElement, v) = x.attr "integrity" v
    [<CustomOperation("is")>] member inline _.is(x: DSLElement, v) = x.attr "is" v
    [<CustomOperation("keyParams")>] member inline _.keyParams(x: DSLElement, v) = x.attr "keyParams" v
    [<CustomOperation("keyType")>] member inline _.keyType(x: DSLElement, v) = x.attr "keyType" v
    [<CustomOperation("kind")>] member inline _.kind(x: DSLElement, v) = x.attr "kind" v
    [<CustomOperation("label")>] member inline _.label(x: DSLElement, v) = x.attr "label" v
    [<CustomOperation("lang")>] member inline _.lang(x: DSLElement, v) = x.attr "lang" v
    [<CustomOperation("list")>] member inline _.list(x: DSLElement, v) = x.attr "list" v
    [<CustomOperation("loop")>] member inline _.loop(x: DSLElement, v) = x.attr "loop" v
    [<CustomOperation("low")>] member inline _.low(x: DSLElement, v) = x.attr "low" v
    [<CustomOperation("manifest")>] member inline _.manifest(x: DSLElement, v) = x.attr "manifest" v
    [<CustomOperation("marginHeight")>] member inline _.marginHeight(x: DSLElement, v) = x.attr "marginHeight" v
    [<CustomOperation("marginWidth")>] member inline _.marginWidth(x: DSLElement, v) = x.attr "marginWidth" v
    [<CustomOperation("max")>] member inline _.max(x: DSLElement, v) = x.attr "max" v
    [<CustomOperation("maxLength")>] member inline _.maxLength(x: DSLElement, v) = x.attr "maxLength" v
    [<CustomOperation("media")>] member inline _.media(x: DSLElement, v) = x.attr "media" v
    [<CustomOperation("mediaGroup")>] member inline _.mediaGroup(x: DSLElement, v) = x.attr "mediaGroup" v
    [<CustomOperation("method")>] member inline _.method(x: DSLElement, v) = x.attr "method" v
    [<CustomOperation("min")>] member inline _.min(x: DSLElement, v) = x.attr "min" v
    [<CustomOperation("minLength")>] member inline _.minLength(x: DSLElement, v) = x.attr "minLength" v
    [<CustomOperation("multiple")>] member inline _.multiple(x: DSLElement, v) = x.attr "multiple" v
    [<CustomOperation("muted")>] member inline _.muted(x: DSLElement, v) = x.attr "muted" v
    [<CustomOperation("name")>] member inline _.name(x: DSLElement, v) = x.attr "name" v
    [<CustomOperation("noValidate")>] member inline _.noValidate(x: DSLElement, v) = x.attr "noValidate" v
    [<CustomOperation("nonce")>] member inline _.nonce(x: DSLElement, v) = x.attr "nonce" v
    [<CustomOperation("open")>] member inline _.open'(x: DSLElement, v) = x.attr "open" v
    [<CustomOperation("optimum")>] member inline _.optimum(x: DSLElement, v) = x.attr "optimum" v
    [<CustomOperation("pattern")>] member inline _.pattern(x: DSLElement, v) = x.attr "pattern" v
    [<CustomOperation("placeholder")>] member inline _.placeholder(x: DSLElement, v) = x.attr "placeholder" v
    [<CustomOperation("poster")>] member inline _.poster(x: DSLElement, v) = x.attr "poster" v
    [<CustomOperation("preload")>] member inline _.preload(x: DSLElement, v) = x.attr "preload" v
    [<CustomOperation("profile")>] member inline _.profile(x: DSLElement, v) = x.attr "profile" v
    [<CustomOperation("radioGroup")>] member inline _.radioGroup(x: DSLElement, v) = x.attr "radioGroup" v
    [<CustomOperation("readOnly")>] member inline _.readOnly(x: DSLElement, v) = x.attr "readOnly" v
    [<CustomOperation("rel")>] member inline _.rel(x: DSLElement, v) = x.attr "rel" v
    [<CustomOperation("required")>] member inline _.required(x: DSLElement, v) = x.attr "required" v
    [<CustomOperation("reversed")>] member inline _.reversed(x: DSLElement, v) = x.attr "reversed" v
    [<CustomOperation("role")>] member inline _.role(x: DSLElement, v) = x.attr "role" v
    [<CustomOperation("rowSpan")>] member inline _.rowSpan(x: DSLElement, v) = x.attr "rowSpan" v
    [<CustomOperation("rows")>] member inline _.rows(x: DSLElement, v) = x.attr "rows" v
    [<CustomOperation("sandbox")>] member inline _.sandbox(x: DSLElement, v) = x.attr "sandbox" v
    [<CustomOperation("scope")>] member inline _.scope(x: DSLElement, v) = x.attr "scope" v
    [<CustomOperation("scoped")>] member inline _.scoped(x: DSLElement, v) = x.attr "scoped" v
    [<CustomOperation("scrolling")>] member inline _.scrolling(x: DSLElement, v) = x.attr "scrolling" v
    [<CustomOperation("seamless")>] member inline _.seamless(x: DSLElement, v) = x.attr "seamless" v
    [<CustomOperation("selected")>] member inline _.selected(x: DSLElement, v) = x.attr "selected" v
    [<CustomOperation("shape")>] member inline _.shape(x: DSLElement, v) = x.attr "shape" v
    [<CustomOperation("size")>] member inline _.size(x: DSLElement, v) = x.attr "size" v
    [<CustomOperation("sizes")>] member inline _.sizes(x: DSLElement, v) = x.attr "sizes" v
    [<CustomOperation("span")>] member inline _.span(x: DSLElement, v) = x.attr "span" v
    [<CustomOperation("spellCheck")>] member inline _.spellCheck(x: DSLElement, v) = x.attr "spellCheck" v
    [<CustomOperation("src")>] member inline _.src(x: DSLElement, v: string) = x.attr "src" v
    [<CustomOperation("srcDoc")>] member inline _.srcDoc(x: DSLElement, v) = x.attr "srcDoc" v
    [<CustomOperation("srcLang")>] member inline _.srcLang(x: DSLElement, v) = x.attr "srcLang" v
    [<CustomOperation("srcSet")>] member inline _.srcSet(x: DSLElement, v) = x.attr "srcSet" v
    [<CustomOperation("start")>] member inline _.start(x: DSLElement, v) = x.attr "start" v
    [<CustomOperation("step")>] member inline _.step(x: DSLElement, v) = x.attr "step" v
    [<CustomOperation("summary")>] member inline _.summary(x: DSLElement, v) = x.attr "summary" v
    [<CustomOperation("tabIndex")>] member inline _.tabIndex(x: DSLElement, v) = x.attr "tabIndex" v
    [<CustomOperation("target")>] member inline _.target(x: DSLElement, v) = x.attr "target" v
    [<CustomOperation("title")>] member inline _.title(x: DSLElement, v) = x.attr "title" v
    [<CustomOperation("type")>] member inline _.type'(x: DSLElement, v) = x.attr "type" v
    [<CustomOperation("useMap")>] member inline _.useMap(x: DSLElement, v) = x.attr "useMap" v
    [<CustomOperation("value")>] member inline _.value(x: DSLElement, v) = x.attr "value" v
    [<CustomOperation("width")>] member inline _.width(x: DSLElement, v) = x.attr "width" v
    [<CustomOperation("wmode")>] member inline _.wmode(x: DSLElement, v) = x.attr "wmode" v
    [<CustomOperation("wrap")>] member inline _.wrap(x: DSLElement, v) = x.attr "wrap" v
    
    
    member _.Run(s: DSLElement) =
        Interop.reactApi.createElement(tag, (createObj s.Attributes), s.Children)
