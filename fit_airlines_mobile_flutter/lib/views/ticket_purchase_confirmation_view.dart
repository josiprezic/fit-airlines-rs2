import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/reservation.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:fit_airlines_mobile_flutter/views/home_view.dart';
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

  void handleDoneButtonPressed() {
    makeRoutePage(
      context: context,
      pageRef: HomeViewWithDrawer(),
    );
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ??
        <String, dynamic>{}) as Map;

    reservation = arguments['reservation'];
    bool showBackButton = arguments['show_back_button'] ?? false;

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
                FitStyleButton('Done', handleDoneButtonPressed),
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

  void makeRoutePage({required BuildContext context, required Widget pageRef}) {
    Navigator.pushAndRemoveUntil(
        context,
        MaterialPageRoute(builder: (context) => pageRef),
        (Route<dynamic> route) => false);
  }
}
