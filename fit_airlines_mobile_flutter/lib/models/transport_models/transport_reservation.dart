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
    data['reservationId'] = this.reservationId;
    data['userId'] = this.userId;
    data['flightId'] = this.flightId;
    data['reservationDate'] = this.reservationDate;
    data['baseTicketPrice'] = this.baseTicketPrice;
    data['totalDiscountPercentage'] = this.totalDiscountPercentage;
    data['isValid'] = this.isValid;
    data['cashierId'] = this.cashierId;
    data['notes'] = this.notes;
    data['seatDeparture'] = this.seatDeparture;
    data['seatReturn'] = this.seatReturn;
    if (this.cashier != null) {
      data['cashier'] = this.cashier!.toJson();
    }
    if (this.flight != null) {
      data['flight'] = this.flight!.toJson();
    }
    if (this.user != null) {
      data['user'] = this.user!.toJson();
    }
    data['clientType'] = this.clientType;
    data['flightOffer'] = this.flightOffer;
    data['discount'] = this.discount;
    data['ticketPrice'] = this.ticketPrice;
    return data;
  }
}
