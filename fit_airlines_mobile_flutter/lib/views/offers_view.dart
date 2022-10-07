import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';

import 'components/fit_airlines_card.dart';

class OffersView extends StatefulWidget {
  const OffersView({Key? key}) : super(key: key);

  @override
  State<OffersView> createState() => _OffersViewState();
}

class _OffersViewState extends State<OffersView> {
  List<Offer> offers = [
    Offer('Offer 1'),
    Offer('Offer 2'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 3'),
    Offer('Offer 23'),
  ];

  void handleItemSelected() {}

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: ListView.builder(
        itemCount: offers.length,
        itemBuilder: (context, index) {
          Offer item = offers[index];

          return FitAirlinesCard(
            item.name,
            Image.asset(
              'assets/images/offer-placeholder.png',
              fit: BoxFit.cover,
            ),
          );
        },
      ),
    );
  }
}

class Offer {
  String name;

  Offer(this.name);
}
