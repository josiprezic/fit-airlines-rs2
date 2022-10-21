import 'package:fit_airlines_mobile_flutter/views/about.dart';
import 'package:fit_airlines_mobile_flutter/views/change_membership_type_view.dart';
import 'package:fit_airlines_mobile_flutter/views/change_password_view.dart';
import 'package:fit_airlines_mobile_flutter/views/flight_details_view.dart';
import 'package:fit_airlines_mobile_flutter/views/flights_view.dart';
import 'package:fit_airlines_mobile_flutter/views/home_view.dart';
import 'package:fit_airlines_mobile_flutter/views/login_view.dart';
import 'package:fit_airlines_mobile_flutter/views/my_flights_view.dart';
import 'package:fit_airlines_mobile_flutter/views/my_stats_view.dart';
import 'package:fit_airlines_mobile_flutter/views/offers_view.dart';
import 'package:fit_airlines_mobile_flutter/views/profile_view.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/main_seat_reservation_view.dart';
import 'package:fit_airlines_mobile_flutter/views/ticket_purchase_confirmation_view.dart';
import 'package:fit_airlines_mobile_flutter/views/ticket_reservation_view.dart';
import 'package:flutter/material.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();
  runApp(
    MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: HomeViewWithDrawer(), // LoginView(),
      routes: {
        '/offers': (context) => OffersView(),
        '/flights': (context) => FlightsView(),
        '/stats': (context) => MyStatsView(),
        '/flight_details': (context) => FlightDetailsView(),
        '/ticket_reservation': (context) => TicketReservationView(),
        '/seat_reservation': (context) => SeatReservationView(),
        '/ticket_purchase_confirmation': (context) =>
            TicketPurchaseConfirmationView(),
        '/profile': (context) => ProfileView(),
        '/about': (context) => AboutView(),
        '/my_flights': (context) => MyFlightsView(),
        '/login': (context) => LoginView(),
        '/change_password': (context) => ChangePasswordView(),
        '/change_membership_type': (context) => ChangeMembershipTypeView(),
      },
    ),
  );
}
