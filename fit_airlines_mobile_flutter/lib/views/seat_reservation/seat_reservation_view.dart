import 'dart:math';

import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/fit_flight_seat_view.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/fit_seat_reservation_tab_buttons_view.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class SeatReservationView extends StatefulWidget {
  const SeatReservationView({Key? key}) : super(key: key);

  @override
  State<SeatReservationView> createState() => _SeatReservationViewState();
}

enum FlightDirection { outbound, inbound }

class _SeatReservationViewState extends State<SeatReservationView> {
  Flight? flight;
  FlightDirection _selectedSegment = FlightDirection.outbound;

  int flightCapacity = 180;
  int numberOfSeatsInRow = 6;

  late int numberOfRows = flightCapacity ~/ numberOfSeatsInRow;

  late List<List<FlightSeat>> seats =
      List<List<FlightSeat>>.generate(numberOfRows, (rowIndex) {
    return List<FlightSeat>.generate(numberOfSeatsInRow, (columnIndex) {
      // TODO: JR SZEF remove random seat selection
      final randomBoolean = Random().nextBool();
      bool isSeatAvailable = randomBoolean;
      return FlightSeat(rowIndex + 1, columnIndex + 1, isSeatAvailable);
    });
  });

  FlightSeat? selectedSeat;
  String selectedSeatString = 'N/A';

  void handleSelectedTabChanged(FlightDirection flightDirection) {
    setState(() {
      print('TODO: Handle tab changed');
      _selectedSegment = flightDirection;
    });
  }

  void handleSeatSelected(FlightSeat selectedSeat) {
    print('handleSeatSelected');
    if (!selectedSeat.available) {
      return;
    }
    setState(() {
      int rowIndex = selectedSeat.row - 1;
      int colIndex = selectedSeat.column - 1;
      unselectAllSeats();
      this.seats[rowIndex][colIndex].selected = true;
      this.selectedSeat = selectedSeat;
      this.selectedSeatString = selectedSeat.getSeatString();
    });
  }

  void unselectAllSeats() {
    seats.forEach((seatRow) {
      seatRow.forEach((seat) {
        seat.selected = false;
      });
    });
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ??
        <String, dynamic>{}) as Map;

    flight = arguments['flight'];

    if (flight == null) {
      // TODO: JR Handle flight not available
    } else {
      // TODO: JR Handle flight available
    }

    String test = (flight?.name ?? '');

    return Scaffold(
      appBar: appBar(),
      body: CupertinoPageScaffold(
        backgroundColor: Colors.white,
        child: getTabContentView(),
      ),
    );
  }

  AppBar appBar() {
    return AppBar(
      title: Text('Seat reservation'),
    );
  }

  Widget getTabContentView() {
    return Column(
      children: [
        getTabButtonsView(),
        getSeatLayoutHeaderView(),
        getSeatsLayoutView()
      ],
    );
  }

  Widget getTabButtonsView() {
    return FitSeatReservationTabButtonsView(
      _selectedSegment,
      handleSelectedTabChanged,
    );
  }

  Widget getSeatLayoutHeaderView() {
    return SizedBox(
      width: double.infinity,
      child: Column(
        children: [
          getSelectedSeatRowView(),
          FitHorizontalDivider(),
          getSeatColumnHeader(),
          FitHorizontalDivider(),
        ],
      ),
    );
  }

  Widget getSeatsLayoutView() {
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

  Widget getSelectedSeatRowView() {
    return Padding(
      padding: const EdgeInsets.only(top: 10, bottom: 4),
      child: Center(
        child: Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              'Selected seat: ',
              style: TextStyle(fontSize: 20),
            ),
            Text(
              selectedSeatString,
              style: TextStyle(fontSize: 20),
            ),
          ],
        ),
      ),
    );
  }

  Widget getSeatColumnHeader() {
    List<Widget> columnHeaderItems = ['A', 'B', 'C', 'D', 'E', 'F']
        .map((columnName) => getSeatColumnHeaderItem(columnName))
        .toList();
    columnHeaderItems.insert(3, getSeatSpacer());
    return Row(children: columnHeaderItems);
  }

  Widget getSeatColumnHeaderItem(String columnName) {
    return Expanded(
      child: Padding(
        padding: const EdgeInsets.only(
          left: 3.0,
          right: 3.0,
          top: 10.0,
          bottom: 10.0,
        ),
        child: Center(
          child: Text(
            columnName,
            style: TextStyle(fontSize: 18),
          ),
        ),
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
