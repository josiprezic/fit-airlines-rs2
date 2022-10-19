import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/models/offer.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_airlines_card.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class FlightsView extends StatefulWidget {
  const FlightsView({Key? key}) : super(key: key);

  @override
  State<FlightsView> createState() => _FlightsViewState();
}

enum FlightTabs { bestDeals, nextFlights }

class _FlightsViewState extends State<FlightsView> {
  List<Flight> displayedFlights = [];
  FlightTabs _selectedSegment = FlightTabs.nextFlights;

  Offer? offer;

  List<Flight> getFlightsForOffer(Offer offer) {
    return [
      Flight('Flight 1 (' + offer.name + ')', '123.45 BAM', 90),
      Flight('Flight 2 (' + offer.name + ')', '123.45 BAM', 12),
      Flight('Flight 3 (' + offer.name + ')', '123.45 BAM', 18),
      Flight('Flight 4 (' + offer.name + ')', '123.45 BAM', 900),
      Flight('Flight 5 (' + offer.name + ')', '123.45 BAM', 180),
      Flight('Flight 6 (' + offer.name + ')', '123.45 BAM', 180),
      Flight('Flight 7 (' + offer.name + ')', '123.45 BAM', 180),
      Flight('Flight 8 (' + offer.name + ')', '123.45 BAM', 180),
      Flight('Flight 9 (' + offer.name + ')', '123.45 BAM', 180),
      Flight('Flight 10 (' + offer.name + ')', '123.45 BAM', 180),
    ];
  }

  void handleItemSelected(int itemIndex) {
    print('Flight item clicked $itemIndex');

    Navigator.of(context).pushNamed('/flight_details',
        arguments: {'flight': displayedFlights[itemIndex]});
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ??
        <String, dynamic>{}) as Map;

    offer = arguments['offer'];

    if (offer == null) {
      // TODO: Show all flights
      displayedFlights = [];
    } else {
      // TODO: Show flighs for this offer
      List<Flight> flights = getFlightsForOffer(offer!);
      displayedFlights = flights;
    }

    String test = 'Flights for ' + (offer?.name ?? '');

    return Scaffold(
      appBar: AppBar(
        title: Text((offer?.name ?? '') + ' flights'),
        actions: [
          IconButton(
            onPressed: () {
              showSearch(
                context: context,
                delegate: FlightSearchDelegate(),
              );
            },
            icon: Icon(Icons.search),
          )
        ],
      ),
      body: CupertinoPageScaffold(
        backgroundColor: Colors.grey,
        //navigationBar: CupertinoNavigationBar(
        //  automaticallyImplyLeading: false,
        // This Cupertino segmented control has the enum "Sky" as the type.
        //middle: SizedBox(width: double.infinity, child: Text('Siema')),
        //),
        child: Column(
          children: [
            // TODO: SZEF JR TUTAJ MAMY _selectedSegment i preko toga mijenjamo sta zelimo prikazati

            Expanded(
              child: ListView.builder(
                itemCount: displayedFlights.length,
                itemBuilder: (context, index) {
                  Flight item = displayedFlights[index];

                  return FitAirlinesCard(
                    title: item.name,
                    rightTitle: item.price,
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
              child: CupertinoSlidingSegmentedControl<FlightTabs>(
                backgroundColor: CupertinoColors.systemGrey2,
                thumbColor: Colors.green,
                // This represents the currently selected segmented control.
                groupValue: _selectedSegment,
                // Callback that sets the selected segmented control.
                onValueChanged: (FlightTabs? value) {
                  if (value != null) {
                    setState(() {
                      print('TODO: Handle tab changed');
                      _selectedSegment = value;
                    });
                  }
                },
                children: const <FlightTabs, Widget>{
                  FlightTabs.bestDeals: Padding(
                    padding: EdgeInsets.symmetric(horizontal: 40, vertical: 10),
                    child: Text(
                      'Best deals',
                      style: TextStyle(color: CupertinoColors.white),
                    ),
                  ),
                  FlightTabs.nextFlights: Padding(
                    padding: EdgeInsets.symmetric(horizontal: 20),
                    child: Text(
                      'Next flights',
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

class FlightSearchDelegate extends SearchDelegate {
  @override
  List<Widget> buildActions(BuildContext context) {
    return [
      IconButton(
        icon: Icon(Icons.clear),
        onPressed: () {
          if (query.isNotEmpty) {
            query = '';
          } else {
            close(context, null);
          }
        },
      ),
    ];
  }

  @override
  Widget buildLeading(BuildContext context) {
    return IconButton(
      icon: Icon(Icons.arrow_back),
      onPressed: () {
        close(context, null);
      },
    );
  }

  @override
  Widget buildResults(BuildContext context) {
    // TODO: implement buildResults
    return Text('BUILD RESULTS');
  }

  @override
  Widget buildSuggestions(BuildContext context) {
    // This method is called everytime the search term changes.
    // If you want to add search suggestions as the user enters their search term, this is the place to do that.
    return Column();
  }
}
