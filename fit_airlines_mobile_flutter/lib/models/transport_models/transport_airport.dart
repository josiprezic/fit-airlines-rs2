class TransportAirport {
  int? airportId;
  String? airportName;
  bool? isAvailable;
  int? cityId;
  Null? city;

  TransportAirport(
      {this.airportId,
      this.airportName,
      this.isAvailable,
      this.cityId,
      this.city});

  TransportAirport.fromJson(Map<String, dynamic> json) {
    airportId = json['airportId'];
    airportName = json['airportName'];
    isAvailable = json['isAvailable'];
    cityId = json['cityId'];
    city = json['city'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['airportId'] = this.airportId;
    data['airportName'] = this.airportName;
    data['isAvailable'] = this.isAvailable;
    data['cityId'] = this.cityId;
    data['city'] = this.city;
    return data;
  }
}
