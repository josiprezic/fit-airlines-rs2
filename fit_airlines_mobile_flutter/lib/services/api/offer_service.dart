import 'package:fit_airlines_mobile_flutter/models/offer.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_country.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_offer.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class OfferService {
  APIService apiService = APIService(route: 'offers');

  Future<List<TransportOffer>> getAllObjects({bool loadPictures = false}) async {
    var params = {'loadPictures': loadPictures};
    var response = await apiService.getObjectList(queryParams: params);
    var result = response.map((e) => TransportOffer.fromJson(e)).toList();
    return result;
  }

  Future<List<TransportOffer>> getFutureOffers({bool loadPictures = false}) async {
    var params = {'loadPictures': loadPictures};
    var response = await apiService.getObjectList(queryParams: params);
    var result = response.map((e) => TransportOffer.fromJson(e)).toList();
    result.removeWhere((element) => !element.isInFuture);
    return result;
  }

  // Future<List<Offer>> getAllOffers() async {
  //   var transportOffers = await getAllObjects();
  //   return transportOffers.map((e) {
  //     return Offer(e.offerName),
  //   })
  // }

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
