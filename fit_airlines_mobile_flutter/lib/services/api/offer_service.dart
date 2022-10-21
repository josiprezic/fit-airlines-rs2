import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_country.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_offer.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class OfferService {
  APIService apiService = APIService(route: 'offers');

  Future<List<TransportOffer>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportOffer.fromJson(e)).toList();
    return result;
  }

  // not used
  Future<TransportOffer> getObject({required int id}) async {
    var list = await getAllObjects();
    var result = list.firstWhere((element) => element.offerId == id);
    return result;

    // var response = await apiService.getObject(id: id);
    // var result = TransportCountry.fromJson(response);
    // return result;
  }
}
