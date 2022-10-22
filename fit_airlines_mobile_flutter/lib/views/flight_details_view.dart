import 'package:fit_airlines_mobile_flutter/constants/constants.dart';
import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_city.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_country.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_flight.dart';
import 'package:fit_airlines_mobile_flutter/services/api/city_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/country_service.dart';
import 'package:fit_airlines_mobile_flutter/services/date_converter.dart';
import 'package:fit_airlines_mobile_flutter/services/image_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/main_seat_reservation_view.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_stars/flutter_rating_stars.dart';

class FlightDetailsView extends StatefulWidget {
  const FlightDetailsView({Key? key}) : super(key: key);

  @override
  State<FlightDetailsView> createState() => _FlightDetailsViewState();
}

class _FlightDetailsViewState extends State<FlightDetailsView> {
  TransportFlight? flight;
  double ratingStarsValue = 0.0;

  void handleMakeReservationButtonPressed() {
    print('TODO: handleMakeReservationButtonPressed');

    // TODO: JR SZEF - MOCKING - TO BE REMOVED
    print('Creating new mock objects ... ');
    int numberOfRows = (flight?.capacity ?? 6) ~/ 6;
    FitTemp.mockOutboundSeats = FitTemp.getRandomlyGeneratedMockSeats(numberOfRows: numberOfRows);
    FitTemp.mockInboundSeats = FitTemp.getRandomlyGeneratedMockSeats(numberOfRows: numberOfRows);
    print('Done - mocked!');
    // ------------ Mocking end ------------

    SeatReservationView.currentFlightId = flight?.flightId ?? 0;
    Navigator.of(context).pushNamed('/ticket_reservation', arguments: {'flight': flight});
  }

  CityService cityService = CityService();
  CountryService countryService = CountryService();
  TransportCity? destinationCity;
  TransportCountry? destinationCountry;

  Future<TransportCity> getData() async {
    var result = await cityService.getObject(id: flight?.cityId ?? 0);
    this.destinationCountry = await countryService.getObject(id: result?.countryId ?? 0);
    destinationCity = result;
    return result;
  }

  @override
  Widget build(BuildContext context) {
    final arguments = (ModalRoute.of(context)?.settings.arguments ?? <String, dynamic>{}) as Map;

    flight = arguments['flight'];
    print('AVERAGE RATING: ' + (flight?.averageRating?.toString() ?? ''));
    ratingStarsValue = flight?.averageRating?.toDouble() ?? 5.0;

    if (ratingStarsValue == 0) {
      ratingStarsValue = 5;
    }

    if (flight == null) {
      // TODO: JR Handle flight not available
    } else {
      // TODO: JR Handle flight available

    }

    return Scaffold(
      //backgroundColor: Colors.blueGrey,
      appBar: AppBar(
        title: Text(flight?.city?.cityName ?? 'Selected flight'),
      ),
      body: FutureBuilder<TransportCity>(
          future: getData(),
          initialData: null,
          builder: (context, snapshot) {
            return Column(
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
                              child: ImageService.getImageFromByteData(this.flight?.picture) ??
                                  Image.asset(
                                    'assets/images/flight-placeholder.jpg',
                                    fit: BoxFit.cover,
                                  ),
                            ),
                            Positioned(
                              bottom: 0,
                              left: 0,
                              right: 0,
                              top: 0,
                              child: Container(
                                height: 120,
                                decoration: BoxDecoration(
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
                          (flight?.city?.cityName ?? 'No name') + ', ' + (destinationCountry?.countryName ?? 'No name'),
                          style: TextStyle(
                            fontSize: 25,
                            color: Colors.black,
                            fontWeight: FontWeight.w900,
                          ),
                        ),
                      ),
                      Container(
                        alignment: Alignment.centerLeft,
                        padding: EdgeInsets.all(10),
                        child: Text(
                          destinationCity?.shortInfo ?? '',
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
                          destinationCountry?.shortInfo ?? '',
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
                          flight?.shortInfo ?? '',
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
                          DateDecorator.decorateMinDay(flight?.startDate) + ' - ' + DateDecorator.decorateMinDay(flight?.endDate),
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
                          'Price: ' + (flight?.price ?? -1).toString() + ' BAM',
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
                          'Availability: Available',
                          style: TextStyle(
                            fontSize: 16,
                            color: Colors.green,
                          ),
                        ),
                      ),
                      Container(
                        alignment: Alignment.centerLeft,
                        padding: EdgeInsets.all(10),
                        child: Text(
                          'Other info: The pilot on this flight will be Mr. ' + (flight?.pilotFullName ?? 'N.N.') + '. ' + (flight?.notes ?? ''),
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
                        valueLabelTextStyle: const TextStyle(color: Colors.white, fontWeight: FontWeight.w400, fontStyle: FontStyle.normal, fontSize: 12.0),
                        valueLabelRadius: 10,
                        maxValue: 5,
                        starSpacing: 0,
                        maxValueVisibility: true,
                        valueLabelVisibility: false,
                        animationDuration: Duration(milliseconds: 1000),
                        valueLabelPadding: const EdgeInsets.symmetric(vertical: 1, horizontal: 8),
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
            );
          }),
    );
  }
}
