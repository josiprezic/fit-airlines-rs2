import 'dart:math';

import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class SeatReservationView extends StatefulWidget {
  const SeatReservationView({Key? key}) : super(key: key);

  @override
  State<SeatReservationView> createState() => _SeatReservationViewState();
}

enum FlightDirection { outbound, inbound }

class FlightSeat {
  int row;
  int column;
  bool available;
  bool selected;

  FlightSeat(this.row, this.column, this.available, {this.selected = false});

  int getSeatNumber() {
    int seatNumber = ((row) * 6) + column;
    return seatNumber;
  }
}

class _SeatReservationViewState extends State<SeatReservationView> {
  Flight? flight;
  FlightDirection _selectedSegment = FlightDirection.outbound;

  int flightCapacity = 180;
  int numberOfSeatsInRow = 6;

  late int numberOfRows = flightCapacity ~/ numberOfSeatsInRow;

  late List<List<FlightSeat>> seats =
      List<List<FlightSeat>>.generate(numberOfRows, (rowIndex) {
    return List<FlightSeat>.generate(numberOfSeatsInRow, (columnIndex) {
      final randomBoolean = Random().nextBool();
      bool isSeatAvailable = randomBoolean;
      return FlightSeat(rowIndex + 1, columnIndex + 1, isSeatAvailable);
    });
  });

  FlightSeat? selectedSeat;

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
        backgroundColor: Colors.grey,
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
        // TODO: SZEF JR TUTAJ MAMY _selectedSegment i preko toga mijenjamo sta zelimo prikazati

        SizedBox(
          width: double.infinity,
          child: getTabButtonsView(),
        ),

        SizedBox(
          width: double.infinity,
          child: Column(
            children: [
              getSelectedSeatRowView(),
              FitHorizontalDivider(),
              getSeatRowHeader(),
              FitHorizontalDivider(),
            ],
          ),
        ),

        Expanded(
          child: ListView.builder(
            itemCount: seats.length,
            itemBuilder: (context, rowIndex) {
              return Container(
                width: double.maxFinite,
                child: getSeatRow(rowIndex),
              );
            },
          ),
        ),
      ],
    );
  }

  Widget getTabButtonsView() {
    return CupertinoSlidingSegmentedControl<FlightDirection>(
      backgroundColor: CupertinoColors.systemGrey2,
      thumbColor: Colors.green,
      // This represents the currently selected segmented control.
      groupValue: _selectedSegment,
      // Callback that sets the selected segmented control.
      onValueChanged: (FlightDirection? value) {
        if (value != null) {
          setState(() {
            print('TODO: Handle tab changed');
            _selectedSegment = value;
          });
        }
      },
      children: const <FlightDirection, Widget>{
        FlightDirection.outbound: Padding(
          padding: EdgeInsets.symmetric(horizontal: 40, vertical: 10),
          child: Text(
            'Outbound',
            style: TextStyle(color: CupertinoColors.white),
          ),
        ),
        FlightDirection.inbound: Padding(
          padding: EdgeInsets.symmetric(horizontal: 20),
          child: Text(
            'Inbound',
            style: TextStyle(color: CupertinoColors.white),
          ),
        ),
      },
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
              'A1',
              style: TextStyle(fontSize: 20),
            ),
          ],
        ),
      ),
    );
  }

  Widget getSeatRowHeader() {
    return Row(
      children: [
        getSeatRowHeaderItem('A'),
        getSeatRowHeaderItem('B'),
        getSeatRowHeaderItem('C'),
        getSeatSpacer(),
        getSeatRowHeaderItem('D'),
        getSeatRowHeaderItem('E'),
        getSeatRowHeaderItem('F'),
      ],
    );
  }

  Widget getSeatRowHeaderItem(String rowName) {
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
            rowName,
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
        .map((e) => getSeat(seats[rowIndex][e].available))
        .toList();

    // Empty space in the middle of the left and right part of the row
    rowItems.insert(3, getSeatSpacer(rowNumberString: rowNumberString));

    return Row(children: rowItems);
  }

  Widget getSeat(bool available, {bool selected = false}) {
    return Expanded(
      child: Padding(
        padding: const EdgeInsets.all(3.0),
        child: AspectRatio(
          aspectRatio: 1,
          child: OutlinedButton(
            onPressed: null,
            style: OutlinedButton.styleFrom(
              backgroundColor: available ? Colors.blue : Colors.red,
              side: BorderSide(color: Colors.black, width: 2),
            ),
            child: Icon(Icons.event_seat),
          ),
        ),
      ),
    );
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
