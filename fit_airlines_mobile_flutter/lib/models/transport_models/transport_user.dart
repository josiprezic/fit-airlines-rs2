import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_membership_type.dart';
import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_user_role.dart';

class TransportUser {
  int? userId;
  String? firstName;
  String? lastName;
  String? birthDate;
  String? gender;
  String? email;
  String? contactNumber;
  String? picture;
  int? credit;
  String? startDate;
  bool? isActive;
  int? userRoleId;
  int? membershipTypeId;
  TransportMembershipType? membershipType;
  TransportUserRole? userRole;

  TransportUser(
      {this.userId,
      this.firstName,
      this.lastName,
      this.birthDate,
      this.gender,
      this.email,
      this.contactNumber,
      this.picture,
      this.credit,
      this.startDate,
      this.isActive,
      this.userRoleId,
      this.membershipTypeId,
      this.membershipType,
      this.userRole});

  TransportUser.fromJson(Map<String, dynamic> json) {
    userId = json['userId'];
    firstName = json['firstName'];
    lastName = json['lastName'];
    birthDate = json['birthDate'];
    gender = json['gender'];
    email = json['email'];
    contactNumber = json['contactNumber'];
    picture = json['picture'];
    credit = json['credit'];
    startDate = json['startDate'];
    isActive = json['isActive'];
    userRoleId = json['userRoleId'];
    membershipTypeId = json['membershipTypeId'];
    membershipType = json['membershipType'] != null ? new TransportMembershipType.fromJson(json['membershipType']) : null;
    userRole = json['userRole'] != null ? TransportUserRole.fromJson(json['userRole']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['userId'] = this.userId;
    data['firstName'] = this.firstName;
    data['lastName'] = this.lastName;
    data['birthDate'] = this.birthDate;
    data['gender'] = this.gender;
    data['email'] = this.email;
    data['contactNumber'] = this.contactNumber;
    data['picture'] = this.picture;
    data['credit'] = this.credit;
    data['startDate'] = this.startDate;
    data['isActive'] = this.isActive;
    data['userRoleId'] = this.userRoleId;
    data['membershipTypeId'] = this.membershipTypeId;
    if (this.membershipType != null) {
      data['membershipType'] = this.membershipType!.toJson();
    }
    if (this.userRole != null) {
      data['userRole'] = this.userRole!.toJson();
    }
    return data;
  }
}
