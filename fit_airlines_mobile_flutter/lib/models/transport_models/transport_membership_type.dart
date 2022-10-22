class TransportMembershipType {
  int? membershipTypeId;
  String? title;
  String? shortInfo;
  int? membershipPrice;
  bool? isPriorityAvailable;
  bool? isExtraBaggageAvailable;
  bool? isFitsandwichAvailable;
  bool? isSeatChangeAvailable;
  bool? isBonusDrinkAvailable;
  bool? isBonusMealAvailable;
  int? basicTicketDiscount;
  int? basicFoodDrinkDiscount;

  TransportMembershipType(
      {this.membershipTypeId,
      this.title,
      this.shortInfo,
      this.membershipPrice,
      this.isPriorityAvailable,
      this.isExtraBaggageAvailable,
      this.isFitsandwichAvailable,
      this.isSeatChangeAvailable,
      this.isBonusDrinkAvailable,
      this.isBonusMealAvailable,
      this.basicTicketDiscount,
      this.basicFoodDrinkDiscount});

  TransportMembershipType.fromJson(Map<String, dynamic> json) {
    membershipTypeId = json['membershipTypeId'];
    title = json['title'];
    shortInfo = json['shortInfo'];
    membershipPrice = json['membershipPrice'];
    isPriorityAvailable = json['isPriorityAvailable'];
    isExtraBaggageAvailable = json['isExtraBaggageAvailable'];
    isFitsandwichAvailable = json['isFitsandwichAvailable'];
    isSeatChangeAvailable = json['isSeatChangeAvailable'];
    isBonusDrinkAvailable = json['isBonusDrinkAvailable'];
    isBonusMealAvailable = json['isBonusMealAvailable'];
    basicTicketDiscount = json['basicTicketDiscount'];
    basicFoodDrinkDiscount = json['basicFoodDrinkDiscount'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['membershipTypeId'] = this.membershipTypeId;
    data['title'] = this.title;
    data['shortInfo'] = this.shortInfo;
    data['membershipPrice'] = this.membershipPrice;
    data['isPriorityAvailable'] = this.isPriorityAvailable;
    data['isExtraBaggageAvailable'] = this.isExtraBaggageAvailable;
    data['isFitsandwichAvailable'] = this.isFitsandwichAvailable;
    data['isSeatChangeAvailable'] = this.isSeatChangeAvailable;
    data['isBonusDrinkAvailable'] = this.isBonusDrinkAvailable;
    data['isBonusMealAvailable'] = this.isBonusMealAvailable;
    data['basicTicketDiscount'] = this.basicTicketDiscount;
    data['basicFoodDrinkDiscount'] = this.basicFoodDrinkDiscount;
    return data;
  }
}
