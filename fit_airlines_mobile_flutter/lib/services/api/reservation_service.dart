import 'dart:ffi';

import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_city.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reservation.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';
import 'package:fit_airlines_mobile_flutter/services/app_user_service.dart';

class ReservationService {
  APIService apiService = APIService(route: 'reservations');

  Future<List<TransportReservation>> getAllObjects() async {
    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportReservation.fromJson(e)).toList();
    return result;
  }

  Future<List<TransportReservation>> getAllReservationsForFlight(int flightId) async {
    var allReservations = await getAllObjects();
    allReservations.removeWhere((element) {
      return flightId != element.flightId;
    });

    var response = await apiService.getObjectList();
    var result = response.map((e) => TransportReservation.fromJson(e)).toList();
    return result;
  }

  Future<List<TransportReservation>> getAllReservationsForCurrentUser() async {
    var allReservations = await getAllObjects();
    var currentUserId = await AppUserService.userId;
    allReservations.removeWhere((element) {
      return currentUserId != element.userId;
    });

    return allReservations;

    // var response = await apiService.getObjectList();
    // var result = response.map((e) => TransportReservation.fromJson(e)).toList();
    // return result;
  }

  Future<TransportReservation> getObject({required int id}) async {
    var list = await getAllObjects();
    var result = list.firstWhere((element) => element.reservationId == id);
    return result;

    // var response = await apiService.getObject(id: id);
    // var result = TransportCity.fromJson(response);
    // return result;
  }
}
