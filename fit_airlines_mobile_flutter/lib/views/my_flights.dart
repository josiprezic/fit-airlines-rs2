import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_airlines_card.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import '../models/reservation.dart';

class MyFlightsView extends StatefulWidget {
  const MyFlightsView({Key? key}) : super(key: key);

  @override
  State<MyFlightsView> createState() => _MyFlightsViewState();
}

enum MyFlightsTabs { upcoming, previous }

class _MyFlightsViewState extends State<MyFlightsView> {
  MyFlightsTabs _selectedSegment = MyFlightsTabs.upcoming;
  bool get isUpcomingShown => _selectedSegment == MyFlightsTabs.upcoming;

  List<Reservation> upcomingReservations = FitTemp.mockedUpcomingReservations;
  List<Reservation> previousReservations = FitTemp.mockedPreviousReservations;

  // TODO: JR SZEF to be set
  List<Reservation> get displayedReservations =>
      isUpcomingShown ? upcomingReservations : previousReservations;

  void handleItemSelected(int index) {
    print('handleItemSelected');

    Navigator.of(context)
        .pushNamed('/ticket_purchase_confirmation', arguments: {
      'reservation': displayedReservations[index],
      'show_back_button': true,
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('My Flights'),
      ),
      body: CupertinoPageScaffold(
        backgroundColor: Colors.grey,
        child: Column(
          children: [
            Expanded(
              child: ListView.builder(
                itemCount: displayedReservations.length,
                itemBuilder: (context, index) {
                  Reservation item = displayedReservations[index];

                  return FitAirlinesCard(
                    title: item.flight.name,
                    rightTitle: item.flight.price,
                    image: Image.asset(
                      'assets/images/flight-placeholder.jpg',
                      fit: BoxFit.cover,
                    ),
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
                thumbColor: Colors.green,
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
      ),
    );
  }
}
