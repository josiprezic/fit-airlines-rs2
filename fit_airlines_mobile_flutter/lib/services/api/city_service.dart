import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_city.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class CityService {
  APIService apiService = APIService(route: 'cities');

  Future<List<TransportCity>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportCity.fromJson(e)).toList();
    return result;
  }

  Future<TransportCity> getObject({required int id}) async {
    var list = await getAllObjects();
    var result = list.firstWhere((element) => element.cityId == id);
    return result;

    // var response = await apiService.getObject(id: id);
    // var result = TransportCity.fromJson(response);
    // return result;
  }
}
