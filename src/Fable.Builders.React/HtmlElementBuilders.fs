module Fable.Builders.React.HtmlElementBuilders

open Fable.Builders.Common
open Fable.Builders.React.HtmlBuilder

type baseBuilder() =
    inherit HtmlBuilder("base")

    [<CustomOperation("href")>]
    member inline _.href (x: DSLElement, v: 'v) = x.attr "href" v

    [<CustomOperation("target")>]
    member inline _.target (x: DSLElement, v: 'v) = x.attr "target" v

type linkBuilder() =
    inherit HtmlBuilder("link")

    [<CustomOperation("crossorigin")>]
    member inline _.crossorigin (x: DSLElement, v: 'v) = x.attr "crossorigin" v

    [<CustomOperation("href")>]
    member inline _.href (x: DSLElement, v: 'v) = x.attr "href" v

    [<CustomOperation("hreflang")>]
    member inline _.hreflang (x: DSLElement, v: 'v) = x.attr "hreflang" v

    [<CustomOperation("importance")>]
    member inline _.importance (x: DSLElement, v: 'v) = x.attr "importance" v

    [<CustomOperation("integrity")>]
    member inline _.integrity (x: DSLElement, v: 'v) = x.attr "integrity" v

    [<CustomOperation("media")>]
    member inline _.media (x: DSLElement, v: 'v) = x.attr "media" v

    [<CustomOperation("referrerpolicy")>]
    member inline _.referrerpolicy (x: DSLElement, v: 'v) = x.attr "referrerpolicy" v

    [<CustomOperation("rel")>]
    member inline _.rel (x: DSLElement, v: 'v) = x.attr "rel" v

    [<CustomOperation("sizes")>]
    member inline _.sizes (x: DSLElement, v: 'v) = x.attr "sizes" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

type metaBuilder() =
    inherit HtmlBuilder("meta")

    [<CustomOperation("charset")>]
    member inline _.charset (x: DSLElement, v: 'v) = x.attr "charset" v

    [<CustomOperation("content")>]
    member inline _.content (x: DSLElement, v: 'v) = x.attr "content" v

    [<CustomOperation("httpEquiv")>]
    member inline _.httpEquiv (x: DSLElement, v: 'v) = x.attr "http-equiv" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

type styleBuilder() =
    inherit HtmlBuilder("style")

    [<CustomOperation("media")>]
    member inline _.media (x: DSLElement, v: 'v) = x.attr "media" v

    [<CustomOperation("scoped")>]
    member inline _.scoped (x: DSLElement, v: 'v) = x.attr "scoped" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

type bodyBuilder() =
    inherit HtmlBuilder("body")

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

type blockquoteBuilder() =
    inherit HtmlBuilder("blockquote")

    [<CustomOperation("cite")>]
    member inline _.cite (x: DSLElement, v: 'v) = x.attr "cite" v

type divBuilder() =
    inherit HtmlBuilder("div")

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type hrBuilder() =
    inherit HtmlBuilder("hr")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("color")>]
    member inline _.color (x: DSLElement, v: 'v) = x.attr "color" v

type liBuilder() =
    inherit HtmlBuilder("li")

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

type olBuilder() =
    inherit HtmlBuilder("ol")

    [<CustomOperation("reversed")>]
    member inline _.reversed (x: DSLElement, v: 'v) = x.attr "reversed" v

    [<CustomOperation("start")>]
    member inline _.start (x: DSLElement, v: 'v) = x.attr "start" v

type aBuilder() =
    inherit HtmlBuilder("a")

    [<CustomOperation("download")>]
    member inline _.download (x: DSLElement, v: 'v) = x.attr "download" v

    [<CustomOperation("href")>]
    member inline _.href (x: DSLElement, v: 'v) = x.attr "href" v

    [<CustomOperation("hreflang")>]
    member inline _.hreflang (x: DSLElement, v: 'v) = x.attr "hreflang" v

    [<CustomOperation("media")>]
    member inline _.media (x: DSLElement, v: 'v) = x.attr "media" v

    [<CustomOperation("ping")>]
    member inline _.ping (x: DSLElement, v: 'v) = x.attr "ping" v

    [<CustomOperation("referrerpolicy")>]
    member inline _.referrerpolicy (x: DSLElement, v: 'v) = x.attr "referrerpolicy" v

    [<CustomOperation("rel")>]
    member inline _.rel (x: DSLElement, v: 'v) = x.attr "rel" v

    [<CustomOperation("shape")>]
    member inline _.shape (x: DSLElement, v: 'v) = x.attr "shape" v

    [<CustomOperation("target")>]
    member inline _.target (x: DSLElement, v: 'v) = x.attr "target" v

type codeBuilder() =
    inherit HtmlBuilder("code")

    [<CustomOperation("code")>]
    member inline _.code (x: DSLElement, v: 'v) = x.attr "code" v

type dataBuilder() =
    inherit HtmlBuilder("data")

    [<CustomOperation("data")>]
    member inline _.data (x: DSLElement, v: 'v) = x.attr "data" v

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

type qBuilder() =
    inherit HtmlBuilder("q")

    [<CustomOperation("cite")>]
    member inline _.cite (x: DSLElement, v: 'v) = x.attr "cite" v

type timeBuilder() =
    inherit HtmlBuilder("time")

    [<CustomOperation("datetime")>]
    member inline _.datetime (x: DSLElement, v: 'v) = x.attr "datetime" v

type areaBuilder() =
    inherit HtmlBuilder("area")

    [<CustomOperation("alt")>]
    member inline _.alt (x: DSLElement, v: 'v) = x.attr "alt" v

    [<CustomOperation("coords")>]
    member inline _.coords (x: DSLElement, v: 'v) = x.attr "coords" v

    [<CustomOperation("download")>]
    member inline _.download (x: DSLElement, v: 'v) = x.attr "download" v

    [<CustomOperation("href")>]
    member inline _.href (x: DSLElement, v: 'v) = x.attr "href" v

    [<CustomOperation("hreflang")>]
    member inline _.hreflang (x: DSLElement, v: 'v) = x.attr "hreflang" v

    [<CustomOperation("media")>]
    member inline _.media (x: DSLElement, v: 'v) = x.attr "media" v

    [<CustomOperation("ping")>]
    member inline _.ping (x: DSLElement, v: 'v) = x.attr "ping" v

    [<CustomOperation("referrerpolicy")>]
    member inline _.referrerpolicy (x: DSLElement, v: 'v) = x.attr "referrerpolicy" v

    [<CustomOperation("rel")>]
    member inline _.rel (x: DSLElement, v: 'v) = x.attr "rel" v

    [<CustomOperation("shape")>]
    member inline _.shape (x: DSLElement, v: 'v) = x.attr "shape" v

    [<CustomOperation("target")>]
    member inline _.target (x: DSLElement, v: 'v) = x.attr "target" v

type audioBuilder() =
    inherit HtmlBuilder("audio")

    [<CustomOperation("autoplay")>]
    member inline _.autoplay (x: DSLElement, v: 'v) = x.attr "autoplay" v

    [<CustomOperation("buffered")>]
    member inline _.buffered (x: DSLElement, v: 'v) = x.attr "buffered" v

    [<CustomOperation("controls")>]
    member inline _.controls (x: DSLElement, v: 'v) = x.attr "controls" v

    [<CustomOperation("crossorigin")>]
    member inline _.crossorigin (x: DSLElement, v: 'v) = x.attr "crossorigin" v

    [<CustomOperation("loop")>]
    member inline _.loop (x: DSLElement, v: 'v) = x.attr "loop" v

    [<CustomOperation("muted")>]
    member inline _.muted (x: DSLElement, v: 'v) = x.attr "muted" v

    [<CustomOperation("preload")>]
    member inline _.preload (x: DSLElement, v: 'v) = x.attr "preload" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

type imgBuilder() =
    inherit HtmlBuilder("img")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("alt")>]
    member inline _.alt (x: DSLElement, v: 'v) = x.attr "alt" v

    [<CustomOperation("border")>]
    member inline _.border (x: DSLElement, v: 'v) = x.attr "border" v

    [<CustomOperation("crossorigin")>]
    member inline _.crossorigin (x: DSLElement, v: 'v) = x.attr "crossorigin" v

    [<CustomOperation("decoding")>]
    member inline _.decoding (x: DSLElement, v: 'v) = x.attr "decoding" v

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("importance")>]
    member inline _.importance (x: DSLElement, v: 'v) = x.attr "importance" v

    [<CustomOperation("intrinsicsize")>]
    member inline _.intrinsicsize (x: DSLElement, v: 'v) = x.attr "intrinsicsize" v

    [<CustomOperation("ismap")>]
    member inline _.ismap (x: DSLElement, v: 'v) = x.attr "ismap" v

    [<CustomOperation("loading")>]
    member inline _.loading (x: DSLElement, v: 'v) = x.attr "loading" v

    [<CustomOperation("referrerpolicy")>]
    member inline _.referrerpolicy (x: DSLElement, v: 'v) = x.attr "referrerpolicy" v

    [<CustomOperation("sizes")>]
    member inline _.sizes (x: DSLElement, v: 'v) = x.attr "sizes" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("srcset")>]
    member inline _.srcset (x: DSLElement, v: 'v) = x.attr "srcset" v

    [<CustomOperation("usemap")>]
    member inline _.usemap (x: DSLElement, v: 'v) = x.attr "usemap" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type mapBuilder() =
    inherit HtmlBuilder("map")

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

type trackBuilder() =
    inherit HtmlBuilder("track")

    [<CustomOperation("default'")>]
    member inline _.default' (x: DSLElement, v: 'v) = x.attr "default" v

    [<CustomOperation("kind")>]
    member inline _.kind (x: DSLElement, v: 'v) = x.attr "kind" v

    [<CustomOperation("label")>]
    member inline _.label (x: DSLElement, v: 'v) = x.attr "label" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("srclang")>]
    member inline _.srclang (x: DSLElement, v: 'v) = x.attr "srclang" v

type videoBuilder() =
    inherit HtmlBuilder("video")

    [<CustomOperation("autoplay")>]
    member inline _.autoplay (x: DSLElement, v: 'v) = x.attr "autoplay" v

    [<CustomOperation("buffered")>]
    member inline _.buffered (x: DSLElement, v: 'v) = x.attr "buffered" v

    [<CustomOperation("controls")>]
    member inline _.controls (x: DSLElement, v: 'v) = x.attr "controls" v

    [<CustomOperation("crossorigin")>]
    member inline _.crossorigin (x: DSLElement, v: 'v) = x.attr "crossorigin" v

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("loop")>]
    member inline _.loop (x: DSLElement, v: 'v) = x.attr "loop" v

    [<CustomOperation("muted")>]
    member inline _.muted (x: DSLElement, v: 'v) = x.attr "muted" v

    [<CustomOperation("poster")>]
    member inline _.poster (x: DSLElement, v: 'v) = x.attr "poster" v

    [<CustomOperation("preload")>]
    member inline _.preload (x: DSLElement, v: 'v) = x.attr "preload" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type embedBuilder() =
    inherit HtmlBuilder("embed")

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type iframeBuilder() =
    inherit HtmlBuilder("iframe")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("allow")>]
    member inline _.allow (x: DSLElement, v: 'v) = x.attr "allow" v

    [<CustomOperation("csp")>]
    member inline _.csp (x: DSLElement, v: 'v) = x.attr "csp" v

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("importance")>]
    member inline _.importance (x: DSLElement, v: 'v) = x.attr "importance" v

    [<CustomOperation("loading")>]
    member inline _.loading (x: DSLElement, v: 'v) = x.attr "loading" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("referrerpolicy")>]
    member inline _.referrerpolicy (x: DSLElement, v: 'v) = x.attr "referrerpolicy" v

    [<CustomOperation("sandbox")>]
    member inline _.sandbox (x: DSLElement, v: 'v) = x.attr "sandbox" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("srcdoc")>]
    member inline _.srcdoc (x: DSLElement, v: 'v) = x.attr "srcdoc" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type objectBuilder() =
    inherit HtmlBuilder("object")

    [<CustomOperation("border")>]
    member inline _.border (x: DSLElement, v: 'v) = x.attr "border" v

    [<CustomOperation("data")>]
    member inline _.data (x: DSLElement, v: 'v) = x.attr "data" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

    [<CustomOperation("usemap")>]
    member inline _.usemap (x: DSLElement, v: 'v) = x.attr "usemap" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type paramBuilder() =
    inherit HtmlBuilder("param")

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

type sourceBuilder() =
    inherit HtmlBuilder("source")

    [<CustomOperation("media")>]
    member inline _.media (x: DSLElement, v: 'v) = x.attr "media" v

    [<CustomOperation("sizes")>]
    member inline _.sizes (x: DSLElement, v: 'v) = x.attr "sizes" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("srcset")>]
    member inline _.srcset (x: DSLElement, v: 'v) = x.attr "srcset" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

type canvasBuilder() =
    inherit HtmlBuilder("canvas")

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type scriptBuilder() =
    inherit HtmlBuilder("script")

    [<CustomOperation("async")>]
    member inline _.async (x: DSLElement, v: 'v) = x.attr "async" v

    [<CustomOperation("charset")>]
    member inline _.charset (x: DSLElement, v: 'v) = x.attr "charset" v

    [<CustomOperation("crossorigin")>]
    member inline _.crossorigin (x: DSLElement, v: 'v) = x.attr "crossorigin" v

    [<CustomOperation("defer")>]
    member inline _.defer (x: DSLElement, v: 'v) = x.attr "defer" v

    [<CustomOperation("importance")>]
    member inline _.importance (x: DSLElement, v: 'v) = x.attr "importance" v

    [<CustomOperation("integrity")>]
    member inline _.integrity (x: DSLElement, v: 'v) = x.attr "integrity" v

    [<CustomOperation("language")>]
    member inline _.language (x: DSLElement, v: 'v) = x.attr "language" v

    [<CustomOperation("referrerpolicy")>]
    member inline _.referrerpolicy (x: DSLElement, v: 'v) = x.attr "referrerpolicy" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

type delBuilder() =
    inherit HtmlBuilder("del")

    [<CustomOperation("cite")>]
    member inline _.cite (x: DSLElement, v: 'v) = x.attr "cite" v

    [<CustomOperation("datetime")>]
    member inline _.datetime (x: DSLElement, v: 'v) = x.attr "datetime" v

type insBuilder() =
    inherit HtmlBuilder("ins")

    [<CustomOperation("cite")>]
    member inline _.cite (x: DSLElement, v: 'v) = x.attr "cite" v

    [<CustomOperation("datetime")>]
    member inline _.datetime (x: DSLElement, v: 'v) = x.attr "datetime" v

type captionBuilder() =
    inherit HtmlBuilder("caption")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

type colBuilder() =
    inherit HtmlBuilder("col")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

    [<CustomOperation("span")>]
    member inline _.span (x: DSLElement, v: 'v) = x.attr "span" v

type colgroupBuilder() =
    inherit HtmlBuilder("colgroup")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

    [<CustomOperation("span")>]
    member inline _.span (x: DSLElement, v: 'v) = x.attr "span" v

type tableBuilder() =
    inherit HtmlBuilder("table")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

    [<CustomOperation("border")>]
    member inline _.border (x: DSLElement, v: 'v) = x.attr "border" v

    [<CustomOperation("summary")>]
    member inline _.summary (x: DSLElement, v: 'v) = x.attr "summary" v

type tbodyBuilder() =
    inherit HtmlBuilder("tbody")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

type tdBuilder() =
    inherit HtmlBuilder("td")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

    [<CustomOperation("colspan")>]
    member inline _.colspan (x: DSLElement, v: 'v) = x.attr "colspan" v

    [<CustomOperation("headers")>]
    member inline _.headers (x: DSLElement, v: 'v) = x.attr "headers" v

    [<CustomOperation("rowspan")>]
    member inline _.rowspan (x: DSLElement, v: 'v) = x.attr "rowspan" v

type tfootBuilder() =
    inherit HtmlBuilder("tfoot")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

type thBuilder() =
    inherit HtmlBuilder("th")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

    [<CustomOperation("colspan")>]
    member inline _.colspan (x: DSLElement, v: 'v) = x.attr "colspan" v

    [<CustomOperation("headers")>]
    member inline _.headers (x: DSLElement, v: 'v) = x.attr "headers" v

    [<CustomOperation("rowspan")>]
    member inline _.rowspan (x: DSLElement, v: 'v) = x.attr "rowspan" v

    [<CustomOperation("scope")>]
    member inline _.scope (x: DSLElement, v: 'v) = x.attr "scope" v

type theadBuilder() =
    inherit HtmlBuilder("thead")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

type trBuilder() =
    inherit HtmlBuilder("tr")

    [<CustomOperation("align")>]
    member inline _.align (x: DSLElement, v: 'v) = x.attr "align" v

    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor (x: DSLElement, v: 'v) = x.attr "bgcolor" v

type buttonBuilder() =
    inherit HtmlBuilder("button")

    [<CustomOperation("autofocus")>]
    member inline _.autofocus (x: DSLElement, v: 'v) = x.attr "autofocus" v

    [<CustomOperation("disabled")>]
    member inline _.disabled (x: DSLElement, v: 'v) = x.attr "disabled" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("formaction")>]
    member inline _.formaction (x: DSLElement, v: 'v) = x.attr "formaction" v

    [<CustomOperation("formenctype")>]
    member inline _.formenctype (x: DSLElement, v: 'v) = x.attr "formenctype" v

    [<CustomOperation("formmethod")>]
    member inline _.formmethod (x: DSLElement, v: 'v) = x.attr "formmethod" v

    [<CustomOperation("formnovalidate")>]
    member inline _.formnovalidate (x: DSLElement, v: 'v) = x.attr "formnovalidate" v

    [<CustomOperation("formtarget")>]
    member inline _.formtarget (x: DSLElement, v: 'v) = x.attr "formtarget" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

type fieldsetBuilder() =
    inherit HtmlBuilder("fieldset")

    [<CustomOperation("disabled")>]
    member inline _.disabled (x: DSLElement, v: 'v) = x.attr "disabled" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

type formBuilder() =
    inherit HtmlBuilder("form")

    [<CustomOperation("accept")>]
    member inline _.accept (x: DSLElement, v: 'v) = x.attr "accept" v

    [<CustomOperation("acceptCharset")>]
    member inline _.acceptCharset (x: DSLElement, v: 'v) = x.attr "accept-charset" v

    [<CustomOperation("action")>]
    member inline _.action (x: DSLElement, v: 'v) = x.attr "action" v

    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete (x: DSLElement, v: 'v) = x.attr "autocomplete" v

    [<CustomOperation("enctype")>]
    member inline _.enctype (x: DSLElement, v: 'v) = x.attr "enctype" v

    [<CustomOperation("formaction")>]
    member inline _.formaction (x: DSLElement, v: 'v) = x.attr "formaction" v

    [<CustomOperation("formenctype")>]
    member inline _.formenctype (x: DSLElement, v: 'v) = x.attr "formenctype" v

    [<CustomOperation("formmethod")>]
    member inline _.formmethod (x: DSLElement, v: 'v) = x.attr "formmethod" v

    [<CustomOperation("formnovalidate")>]
    member inline _.formnovalidate (x: DSLElement, v: 'v) = x.attr "formnovalidate" v

    [<CustomOperation("formtarget")>]
    member inline _.formtarget (x: DSLElement, v: 'v) = x.attr "formtarget" v

    [<CustomOperation("method")>]
    member inline _.method (x: DSLElement, v: 'v) = x.attr "method" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("novalidate")>]
    member inline _.novalidate (x: DSLElement, v: 'v) = x.attr "novalidate" v

    [<CustomOperation("target")>]
    member inline _.target (x: DSLElement, v: 'v) = x.attr "target" v

type inputBuilder() =
    inherit HtmlBuilder("input")

    [<CustomOperation("accept")>]
    member inline _.accept (x: DSLElement, v: 'v) = x.attr "accept" v

    [<CustomOperation("alt")>]
    member inline _.alt (x: DSLElement, v: 'v) = x.attr "alt" v

    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete (x: DSLElement, v: 'v) = x.attr "autocomplete" v

    [<CustomOperation("autofocus")>]
    member inline _.autofocus (x: DSLElement, v: 'v) = x.attr "autofocus" v

    [<CustomOperation("capture")>]
    member inline _.capture (x: DSLElement, v: 'v) = x.attr "capture" v

    [<CustomOperation("checked'")>]
    member inline _.checked' (x: DSLElement, v: 'v) = x.attr "checked" v

    [<CustomOperation("dirname")>]
    member inline _.dirname (x: DSLElement, v: 'v) = x.attr "dirname" v

    [<CustomOperation("disabled")>]
    member inline _.disabled (x: DSLElement, v: 'v) = x.attr "disabled" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("formaction")>]
    member inline _.formaction (x: DSLElement, v: 'v) = x.attr "formaction" v

    [<CustomOperation("formenctype")>]
    member inline _.formenctype (x: DSLElement, v: 'v) = x.attr "formenctype" v

    [<CustomOperation("formmethod")>]
    member inline _.formmethod (x: DSLElement, v: 'v) = x.attr "formmethod" v

    [<CustomOperation("formnovalidate")>]
    member inline _.formnovalidate (x: DSLElement, v: 'v) = x.attr "formnovalidate" v

    [<CustomOperation("formtarget")>]
    member inline _.formtarget (x: DSLElement, v: 'v) = x.attr "formtarget" v

    [<CustomOperation("height")>]
    member inline _.height (x: DSLElement, v: 'v) = x.attr "height" v

    [<CustomOperation("list")>]
    member inline _.list (x: DSLElement, v: 'v) = x.attr "list" v

    [<CustomOperation("max")>]
    member inline _.max (x: DSLElement, v: 'v) = x.attr "max" v

    [<CustomOperation("maxlength")>]
    member inline _.maxlength (x: DSLElement, v: 'v) = x.attr "maxlength" v

    [<CustomOperation("minlength")>]
    member inline _.minlength (x: DSLElement, v: 'v) = x.attr "minlength" v

    [<CustomOperation("min")>]
    member inline _.min (x: DSLElement, v: 'v) = x.attr "min" v

    [<CustomOperation("multiple")>]
    member inline _.multiple (x: DSLElement, v: 'v) = x.attr "multiple" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("pattern")>]
    member inline _.pattern (x: DSLElement, v: 'v) = x.attr "pattern" v

    [<CustomOperation("placeholder")>]
    member inline _.placeholder (x: DSLElement, v: 'v) = x.attr "placeholder" v

    [<CustomOperation("readonly")>]
    member inline _.readonly (x: DSLElement, v: 'v) = x.attr "readonly" v

    [<CustomOperation("required")>]
    member inline _.required (x: DSLElement, v: 'v) = x.attr "required" v

    [<CustomOperation("size")>]
    member inline _.size (x: DSLElement, v: 'v) = x.attr "size" v

    [<CustomOperation("src")>]
    member inline _.src (x: DSLElement, v: 'v) = x.attr "src" v

    [<CustomOperation("step")>]
    member inline _.step (x: DSLElement, v: 'v) = x.attr "step" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

    [<CustomOperation("usemap")>]
    member inline _.usemap (x: DSLElement, v: 'v) = x.attr "usemap" v

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

    [<CustomOperation("width")>]
    member inline _.width (x: DSLElement, v: 'v) = x.attr "width" v

type labelBuilder() =
    inherit HtmlBuilder("label")

    [<CustomOperation("for'")>]
    member inline _.for' (x: DSLElement, v: 'v) = x.attr "for" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

type meterBuilder() =
    inherit HtmlBuilder("meter")

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("high")>]
    member inline _.high (x: DSLElement, v: 'v) = x.attr "high" v

    [<CustomOperation("low")>]
    member inline _.low (x: DSLElement, v: 'v) = x.attr "low" v

    [<CustomOperation("max")>]
    member inline _.max (x: DSLElement, v: 'v) = x.attr "max" v

    [<CustomOperation("min")>]
    member inline _.min (x: DSLElement, v: 'v) = x.attr "min" v

    [<CustomOperation("optimum")>]
    member inline _.optimum (x: DSLElement, v: 'v) = x.attr "optimum" v

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

type optgroupBuilder() =
    inherit HtmlBuilder("optgroup")

    [<CustomOperation("disabled")>]
    member inline _.disabled (x: DSLElement, v: 'v) = x.attr "disabled" v

    [<CustomOperation("label")>]
    member inline _.label (x: DSLElement, v: 'v) = x.attr "label" v

type optionBuilder() =
    inherit HtmlBuilder("option")

    [<CustomOperation("disabled")>]
    member inline _.disabled (x: DSLElement, v: 'v) = x.attr "disabled" v

    [<CustomOperation("label")>]
    member inline _.label (x: DSLElement, v: 'v) = x.attr "label" v

    [<CustomOperation("selected")>]
    member inline _.selected (x: DSLElement, v: 'v) = x.attr "selected" v

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

type outputBuilder() =
    inherit HtmlBuilder("output")

    [<CustomOperation("for'")>]
    member inline _.for' (x: DSLElement, v: 'v) = x.attr "for" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

type progressBuilder() =
    inherit HtmlBuilder("progress")

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("max")>]
    member inline _.max (x: DSLElement, v: 'v) = x.attr "max" v

    [<CustomOperation("value")>]
    member inline _.value (x: DSLElement, v: 'v) = x.attr "value" v

type selectBuilder() =
    inherit HtmlBuilder("select")

    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete (x: DSLElement, v: 'v) = x.attr "autocomplete" v

    [<CustomOperation("autofocus")>]
    member inline _.autofocus (x: DSLElement, v: 'v) = x.attr "autofocus" v

    [<CustomOperation("disabled")>]
    member inline _.disabled (x: DSLElement, v: 'v) = x.attr "disabled" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("multiple")>]
    member inline _.multiple (x: DSLElement, v: 'v) = x.attr "multiple" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("required")>]
    member inline _.required (x: DSLElement, v: 'v) = x.attr "required" v

    [<CustomOperation("size")>]
    member inline _.size (x: DSLElement, v: 'v) = x.attr "size" v

type textareaBuilder() =
    inherit HtmlBuilder("textarea")

    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete (x: DSLElement, v: 'v) = x.attr "autocomplete" v

    [<CustomOperation("autofocus")>]
    member inline _.autofocus (x: DSLElement, v: 'v) = x.attr "autofocus" v

    [<CustomOperation("cols")>]
    member inline _.cols (x: DSLElement, v: 'v) = x.attr "cols" v

    [<CustomOperation("dirname")>]
    member inline _.dirname (x: DSLElement, v: 'v) = x.attr "dirname" v

    [<CustomOperation("disabled")>]
    member inline _.disabled (x: DSLElement, v: 'v) = x.attr "disabled" v

    [<CustomOperation("enterkeyhint")>]
    member inline _.enterkeyhint (x: DSLElement, v: 'v) = x.attr "enterkeyhint" v

    [<CustomOperation("form")>]
    member inline _.form (x: DSLElement, v: 'v) = x.attr "form" v

    [<CustomOperation("inputmode")>]
    member inline _.inputmode (x: DSLElement, v: 'v) = x.attr "inputmode" v

    [<CustomOperation("maxlength")>]
    member inline _.maxlength (x: DSLElement, v: 'v) = x.attr "maxlength" v

    [<CustomOperation("minlength")>]
    member inline _.minlength (x: DSLElement, v: 'v) = x.attr "minlength" v

    [<CustomOperation("name")>]
    member inline _.name (x: DSLElement, v: 'v) = x.attr "name" v

    [<CustomOperation("placeholder")>]
    member inline _.placeholder (x: DSLElement, v: 'v) = x.attr "placeholder" v

    [<CustomOperation("readonly")>]
    member inline _.readonly (x: DSLElement, v: 'v) = x.attr "readonly" v

    [<CustomOperation("required")>]
    member inline _.required (x: DSLElement, v: 'v) = x.attr "required" v

    [<CustomOperation("rows")>]
    member inline _.rows (x: DSLElement, v: 'v) = x.attr "rows" v

    [<CustomOperation("wrap")>]
    member inline _.wrap (x: DSLElement, v: 'v) = x.attr "wrap" v

type detailsBuilder() =
    inherit HtmlBuilder("details")

    [<CustomOperation("open'")>]
    member inline _.open' (x: DSLElement, v: 'v) = x.attr "open" v

type dialogBuilder() =
    inherit HtmlBuilder("dialog")

    [<CustomOperation("open'")>]
    member inline _.open' (x: DSLElement, v: 'v) = x.attr "open" v

type menuBuilder() =
    inherit HtmlBuilder("menu")

    [<CustomOperation("contextmenu")>]
    member inline _.contextmenu (x: DSLElement, v: 'v) = x.attr "contextmenu" v

    [<CustomOperation("type'")>]
    member inline _.type' (x: DSLElement, v: 'v) = x.attr "type" v

type summaryBuilder() =
    inherit HtmlBuilder("summary")

    [<CustomOperation("summary")>]
    member inline _.summary (x: DSLElement, v: 'v) = x.attr "summary" v

