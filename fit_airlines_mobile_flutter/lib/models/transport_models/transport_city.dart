class TransportCity {
  int? cityId;
  String? cityName;
  String? shortInfo;
  String? picture;
  int? countryId;

  TransportCity(
      {this.cityId,
      this.cityName,
      this.shortInfo,
      this.picture,
      this.countryId});

  TransportCity.fromJson(Map<String, dynamic> json) {
    cityId = json['cityId'];
    cityName = json['cityName'];
    shortInfo = json['shortInfo'];
    picture = json['picture'];
    countryId = json['countryId'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['cityId'] = this.cityId;
    data['cityName'] = this.cityName;
    data['shortInfo'] = this.shortInfo;
    data['picture'] = this.picture;
    data['countryId'] = this.countryId;
    return data;
  }
}
