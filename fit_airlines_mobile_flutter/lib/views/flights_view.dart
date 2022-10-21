import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_flight.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_offer.dart';
import 'package:fit_airlines_mobile_flutter/services/api/flight_service.dart';
import 'package:fit_airlines_mobile_flutter/services/image_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_airlines_card.dart';
import 'package:fit_airlines_mobile_flutter/views/components/loading_view.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class FlightsView extends StatefulWidget {
  const FlightsView({Key? key}) : super(key: key);

  @override
  State<FlightsView> createState() => _FlightsViewState();
}

enum FlightTabs { bestDeals, nextFlights }

class _FlightsViewState extends State<FlightsView> {
  List<TransportFlight> displayedFlights = [];
  FlightTabs _selectedSegment = FlightTabs.nextFlights;

  TransportOffer? offer;
  FlightService flightService = FlightService();

  void handleItemSelected(int itemIndex) {
    print('Flight item clicked $itemIndex');
    Navigator.of(context).pushNamed('/flight_details', arguments: {'flight': displayedFlights[itemIndex]});
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ?? <String, dynamic>{}) as Map;

    offer = arguments['offer'];

    if (offer == null) {
      // TODO: Show all flights
      displayedFlights = [];
    } else {
      // TODO: Show flighs for this offer
      displayedFlights = [];
    }

    var isLoading = false;
    Future<List<TransportFlight>> getData() async {
      // TODO: JR
      isLoading = true;
      var result = await flightService.getAllObjects(loadPictures: true);
      isLoading = false;
      this.displayedFlights = result;
      return result;
    }

    String test = 'Flights for ' + (offer?.offerName ?? '');

    return Scaffold(
      appBar: AppBar(
        title: Text((offer?.offerName ?? '') + ' flights'),
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
      body: FutureBuilder<List<TransportFlight>>(
        future: getData(),
        initialData: [],
        builder: (context, response) {
          if (isLoading) {
            return LoadingView();
          }

          return CupertinoPageScaffold(
            backgroundColor: Colors.white,
            child: Column(
              children: [
                // TODO: SZEF JR TUTAJ MAMY _selectedSegment i preko toga mijenjamo sta zelimo prikazati

                Expanded(
                  child: ListView.builder(
                    itemCount: displayedFlights.length,
                    itemBuilder: (context, index) {
                      TransportFlight item = displayedFlights[index];
                      Image? itemImage = ImageService.getImageFromByteData(item.picture);

                      return FitAirlinesCard(
                        title: item.city?.cityName ?? 'TODO',
                        rightTitle: item.price?.toString() ?? 'Unknown',
                        image: itemImage ??
                            Image.asset(
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
          );
        },
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
