import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/models/reservation.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_airport.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_flight.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reservation.dart';
import 'package:fit_airlines_mobile_flutter/services/api/airport_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/flight_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/reservation_service.dart';
import 'package:fit_airlines_mobile_flutter/services/app_user_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class TicketReservationView extends StatefulWidget {
  const TicketReservationView({Key? key}) : super(key: key);

  @override
  State<TicketReservationView> createState() => _TicketReservationViewState();
}

class _TicketReservationViewState extends State<TicketReservationView> {
  TransportFlight? flight; // set by previous screen
  TransportAirport? airport;
  late TransportReservation reservation;

  void handleSeatsSelected(TransportReservation reservation) {
    print('Selected Seats: ' + (this.reservation.seatDeparture ?? 'N/A')); // + ' ' + (reservation.inboundSeat?.getSeatString() ?? 'N/A'));
    print('Selected Seats: ' + (this.reservation.seatReturn ?? 'N/A')); // + ' ' + (this.reservation.inboundSeat?.getSeatString() ?? 'N/A'));

    // print('Selected Seats: ' + (reservation.outboundSeat?.getSeatString() ?? 'N/A') + ' ' + (reservation.inboundSeat?.getSeatString() ?? 'N/A'));
    //
    // print('Selected Seats: ' + (this.reservation.outboundSeat?.getSeatString() ?? 'N/A') + ' ' + (this.reservation.inboundSeat?.getSeatString() ?? 'N/A'));
  }

  void handleReserveSeatsButtonPressed() {
    print('handleReserveSeatsButtonPressed');
    Navigator.of(context).pushNamed('/seat_reservation', arguments: {
      'reservation': reservation,
      'seatSelectionHandler': handleSeatsSelected,
    });
  }

  void handleBuyTicketButtonPressed() async {
    print('handleBuyTicketButtonPressed');
    reservation.userId = await AppUserService.userId;
    reservation.flightId = reservation?.flight?.flightId;
    reservation.isValid = true;

    print('RESERVATION' + reservation.userId.toString());
    print('RESERVATION' + reservation.flightId.toString());
    print('RESERVATION' + reservation.isValid.toString());
    print('RESERVATION' + reservation.seatReturn.toString());
    print('RESERVATION' + reservation.seatDeparture.toString());

    var service = ReservationService();

    var params = reservation.toJson();
    var postResult = await service.postReservation(params);

    // Navigator.of(context).pushNamed('/ticket_purchase_confirmation', arguments: {
    //   'reservation': reservation,
    // });
  }

  var isLoading = false;
  var airportService = AirportService();
  var flightService = FlightService();
  Future<TransportAirport> getData() async {
    isLoading = true;
    var result = await airportService.getObject(id: flight?.destinationAirportId ?? 0);

    this.airport = result;
    isLoading = false;
    return result;
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ?? <String, dynamic>{}) as Map;

    flight = arguments['flight'];

    if (flight == null) {
      // Handle flight not available
      return const Center(
        child: Text('Error: flight = null'),
      );
    } else {
      // Handle flight available
      reservation = TransportReservation(flightId: flight!.flightId, flight: flight!);
      print('RESERVATION TEST: ' + flight!.flightId.toString());

      return Scaffold(
        appBar: AppBar(
          title: const Text('Ticket Reservation'),
        ),
        body: FutureBuilder<TransportAirport>(
            future: getData(),
            initialData: null,
            builder: (context, snapshot) {
              return SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: Text(
                        (flight?.city?.cityName ?? 'Error flight name') + ', ' + (flight?.countryName ?? 'Error country name'),
                        style: const TextStyle(
                          fontSize: 20,
                          fontWeight: FontWeight.w900,
                        ),
                      ),
                    ),
                    const FitHorizontalDivider(),
                    getFlightDatesSectionHeader('Outbound date: ' + DateFormat('yyyy-MM-dd').format(DateTime.parse(flight?.startDate ?? ''))),
                    const FitHorizontalDivider(),
                    getFlightInfoView(true, DateFormat.Hm().format(DateTime.parse(flight?.startDate ?? '')), 'Mostar Airport, Mostar'),
                    getVerticalLine(),
                    getFlightInfoView(false, DateFormat.Hm().format(DateTime.parse(flight?.startDateArrival ?? '')),
                        (airport?.airportName ?? 'Error airport name') + ', ' + (flight?.city?.cityName ?? 'Error city name')),
                    const FitHorizontalDivider(),
                    getFlightDatesSectionHeader('Inbound date: ' + DateFormat('yyyy-MM-dd').format(DateTime.parse(flight?.endDate ?? ''))),
                    const FitHorizontalDivider(),
                    getFlightInfoView(true, DateFormat.Hm().format(DateTime.parse(flight?.endDate ?? '')),
                        (airport?.airportName ?? 'Error airport name') + ', ' + (flight?.city?.cityName ?? 'Error city name')),
                    getVerticalLine(),
                    getFlightInfoView(false, DateFormat.Hm().format(DateTime.parse(flight?.endDateArrival ?? '')), 'Mostar Airport, Mostar'),
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
              );
            }),
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
            (flight?.price?.toString() ?? '--') + ' KM',
            style: TextStyle(fontSize: 16, color: Colors.green, fontWeight: FontWeight.w900),
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
            style: TextStyle(fontSize: 16, color: Colors.black, fontWeight: FontWeight.w500),
          ),
          SizedBox(
            height: 10,
          ),
          Text(
            flight?.notes ?? 'No notes',
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
          fontWeight: FontWeight.w500,
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
            borderRadius: BorderRadius.vertical(top: Radius.circular(10), bottom: Radius.circular(10)),
          ),
        ),
      ),
    );
  }
}
