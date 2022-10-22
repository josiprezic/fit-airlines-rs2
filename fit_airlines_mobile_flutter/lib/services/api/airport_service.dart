import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_airport.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class AirportService {
  APIService apiService = APIService(route: 'airports');

  Future<List<TransportAirport>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportAirport.fromJson(e)).toList();
    return result;
  }

  // not used
  Future<TransportAirport> getObject({required int id}) async {
    var list = await getAllObjects();
    var result = list.firstWhere((element) => element.airportId == id);
    return result;

    // var response = await apiService.getObject(id: id);
    // var result = TransportCountry.fromJson(response);
    // return result;
  }
}
