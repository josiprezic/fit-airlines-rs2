import 'package:fit_airlines_mobile_flutter/models/transport_models/transport_membership_type.dart';
import 'package:fit_airlines_mobile_flutter/services/api/membership_type_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:fit_airlines_mobile_flutter/views/components/loading_view.dart';
import 'package:flutter/material.dart';

class ChangeMembershipTypeView extends StatefulWidget {
  const ChangeMembershipTypeView({Key? key}) : super(key: key);

  @override
  State<ChangeMembershipTypeView> createState() => _ChangeMembershipTypeViewState();
}

class _ChangeMembershipTypeViewState extends State<ChangeMembershipTypeView> {
  int membershipSelectedValue = 1;
  List<DropdownMenuItem<int>> dropdownItems = [];

  void handleUpdateButtonPressed() {
    print('handleUpdateButtonPressed');
  }

  var membershipTypeService = MembershipTypeService();
  List<TransportMembershipType> membershipTypes = [];
  var isLoading = false;

  Future<List<TransportMembershipType>> getData() async {
    isLoading = true;
    var result = await membershipTypeService.getAllObjects();
    membershipTypes = result;
    dropdownItems = membershipTypes.map((e) {
      return DropdownMenuItem(child: Text(e.title ?? 'No title'), value: e.membershipTypeId);
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
                  'Update',
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
}
