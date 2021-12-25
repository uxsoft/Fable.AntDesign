module Fable.Builders.AntDesignCharts.Charts

open Core
open Fable.Core.JsInterop
    
type AreaBuilder() =
    inherit ChartBuilder(import "Area" "@ant-design/charts")
    
type BarBuilder() =
    inherit ChartBuilder(import "Bar" "@ant-design/charts")
    
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
    
type BoxBuilder() =
    inherit ChartBuilder(import "Box" "@ant-design/charts")
    
type LiquidBuilder() =
    inherit ChartBuilder(import "Liquid" "@ant-design/charts")
    
type HeatmapBuilder() =
    inherit ChartBuilder(import "Heatmap" "@ant-design/charts")
    
type PieBuilder() =
    inherit ChartBuilder(import "Pie" "@ant-design/charts")
    
type GaugeBuilder() =
    inherit ChartBuilder(import "Gauge" "@ant-design/charts")
    
type ProgressBuilder() =
    inherit ChartBuilder(import "Progress" "@ant-design/charts")
    
type RadarBuilder() =
    inherit ChartBuilder(import "Radar" "@ant-design/charts")
    
type RingProgressBuilder() =
    inherit ChartBuilder(import "RingProgress" "@ant-design/charts")
    
type RoseBuilder() =
    inherit ChartBuilder(import "Rose" "@ant-design/charts")
    
type ChordBuilder() =
    inherit ChartBuilder(import "Chord" "@ant-design/charts")
    
type ScatterBuilder() =
    inherit ChartBuilder(import "Scatter" "@ant-design/charts")
    
type TinyAreaBuilder() =
    inherit ChartBuilder(import "TinyArea" "@ant-design/charts")
    
type TinyColumnBuilder() =
    inherit ChartBuilder(import "TinyColumn" "@ant-design/charts")
    
type DualAxesBuilder() =
    inherit ChartBuilder(import "DualAxes" "@ant-design/charts")
    
type TinyLineBuilder() =
    inherit ChartBuilder(import "TinyLine" "@ant-design/charts")
    
type WaterfallBuilder() =
    inherit ChartBuilder(import "Waterfall" "@ant-design/charts")
    
type WordCloudBuilder() =
    inherit ChartBuilder(import "WordCloud" "@ant-design/charts")
    
type SunburstBuilder() =
    inherit ChartBuilder(import "Sunburst" "@ant-design/charts")
    
type StockBuilder() =
    inherit ChartBuilder(import "Stock" "@ant-design/charts")
    
type RadialBarBuilder() =
    inherit ChartBuilder(import "RadialBar" "@ant-design/charts")
    
type SankeyBuilder() =
    inherit ChartBuilder(import "Sankey" "@ant-design/charts")
    
type TreemapBuilder() =
    inherit ChartBuilder(import "Treemap" "@ant-design/charts")
    
type ViolinBuilder() =
    inherit ChartBuilder(import "Violin" "@ant-design/charts")
    
type VennBuilder() =
    inherit ChartBuilder(import "Venn" "@ant-design/charts")
    
type CirclePackingBuilder() =
    inherit ChartBuilder(import "CirclePacking" "@ant-design/charts")
    
type FacetBuilder() =
    inherit ChartBuilder(import "Facet" "@ant-design/charts")
    
type MultiViewBuilder() =
    inherit ChartBuilder(import "MultiView" "@ant-design/charts")
    
type MixBuilder() =
    inherit ChartBuilder(import "Mix" "@ant-design/charts")
    
type BidirectionalBarBuilder() =
    inherit ChartBuilder(import "BidirectionalBar" "@ant-design/charts")
    
type OrganizationGraphBuilder() =
    inherit ChartBuilder(import "OrganizationGraph" "@ant-design/charts")
    
type RadialTreeGraphBuilder() =
    inherit ChartBuilder(import "RadialTreeGraph" "@ant-design/charts")
    
type FlowAnalysisGraphBuilder() =
    inherit ChartBuilder(import "FlowAnalysisGraph" "@ant-design/charts")
    
type DecompositionTreeGraphBuilder() =
    inherit ChartBuilder(import "DecompositionTreeGraph" "@ant-design/charts")
    
type FundFlowGraphBuilder() =
    inherit ChartBuilder(import "FundFlowGraph" "@ant-design/charts")
        
type DotMapBuilder() =
    inherit ChartBuilder(import "DotMap" "@ant-design/charts")
    
type HeatMapBuilder() =
    inherit ChartBuilder(import "HeatMap" "@ant-design/charts")
    
type GridMapBuilder() =
    inherit ChartBuilder(import "GridMap" "@ant-design/charts")
    
type HexbinMapBuilder() =
    inherit ChartBuilder(import "HexbinMap" "@ant-design/charts")
    
//type PathMapBuilder() =
//    inherit ChartBuilder(import "PathMap" "@ant-design/charts")
    
//type FlowMapBuilder() =
//    inherit ChartBuilder(import "FlowMap" "@ant-design/charts")
    
type AreaMapBuilder() =
    inherit ChartBuilder(import "AreaMap" "@ant-design/charts")
    
type ChoroplethMapBuilder() =
    inherit ChartBuilder(import "ChoroplethMap" "@ant-design/charts")
    