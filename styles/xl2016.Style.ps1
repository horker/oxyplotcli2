# xl2016 style
# https://github.com/tidyverse/ggplot2/blob/master/R/theme-defaults.r

Set-StrictMode -Version 3

$baseSize = [Horker.PSOxyPlot.TypeAdaptors.Double]::ConvertFrom("11.0pt")
$baseLineSize = $baseSize / 22
$baseRectSize = $baseSize / 22
$halfLine = $baseSize / 2

$config = @{

  # Color scheme
  "[DefaultColorScheme]" = "colorful1"

  # Default
  "PlotModel.DefaultFontSize" = $baseSize

  # PlotArea
  "PlotModel.PlotAreaBorderThickness" = 0
  "PlotModel.TitleFontSize" = $baseSize * 2
  "PlotModel.SubtitleFontSize" = $baseSize * 0.9

  # Legend
  "PlotModel.LegendBackground" = "#000000-00"
  "PlotModel.LegendBorderThickness" = 0
  "PlotModel.LegendOrientation" = "Horizontal"
  "PlotModel.LegendPlacement" = "Outside"
  "PlotModel.LegendPosition" = "BottomCenter"

  "PlotModel.LegendTitleFontSize" = $baseSize
  "PlotModel.LegendTitleFontWeight" = 800
  "PlotModel.LegendFontSize" = $baseSize

  # *Axis: Tick
  "*Axis.TickStyle" = "None"
  "*Axis.TextColor" = "#595959"
  "*Axis.FontSize" = $baseSize * 0.8

  # *Axis: MinorTick
  "*Axis.MinorTickSize" = 0

  # *Axis: MajorGridline
  "*Axis.MajorGridlineStyle" = "Solid"
  "*Axis.MajorGridlineColor" = "#D9D9D9"
  "*Axis.MajorGridlineThickness" = 0

  # *Axis: MinorGridline
  "*Axis.MinorGridlineThickness" = 0

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
  "PieSeries.AreInsideLabelsAngled" = $true

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

  # Event hook
  "[BeforeRendering]" = {
    param($m)
    $s = $m.Series[0]
    $thickness = [Horker.PSOxyPlot.TypeAdaptors.Double]::ConvertFrom("1pt")
    foreach ($a in $m.Axes) {
        if ($s -is [OxyPlot.Series.BarSeries] -or
            $s -is [OxyPlot.Series.IntervalBarSeries] -or
            $s -is [OxyPlot.Series.TornadoBarSeries]) {
            if ($a.IsHorizontal()) {
                $a.MajorGridLineThickness = $thickness
            }
        }
        else {
            if ($a.IsVertical()) {
                $a.MajorGridLineThickness = $thickness
            }
        }
    }
  }

}

Add-OxyStyle xl2016 $config -BaseStyle vanilla
