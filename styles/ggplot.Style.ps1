# ggplot2 default gray style
# https://github.com/tidyverse/ggplot2/blob/master/R/theme-defaults.r

Set-StrictMode -Version 3

$baseSize = [Horker.OxyPlotCli.TypeAdaptors.Double]::ConvertFrom("11.0pt")
$baseLineSize = $baseSize / 22
$baseRectSize = $baseSize / 22
$halfLine = $baseSize / 2

$config = @{

  # Color scheme
  "[DefaultColorScheme]" = "ggplot"

  # Default
  "PlotModel.DefaultFontSize" = "$($baseSize)pt"

  # PlotArea
  "PlotModel.PlotAreaBackground" = "#E5E5E5"
  "PlotModel.PlotAreaBorderThickness" = 0
  "PlotModel.TitleFontSize" = $baseSize * 1.2
  "PlotModel.SubtitleFontSize" = $baseSize * 0.9

  # Legend
  "PlotModel.LegendPosition" = "RightMiddle"
  "PlotModel.LegendPlacement" = "Outside"

  "PlotModel.LegendBorder" = "gray"
  "PlotModel.LegendBorderThickness" = "1px"

  "PlotModel.LegendTitleFontSize" = $baseSize
  "PlotModel.LegendTitleFontWeight" = 800
  "PlotModel.LegendFontSize" = $baseSize * 0.9
  "PlotModel.LegendLineSpacing" = $baseLineSize

  # *Axis: Tick
  "*Axis.TickStyle" = "Outside"
  "*Axis.TicklineColor" = "#4D4D4D"
  "*Axis.TextColor" = "#4D4D4D"
  "*Axis.FontSize" = $baseSize * 0.8

  # *Axis: MinorTick
  "*Axis.MinorTickSize" = 0

  # *Axis: MajorGridline
  "*Axis.MajorGridlineStyle" = "Solid"
  "*Axis.MajorGridlineColor" = "White"
  "*Axis.MajorGridlineThickness" = "1px"

  # *Axis: MinorGridline
  "*Axis.MinorGridlineStyle" = "Solid"
  "*Axis.MinorGridlineColor" = "#F0F0F0"
  "*Axis.MinorGridlineThickness" = "1px"

  # *Axis: Title
  "*Axis.TitleFontSize" = $baseSize * 1.2
  "*Axis.TitleColor" = "#4D4D4D"
  "*Axis.AxisTitleDistance" = $baseSize * 2

  # CategoryAxis: FontSize
  "CategoryAxis.FontSize" = $baseSize

  # Scatter*Series
  "Scatter*Series.MarkerType" = "Circle"
  "Scatter*Series.MarkerSize" = "3px"

  # BoxPlotSeries
  "BoxPlotSeries.BoxWidth" = .6
  "BoxPlotSeries.StrokeThickness" = "2pt"
  "BoxPlotSeries.WhiskerWidth" = 0
  "BoxPlotSeries.OutlierSize" = "3pt"

  # CandleStickAndVolumeSeries
  "CandleStickAndVolumeSeries.VolumeStyle" = "Stacked"

  # VolumeSeries
  "VolumeSeries.VolumeStyle" = "Stacked"

  # ErrorColumnSeries
  "ErrorColumnSeries.StrokeColor" = "gray"

  # PieSeries
  "PieSeries.StartAngle" = -90
  "PieSeries.Diameter" = 0.75
  "PieSeries.InnerDiameter" = 0.35
  "PieSeries.AreInsideLabelsAngled" = $false

  # IntervalBarSeries
  "IntervalBarSeries.StrokeThickness" = 0
  "IntervalBarSeries.TextColor" = "white"

  # RectangleBarSeries
  "RectangleBarSeries.StrokeThickness" = 0

  # TornadobarSeries
  "TornadoBarSeries.StrokeThickness" = 0

  # AreaSeries
  "AreaSeries.StrokeThickness" = 0

  # TwoColorAreaSeries
  "TwoColorAreaSeries.StrokeThickness" = 0
}

Add-OxyStyle ggplot $config -BaseStyle vanilla
