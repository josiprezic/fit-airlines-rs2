import 'package:fit_airlines_mobile_flutter/models/flight.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_airlines_card.dart';
import 'package:flutter/material.dart';

class FlightDetailsView extends StatefulWidget {
  const FlightDetailsView({Key? key}) : super(key: key);

  @override
  State<FlightDetailsView> createState() => _FlightDetailsViewState();
}

class _FlightDetailsViewState extends State<FlightDetailsView> {
  Flight? flight;

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
      backgroundColor: Colors.blueGrey,
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
                      // Positioned(
                      //   bottom: 0,
                      //   left: 0,
                      //   child: Row(
                      //     children: [],
                      //   ),
                      // ),
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

                Divider(
                  indent: 10,
                  endIndent: 10,
                  color: Colors.black45,
                  thickness: 1,
                ),
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

                // TODO: JR Add star widget
              ],
            ),
          ),
          SizedBox(
            height: 60,
            width: double.infinity,
            child: Padding(
              padding: const EdgeInsets.all(8.0),
              child: TextButton(
                style: TextButton.styleFrom(
                  foregroundColor: Colors.purpleAccent,
                  backgroundColor: Colors.blue,
                ),
                onPressed: () {
                  print('Make reservation button pressed!');
                },
                child: Text('Make reservation'),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
