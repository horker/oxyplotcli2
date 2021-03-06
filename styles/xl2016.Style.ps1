# xl2016 style

Set-StrictMode -Version 3

$baseSize = [Horker.OxyPlotCli.TypeAdaptors.Double]::ConvertFrom("12.0pt")
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
  "PlotModel.PlotAreaBorderColor" = "#D9D9D9"

  # Titles
  "PlotModel.TitleFontSize" = $baseSize * 1.5
  "PlotModel.TitleFontWeight" = 400
  "PlotModel.SubtitleFontSize" = $baseSize * 0.9
  "PlotModel.SubtitleFontWeight" = 400

  # Legend
  "PlotModel.LegendBackground" = "#000000-00"
  "PlotModel.LegendBorderThickness" = 0
  "PlotModel.LegendMargin" = 0
  "PlotModel.LegendItemSpacing" = 12
  "PlotModel.LegendOrientation" = "Horizontal"
  "PlotModel.LegendPlacement" = "Outside"
  "PlotModel.LegendPosition" = "BottomCenter"
  "PlotModel.LegendTitleFontSize" = $baseSize
  "PlotModel.LegendTitleFontWeight" = 400
  "PlotModel.LegendFontSize" = $baseSize * 0.8
  "PlotModel.LegendTextColor" = "#595959"

  # *Axis: Tick
  "*Axis.TickStyle" = "None"
  "*Axis.TextColor" = "#595959"
  "*Axis.FontSize" = $baseSize

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
  "*Axis.AxisTitleDistance" = $baseSize

  # CategoryAxis: FontSize
  "CategoryAxis.FontSize" = $baseSize

  # Scatter*Series
  "Scatter*Series.MarkerType" = "Circle"
  "Scatter*Series.MarkerSize" = "3px"

  # BoxPlotSeries
  "BoxPlotSeries.BoxWidth" = .6
  "BoxPlotSeries.Stroke" = "Black"

  # CandleStickAndVolumeSeries
  "CandleStickAndVolumeSeries.VolumeStyle" = "Stacked"

  # VolumeSeries
  "VolumeSeries.VolumeStyle" = "Stacked"

  # ErrorColumnSeries
  "ErrorColumnSeries.StrokeColor" = "gray"

  # PieSeries
  "PieSeries.StartAngle" = -90
  "PieSeries.Diameter" = 0.75

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

    if ($null -eq $m -or $m.Series.Count -eq 0) {
        return
    }

    $s = $m.Series[0]
    $thickness = [Horker.OxyPlotCli.TypeAdaptors.Double]::ConvertFrom("1pt")

    foreach ($a in $m.Axes) {
        if ($s -is [OxyPlot.Series.BarSeries] -or
            $s -is [OxyPlot.Series.IntervalBarSeries] -or
            $s -is [OxyPlot.Series.TornadoBarSeries]) {
            if ($a.IsHorizontal()) {
                $a.MajorGridLineThickness = $thickness
            }
        }
        elseif ($s -isnot [OxyPlot.Series.HeatmapSeries] -and
                $s -isnot [OxyPlot.Series.PieSeries] -and
                $s -isnot [OxyPlot.Series.RectangleSeries] -and
                $s -isnot [OxyPlot.Series.RectangleBarSeries]) {
            if ($a.IsVertical()) {
                $a.MajorGridLineThickness = $thickness
            }
        }
    }

    if ($s -is [OxyPlot.Series.HeatmapSeries] -or
        $s -is [OxyPlot.Series.RectangleSeries] -or
        $s -is [OxyPlot.Series.RectangleBarSeries]) {
        $m.PlotAreaBorderThickness = New-Object OxyPlot.OxyThickness $thickness, 0, 0, $thickness
    }
    elseif ($s -is [OxyPlot.Series.IntervalBarSeries] -or
        $s -is [OxyPlot.Series.TornadoBarSeries]) {
        $m.PlotAreaBorderThickness = New-Object OxyPlot.OxyThickness $thickness, 0, 0, 0
    }
    elseif ($s -isnot [OxyPlot.Series.BarSeries] -and
            $s -isnot [OxyPlot.Series.ColumnSeries] -and
            $s -isnot [OxyPlot.Series.ErrorColumnSeries] -and
            $s -isnot [OxyPlot.Series.HistogramSeries] -and
            $s -isnot [OxyPlot.Series.VolumeSeries]) {
       $m.PlotAreaBorderThickness = New-Object OxyPlot.OxyThickness 0, 0, 0, $thickness
    }
  }
}

Add-OxyStyle xl2016 $config -BaseStyle vanilla
