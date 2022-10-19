import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:flutter/material.dart';

class FitFlightSeatView extends StatelessWidget {
  FlightSeat flightSeat;
  Function handleSeatSelected;

  FitFlightSeatView(
    this.flightSeat,
    this.handleSeatSelected(FlightSeat flightSeat),
  );

  @override
  Widget build(BuildContext context) {
    Color seatColor = Colors.red;
    Color foregroundColor = Colors.black45;
    double borderWidth = 2;

    if (flightSeat.available) {
      if (flightSeat.selected) {
        seatColor = Colors.yellow;
        foregroundColor = Colors.black;
        borderWidth = 6;
      } else {
        seatColor = Colors.green;
        foregroundColor = Colors.black54;
      }
    } else {
      seatColor = Colors.red;
      foregroundColor = Colors.black54;
    }

    return Expanded(
      child: Padding(
        padding: const EdgeInsets.all(3.0),
        child: AspectRatio(
          aspectRatio: 1,
          child: OutlinedButton(
            onPressed: () {
              handleSeatSelected(flightSeat);
            },
            style: OutlinedButton.styleFrom(
              backgroundColor: seatColor,
              side: BorderSide(color: Colors.black, width: borderWidth),
            ),
            child: Icon(
              Icons.event_seat,
              color: foregroundColor,
            ),
          ),
        ),
      ),
    );
  }
}
