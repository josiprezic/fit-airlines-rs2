import 'dart:convert';

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

enum FlightTabs { recommendedFlights, nextFlights }

class _FlightsViewState extends State<FlightsView> {
  FlightTabs _selectedSegment = FlightTabs.nextFlights;
  bool get isNextFlightsShown => (_selectedSegment == FlightTabs.nextFlights);

  List<TransportFlight> get displayedFlights => isNextFlightsShown ? nextFlights : recommendedFlights;
  List<TransportFlight> nextFlights = [];
  List<TransportFlight> recommendedFlights = [];

  FlightService flightService = FlightService();
  TransportOffer? offer;
  var isLoading = false;

  void handleItemSelected(int itemIndex) {
    print('Flight item clicked $itemIndex');
    Navigator.of(context).pushNamed('/flight_details', arguments: {'flight': displayedFlights[itemIndex]});
  }

  Future<List<TransportFlight>> getData() async {
    isLoading = true;
    var resultR = await flightService.getRecommendedFlights(loadPictures: true);
    this.recommendedFlights = resultR;
    List<TransportFlight> resultF = [];
    if (offer?.offerId == null) {
      resultF = await flightService.getAllObjects(loadPictures: true);
    } else {
      resultF = await flightService.getFutureFlights(offer!.offerId!);
    }

    this.nextFlights = resultF;
    isLoading = false;
    return [];
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ?? <String, dynamic>{}) as Map;

    offer = arguments['offer'];

    if (offer == null) {
      // TODO: Show all flights
      //displayedFlights = [];

    } else {
      // TODO: Show flighs for this offer
      //displayedFlights = [];
    }

    return Scaffold(
      appBar: AppBar(
        title: Text((offer?.offerName ?? '') + ' flights'),
        actions: _selectedSegment != FlightTabs.nextFlights
            ? null
            : [
                IconButton(
                  onPressed: () {
                    showSearch(
                      context: context,
                      delegate: FlightSearchDelegate(
                        nextFlights,
                        handleItemSelected,
                        this._selectedSegment,
                      ),
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
                        rightTitle: (item.price?.toString() ?? 'Unknown') + ' KM',
                        image: itemImage ??
                            Image.asset(
                              'assets/images/flight-placeholder.jpg',
                              fit: BoxFit.cover,
                            ),
                        isActive: true,
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
                    thumbColor: Colors.blue,
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
                      FlightTabs.recommendedFlights: Padding(
                        padding: EdgeInsets.symmetric(horizontal: 40, vertical: 10),
                        child: Text(
                          'Recommended 🔥',
                          style: TextStyle(color: CupertinoColors.white),
                        ),
                      ),
                      FlightTabs.nextFlights: Padding(
                        padding: EdgeInsets.symmetric(horizontal: 20),
                        child: Text(
                          'Next flights ⏰',
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

//
// MARK: - SEARCH DELEGATE
//

class FlightSearchDelegate extends SearchDelegate {
  FlightSearchDelegate(this.nextFlights, this.selectionHandler, this.currentTab);

  List<TransportFlight> nextFlights = [];
  Function(int) selectionHandler;
  FlightTabs currentTab;

  List<TransportFlight> filteredFlights = [];

  void updateFilteredOffers() {
    if (currentTab == FlightTabs.recommendedFlights) {
      filteredFlights = [];
    }

    if (query.isEmpty) {
      filteredFlights = List.from(nextFlights);
    }

    List<TransportFlight> tempFlights = List.from(nextFlights);

    tempFlights.removeWhere((element) {
      var lowQuery = query.toLowerCase();
      var lowCityName = element.city?.cityName?.toLowerCase();
      return !(lowCityName?.contains(lowQuery) ?? false);
    });

    filteredFlights = tempFlights;
  }

  @override
  List<Widget> buildActions(BuildContext context) {
    if (currentTab == FlightTabs.recommendedFlights) {
      return [];
    }

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
    if (currentTab == FlightTabs.recommendedFlights) {
      return Container(); // TODO: JR
    }

    return IconButton(
      icon: Icon(Icons.arrow_back),
      onPressed: () {
        close(context, null);
      },
    );
  }

  @override
  Widget buildResults(BuildContext context) {
    if (currentTab == FlightTabs.recommendedFlights) {
      return Container();
    }
    return getResult();
  }

  @override
  Widget buildSuggestions(BuildContext context) {
    if (currentTab == FlightTabs.recommendedFlights) {
      return Container();
    }
    return getResult();
  }

  Widget getResult() {
    if (currentTab == FlightTabs.recommendedFlights) {
      return Container();
    }
    updateFilteredOffers();

    return ListView.builder(
      itemCount: filteredFlights.length,
      itemBuilder: (context, index) {
        var item = filteredFlights[index];
        return FitAirlinesCard(
          title: item.city?.cityName ?? 'Unknown',
          image: getImage(item),
          isActive: item.isInFuture,
          onCardClick: () {
            var realIndex = nextFlights.indexWhere((element) => element.flightId == filteredFlights[index].flightId);
            selectionHandler(realIndex);
          },
        );
      },
    );
  }

  Image getImage(TransportFlight item) {
    return ImageService.getImageFromByteData(item.picture) ??
        Image.memory(
          base64.decode(item.picture!),
          fit: BoxFit.cover,
        );
  }
}
