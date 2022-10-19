import 'package:fit_airlines_mobile_flutter/views/drawer/fit_drawer.dart';
import 'package:fit_airlines_mobile_flutter/views/offers_view.dart';
import 'package:flutter/material.dart';

class HomeViewWithDrawer extends StatefulWidget {
  const HomeViewWithDrawer({Key? key}) : super(key: key);

  @override
  State<HomeViewWithDrawer> createState() => _HomeViewWithDrawerState();
}

class _HomeViewWithDrawerState extends State<HomeViewWithDrawer> {
  @override
  Widget build(BuildContext context) {
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
        body: OffersView());
  }
}

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
    // TODO: JR implement buildResults
    return Text('BUILD RESULTS');
  }

  @override
  Widget buildSuggestions(BuildContext context) {
    // This method is called everytime the search term changes.
    // If you want to add search suggestions as the user enters their search term, this is the place to do that.
    return Column();
  }
}
