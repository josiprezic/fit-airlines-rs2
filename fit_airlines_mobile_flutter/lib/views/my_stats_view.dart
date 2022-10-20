import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:syncfusion_flutter_charts/sparkcharts.dart';
import 'package:flutter/material.dart';

class MyStatsView extends StatefulWidget {
  const MyStatsView({Key? key}) : super(key: key);

  @override
  State<MyStatsView> createState() => _MyStatsViewState();
}

class _MyStatsViewState extends State<MyStatsView> {
  List<_FlightsStatsData> data = [
    _FlightsStatsData('Jan', 35),
    _FlightsStatsData('Feb', 28),
    _FlightsStatsData('Mar', 34),
    _FlightsStatsData('Apr', 32),
    _FlightsStatsData('May', 40)
  ];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Syncfusion Flutter chart'),
        ),
        body: Column(children: [
          //Initialize the chart widget
          SfCartesianChart(
              primaryXAxis: CategoryAxis(),
              // Chart title
              title: ChartTitle(text: 'Half yearly sales analysis'),
              // Enable legend
              legend: Legend(isVisible: true),
              // Enable tooltip
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries<_FlightsStatsData, String>>[
                LineSeries<_FlightsStatsData, String>(
                    dataSource: data,
                    xValueMapper: (_FlightsStatsData sales, _) => sales.year,
                    yValueMapper: (_FlightsStatsData sales, _) => sales.sales,
                    name: 'Sales',
                    // Enable data label
                    dataLabelSettings: DataLabelSettings(isVisible: true))
              ]),
          Expanded(
            child: Padding(
              padding: const EdgeInsets.all(8.0),
              //Initialize the spark charts widget
              child: SfSparkLineChart.custom(
                //Enable the trackball
                trackball: SparkChartTrackball(
                    activationMode: SparkChartActivationMode.tap),
                //Enable marker
                marker: SparkChartMarker(
                    displayMode: SparkChartMarkerDisplayMode.all),
                //Enable data label
                labelDisplayMode: SparkChartLabelDisplayMode.all,
                xValueMapper: (int index) => data[index].year,
                yValueMapper: (int index) => data[index].sales,
                dataCount: 5,
              ),
            ),
          )
        ]));
  }
}

class _FlightsStatsData {
  _FlightsStatsData(this.year, this.sales);

  final String year;
  final double sales;
}
