import 'dart:math';
import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:fit_airlines_mobile_flutter/models/reservation.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/fit_seat_layout_column_header_view.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/fit_seat_layout_view.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/fit_seat_reservation_tab_buttons_view.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/fit_selected_seat_header_row_view.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class SeatReservationView extends StatefulWidget {
  const SeatReservationView({Key? key}) : super(key: key);

  @override
  State<SeatReservationView> createState() => _SeatReservationViewState();
}

enum FlightDirection { outbound, inbound }

class _SeatReservationViewState extends State<SeatReservationView> {
  //
  // MARK: - PROPERTIES
  //

  // general
  Reservation? reservation; // set by previous screen
  late Function(Reservation)
      seatSelectionCompletionHandler; // set by previous screen

  FlightDirection selectedTab = FlightDirection.outbound;
  bool get isOutboundTab =>
      displayedFlightDirection == FlightDirection.outbound;
  bool get isReserveButtonEnabled =>
      selectedSeatInbound != null && selectedSeatOutbound != null;

  // seats
  late List<List<FlightSeat>> _outboundSeats = FitTemp.mockOutboundSeats;
  late List<List<FlightSeat>> _inboundSeats = FitTemp.mockInboundSeats;
  FlightSeat? selectedSeatOutbound;
  FlightSeat? selectedSeatInbound;

  // plane
  late int flightCapacity = reservation?.flight.capacity ?? 0;
  int numberOfSeatsInRow = 6; // TODO: Move to Constants
  late int numberOfRows = flightCapacity ~/ numberOfSeatsInRow;

  // computed properties
  List<List<FlightSeat>> get displayedSeats =>
      isOutboundTab ? _outboundSeats : _inboundSeats;

  FlightDirection get displayedFlightDirection => selectedTab;

  FlightSeat? get displayedSelectedSeat =>
      isOutboundTab ? selectedSeatOutbound : selectedSeatInbound;

  String get displayedSelectedSeatString =>
      displayedSelectedSeat?.getSeatString() ?? 'N/A';

  //
  // MARK - HANDLERS
  //

  void handleReserveSeatsButtonPressed() {
    print('TODO: JR SZEF handleReserveSeatsButtonPressed');
    if (reservation != null &&
        reservation!.outboundSeat != null &&
        reservation!.inboundSeat != null) {
      Navigator.of(context).pop();
      seatSelectionCompletionHandler(reservation!);
    }
  }

  void handleSeatSelected(FlightSeat selectedSeat, FlightDirection? direction) {
    // set initial value
    bool isOutboundValue = isOutboundTab;

    // override if required (used for initial values if seats are already chosen by that user)
    if (direction != null) {
      isOutboundValue = direction == FlightDirection.outbound;
    } else {
      // handle new seat selection triggered by the used on the currently opened tab
      unselectAllSeatsForCurrentTab();
    }

    // blocks selecting seats that are already taken (red ones)
    if (!selectedSeat.available) {
      return;
    }

    // all checks passed, selecting seats ...
    setState(() {
      int rowIndex = selectedSeat.row - 1;
      int colIndex = selectedSeat.column - 1;

      if (isOutboundValue) {
        selectedSeatOutbound = selectedSeat;
        _outboundSeats[rowIndex][colIndex].selected = true;
        reservation?.outboundSeat = selectedSeat;
      } else {
        selectedSeatInbound = selectedSeat;
        _inboundSeats[rowIndex][colIndex].selected = true;
        reservation?.inboundSeat = selectedSeat;
      }
    });
  }

  void handleSelectedTabChanged(FlightDirection flightDirection) {
    setState(() {
      selectedTab = flightDirection;
    });
  }

  //
  // MARK: - HELPERS
  //

  void unselectAllSeatsForCurrentTab() {
    if (isOutboundTab) {
      _outboundSeats.forEach((seatRow) {
        seatRow.forEach((seat) {
          seat.selected = false;
        });
      });
    } else {
      _inboundSeats.forEach((seatRow) {
        seatRow.forEach((seat) {
          seat.selected = false;
        });
      });
    }
  }

  String getReserveButtonText() {
    if (selectedSeatInbound == null && selectedSeatOutbound == null) {
      return 'Please select seats';
    } else if (selectedSeatOutbound == null) {
      return 'Please select outbound seat';
    } else if (selectedSeatInbound == null) {
      return 'Please select inbound seat';
    } else {
      return 'Reserve selected seats';
    }
  }

  //
  // MARK: - WIDGETS
  //

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ??
        <String, dynamic>{}) as Map;

    reservation = arguments['reservation'];

    if (reservation?.outboundSeat != null && reservation?.inboundSeat != null) {
      setState(() {
        handleSeatSelected(
          reservation!.inboundSeat!,
          FlightDirection.inbound,
        );
        handleSeatSelected(
          reservation!.outboundSeat!,
          FlightDirection.outbound,
        );
        seatSelectionCompletionHandler = arguments['seatSelectionHandler'];
      });
    }

    if (reservation == null) {
      // Handle reservation not available
      return Scaffold(
        body: Center(
          child: Text('Error: reservation = null'),
        ),
      );
    } else {
      // Handle flight available

      return Scaffold(
        appBar: appBar(),
        body: CupertinoPageScaffold(
          backgroundColor: Colors.white,
          child: getTabContentView(),
        ),
      );
    }
  }

  Widget getTabContentView() {
    return Column(
      children: [
        getTabButtonsView(),
        getSeatLayoutHeaderView(),
        getFitSeatLayoutView(),
        getReserveSelectedSeatsButtonView(),
      ],
    );
  }

  AppBar appBar() {
    return AppBar(
      title: Text('Seat reservation'),
    );
  }

  Widget getTabButtonsView() {
    return FitSeatReservationTabButtonsView(
      selectedTab,
      handleSelectedTabChanged,
    );
  }

  Widget getSeatLayoutHeaderView() {
    return SizedBox(
      width: double.infinity,
      child: Column(
        children: [
          FitSelectedSeatHeaderRowView(displayedSelectedSeatString),
          FitHorizontalDivider(),
          FitSeatLayoutColumnHeaderView(),
          FitHorizontalDivider(),
        ],
      ),
    );
  }

  Widget getFitSeatLayoutView() {
    return FitSeatLayoutView(
      displayedSeats,
      (selectedSeat) => handleSeatSelected(
        selectedSeat,
        null,
      ),
    );
  }

  Widget getReserveSelectedSeatsButtonView() {
    return SizedBox(
      height: 60,
      width: double.infinity,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: TextButton(
          style: TextButton.styleFrom(
            foregroundColor: Colors.white,
            backgroundColor: isReserveButtonEnabled ? Colors.blue : Colors.grey,
          ),
          onPressed: this.isReserveButtonEnabled
              ? handleReserveSeatsButtonPressed
              : null,
          child: Text(getReserveButtonText()),
        ),
      ),
    );
  }
}
