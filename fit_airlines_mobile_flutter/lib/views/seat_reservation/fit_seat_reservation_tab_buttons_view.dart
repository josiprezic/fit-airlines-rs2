import 'package:fit_airlines_mobile_flutter/views/seat_reservation/main_seat_reservation_view.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class FitSeatReservationTabButtonsView extends StatelessWidget {
  FlightDirection _selectedSegment;
  Function(FlightDirection) handleSelectedTabChanged;

  FitSeatReservationTabButtonsView(
    this._selectedSegment,
    this.handleSelectedTabChanged,
  );

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      width: double.infinity,
      child: CupertinoSlidingSegmentedControl<FlightDirection>(
        backgroundColor: CupertinoColors.systemGrey2,
        thumbColor: Colors.green,
        // This represents the currently selected segmented control.
        groupValue: _selectedSegment,
        // Callback that sets the selected segmented control.
        onValueChanged: (FlightDirection? value) {
          if (value != null) {
            handleSelectedTabChanged(value);
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
      ),
    );
  }
}
