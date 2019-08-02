param(
    [Hashtable]$OutParams = @{ Show = $true }
)

Set-StrictMode -Version Latest

$s = (
  @(oxy.area -x1 10,20,30 -y1 10,30,20 -x2 10,15,25,30 -y2 -10,-20,-15,5 | oxy.model -title "Area Series"),
  @(oxy.bar -value 1,2,3 -category a,b,c | oxy.model -title "Bar Series"),
  @(oxy.boxPlot -category January, Februay, March -lowerWhisker 1,2,3 -boxBottom 5,10,15 -median 10,15,20 -boxTop 15,20,25 -upperWhisker 20,25,30 -outliers @(30,31),@(32,33),@(34,35) | oxy.model -title "Box Plot Series"),
  @(oxy.candleStick -x "2019/1/1", "2019/2/1", "2019/3/1", "2019/4/1", "2019/5/1" -open 10,11,14,13,12 -high 15,16,6,7,17 -low 8,7,16,17,6 -close 12,13,12,11,14 | oxy.model -title "Candle Stick Series"),
  @(oxy.candleStickAndVolume -x "2019/1/1", "2019/2/1", "2019/3/1", "2019/4/1", "2019/5/1" -open 10,11,14,13,12 -high 15,16,6,7,17 -low 8,7,16,17,6 -close 12,13,12,11,14 -buyvolume 1000,2000,1500,2000,2000 -sellvolume 100,200,150,200,200 -volumestyle stacked | oxy.model -title "Candle Stick And Volume Series"),
  @(oxy.column -value 1,2,3 -category a,b,c | oxy.model -title "Column Series"),
  @(oxy.errorColumn -value 1,2,3 -error .2,.3,.4 -category a,b,c | oxy.model -title "Error Column Series"),
  @(oxy.func -f "x => Math.Sin(x) * Math.Cos(2 * x)" -x0 -7 -x1 7 | oxy.model -title "Function Series"),
  @(oxy.heatMap -data @(@(1,2,3,4),@(4,5,6,7), @(7,8,15,10),@(10,11,12,13)) -Interpolate $true | oxy.model -title "Heatmap Series"),
  @(oxy.highLow -x "2019/1/1", "2019/2/1", "2019/3/1", "2019/4/1", "2019/5/1" -open 10,11,14,13,12 -high 13,14,15,14,13 -low 9,10,11,10,9 -close 12,13,12,11,10 | oxy.model -title "High Low Series"),
  @(oxy.hist2 -Data 1,2,3,4,5,2,3,4,5,2,3,4,2 | oxy.model -title "Histogram Series"),
  @(oxy.intervalBar -start 1,2,3 -end 11,12,13 -bartitle a,b,c -category X,Y,Z | oxy.model -title "Interval Bar Series"),
  @(oxy.linearBar -x 1,2,3,4,5 -y 11,15,13,12,13 | oxy.model -title "Linear Bar Series"),
  @(oxy.line -x 1,2,3,4,5 -y 11,15,13,12,13 | oxy.model -title "Line Series"),
  @(oxy.pie -label January, Februay, March -value 10,20,30  | oxy.model -title "Pie Series"),
  @(oxy.rectangle -x1 1,2,3 -y1 1,2,3 -x2 4,5,6 -y2 4,5,6 -value 10,20,30 | oxy.model -title "Rectangle Series"),
  @(oxy.rectanglebar -x0 10, 20,30 -y0 10,20,30 -x1 20,30,40 -y1 20,30,40 | oxy.model -title "Rectangle Bar Series"),
  @(oxy.scatterError -x 1,2,3,4,5 -y 11,15,13,12,13 -ErrorX .1,.2,.3,.1,.2 -ErrorY .4,.5,.6,.5,.6 | oxy.model -title "Scatter Error Series"),
  @(oxy.scatter -x 1,2,3,4,5 -y 11,15,13,12,13 | oxy.model -title "Scatter Series"),
  @(oxy.stairStep -x 1,2,3,4,5 -y 11,15,13,12,13 | oxy.model -title "Stair Step Series"),
  @(oxy.stem -x 1,2,3,4,5 -y 11,15,13,12,13 | oxy.model -title "Stem Series"),
  @(oxy.3cLine -x 1,2,3 -y -3,5,3 -limithi 2 -limitlo -1 -color automatic | oxy.model -title "Three-Color Line Series"),
  @(oxy.tornadoBar -minimum 10,20,30 -maximum 100,120,130 -barbasevalue 50,60,70 -category January, Februay, March | oxy.model -title "Tornado Bar Series"),
  @(oxy.2cArea -x1 10,20,30 -y1 10,30,20 -x2 10,15,25,30 -y2 -10,-20,-15,5 | oxy.model -title "Two-Color Area Series"),
  @(oxy.2cLine -x 1,2,3 -y -3,5,3 | oxy.model -title "Two-Color Line Series"),
  @(oxy.volume -x "2019/1/1", "2019/2/1", "2019/3/1" -open 10,11,12 -high 15,16,17 -low 8,7,6 -close 12,13,14 -buyvolume 1000,2000,1500 -sellvolume 100,200,150 -volumestyle stacked | oxy.model -title "Volume Series" -axmaximum 2019/4/1 -aymaximum 2000 -ayminimum -100)
)

oxy.gridView $s @OutParams
