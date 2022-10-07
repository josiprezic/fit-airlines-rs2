import 'package:flutter/material.dart';

class OffersView extends StatefulWidget {
  const OffersView({Key? key}) : super(key: key);

  @override
  State<OffersView> createState() => _OffersViewState();
}

class _OffersViewState extends State<OffersView> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      //appBar: AppBar(title: Text('Offers')),
      body: Center(
        child: Text('Offers'),
      ),
    );
  }
}
