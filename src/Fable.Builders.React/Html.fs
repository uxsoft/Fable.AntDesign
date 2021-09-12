module Fable.Builders.React.Html

open Fable.Builders.React.HtmlBuilder

// Source: https://developer.mozilla.org/en-US/docs/Web/HTML/Element

// Document metadata
let base' = HtmlBuilder("base")
let head = HtmlBuilder("head")
let link = HtmlBuilder("link")
let meta = HtmlBuilder("meta")
let style = HtmlBuilder("style")
let title = HtmlBuilder("title")

// Sectioning root
let body = HtmlBuilder("body")

// Content sectioning
let address = HtmlBuilder("address")
let article = HtmlBuilder("article")
let aside = HtmlBuilder("aside")
let footer = HtmlBuilder("footer")
let header = HtmlBuilder("header")
let h1 = HtmlBuilder("h1")
let h2 = HtmlBuilder("h2")
let h3 = HtmlBuilder("h3")
let h4 = HtmlBuilder("h4")
let h5 = HtmlBuilder("h5")
let h6 = HtmlBuilder("h6")
let main = HtmlBuilder("main")
let nav = HtmlBuilder("nav")
let section = HtmlBuilder("section")

// Text content
let blockquote = HtmlBuilder("blockquote")
let dd = HtmlBuilder("dd")
let div = HtmlBuilder("div")
let dl = HtmlBuilder("dl")
let dt = HtmlBuilder("dt")
let figcaption = HtmlBuilder("figcaption")
let figure = HtmlBuilder("figure")
let hr = HtmlBuilder("hr")
let li = HtmlBuilder("li")
let ol = HtmlBuilder("ol")
let p = HtmlBuilder("p")
let pre = HtmlBuilder("pre")
let ul = HtmlBuilder("ul")

// Inline text semantics
let a = HtmlBuilder("a")
let abbr = HtmlBuilder("abbr")
let b = HtmlBuilder("b")
let bdi = HtmlBuilder("bdi")
let bdo = HtmlBuilder("bdo")
let br = HtmlBuilder("br")
let cite = HtmlBuilder("cite")
let code = HtmlBuilder("code")
let data = HtmlBuilder("data")
let dfn = HtmlBuilder("dfn")
let em = HtmlBuilder("em")
let i = HtmlBuilder("i")
let kbd = HtmlBuilder("kbd")
let mark = HtmlBuilder("mark")
let q = HtmlBuilder("q")
let rp = HtmlBuilder("rp")
let rt = HtmlBuilder("rt")
let ruby = HtmlBuilder("ruby")
let s = HtmlBuilder("s")
let samp = HtmlBuilder("samp")
let small = HtmlBuilder("small")
let span = HtmlBuilder("span")
let strong = HtmlBuilder("strong")
let sub = HtmlBuilder("sub")
let sup = HtmlBuilder("sup")
let time = HtmlBuilder("time")
let u = HtmlBuilder("u")
let var = HtmlBuilder("var")
let wbr = HtmlBuilder("wbr")

// Image and multimedia
let area = HtmlBuilder("area")
let audio = HtmlBuilder("audio")
let img = HtmlBuilder("img")
let map = HtmlBuilder("map")
let track = HtmlBuilder("track")
let video = HtmlBuilder("video")

// Embedded content
let embed = HtmlBuilder("embed")
let iframe = HtmlBuilder("iframe")
let object = HtmlBuilder("object")
let param = HtmlBuilder("param")
let picture = HtmlBuilder("picture")
let portal = HtmlBuilder("portal")
let source = HtmlBuilder("source")

// SVG and MathML
let svg = HtmlBuilder("svg")
let math = HtmlBuilder("math")

// Scripting
let canvas = HtmlBuilder("canvas")
let noscript = HtmlBuilder("noscript")
let script = HtmlBuilder("script")

// Demarcating edits
let del = HtmlBuilder("del")
let ins = HtmlBuilder("ins")

// Table content
let caption = HtmlBuilder("caption")
let col = HtmlBuilder("col")
let colgroup = HtmlBuilder("colgroup")
let table = HtmlBuilder("table")
let tbody = HtmlBuilder("tbody")
let td = HtmlBuilder("td")
let tfoot = HtmlBuilder("tfoot")
let th = HtmlBuilder("th")
let thead = HtmlBuilder("thead")
let tr = HtmlBuilder("tr")

// Forms
let button = HtmlBuilder("button")
let datalist = HtmlBuilder("datalist")
let fieldset = HtmlBuilder("fieldset")
let form = HtmlBuilder("form")
let input = HtmlBuilder("input")
let label = HtmlBuilder("label")
let legend = HtmlBuilder("legend")
let meter = HtmlBuilder("meter")
let optgroup = HtmlBuilder("optgroup")
let option = HtmlBuilder("option")
let output = HtmlBuilder("output")
let progress = HtmlBuilder("progress")
let select = HtmlBuilder("select")
let textarea = HtmlBuilder("textarea")

// Interactive elements
let details = HtmlBuilder("details")
let dialog = HtmlBuilder("dialog")
let menu = HtmlBuilder("menu")
let summary = HtmlBuilder("summary")

// Web Components
let slot = HtmlBuilder("slot")
let template = HtmlBuilder("template")