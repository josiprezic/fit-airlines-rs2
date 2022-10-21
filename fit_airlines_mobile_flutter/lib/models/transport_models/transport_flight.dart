class TransportFlight {
  int? flightId;
  int? cityId;
  int? destinationAirportId;
  int? offerId;
  int? planeId;
  int? addedByUserId;
  String? addedDate;
  String? voucherCode;
  int? voucherDiscountPercentage;
  String? startDate;
  String? startDateArrival;
  String? endDate;
  String? endDateArrival;
  String? pilotFullName;
  String? flightDuration;
  int? price;
  String? shortInfo;
  String? picture;
  String? notes;
  int? availableToMemberTypeId;
  bool? isActive;
  Null? addedByUser;
  int? capacity;
  int? availableSeats;
  int? averageRating;
  String? countryName;

  TransportFlight(
      {this.flightId,
      this.cityId,
      this.destinationAirportId,
      this.offerId,
      this.planeId,
      this.addedByUserId,
      this.addedDate,
      this.voucherCode,
      this.voucherDiscountPercentage,
      this.startDate,
      this.startDateArrival,
      this.endDate,
      this.endDateArrival,
      this.pilotFullName,
      this.flightDuration,
      this.price,
      this.shortInfo,
      this.picture,
      this.notes,
      this.availableToMemberTypeId,
      this.isActive,
      this.addedByUser,
      this.capacity,
      this.availableSeats,
      this.averageRating,
      this.countryName});

  TransportFlight.fromJson(Map<String, dynamic> json) {
    flightId = json['flightId'];
    cityId = json['cityId'];
    destinationAirportId = json['destinationAirportId'];
    offerId = json['offerId'];
    planeId = json['planeId'];
    addedByUserId = json['addedByUserId'];
    addedDate = json['addedDate'];
    voucherCode = json['voucherCode'];
    voucherDiscountPercentage = json['voucherDiscountPercentage'];
    startDate = json['startDate'];
    startDateArrival = json['startDateArrival'];
    endDate = json['endDate'];
    endDateArrival = json['endDateArrival'];
    pilotFullName = json['pilotFullName'];
    flightDuration = json['flightDuration'];
    price = json['price'];
    shortInfo = json['shortInfo'];
    picture = json['picture'];
    notes = json['notes'];
    availableToMemberTypeId = json['availableToMemberTypeId'];
    isActive = json['isActive'];
    addedByUser = json['addedByUser'];
    capacity = json['capacity'];
    availableSeats = json['availableSeats'];
    averageRating = json['averageRating'];
    countryName = json['countryName'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['flightId'] = this.flightId;
    data['cityId'] = this.cityId;
    data['destinationAirportId'] = this.destinationAirportId;
    data['offerId'] = this.offerId;
    data['planeId'] = this.planeId;
    data['addedByUserId'] = this.addedByUserId;
    data['addedDate'] = this.addedDate;
    data['voucherCode'] = this.voucherCode;
    data['voucherDiscountPercentage'] = this.voucherDiscountPercentage;
    data['startDate'] = this.startDate;
    data['startDateArrival'] = this.startDateArrival;
    data['endDate'] = this.endDate;
    data['endDateArrival'] = this.endDateArrival;
    data['pilotFullName'] = this.pilotFullName;
    data['flightDuration'] = this.flightDuration;
    data['price'] = this.price;
    data['shortInfo'] = this.shortInfo;
    data['picture'] = this.picture;
    data['notes'] = this.notes;
    data['availableToMemberTypeId'] = this.availableToMemberTypeId;
    data['isActive'] = this.isActive;
    data['addedByUser'] = this.addedByUser;
    data['capacity'] = this.capacity;
    data['availableSeats'] = this.availableSeats;
    data['averageRating'] = this.averageRating;
    data['countryName'] = this.countryName;
    return data;
  }
}
