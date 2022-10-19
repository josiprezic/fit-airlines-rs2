import 'dart:math';
import 'package:fit_airlines_mobile_flutter/models/flight.dart';

import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:flutter/material.dart';

import '../models/reservation.dart';

class FitConstant {
  static FitColor color = FitColor();
  static FitPadding padding = FitPadding();
  static FitFontSize fontSize = FitFontSize();
}

class FitColor {
  static Color primary = Colors.blue;
}

class FitPadding {
  double screenEdge = 12.0;
}

class FitFontSize {
  double title = 20.0;
  double description = 10;
}

// TODO: JR SZEF to be removed
class FitTemp {
  static List<Reservation> mockedUpcomingReservations = getMockReservations();
  static List<Reservation> mockedPreviousReservations =
      getMockReservations().sublist(3, 6);

  static List<List<FlightSeat>> mockOutboundSeats =
      getRandomlyGeneratedMockSeats(numberOfRows: 100);
  static List<List<FlightSeat>> mockInboundSeats =
      getRandomlyGeneratedMockSeats(numberOfRows: 100);

  static List<List<FlightSeat>> getRandomlyGeneratedMockSeats(
      {required int numberOfRows, int numberOfSeatsInRow = 6}) {
    return List<List<FlightSeat>>.generate(numberOfRows, (rowIndex) {
      return List<FlightSeat>.generate(numberOfSeatsInRow, (columnIndex) {
        // TODO: JR SZEF remove random seat selection
        final randomBoolean = Random().nextBool();
        bool isSeatAvailable = randomBoolean;
        return FlightSeat(rowIndex + 1, columnIndex + 1, isSeatAvailable);
      });
    });
  }

  static List<Reservation> getMockReservations() {
    var result = [
      Reservation(
          Flight('Flight 1 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 90)),
      Reservation(
          Flight('Flight 2 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 12)),
      Reservation(
          Flight('Flight 3 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 18)),
      Reservation(
          Flight('Flight 4 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 900)),
      Reservation(
          Flight('Flight 5 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 180)),
      Reservation(
          Flight('Flight 6 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 180)),
      Reservation(
          Flight('Flight 1 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 90)),
      Reservation(
          Flight('Flight 2 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 12)),
      Reservation(
          Flight('Flight 3 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 18)),
      Reservation(
          Flight('Flight 4 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 900)),
      Reservation(
          Flight('Flight 5 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 180)),
      Reservation(
          Flight('Flight 6 (' + 'Barcelona, Spain' + ')', '123.45 BAM', 180)),
    ];

    result.map((e) {
      e.isPaymentSuccessful = Random().nextBool();
      e.outboundSeat = FlightSeat(2, 3, false);
      e.inboundSeat = FlightSeat(4, 5, false);
      return e;
    });

    return result;
  }

  static String loremIpsum =
      "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
}
