import 'dart:convert';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_offer.dart';
import 'package:fit_airlines_mobile_flutter/services/api/offer_service.dart';
import 'package:fit_airlines_mobile_flutter/services/image_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/loading_view.dart';
import 'package:fit_airlines_mobile_flutter/views/drawer/fit_drawer.dart';
import 'package:flutter/material.dart';
import 'components/fit_airlines_card.dart';

class OffersView extends StatefulWidget {
  const OffersView({Key? key}) : super(key: key);
  @override
  State<OffersView> createState() => _OffersViewState();
}

class _OffersViewState extends State<OffersView> {
  OfferService offerService = OfferService();
  List<TransportOffer> offers = [];
  bool isLoading = false;

  Future<List<TransportOffer>> getData() async {
    isLoading = true;
    offers = await offerService.getAllObjects(loadPictures: true);
    isLoading = false;
    return offers;
  }

  void handleItemSelected(int itemIndex) {
    Navigator.of(context).pushNamed('/flights', arguments: {'offer': offers[itemIndex]});
  }

  @override
  Widget build(BuildContext context) {
    return FutureBuilder<List<TransportOffer>>(
      future: getData(),
      initialData: [],
      builder: (context, snapshot) {
        if (snapshot.hasData == false) {
          return LoadingView();
        }

        return Scaffold(
          appBar: AppBar(
            title: Text('Offers'),
            actions: [
              IconButton(
                onPressed: () {
                  showSearch(
                    context: context,
                    delegate: OfferSearchDelegate(),
                  );
                },
                icon: Icon(Icons.search),
              )
            ],
          ),
          drawer: FitDrawer().getView(context),
          body: ListView.builder(
            itemCount: offers.length,
            itemBuilder: (context, index) {
              TransportOffer item = offers[index];
              return FitAirlinesCard(
                title: item.offerName ?? 'Unknown',
                image: getImage(item),
                isActive: item.isInFuture,
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

  //
  // MARK: - HELPERS
  //

  Image getImage(TransportOffer item) {
    return ImageService.getImageFromByteData(item.picture) ??
        Image.memory(
          base64.decode(item.picture!),
          fit: BoxFit.cover,
        );
  }
}

//
// MARK: - SEARCH DELEGATE
//

class OfferSearchDelegate extends SearchDelegate {
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
    return ListView.builder(
      itemCount: 3,
      itemBuilder: (context, index) {
        return FitAirlinesCard(
          title: 'Titleeeee',
          image: Image.asset('assets/images/offer-placeholder.png'),
          onCardClick: () {},
        );
      },
    );
  }

  @override
  Widget buildSuggestions(BuildContext context) {
    // This method is called everytime the search term changes.
    // If you want to add search suggestions as the user enters their search term, this is the place to do that.
    return ListView.builder(
      itemCount: 3,
      itemBuilder: (context, index) {
        return FitAirlinesCard(
          title: 'Titleeeee',
          image: Image.asset('assets/images/offer-placeholder.png'),
          onCardClick: () {},
        );
      },
    );
  }
}
