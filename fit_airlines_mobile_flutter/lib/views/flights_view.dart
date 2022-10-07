import 'package:fit_airlines_mobile_flutter/models/offer.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_airlines_card.dart';
import 'package:flutter/material.dart';

class FlightsView extends StatefulWidget {
  const FlightsView({Key? key}) : super(key: key);

  @override
  State<FlightsView> createState() => _FlightsViewState();
}

class _FlightsViewState extends State<FlightsView> {
  Offer? offer;

  List<Flight> getFlightsForOffer(Offer offer) {
    return [
      Flight('Flight 1 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 2 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 3 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 4 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 5 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 6 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 7 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 8 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 9 (' + offer.name + ')', '123.45 BAM'),
      Flight('Flight 10 (' + offer.name + ')', '123.45 BAM'),
    ];
  }

  void handleItemSelected(int itemIndex) {
    print('Flight item clicked $itemIndex');
    //Navigator.of(context)
    //    .pushNamed('/flights', arguments: {'offer': offers[itemIndex]});
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ??
        <String, dynamic>{}) as Map;

    offer = arguments['offer'];

    List<Flight> displayedFlights = [];

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
        title: Text('Flights'),
      ),
      body: ListView.builder(
        itemCount: displayedFlights.length,
        itemBuilder: (context, index) {
          Flight item = displayedFlights[index];

          return FitAirlinesCard(
            title: item.name,
            rightTitle: item.price,
            image: Image.asset(
              'assets/images/offer-placeholder.png', // TODO: JR change flights default image
              fit: BoxFit.cover,
            ),
            onCardClick: () {
              handleItemSelected(index);
            },
          );
        },
      ),
    );
  }
}

class Flight {
  String name;
  String price;

  Flight(this.name, this.price);
}
