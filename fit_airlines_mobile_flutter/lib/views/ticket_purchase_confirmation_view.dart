import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/reservation.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:flutter/material.dart';

class TicketPurchaseConfirmationView extends StatefulWidget {
  const TicketPurchaseConfirmationView({Key? key}) : super(key: key);

  @override
  State<TicketPurchaseConfirmationView> createState() =>
      _TicketPurchaseConfirmationViewState();
}

class _TicketPurchaseConfirmationViewState
    extends State<TicketPurchaseConfirmationView> {
  Reservation? reservation;

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ??
        <String, dynamic>{}) as Map;

    reservation = arguments['reservation'];

    if (reservation == null) {
      return Scaffold(
        body: Center(
          child: Text('Error: reservation == null'),
        ),
      );
    } else {
      return Scaffold(
        appBar: AppBar(
          title: Text('Happy travelling'),
        ),
        body: SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.all(8.0),
            child: Column(
              children: [
                getDescriptionRow('First name', 'Joe'),
                getDescriptionRow('Last name', 'Joeseen'),
                getDescriptionRow('Destination', reservation!.flight.name),
                getDescriptionRow('Price', reservation!.flight.price + ' BAM'),
                getDescriptionRow(
                    'Outbound seat',
                    reservation!.outboundSeat?.getSeatString() ??
                        'Not selected'),
                getDescriptionRow(
                    'Inbound seat',
                    reservation!.inboundSeat?.getSeatString() ??
                        'Not selected'),
                getDescriptionRow('Test row title', 'Test row description'),
                getDescriptionRow('Test row title', FitTemp.loremIpsum),
                getDescriptionRow('Test row title', FitTemp.loremIpsum),
                getDescriptionRow('Test row title', 'Test row description'),
                getDescriptionRow('Test row title', FitTemp.loremIpsum),
                getDescriptionRow('Test row title', 'Test row description'),
                getDescriptionRow('Test row title', FitTemp.loremIpsum),
                getDescriptionRow('Test row title', FitTemp.loremIpsum),
                getDescriptionRow('Test row title', 'Test row description'),
              ],
            ),
          ),
        ),
      );
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
            // DecoratedBox(
            //   decoration: BoxDecoration(color: Colors.grey),
            //   child: SizedBox(
            //     width: 1,
            //     height: 40,
            //   ),
            // ),
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
}
