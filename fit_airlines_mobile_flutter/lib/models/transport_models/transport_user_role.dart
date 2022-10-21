class TransportUserRole {
  int? userRoleId;
  String? title;
  bool? isAbleToAddNewUsers;
  bool? isAbleToAddNewOffers;
  bool? isAbleToAddNewFlights;
  bool? isAbleToAddNewPlanes;
  bool? isAbleToAddUserCredits;
  bool? isAbleToAddNewReservations;
  bool? isAbleToAddNewPlaces;
  bool? isSuperUser;

  TransportUserRole({
    this.userRoleId,
    this.title,
    this.isAbleToAddNewUsers,
    this.isAbleToAddNewOffers,
    this.isAbleToAddNewFlights,
    this.isAbleToAddNewPlanes,
    this.isAbleToAddUserCredits,
    this.isAbleToAddNewReservations,
    this.isAbleToAddNewPlaces,
    this.isSuperUser,
  });

  TransportUserRole.fromJson(Map<String, dynamic> json) {
    userRoleId = json['userRoleId'];
    title = json['title'];
    isAbleToAddNewUsers = json['isAbleToAddNewUsers'];
    isAbleToAddNewOffers = json['isAbleToAddNewOffers'];
    isAbleToAddNewFlights = json['isAbleToAddNewFlights'];
    isAbleToAddNewPlanes = json['isAbleToAddNewPlanes'];
    isAbleToAddUserCredits = json['isAbleToAddUserCredits'];
    isAbleToAddNewReservations = json['isAbleToAddNewReservations'];
    isAbleToAddNewPlaces = json['isAbleToAddNewPlaces'];
    isSuperUser = json['isSuperUser'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['userRoleId'] = this.userRoleId;
    data['title'] = this.title;
    data['isAbleToAddNewUsers'] = this.isAbleToAddNewUsers;
    data['isAbleToAddNewOffers'] = this.isAbleToAddNewOffers;
    data['isAbleToAddNewFlights'] = this.isAbleToAddNewFlights;
    data['isAbleToAddNewPlanes'] = this.isAbleToAddNewPlanes;
    data['isAbleToAddUserCredits'] = this.isAbleToAddUserCredits;
    data['isAbleToAddNewReservations'] = this.isAbleToAddNewReservations;
    data['isAbleToAddNewPlaces'] = this.isAbleToAddNewPlaces;
    data['isSuperUser'] = this.isSuperUser;
    return data;
  }
}
