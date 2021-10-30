namespace Fable.Builders.AntDesignCharts

open Fable.Builders.Common
open Fable.Core

[<AutoOpen>]
module Core =

    [<RequireQualifiedAccess; StringEnum>]
    type ChartRendered = Canvas | Svg
    
    type ChartBuilder(import: obj) =
        inherit ReactBuilder(import)
    
        // plot container
        [<CustomOperation("width")>] member inline _.width (x: DSLElement, v: int) = x.attr "width" v
        [<CustomOperation("height")>] member inline _.height (x: DSLElement, v: int) = x.attr "height" v
        [<CustomOperation("autoFit")>] member inline _.autoFit (x: DSLElement, v: bool) = x.attr "autoFit" v
        [<CustomOperation("padding")>] member inline _.padding (x: DSLElement, v: int list) = x.attr "padding" v
        [<CustomOperation("appendPadding")>] member inline _.appendPadding (x: DSLElement, v: int list) = x.attr "appendPadding" v
        [<CustomOperation("renderer")>] member inline _.renderer (x: DSLElement, v: bool) = x.attr "renderer" v
        [<CustomOperation("pixelRatio")>] member inline _.pixelRatio (x: DSLElement, v: float) = x.attr "pixelRatio" v
        [<CustomOperation("limitInPlot")>] member inline _.limitInPlot (x: DSLElement, v: bool) = x.attr "limitInPlot" v
        [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: string) = x.attr "locale" v
        
        // data mapping
        [<CustomOperation("data")>] member inline _.data (x: DSLElement, v: 'v array) = x.attr "data" v
        [<CustomOperation("xField")>] member inline _.xField (x: DSLElement, v: string) = x.attr "xField" v
        [<CustomOperation("yField")>] member inline _.yField (x: DSLElement, v: string) = x.attr "yField" v
        [<CustomOperation("seriesField")>] member inline _.seriesField (x: DSLElement, v: string) = x.attr "seriesField" v
        [<CustomOperation("groupField")>] member inline _.groupField (x: DSLElement, v: string) = x.attr "groupField" v
        [<CustomOperation("isGroup")>] member inline _.isGroup (x: DSLElement, v: bool) = x.attr "isGroup" v
        [<CustomOperation("isStack")>] member inline _.isStack (x: DSLElement, v: bool) = x.attr "isStack" v
        [<CustomOperation("isRange")>] member inline _.isRange (x: DSLElement, v: bool) = x.attr "isRange" v
        [<CustomOperation("isPercent")>] member inline _.isPercent (x: DSLElement, v: bool) = x.attr "isPercent" v
        [<CustomOperation("meta")>] member inline _.meta (x: DSLElement, v: 'v) = x.attr "meta" v
        [<CustomOperation("color")>] member inline _.color (x: DSLElement, v: 'v -> string) = x.attr "color" v
        [<CustomOperation("color")>] member inline _.color (x: DSLElement, v: string) = x.attr "color" v
        [<CustomOperation("colorField")>] member inline _.colorField (x: DSLElement, v: string) = x.attr "colorField" v
        [<CustomOperation("intervalPadding")>] member inline _.intervalPadding (x: DSLElement, v: int) = x.attr "intervalPadding" v
        [<CustomOperation("dodgePadding")>] member inline _.dodgePadding (x: DSLElement, v: int) = x.attr "dodgePadding" v
        [<CustomOperation("minColumnWidth")>] member inline _.minColumnWidth (x: DSLElement, v: int) = x.attr "minColumnWidth" v
        [<CustomOperation("maxColumnWidth")>] member inline _.maxColumnWidth (x: DSLElement, v: int) = x.attr "maxColumnWidth" v
        [<CustomOperation("style")>] member inline _.style (x: DSLElement, v: 'v) = x.attr "style" v
        [<CustomOperation("columnBackground")>] member inline _.columnBackground (x: DSLElement, v: 'v) = x.attr "columnBackground" v
        [<CustomOperation("columnWidthRatio")>] member inline _.columnWidthRatio (x: DSLElement, v: float) = x.attr "columnWidthRatio" v
        [<CustomOperation("marginRatio")>] member inline _.marginRatio (x: DSLElement, v: float) = x.attr "marginRatio" v
        [<CustomOperation("state")>] member inline _.state (x: DSLElement, v: 'v) = x.attr "state" v
        
        // plot components
//        [<CustomOperation("isRange")>] member inline _.isRange (x: DSLElement, v: bool) = x.attr "isRange" v
//        [<CustomOperation("isRange")>] member inline _.isRange (x: DSLElement, v: bool) = x.attr "isRange" v
//        [<CustomOperation("isRange")>] member inline _.isRange (x: DSLElement, v: bool) = x.attr "isRange" v
//        [<CustomOperation("isRange")>] member inline _.isRange (x: DSLElement, v: bool) = x.attr "isRange" v