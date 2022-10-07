import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';

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
      //appBar: AppBar(title: Text('Offers')),
      body: ListView.builder(
        itemCount: offers.length,
        itemBuilder: (context, index) {
          Offer item = offers[index];

          return Container(
            height: 150,
            margin: EdgeInsets.only(left: 10, top: 10, right: 10),
            child: Stack(
              children: [
                Positioned.fill(
                  child: ClipRRect(
                    borderRadius: BorderRadius.circular(10),
                    child: Image.asset(
                      'assets/images/offer-placeholder.png',
                      fit: BoxFit.cover,
                    ),
                  ),
                ),
                Positioned(
                  bottom: 0,
                  left: 0,
                  right: 0,
                  top: 0,
                  child: Container(
                    height: 120,
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.only(
                        bottomLeft: Radius.circular(10),
                        bottomRight: Radius.circular(10),
                      ),
                      gradient: LinearGradient(
                        begin: Alignment.bottomCenter,
                        end: Alignment.topCenter,
                        colors: [
                          Colors.black.withOpacity(0.8),
                          Colors.transparent,
                          Colors.transparent,
                        ],
                      ),
                    ),
                  ),
                ),
                Positioned(
                  bottom: 0,
                  left: 0,
                  child: Row(
                    children: [
                      Container(
                        padding: EdgeInsets.all(10),
                        child: Text(
                          item.name,
                          style: TextStyle(fontSize: 18, color: Colors.white),
                        ),
                      )
                    ],
                  ),
                )
              ],
            ),
          );
        },
      ),
    );
  }
}

class FitAirlinesCard extends StatelessWidget {
  //const FitAirlinesCard({Key? key});// : super(key: key);

  String title;
  Image image;

  FitAirlinesCard(this.title, this.image);

  @override
  Widget build(BuildContext context) {
    return Container();
  }
}

class Offer {
  String name;

  Offer(this.name);
}
