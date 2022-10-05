import 'package:flutter/material.dart';
import 'home_view.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();
  runApp(MaterialApp(
    title: 'Flutter Demo',
    theme: ThemeData(
      primarySwatch: Colors.blue,
    ),
    home: const HomeView(),
    routes: {
      // '/loading':(context) =? Loading();
    },
  ));
}
