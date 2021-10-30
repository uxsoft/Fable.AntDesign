module Fable.Builders.AntDesignCharts.Charts

open Core
open Fable.Core.JsInterop

type AreaBuilder() =
    inherit ChartBuilder(import "Area" "@ant-design/charts")
    
type BarBuilder() =
    inherit ChartBuilder(import "Bar" "@ant-design/charts")
    
type BoxBuilder() =
    inherit ChartBuilder(import "Box" "@ant-design/charts")
    
type BulletBuilder() =
    inherit ChartBuilder(import "Bullet" "@ant-design/charts")
    
type ColumnBuilder() =
    inherit ChartBuilder(import "Column" "@ant-design/charts")
    
type FunnelBuilder() =
    inherit ChartBuilder(import "Funnel" "@ant-design/charts")
    
type HistogramBuilder() =
    inherit ChartBuilder(import "Histogram" "@ant-design/charts")
    
type LineBuilder() =
    inherit ChartBuilder(import "Line" "@ant-design/charts")
    
type LiquidBuilder() =
    inherit ChartBuilder(import "Liquid" "@ant-design/charts")
    
type HeatmapBuilder() =
    inherit ChartBuilder(import "Heatmap" "@ant-design/charts")
    
type PieBuilder() =
    inherit ChartBuilder(import "Pie" "@ant-design/charts")
    
type ProgressBuilder() =
    inherit ChartBuilder(import "Progress" "@ant-design/charts")
    
type RadarBuilder() =
    inherit ChartBuilder(import "Radar" "@ant-design/charts")
    
type RingProgressBuilder() =
    inherit ChartBuilder(import "RingProgress" "@ant-design/charts")
    
type RoseBuilder() =
    inherit ChartBuilder(import "Rose" "@ant-design/charts")
    
type ScatterBuilder() =
    inherit ChartBuilder(import "Scatter" "@ant-design/charts")
    
type TinyAreaBuilder() =
    inherit ChartBuilder(import "TinyArea" "@ant-design/charts")
    
type TinyColumnBuilder() =
    inherit ChartBuilder(import "TinyColumn" "@ant-design/charts")
    
type TinyLineBuilder() =
    inherit ChartBuilder(import "TinyLine" "@ant-design/charts")
    
type WaterfallBuilder() =
    inherit ChartBuilder(import "Waterfall" "@ant-design/charts")
    
type WordCloudBuilder() =
    inherit ChartBuilder(import "WordCloud" "@ant-design/charts")
    
type SunburstBuilder() =
    inherit ChartBuilder(import "Sunburst" "@ant-design/charts")
    
type DualAxesBuilder() =
    inherit ChartBuilder(import "DualAxes" "@ant-design/charts")
    
type StockBuilder() =
    inherit ChartBuilder(import "Stock" "@ant-design/charts")
    
type RadialBarBuilder() =
    inherit ChartBuilder(import "RadialBar" "@ant-design/charts")
    
type GaugeBuilder() =
    inherit ChartBuilder(import "Gauge" "@ant-design/charts")
    
type SankeyBuilder() =
    inherit ChartBuilder(import "Sankey" "@ant-design/charts")
    
type BidirectionalBarBuilder() =
    inherit ChartBuilder(import "BidirectionalBar" "@ant-design/charts")
    
type OrganizationTreeGraphBuilder() =
    inherit ChartBuilder(import "OrganizationTreeGraph" "@ant-design/charts")
    
type DagreGraphBuilder() =
    inherit ChartBuilder(import "DagreGraph" "@ant-design/charts")
    
type IndentedTreeBuilder() =
    inherit ChartBuilder(import "IndentedTree" "@ant-design/charts")
    
type DagreFundFlowGraphBuilder() =
    inherit ChartBuilder(import "DagreFundFlowGraph" "@ant-design/charts")
    