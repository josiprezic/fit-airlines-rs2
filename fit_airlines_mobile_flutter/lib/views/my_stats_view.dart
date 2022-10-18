import 'package:flutter/material.dart';

class MyStatsView extends StatefulWidget {
  const MyStatsView({Key? key}) : super(key: key);

  @override
  State<MyStatsView> createState() => _MyStatsViewState();
}

class _MyStatsViewState extends State<MyStatsView> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('My Stats'),
      ),
      body: Center(
        child: Text('My stats'),
      ),
    );
  }
}
