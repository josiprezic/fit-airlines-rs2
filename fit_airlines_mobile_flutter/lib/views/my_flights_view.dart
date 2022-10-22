import 'dart:convert';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reservation.dart';
import 'package:fit_airlines_mobile_flutter/services/api/flight_service.dart';
import 'package:fit_airlines_mobile_flutter/services/image_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_airlines_card.dart';
import 'package:fit_airlines_mobile_flutter/views/components/loading_view.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class MyFlightsView extends StatefulWidget {
  const MyFlightsView({Key? key}) : super(key: key);

  @override
  State<MyFlightsView> createState() => _MyFlightsViewState();
}

enum MyFlightsTabs { upcoming, previous }

class _MyFlightsViewState extends State<MyFlightsView> {
  MyFlightsTabs _selectedSegment = MyFlightsTabs.upcoming;
  bool get isUpcomingShown => _selectedSegment == MyFlightsTabs.upcoming;

  List<TransportReservation> upcomingReservations = [];
  List<TransportReservation> previousReservations = [];

  // TODO: JR SZEF to be set
  List<TransportReservation> get displayedReservations => isUpcomingShown ? upcomingReservations : previousReservations;

  void handleItemSelected(int index) {
    print('handleItemSelected');

    Navigator.of(context).pushNamed('/ticket_purchase_confirmation', arguments: {
      'reservation': displayedReservations[index],
      'show_back_button': true,
    });
  }

  var flightsService = FlightService();
  var isLoading = false;

  Future<List<TransportReservation>> getData() async {
    isLoading = true;
    var allUserReservations = await flightsService.getReservationsWithFlightsForCurrentUser();
    upcomingReservations = List.from(allUserReservations);
    previousReservations = List.from(allUserReservations);

    upcomingReservations.removeWhere((reservation) {
      return !(reservation?.flight?.isInFuture ?? false);
    });

    previousReservations.removeWhere((reservation) {
      return (reservation?.flight?.isInFuture ?? false);
    });
    isLoading = false;
    return displayedReservations;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('My Flights'),
      ),
      body: FutureBuilder<List<TransportReservation>>(
          future: getData(),
          builder: (context, snapshot) {
            if (isLoading) {
              return LoadingView();
            }
            return CupertinoPageScaffold(
              backgroundColor: Colors.white,
              child: Column(
                children: [
                  Expanded(
                    child: ListView.builder(
                      itemCount: displayedReservations.length,
                      itemBuilder: (context, index) {
                        TransportReservation item = displayedReservations[index];

                        return FitAirlinesCard(
                          title: item.flight?.city?.cityName ?? 'No city name',
                          rightTitle: (item.flight?.price?.toString() ?? '-') + ' KM',
                          image: getImage(item),
                          onCardClick: () {
                            handleItemSelected(index);
                          },
                        );
                      },
                    ),
                  ),
                  SizedBox(
                    width: double.infinity,
                    child: CupertinoSlidingSegmentedControl<MyFlightsTabs>(
                      backgroundColor: CupertinoColors.systemGrey2,
                      thumbColor: Colors.blue,
                      // This represents the currently selected segmented control.
                      groupValue: _selectedSegment,
                      // Callback that sets the selected segmented control.
                      onValueChanged: (MyFlightsTabs? value) {
                        if (value != null) {
                          print('TODO: Handle tab changed');
                          setState(() {
                            _selectedSegment = value;
                          });
                        }
                      },
                      children: const <MyFlightsTabs, Widget>{
                        MyFlightsTabs.upcoming: Padding(
                          padding: EdgeInsets.symmetric(horizontal: 40, vertical: 10),
                          child: Text(
                            'Upcoming flights',
                            style: TextStyle(color: CupertinoColors.white),
                          ),
                        ),
                        MyFlightsTabs.previous: Padding(
                          padding: EdgeInsets.symmetric(horizontal: 20),
                          child: Text(
                            'Previous flights',
                            style: TextStyle(color: CupertinoColors.white),
                          ),
                        ),
                      },
                    ),
                  ),
                ],
              ),
            );
          }),
    );
  }

  Image getImage(TransportReservation item) {
    return ImageService.getImageFromByteData(item.flight?.picture) ??
        Image.memory(
          base64.decode(item.flight!.picture!),
          fit: BoxFit.cover,
        );
  }
}
