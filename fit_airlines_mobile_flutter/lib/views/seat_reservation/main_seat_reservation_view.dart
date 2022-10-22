import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:fit_airlines_mobile_flutter/models/reservation.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reservation.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reserved_seat.dart';
import 'package:fit_airlines_mobile_flutter/services/api/reserved_seat_service.dart';
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
  static int currentFlightId = 0;
}

enum FlightDirection { outbound, inbound }

class _SeatReservationViewState extends State<SeatReservationView> {
  //
  // MARK: - PROPERTIES
  //

  // general
  TransportReservation? reservation; // set by previous screen
  late Function(TransportReservation) seatSelectionCompletionHandler; // set by previous screen

  FlightDirection selectedTab = FlightDirection.outbound;
  bool get isOutboundTab => displayedFlightDirection == FlightDirection.outbound;
  bool get isReserveButtonEnabled => selectedSeatInbound != null && selectedSeatOutbound != null;

  // seats
  late List<List<FlightSeat>> _outboundSeats = [];
  late List<List<FlightSeat>> _inboundSeats = [];
  FlightSeat? selectedSeatOutbound;
  FlightSeat? selectedSeatInbound;

  // plane
  late int flightCapacity = reservation?.flight?.capacity ?? 0;
  int numberOfSeatsInRow = 6; // TODO: Move to Constants
  late int numberOfRows = flightCapacity ~/ numberOfSeatsInRow;

  // computed properties
  List<List<FlightSeat>> get displayedSeats => isOutboundTab ? _outboundSeats : _inboundSeats;
  FlightDirection get displayedFlightDirection => selectedTab;
  FlightSeat? get displayedSelectedSeat => isOutboundTab ? selectedSeatOutbound : selectedSeatInbound;
  String get displayedSelectedSeatString => displayedSelectedSeat?.getSeatString() ?? 'N/A';

  //
  // MARK - HANDLERS
  //

  void handleReserveSeatsButtonPressed() {
    print('TODO: JR SZEF handleReserveSeatsButtonPressed');
    if (reservation != null && reservation!.seatDeparture != null && reservation!.seatReturn != null) {
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
        reservation?.seatDeparture = selectedSeat.getSeatString();
        //TransportReservedSeat.from(selectedSeat, reservation?.reservationId? ?? 0, this.displayedFlightDirection);
      } else {
        selectedSeatInbound = selectedSeat;
        _inboundSeats[rowIndex][colIndex].selected = true;
        reservation?.seatReturn = selectedSeat.getSeatString();
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

  var isLoading = false;
  var reservedSeatService = ReservedSeatService();

  late final Future<List<List<FlightSeat>>> myFuture;

  @override
  void initState() {
    myFuture = getData();
  }

  Future<List<List<FlightSeat>>> getData() async {
    isLoading = true;
    var flightReservedSeats = await reservedSeatService.getReservedSeatsForFlight(SeatReservationView.currentFlightId);
    var outboundSeatReservations = List<TransportReservedSeat>.from(flightReservedSeats);
    var inboundSeatReservations = List<TransportReservedSeat>.from(flightReservedSeats);
    outboundSeatReservations.removeWhere((element) => element.direction == '2');
    inboundSeatReservations.removeWhere((element) => element.direction == '1');

    this._inboundSeats = FitHelper.generateReservedSeatsTable(capacity: flightCapacity, seatReservations: inboundSeatReservations);
    this._outboundSeats = FitHelper.generateReservedSeatsTable(capacity: flightCapacity, seatReservations: outboundSeatReservations);

    selectPreviouslySelectedSeats();
    isLoading = false;
    return displayedSeats;
  }

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

  bool shouldExecuteOnlyOnceMethod = true;
  void onlyOnceMethod() {
    if (shouldExecuteOnlyOnceMethod == false) {
      return;
    }
    shouldExecuteOnlyOnceMethod = false;

    final arguments = (ModalRoute.of(context)?.settings.arguments ?? <String, dynamic>{}) as Map;
    reservation = arguments['reservation'];
    seatSelectionCompletionHandler = arguments['seatSelectionHandler'];
    //selectPreviouslySelectedSeats();
  }

  void selectPreviouslySelectedSeats() {
    if (reservation?.seatDeparture != null && reservation?.seatReturn != null) {
      setState(() {
        FlightSeat seatDeparture = FlightSeat.getFrom(reservation?.seatDeparture ?? 'A1');
        FlightSeat seatReturn = FlightSeat.getFrom(reservation?.seatReturn ?? 'A1');

        handleSeatSelected(
          seatReturn,
          FlightDirection.inbound,
        );

        handleSeatSelected(
          seatDeparture,
          FlightDirection.outbound,
        );
      });
    }
  }

  //
  // MARK: - WIDGETS
  //

  @override
  Widget build(BuildContext context) {
    onlyOnceMethod();

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
        body: FutureBuilder<List<List<FlightSeat>>>(
            future: myFuture,
            initialData: [],
            builder: (context, snapshot) {
              return CupertinoPageScaffold(
                backgroundColor: Colors.white,
                child: getTabContentView(),
              );
            }),
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
          onPressed: this.isReserveButtonEnabled ? handleReserveSeatsButtonPressed : null,
          child: Text(getReserveButtonText()),
        ),
      ),
    );
  }
}
