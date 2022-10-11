import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';
import '../models/offer.dart';

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
    Offer('Offer 4'),
    Offer('Offer 5'),
    Offer('Offer 6'),
    Offer('Offer 7'),
    Offer('Offer 8'),
    Offer('Offer 9'),
    Offer('Offer 10'),
  ];

  void handleItemSelected(int itemIndex) {
    print('Offer item clicked');
    Navigator.of(context)
        .pushNamed('/flights', arguments: {'offer': offers[itemIndex]});
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: ListView.builder(
        itemCount: offers.length,
        itemBuilder: (context, index) {
          Offer item = offers[index];

          return FitAirlinesCard(
            title: item.name,
            image: Image.asset(
              'assets/images/offer-placeholder.jpg',
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
