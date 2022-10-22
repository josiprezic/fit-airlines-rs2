import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_flight.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_user.dart';

class TransportReservation {
  int? reservationId;
  int? userId;
  int? flightId;
  String? reservationDate;
  int? baseTicketPrice;
  int? totalDiscountPercentage;
  bool? isValid;
  int? cashierId;
  String? notes;
  String? seatDeparture;
  String? seatReturn;
  TransportUser? cashier;
  TransportFlight? flight;
  TransportUser? user;
  String? clientType;
  String? flightOffer;
  String? discount;
  String? ticketPrice;

  TransportReservation(
      {this.reservationId,
      this.userId,
      this.flightId,
      this.reservationDate,
      this.baseTicketPrice,
      this.totalDiscountPercentage,
      this.isValid,
      this.cashierId,
      this.notes,
      this.seatDeparture,
      this.seatReturn,
      this.cashier,
      this.flight,
      this.user,
      this.clientType,
      this.flightOffer,
      this.discount,
      this.ticketPrice});

  TransportReservation.fromJson(Map<String, dynamic> json) {
    reservationId = json['reservationId'];
    userId = json['userId'];
    flightId = json['flightId'];
    reservationDate = json['reservationDate'];
    baseTicketPrice = json['baseTicketPrice'];
    totalDiscountPercentage = json['totalDiscountPercentage'];
    isValid = json['isValid'];
    cashierId = json['cashierId'];
    notes = json['notes'];
    seatDeparture = json['seatDeparture'];
    seatReturn = json['seatReturn'];
    cashier = json['cashier'] != null ? new TransportUser.fromJson(json['cashier']) : null;
    flight = json['flight'] != null ? new TransportFlight.fromJson(json['flight']) : null;
    user = json['user'] != null ? new TransportUser.fromJson(json['user']) : null;
    clientType = json['clientType'];
    flightOffer = json['flightOffer'];
    discount = json['discount'];
    ticketPrice = json['ticketPrice'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();

    if (seatDeparture != null) {
      String seatString = seatDeparture!;
      var rowCalc = int.parse(seatString.substring(1));
      var colCalc = FlightSeat.getSeatColumnNumber(seatString[0]);
      data['seatIndexDeparture'] = colCalc - 1 + ((rowCalc - 1) * 6);
    }

    if (seatReturn != null) {
      String seatString = seatReturn!;
      var rowCalc = int.parse(seatString.substring(1));
      var colCalc = FlightSeat.getSeatColumnNumber(seatString[0]);
      data['seatIndexReturn'] = colCalc - 1 + ((rowCalc - 1) * 6);
    }

    data['isValid'] = true;

    data['userId'] = this.userId;
    data['flightId'] = this.flightId;
    data['notes'] = 'Mobile reservation';
    return data;
  }
}
