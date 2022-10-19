import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:flutter/material.dart';

class ChangeMembershipTypeView extends StatefulWidget {
  const ChangeMembershipTypeView({Key? key}) : super(key: key);

  @override
  State<ChangeMembershipTypeView> createState() =>
      _ChangeMembershipTypeViewState();
}

class _ChangeMembershipTypeViewState extends State<ChangeMembershipTypeView> {
  String membershipSelectedValue = "1";
  List<DropdownMenuItem<String>> get dropdownItems {
    List<DropdownMenuItem<String>> menuItems = [
      DropdownMenuItem(child: Text("MemType 1"), value: "1"),
      DropdownMenuItem(child: Text("MemType 2"), value: "2"),
      DropdownMenuItem(child: Text("MemType 3"), value: "3"),
      DropdownMenuItem(child: Text("MemType 4"), value: "4"),
    ];
    return menuItems;
  }

  void handleUpdateButtonPressed() {
    print('handleUpdateButtonPressed');
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Membership'),
      ),
      body: Padding(
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
                  onChanged: (String? value) {
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
      ),
    );
  }
}
