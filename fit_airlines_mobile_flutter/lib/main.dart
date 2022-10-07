import 'package:fit_airlines_mobile_flutter/views/flights_view.dart';
import 'package:fit_airlines_mobile_flutter/views/offers_view.dart';
import 'package:fit_airlines_mobile_flutter/views/profile_view.dart';
import 'package:fit_airlines_mobile_flutter/views/settings_view.dart';
import 'package:flutter/material.dart';
import 'views/home_view.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();
  runApp(
    MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const HomeView(),
      routes: {
        //'/loading':(context) =? Loading();
        '/offers': (context) => OffersView(),
        '/flights': (context) => FlightsView(),
        '/settings': (context) => SettingsView(),
        '/profile': (context) => ProfileView(),
      },
    ),
  );
}
