import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_city.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reserved_seat.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';

class ReservedSeatService {
  APIService apiService = APIService(route: 'ReservedSeats');

  Future<List<TransportReservedSeat>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportReservedSeat.fromJson(e)).toList();
    return result;
  }

  Future<List<TransportReservedSeat>> getReservedSeatsForFlight(int flightId) async {
    print('AAAA CALLED');
    var params = {'FlightId': flightId};
    var reservedSeatObjects = await apiService.getObjectList(queryParams: params);
    var seats = reservedSeatObjects.map((e) => TransportReservedSeat.fromJson(e)).toList();
    return seats;
  }
}
