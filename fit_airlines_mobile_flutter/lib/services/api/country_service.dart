import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_country.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class CountryService {
  APIService apiService = APIService(route: 'countries');

  Future<List<TransportCountry>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportCountry.fromJson(e)).toList();
    return result;
  }

  // not used
  Future<TransportCountry> getObject({required int id}) async {
    var response = await apiService.getObject(id: id);
    var result = TransportCountry.fromJson(response);
    return result;
  }
}
