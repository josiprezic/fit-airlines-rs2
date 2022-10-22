import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reservation.dart';
import 'package:fit_airlines_mobile_flutter/services/app_user_service.dart';
import 'package:fit_airlines_mobile_flutter/services/date_converter.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:fit_airlines_mobile_flutter/views/home_view.dart';
import 'package:flutter/material.dart';

class TicketPurchaseConfirmationView extends StatefulWidget {
  const TicketPurchaseConfirmationView({Key? key}) : super(key: key);

  @override
  State<TicketPurchaseConfirmationView> createState() => _TicketPurchaseConfirmationViewState();
}

class _TicketPurchaseConfirmationViewState extends State<TicketPurchaseConfirmationView> {
  TransportReservation? reservation;

  void handleDoneButtonPressed() {
    makeRoutePage(
      context: context,
      pageRef: HomeViewWithDrawer(),
    );
  }

  var isLoading = false;
  var firstName = '';
  var lastName = '';
  Future<void> getData() async {
    isLoading = true;
    firstName = await AppUserService.firstName;
    lastName = await AppUserService.lastName;
    isLoading = false;
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ?? <String, dynamic>{}) as Map;

    reservation = arguments['reservation'];
    bool showBackButton = arguments['show_back_button'] ?? false;

    if (reservation == null) {
      return Scaffold(
        body: Center(
          child: Text('Error: reservation == null'),
        ),
      );
    } else {
      return FutureBuilder<void>(
          future: getData(),
          builder: (context, snapshot) {
            return Scaffold(
              appBar: AppBar(
                title: Text('Happy travelling'),
                automaticallyImplyLeading: showBackButton,
              ),
              body: SingleChildScrollView(
                child: Padding(
                  padding: const EdgeInsets.all(10.0),
                  child: Column(
                    children: [
                      SizedBox(height: 50),
                      Image(
                        image: AssetImage('assets/images/all-done.png'),
                        //height: 00,
                        width: double.maxFinite,
                      ),
                      SizedBox(height: 50),
                      getDescriptionRow('First name', firstName),
                      getDescriptionRow('Last name', lastName),
                      getDescriptionRow('Destination', reservation!.flight?.city?.cityName ?? 'No city name'),
                      getDescriptionRow('Flight duration', reservation?.flight?.flightDuration?.toString() ?? '-'),
                      getDescriptionRow('Outbound seat', reservation!.seatDeparture ?? 'Not selected'),
                      getDescriptionRow('Inbound seat', reservation!.seatReturn ?? 'Not selected'),
                      getDescriptionRow('Destination', reservation?.flight?.city?.cityName ?? '-'),
                      getDescriptionRow('About city', reservation?.flight?.city?.shortInfo ?? '-'),
                      getDescriptionRow('Outbound date', DateDecorator.decorateMinDay(reservation?.flight?.startDate)),
                      getDescriptionRow('Inbound date', DateDecorator.decorateMinDay(reservation?.flight?.endDate)),
                      getDescriptionRow('Reservation notes', reservation?.notes ?? 'No additional notes are provided.'),
                      getDescriptionRow('Pilot', (reservation!.flight?.pilotFullName?.toString() ?? '-')),
                      getDescriptionRow('Additional info', reservation?.flight?.shortInfo ?? '-'),
                      getDescriptionRow('Price', (reservation!.flight?.price?.toString() ?? '-') + ' KM'),
                      FitStyleButton('Done', handleDoneButtonPressed),
                    ],
                  ),
                ),
              ),
            );
          });
    }
  }

  Widget getDescriptionRow(String title, String descrption) {
    return Column(
      children: [
        Row(
          children: [
            SizedBox(
              width: 150,
              child: Text(
                title + ': ',
                style: TextStyle(
                  fontSize: 16,
                  color: Colors.black,
                ),
              ),
            ),
            SizedBox(width: 10),
            Flexible(
              child: Text(
                descrption,
                style: TextStyle(
                  fontSize: 16,
                  color: Colors.black,
                ),
              ),
            ),
          ],
        ),
        Divider(
          indent: 0,
          endIndent: 0,
          color: Colors.black45,
          thickness: 1,
        ),
      ],
    );
  }

  void makeRoutePage({required BuildContext context, required Widget pageRef}) {
    Navigator.pushAndRemoveUntil(context, MaterialPageRoute(builder: (context) => pageRef), (Route<dynamic> route) => false);
  }
}
