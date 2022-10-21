import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_flight.dart';
import 'package:fit_airlines_mobile_flutter/services/date_converter.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';
import 'package:flutter/material.dart';

class FlightService {
  APIService apiService = APIService(route: 'Flights');

  Future<List<TransportFlight>> getAllObjects({bool loadPictures = false}) async {
    var params = {'loadPictures': loadPictures};
    var response = await apiService.getObjectList(queryParams: params);
    var result = response.map((e) => TransportFlight.fromJson(e)).toList();
    return result;
  }

  // not used
  Future<TransportFlight> getObject({required int id}) async {
    var list = await getAllObjects();
    var result = list.firstWhere((element) => element.flightId == id);
    return result;

    // var response = await apiService.getObject(id: id);
    // var result = TransportCountry.fromJson(response);
    // return result;
  }

  Future<List<TransportFlight>> getFutureFlights(int offerId) async {
    var params = {'loadPictures': true, 'OfferId': offerId};
    var flightObjects = await apiService.getObjectList(queryParams: params);
    var flights = flightObjects.map((e) => TransportFlight.fromJson(e)).toList();
    flights.removeWhere((element) {
      var startDate = element.startDate?.asDateTime();
      print(startDate.toString());
      if (startDate?.isAfter(DateTime.now()) ?? false) {
        return false;
      }
      return true;
    });
    return flights;
  }

  Future<List<TransportFlight>> getRecommendedFlights({bool loadPictures = false}) async {
    var params = {'loadPictures': loadPictures};
    var response = await apiService.getObjectList(path: 'GetRecommendedFlights', queryParams: params);
    var result = response.map((e) => TransportFlight.fromJson(e)).toList();
    return result;
  }
}

extension on String {
  DateTime asDateTime() {
    return DateTime.parse(this);
  }
}
