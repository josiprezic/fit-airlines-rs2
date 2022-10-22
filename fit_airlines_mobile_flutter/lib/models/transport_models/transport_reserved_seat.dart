import 'package:fit_airlines_mobile_flutter/models/flight_seat.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_reservation.dart';
import 'package:fit_airlines_mobile_flutter/views/seat_reservation/main_seat_reservation_view.dart';

class TransportReservedSeat {
  int? reservedSeatId;
  int? reservationId;
  String? direction;
  int? seatPrice;
  int? seatIndex;
  //TransportReservation? reservation;
  int? seatRow;
  int? seatColumn;
  String? seatName;

  TransportReservedSeat(
      {this.reservedSeatId,
      this.reservationId,
      this.direction,
      this.seatPrice,
      this.seatIndex,
      //this.reservation,
      this.seatRow,
      this.seatColumn,
      this.seatName});

  TransportReservedSeat.fromJson(Map<String, dynamic> json) {
    reservedSeatId = json['reservedSeatId'];
    reservationId = json['reservationId'];
    direction = json['direction'];
    seatPrice = json['seatPrice'];
    seatIndex = json['seatIndex'];
    //reservation = json['reservation'];
    seatRow = json['seatRow'];
    seatColumn = json['seatColumn'];
    seatName = json['seatName'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['reservedSeatId'] = this.reservedSeatId;
    data['reservationId'] = this.reservationId;
    data['direction'] = this.direction;
    data['seatPrice'] = this.seatPrice;
    data['seatIndex'] = this.seatIndex;
    //data['reservation'] = this.reservation;
    data['seatRow'] = this.seatRow;
    data['seatColumn'] = this.seatColumn;
    data['seatName'] = this.seatName;
    return data;
  }

  TransportReservedSeat.from(FlightSeat seat, int reservationId, FlightDirection flightDirection) {
    reservationId = reservationId;
    direction = flightDirection == FlightDirection.outbound ? '1' : '2';
    seatPrice = 5;
    seatIndex = seat.getSeatIndex();
    seatRow = seat.row;
    seatColumn = seatColumn;
    seatName = seat.getSeatString();
  }
}
