import 'dart:ffi';

import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_membership_type.dart';
import 'package:fit_airlines_mobile_flutter/services/api/membership_type_service.dart';
import 'package:fit_airlines_mobile_flutter/services/app_user_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_horizontal_divider.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:fit_airlines_mobile_flutter/views/components/loading_view.dart';
import 'package:flutter/material.dart';

class ChangeMembershipTypeView extends StatefulWidget {
  const ChangeMembershipTypeView({Key? key}) : super(key: key);

  @override
  State<ChangeMembershipTypeView> createState() => _ChangeMembershipTypeViewState();
}

class _ChangeMembershipTypeViewState extends State<ChangeMembershipTypeView> {
  int? membershipSelectedValue;
  List<DropdownMenuItem<int>> dropdownItems = [];

  String buttonTitleExtension = '';

  void handleUpdateButtonPressed() {
    print('handleUpdateButtonPressed');
  }

  var membershipTypeService = MembershipTypeService();
  List<TransportMembershipType> membershipTypes = [];
  TransportMembershipType? currentMembershipType;
  var isLoading = false;

  var executed = false;
  Future<List<TransportMembershipType>> getData() async {
    if (executed) {
      return [];
    } else {
      executed = true;
    }

    isLoading = true;
    var result = await membershipTypeService.getAllObjects();
    var currentMemTypeId = await AppUserService.membershipTypeId;
    this.currentMembershipType = result.firstWhere((element) => element.membershipTypeId == currentMemTypeId);

    result.removeWhere((element) => (element?.membershipTypeId ?? 100) <= currentMemTypeId);

    membershipTypes = result;
    membershipSelectedValue = membershipTypes.first?.membershipTypeId;

    dropdownItems = membershipTypes.map((e) {
      return DropdownMenuItem(child: Text(e.title ?? 'No title' + ' (' + (e.membershipPrice ?? 0).toString() + ' KM)'), value: e.membershipTypeId);
    }).toList();

    isLoading = false;
    return result;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Membership Type'),
      ),
      body: FutureBuilder<List<TransportMembershipType>>(
        future: getData(),
        initialData: null,
        builder: (context, snapshot) {
          if (isLoading) {
            return LoadingView();
          }

          return Padding(
            padding: const EdgeInsets.all(20.0),
            child: Column(
              children: [
                Text(
                  'Current membership type:',
                  style: TextStyle(
                    fontSize: 20,
                    color: Colors.black,
                  ),
                ),
                SizedBox(height: 20),
                Text(
                  currentMembershipType?.title ?? '-',
                  style: TextStyle(
                    fontSize: 30,
                    color: Colors.green,
                    fontWeight: FontWeight.w900,
                  ),
                ),
                SizedBox(height: 20),
                Divider(
                  indent: 0,
                  endIndent: 0,
                  color: Colors.black45,
                  thickness: 1,
                ),
                getDescriptionRow('Bonus drink', (currentMembershipType?.isBonusDrinkAvailable ?? false) ? '✔️Available' : '❌ Not available '),
                getDescriptionRow('Bonus meal', (currentMembershipType?.isBonusMealAvailable ?? false) ? '✔️Available' : '❌ Not available'),
                getDescriptionRow('Free extra baggage', (currentMembershipType?.isExtraBaggageAvailable ?? false) ? '✔️Available' : '❌ Not available'),
                getDescriptionRow('FIT Sanwitch gift', (currentMembershipType?.isFitsandwichAvailable ?? false) ? '✔️Available' : '❌ Not available'),
                getDescriptionRow('Priority', (currentMembershipType?.isPriorityAvailable ?? false) ? '✔️Available' : '❌ Not available'),
                getDescriptionRow('Free seat change', (currentMembershipType?.isSeatChangeAvailable ?? false) ? '✔️Available' : '❌ Not available'),
                SizedBox(
                  height: 20,
                ),
                FitHorizontalDivider(),
                SizedBox(
                  height: 20,
                ),
                Text(
                  'Upgrade your membership:',
                  style: TextStyle(
                    fontSize: 20,
                    color: Colors.black,
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                Container(
                  decoration: BoxDecoration(
                    border: Border.all(color: Colors.black54, width: 3.0),
                  ),
                  child: Padding(
                    padding: const EdgeInsets.symmetric(horizontal: 8.0),
                    child: DropdownButton(
                      isExpanded: true,
                      value: membershipSelectedValue,
                      items: dropdownItems,
                      onChanged: (int? value) {
                        if (value == null) {
                          return;
                        }
                        buttonTitleExtension = membershipTypes.firstWhere((element) => element.membershipTypeId == value).membershipPrice.toString();
                        this.setState(() {
                          membershipSelectedValue = value;
                        });
                      },
                    ),
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                FitStyleButton(
                  'Update' + buttonTitleExtension,
                  handleUpdateButtonPressed,
                  padding: 0,
                )
              ],
            ),
          );
        },
      ),
    );
  }

  Widget getDescriptionRow(String title, String descrption) {
    return Column(
      children: [
        Row(
          children: [
            SizedBox(
              width: 150,
              child: Text(
                title + ': ',
                style: TextStyle(
                  fontSize: 16,
                  color: Colors.black,
                ),
              ),
            ),
            SizedBox(width: 10),
            Flexible(
              child: Text(
                descrption,
                style: TextStyle(
                  fontSize: 16,
                  color: Colors.black,
                ),
              ),
            ),
          ],
        ),
        Divider(
          indent: 0,
          endIndent: 0,
          color: Colors.black45,
          thickness: 1,
        ),
      ],
    );
  }
}
