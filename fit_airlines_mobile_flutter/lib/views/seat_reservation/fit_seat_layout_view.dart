import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/fit_flight_seat_view.dart';
import 'package:flutter/material.dart';

class FitSeatLayoutView extends StatelessWidget {
  List<List<FlightSeat>> seats;
  Function(FlightSeat) handleSeatSelected;

  FitSeatLayoutView(this.seats, this.handleSeatSelected);

  @override
  Widget build(BuildContext context) {
    return Expanded(
      child: ListView.builder(
        itemCount: seats.length,
        itemBuilder: (context, rowIndex) {
          return Container(
            width: double.maxFinite,
            child: getSeatRow(rowIndex),
          );
        },
      ),
    );
  }

  Widget getSeatRow(int rowIndex) {
    int rowNumber = rowIndex + 1;
    String rowNumberString = rowNumber.toString();

    // Left and right site seats
    List<Widget> rowItems = Iterable<int>.generate(6)
        .map((columnIndex) => seats[rowIndex][columnIndex])
        .map((flightSeat) => getSeat(flightSeat))
        .toList();

    // Empty space in the middle of the left and right part of the row
    rowItems.insert(3, getSeatSpacer(rowNumberString: rowNumberString));

    return Row(children: rowItems);
  }

  Widget getSeat(FlightSeat flightSeat) {
    return FitFlightSeatView(flightSeat, (flightSeat) {
      handleSeatSelected(flightSeat);
    });
  }

  Widget getSeatSpacer({String rowNumberString = ''}) {
    return SizedBox(
      width: 50,
      child: Center(
        child: Text(
          rowNumberString,
          style: TextStyle(fontSize: 18),
        ),
      ),
    );
  }
}
