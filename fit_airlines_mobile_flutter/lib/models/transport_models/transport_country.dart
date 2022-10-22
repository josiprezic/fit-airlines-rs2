class TransportCountry {
  int? countryId;
  String? countryName;
  String? shortInfo;
  String? picture;

  TransportCountry(
      {this.countryId, this.countryName, this.shortInfo, this.picture});

  TransportCountry.fromJson(Map<String, dynamic> json) {
    countryId = json['countryId'];
    countryName = json['countryName'];
    shortInfo = json['shortInfo'];
    picture = json['picture'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['countryId'] = this.countryId;
    data['countryName'] = this.countryName;
    data['shortInfo'] = this.shortInfo;
    data['picture'] = this.picture;
    return data;
  }
}
