import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_city.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_user.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class UserService {
  APIService apiService = APIService(route: 'users');

  Future<List<TransportUser>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportUser.fromJson(e)).toList();
    return result;
  }

  Future<TransportUser> getObject({required int id}) async {
    var list = await getAllObjects();
    var result = list.firstWhere((element) => element.userId == id);
    return result;
  }

  Future<TransportUser> getMyProfile() async {
    var response = await apiService.getObject(path: 'MyProfile');
    var result = TransportUser.fromJson(response);
    return result;
  }
}
