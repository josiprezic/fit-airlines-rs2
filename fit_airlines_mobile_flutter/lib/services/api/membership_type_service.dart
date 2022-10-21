import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_membership_type.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class MembershipTypeService {
  APIService apiService = APIService(route: 'cities');

  Future<List<TransportMembershipType>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportMembershipType.fromJson(e)).toList();
    return result;
  }

  Future<TransportMembershipType> getObject({required int id}) async {
    var list = await getAllObjects();
    var result = list.firstWhere((element) => element.membershipTypeId == id);
    return result;

    // var response = await apiService.getObject(id: id);
    // var result = TransportCity.fromJson(response);
    // return result;
  }
}
