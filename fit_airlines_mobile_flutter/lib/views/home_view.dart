import 'package:fit_airlines_mobile_flutter/views/components/fit_airlines_card.dart';
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
    return OffersView();
  }
}
