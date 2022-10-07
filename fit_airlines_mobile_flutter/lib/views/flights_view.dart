import 'package:flutter/material.dart';

class FlightsView extends StatefulWidget {
  const FlightsView({Key? key}) : super(key: key);

  @override
  State<FlightsView> createState() => _FlightsViewState();
}

class _FlightsViewState extends State<FlightsView> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Flights')),
      body: Center(
        child: Text('Flights'),
      ),
    );
  }
}
