import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:flutter/material.dart';

class TicketReservationView extends StatefulWidget {
  const TicketReservationView({Key? key}) : super(key: key);

  @override
  State<TicketReservationView> createState() => _TicketReservationViewState();
}

class _TicketReservationViewState extends State<TicketReservationView> {
  Flight? flight; // set by previous screen

  void handleSeatsSelected(Flight flight) {
    print('Selected Seats: ' +
        flight.selectedSeatOutbound +
        ' ' +
        flight.selectedSeatInbound);
  }

  void handleReserveSeatsButtonPressed() {
    print('handleReserveSeatsButtonPressed');
    Navigator.of(context).pushNamed('/seat_reservation', arguments: {
      'flight': flight,
      'seatSelectionHandler': handleSeatsSelected,
    });
  }

  void handleBuyTicketButtonPressed() {
    print('handleBuyTicketButtonPressed');
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ??
        <String, dynamic>{}) as Map;

    flight = arguments['flight'];

    if (flight == null) {
      // Handle flight not available
      return const Center(
        child: Text('Error: flight = null'),
      );
    } else {
      // Handle flight available

      return Scaffold(
        appBar: AppBar(
          title: const Text('Ticket Reservation'),
        ),
        body: SingleChildScrollView(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Text(
                  flight?.name ?? 'Error flight name',
                  style: const TextStyle(
                    fontSize: 20,
                  ),
                ),
              ),
              const FitHorizontalDivider(),
              getFlightDatesSectionHeader('Outbound date: DATE'),
              const FitHorizontalDivider(),
              getFlightInfoView(true, 'HH:MM', 'Mostar, BiH'),
              getVerticalLine(),
              getFlightInfoView(false, 'HH:MM', 'Mostar, BiH'),
              const FitHorizontalDivider(),
              getFlightDatesSectionHeader('Inbound date: DATE'),
              const FitHorizontalDivider(),
              getFlightInfoView(true, 'HH:MM', 'Mostar, BiH'),
              getVerticalLine(),
              getFlightInfoView(false, 'HH:MM', 'Mostar, BiH'),
              const FitHorizontalDivider(),
              FitStyleButton(
                'Reserve seats',
                handleReserveSeatsButtonPressed,
              ),
              getAdditionalFlightInfoView(),
              const FitHorizontalDivider(),
              getPriceRowView(),
              FitStyleButton(
                'Confirm and buy ticket',
                handleBuyTicketButtonPressed,
              ),
              SizedBox(height: 50),
            ],
          ),
        ),
      );
    }
  }

  Widget getPriceRowView() {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: Row(
        children: [
          Text(
            'PRICE: ',
            style: TextStyle(
              fontSize: 16,
              color: Colors.black,
            ),
          ),
          Spacer(),
          Text(
            '120 PLN',
            style: TextStyle(
              fontSize: 16,
              color: Colors.black,
            ),
          ),
        ],
      ),
    );
  }

  Widget getAdditionalFlightInfoView() {
    return Padding(
      padding: const EdgeInsets.all(10.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Additional flight info:',
            style: TextStyle(
              fontSize: 16,
              color: Colors.black,
            ),
          ),
          SizedBox(
            height: 10,
          ),
          Text(
            "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
            style: TextStyle(
              fontSize: 16,
              color: Colors.black,
            ),
          ),
        ],
      ),
    );
  }

  Widget getFlightDatesSectionHeader(String title) {
    return Padding(
      padding: const EdgeInsets.symmetric(
        vertical: 0.0,
        horizontal: 8.0,
      ),
      child: Text(
        title,
        style: const TextStyle(
          fontSize: 16,
        ),
      ),
    );
  }

  Widget getFlightInfoView(
    bool isOutbound,
    String timeString,
    String airportString,
  ) {
    return Padding(
      padding: const EdgeInsets.all(10.0),
      child: Row(
        children: [
          Icon(isOutbound ? Icons.flight_takeoff : Icons.flight_land),
          Padding(
            padding: const EdgeInsets.only(left: 18.0),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(timeString),
                Text(airportString),
              ],
            ),
          )
        ],
      ),
    );
  }

  Widget getVerticalLine() {
    return const Padding(
      padding: EdgeInsets.symmetric(horizontal: 18.0),
      child: SizedBox(
        width: 1.5,
        height: 42.0,
        child: DecoratedBox(
          decoration: BoxDecoration(
            color: Colors.black,
            borderRadius: BorderRadius.vertical(
                top: Radius.circular(10), bottom: Radius.circular(10)),
          ),
        ),
      ),
    );
  }
}
