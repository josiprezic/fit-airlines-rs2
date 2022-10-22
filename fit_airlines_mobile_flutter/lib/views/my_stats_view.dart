import 'dart:collection';

import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reservation.dart';
import 'package:fit_airlines_mobile_flutter/services/api/flight_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/components/loading_view.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:syncfusion_flutter_charts/sparkcharts.dart';
import 'dart:math';

class MyStatsView extends StatefulWidget {
  const MyStatsView({Key? key}) : super(key: key);

  @override
  State<MyStatsView> createState() => _MyStatsViewState();
}

class _MyStatsViewState extends State<MyStatsView> {
  var flightsService = FlightService();
  var isLoading = false;

  Future<List<_FlightsStatsData>> getData() async {
    isLoading = true;
    var allUserReservations = await flightsService.getReservationsWithFlightsForCurrentUser();
    var upcomingReservations = List.from(allUserReservations);
    var previousReservations = List.from(allUserReservations);

    upcomingReservations.removeWhere((reservation) {
      return !(reservation?.flight?.isInFuture ?? false);
    });

    previousReservations.removeWhere((reservation) {
      return (reservation?.flight?.isInFuture ?? false);
    });

    numberOfFutureFlights = upcomingReservations.length;
    numberOfPreviousFlights = previousReservations.length;

    for (var e in allUserReservations) {
      totalAmountOfMoneyGiven += (e.flight?.price ?? 0);
    }

    for (var e in previousReservations) {
      citiesVisited += (e.flight?.city?.cityName ?? '') + ', ';
    }
    citiesVisited = citiesVisited.substring(0, citiesVisited.length - 2);

    for (var e in upcomingReservations) {
      citiesToVisit += (e.flight?.city?.cityName ?? '') + ', ';
    }
    citiesToVisit = citiesToVisit.substring(0, citiesToVisit.length - 2);

    var yearsOfReservation = allUserReservations.map((e) => DateTime.parse(e.flight?.startDate ?? '').year).toList();
    var additionalYear = yearsOfReservation.reduce(min) - 1;

    yearsOfReservation.forEach((element) {
      print('YEAR::::' + element.toString());
      graphSourceData[element.toString()] = (graphSourceData[element.toString()] ?? 0) + 1;
    });

    graphSourceData[additionalYear.toString()] = 0;

    graphSourceData.forEach((key, value) {
      graphData.add(_FlightsStatsData(key, value));
    });

    var sortedKeys = graphSourceData.keys.toList()..sort();

    graphData = [];

    sortedKeys.forEach((element) {
      graphData.add(_FlightsStatsData(element, graphSourceData[element] ?? 0));
    });

    isLoading = false;

    return graphData;
  }

  var numberOfPreviousFlights = 0;
  var numberOfFutureFlights = 0;
  var totalAmountOfMoneyGiven = 0;
  var citiesVisited = '';
  var citiesToVisit = '';
  Map<String, int> graphSourceData = {};
  List<_FlightsStatsData> graphData = [];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('My stats'),
        ),
        body: FutureBuilder<List<_FlightsStatsData>>(
          future: getData(),
          builder: (context, snapshot) {
            if (isLoading) {
              return LoadingView();
            }

            return Padding(
              padding: const EdgeInsets.all(8.0),
              child: Column(
                children: [
                  //Initialize the chart widget
                  SfCartesianChart(
                      primaryXAxis: CategoryAxis(),
                      // Chart title
                      title: ChartTitle(text: 'Number of reservations per year'),
                      // Enable legend
                      legend: Legend(isVisible: true),
                      // Enable tooltip
                      tooltipBehavior: TooltipBehavior(enable: true),
                      series: <ChartSeries<_FlightsStatsData, String>>[
                        LineSeries<_FlightsStatsData, String>(
                            dataSource: graphData,
                            xValueMapper: (_FlightsStatsData reservations, _) => reservations.year,
                            yValueMapper: (_FlightsStatsData reservations, _) => reservations.numberOfReservations,
                            name: 'Reservations',
                            xAxisName: 'Year',
                            yAxisName: 'Number of reservations',
                            // Enable data label
                            dataLabelSettings: DataLabelSettings(isVisible: true))
                      ]),

                  SizedBox(
                    height: 20,
                  ),
                  Divider(
                    indent: 0,
                    endIndent: 0,
                    color: Colors.black45,
                    thickness: 1,
                  ),
                  getDescriptionRow('Flights total', (numberOfPreviousFlights + numberOfFutureFlights).toString()),
                  getDescriptionRow('Previous flights', (numberOfPreviousFlights).toString()),
                  getDescriptionRow('Future flights', (numberOfFutureFlights).toString()),
                  getDescriptionRow('Total amount of money given', totalAmountOfMoneyGiven.toString() + ' KM'),
                  getDescriptionRow('Cities visited', citiesVisited),
                  getDescriptionRow('Upcoming trips', citiesToVisit),
                ],
              ),
            );
          },
        ));
  }

  Widget getDescriptionRow(String title, String descrption) {
    return Column(
      children: [
        Row(
          children: [
            SizedBox(
              width: 150,
              child: Text(
                title + ': ',
                style: TextStyle(
                  fontSize: 16,
                  color: Colors.black,
                ),
              ),
            ),
            SizedBox(width: 10),
            Flexible(
              child: Text(
                descrption,
                style: TextStyle(
                  fontSize: 16,
                  color: Colors.black,
                ),
              ),
            ),
          ],
        ),
        Divider(
          indent: 0,
          endIndent: 0,
          color: Colors.black45,
          thickness: 1,
        ),
      ],
    );
  }
}

class _FlightsStatsData {
  _FlightsStatsData(this.year, this.numberOfReservations);

  final String year;
  final int numberOfReservations;
}
