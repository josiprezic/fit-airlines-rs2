import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';

class Reservation {
  Flight flight;
  FlightSeat? outboundSeat;
  FlightSeat? inboundSeat;
  bool isPaymentSuccessful = false;

  Reservation(this.flight);
}
