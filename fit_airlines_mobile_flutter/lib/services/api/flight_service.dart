import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_country.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_flight.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class FlightService {
  APIService apiService = APIService(route: 'flights');

  Future<List<TransportFlight>> getAllObjects() async {
    var response = await apiService.getObjectList();
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
}
