import 'dart:typed_data';

class TransportOffer {
  int? offerId;
  String? offerName;
  String? shortInfo;
  String? picture;
  String? startDate;
  String? endDate;
  bool? isActive;
  String? dateAdded;
  int? offerTypeId;
  int? numberOfDestinations;
  int? viewportWidth;
  int? viewportWidthLabel;

  TransportOffer(
      {this.offerId,
      this.offerName,
      this.shortInfo,
      this.picture,
      this.startDate,
      this.endDate,
      this.isActive,
      this.dateAdded,
      this.offerTypeId,
      this.numberOfDestinations,
      this.viewportWidth,
      this.viewportWidthLabel});

  TransportOffer.fromJson(Map<String, dynamic> json) {
    offerId = json['offerId'];
    offerName = json['offerName'];
    shortInfo = json['shortInfo'];
    picture = json['picture'];
    startDate = json['startDate'];
    endDate = json['endDate'];
    isActive = json['isActive'];
    dateAdded = json['dateAdded'];
    offerTypeId = json['offerTypeId'];
    numberOfDestinations = json['numberOfDestinations'];
    viewportWidth = json['viewportWidth'];
    viewportWidthLabel = json['viewportWidthLabel'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['offerId'] = this.offerId;
    data['offerName'] = this.offerName;
    data['shortInfo'] = this.shortInfo;
    data['picture'] = this.picture;
    data['startDate'] = this.startDate;
    data['endDate'] = this.endDate;
    data['isActive'] = this.isActive;
    data['dateAdded'] = this.dateAdded;
    data['offerTypeId'] = this.offerTypeId;
    data['numberOfDestinations'] = this.numberOfDestinations;
    data['viewportWidth'] = this.viewportWidth;
    data['viewportWidthLabel'] = this.viewportWidthLabel;
    return data;
  }

  bool get isInFuture {
    return startDate?.asDateTime().isAfter(DateTime.now()) ?? false;
  }
}

extension on String {
  DateTime asDateTime() {
    return DateTime.parse(this);
  }
}
