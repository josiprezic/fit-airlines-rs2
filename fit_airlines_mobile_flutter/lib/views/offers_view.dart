import 'dart:convert';
import 'dart:typed_data';

import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_offer.dart';
import 'package:fit_airlines_mobile_flutter/services/api/offer_service.dart';
import 'package:flutter/material.dart';
import '../models/offer.dart';
import 'dart:developer';
import 'components/fit_airlines_card.dart';

class OffersView extends StatefulWidget {
  const OffersView({Key? key}) : super(key: key);

  @override
  State<OffersView> createState() => _OffersViewState();
}

class _OffersViewState extends State<OffersView> {
  OfferService offerService = OfferService();
  List<TransportOffer> offers = [];

  Future<List<TransportOffer>> getData() async {
    print('START');
    offers = await offerService.getAllObjects(loadPictures: false);
    print('Offers count:' + offers.length.toString());
    return offers;
  }

  void handleItemSelected(int itemIndex) {
    print('Offer item clicked');
    Navigator.of(context).pushNamed('/flights', arguments: {'offer': offers[itemIndex]});
  }

  @override
  Widget build(BuildContext context) {
    return FutureBuilder<List<TransportOffer>>(
      future: getData(),
      initialData: [],
      builder: (context, snapshot) {
        // if (snapshot.data.isNotEmpty) {
        //   return Text('Loading');
        // }

        return Scaffold(
          body: ListView.builder(
            itemCount: offers.length,
            itemBuilder: (context, index) {
              TransportOffer item = offers[index];

              return FitAirlinesCard(
                title: item.offerName ?? 'Unknown',
                image: getImage(item),
                onCardClick: () {
                  handleItemSelected(index);
                },
              );
            },
          ),
        );
      },
    );
  }

  Image getImage(TransportOffer item) {
    if (item.picture == null) {
      return Image.asset(
        'assets/images/offer-placeholder.jpg',
        fit: BoxFit.cover,
      );
    } else {
      return Image.memory(
        base64.decode(item.picture!),
        fit: BoxFit.cover,
      );
    }
  }
}
