import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_stars/flutter_rating_stars.dart';

class FlightDetailsView extends StatefulWidget {
  const FlightDetailsView({Key? key}) : super(key: key);

  @override
  State<FlightDetailsView> createState() => _FlightDetailsViewState();
}

class _FlightDetailsViewState extends State<FlightDetailsView> {
  Flight? flight;
  double ratingStarsValue = 0.0;

  void handleMakeReservationButtonPressed() {
    print('TODO: handleMakeReservationButtonPressed');

    // TODO: JR SZEF - MOCKING - TO BE REMOVED
    print('Creating new mock objects ... ');
    int numberOfRows = (flight?.capacity ?? 6) ~/ 6;
    FitTemp.mockOutboundSeats =
        FitTemp.getRandomlyGeneratedMockSeats(numberOfRows: numberOfRows);
    FitTemp.mockInboundSeats =
        FitTemp.getRandomlyGeneratedMockSeats(numberOfRows: numberOfRows);
    print('Done - mocked!');
    // ------------ Mocking end ------------

    Navigator.of(context)
        .pushNamed('/ticket_reservation', arguments: {'flight': flight});
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
      //backgroundColor: Colors.blueGrey,
      appBar: AppBar(
        title: Text(flight?.name ?? 'Selected flight'),
      ),
      body: Column(
        children: [
          Expanded(
            child: ListView(
              children: [
                Container(
                  height: 150,
                  //margin: EdgeInsets.only(left: 10, top: 8, right: 10, bottom: 2),
                  child: Stack(
                    children: [
                      Positioned.fill(
                        //child: ClipRRect(
                        //borderRadius: BorderRadius.circular(10),
                        child: Image.asset(
                          'assets/images/flight-placeholder.jpg',
                          fit: BoxFit.cover,
                        ),
                        //),
                      ),
                      Positioned(
                        bottom: 0,
                        left: 0,
                        right: 0,
                        top: 0,
                        child: Container(
                          height: 120,
                          decoration: BoxDecoration(
                            //border: Border.all(color: Colors.black54, width: 1.0),
                            //borderRadius: BorderRadius.circular(10),
                            gradient: LinearGradient(
                              begin: Alignment.bottomCenter,
                              end: Alignment.topCenter,
                              colors: [
                                Colors.black.withOpacity(0.8),
                                Colors.transparent,
                                Colors.transparent,
                              ],
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
                Container(
                  alignment: Alignment.centerLeft,
                  padding: EdgeInsets.all(10),
                  child: Text(
                    flight?.name ?? 'No name',
                    style: TextStyle(
                      fontSize: 20,
                      color: Colors.black,
                    ),
                  ),
                ),
                Container(
                  alignment: Alignment.centerLeft,
                  padding: EdgeInsets.all(10),
                  child: Text(
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.black,
                    ),
                  ),
                ),
                FitHorizontalDivider(),
                Container(
                  alignment: Alignment.centerLeft,
                  padding: EdgeInsets.all(10),
                  child: Text(
                    'START DATE - END DATE',
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.black,
                    ),
                  ),
                ),
                Container(
                  alignment: Alignment.centerLeft,
                  padding: EdgeInsets.all(10),
                  child: Text(
                    'Price: 100,24 BAM',
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.black,
                    ),
                  ),
                ),
                Container(
                  alignment: Alignment.centerLeft,
                  padding: EdgeInsets.all(10),
                  child: Text(
                    'Availability: Only 3 places left!',
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.black,
                    ),
                  ),
                ),
                Container(
                  alignment: Alignment.centerLeft,
                  padding: EdgeInsets.all(10),
                  child: Text(
                    'Other info...',
                    style: TextStyle(
                      fontSize: 16,
                      color: Colors.black,
                    ),
                  ),
                ),
                RatingStars(
                  value: ratingStarsValue,
                  onValueChanged: (v) {
                    //
                    setState(() {
                      ratingStarsValue = v;
                    });
                  },
                  starBuilder: (index, color) => Icon(
                    Icons.star,
                    color: color,
                  ),
                  starCount: 5,
                  starSize: 50,
                  valueLabelColor: const Color(0xff9b9b9b),
                  valueLabelTextStyle: const TextStyle(
                      color: Colors.white,
                      fontWeight: FontWeight.w400,
                      fontStyle: FontStyle.normal,
                      fontSize: 12.0),
                  valueLabelRadius: 10,
                  maxValue: 5,
                  starSpacing: 0,
                  maxValueVisibility: true,
                  valueLabelVisibility: false,
                  animationDuration: Duration(milliseconds: 1000),
                  valueLabelPadding:
                      const EdgeInsets.symmetric(vertical: 1, horizontal: 8),
                  valueLabelMargin: const EdgeInsets.only(right: 8),
                  starOffColor: const Color(0xffe7e8ea),
                  starColor: Colors.orangeAccent,
                ),
              ],
            ),
          ),
          FitStyleButton(
            'Make reservation',
            handleMakeReservationButtonPressed,
          ),
        ],
      ),
    );
  }
}
