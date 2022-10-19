import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:intl/date_symbol_data_local.dart';

import 'components/fit_style_button.dart';

class ProfileView extends StatefulWidget {
  const ProfileView({Key? key}) : super(key: key);

  @override
  State<ProfileView> createState() => _ProfileViewState();
}

class _ProfileViewState extends State<ProfileView> {
  TextEditingController dateinput = TextEditingController();
  String genderSelectedValue = "M";
  List<DropdownMenuItem<String>> get dropdownItems {
    List<DropdownMenuItem<String>> menuItems = [
      DropdownMenuItem(child: Text("M"), value: "M"),
      DropdownMenuItem(child: Text("F"), value: "F"),
    ];
    return menuItems;
  }

  void handleChangePasswordButtonPressed() {
    print('handleChangePasswordButtonPressed');
    Navigator.of(context).pushNamed('/change_password');
  }

  void handleChangeMembershipTypeButtonPressed() {
    print('handleChangeMembershipTypeButtonPressed');
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('My Profile'),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.all(20.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Row(
                children: [
                  avatar(),
                  SizedBox(width: 20),
                  credit(),
                ],
              ),
              personalInfo(),
            ],
          ),
        ),
      ),
    );
  }

  Widget avatar() {
    return Expanded(
      child: AspectRatio(
        aspectRatio: 1,
        child: Material(
          borderRadius: BorderRadius.circular(200),
          clipBehavior: Clip.antiAliasWithSaveLayer,
          elevation: 8,
          child: InkWell(
            onTap: () {},
            child: Ink.image(
                image: AssetImage(
                  'assets/images/profile-photo-placeholder.png',
                ),
                height: 100,
                width: 100,
                fit: BoxFit.cover),
          ),
        ),
      ),
    );
  }

  Widget credit() {
    return Expanded(
      child: AspectRatio(
        aspectRatio: 1,
        child: Container(
          decoration: BoxDecoration(
            border: Border.all(color: Colors.black54, width: 3.0),
          ),
          //color: Colors.blue,
          //height: 100,
          //width: 100,
          child: Column(
            children: [
              Spacer(),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Icon(Icons.monetization_on_outlined),
                  Text(
                    'Credit:',
                    style: TextStyle(
                      fontSize: 20,
                      color: Colors.black,
                    ),
                  ),
                ],
              ),
              SizedBox(height: 20),
              Text(
                '1234,56 KM',
                style: TextStyle(
                  fontSize: 20,
                  color: Colors.black,
                ),
              ),
              Spacer(),
            ],
          ),
        ),
      ),
    );
  }

  Widget personalInfo() {
    return Column(
      children: [
        SizedBox(height: 20),
        Text(
          'Personal info:',
          style: TextStyle(
            fontSize: 20,
            color: Colors.black,
          ),
        ),
        SizedBox(height: 20),
        TextField(
          decoration: InputDecoration(
            hintText: 'First name',
            enabledBorder: OutlineInputBorder(
                borderSide: BorderSide(width: 3, color: Colors.grey)),
            focusedBorder: OutlineInputBorder(
                borderSide: BorderSide(width: 3, color: Colors.blue)),
            errorBorder: OutlineInputBorder(
                borderSide: BorderSide(width: 3, color: Colors.red)),
          ),
        ),
        SizedBox(height: 20),
        TextField(
          decoration: InputDecoration(
            hintText: 'Last name',
            enabledBorder: OutlineInputBorder(
                borderSide: BorderSide(width: 3, color: Colors.grey)),
            focusedBorder: OutlineInputBorder(
                borderSide: BorderSide(width: 3, color: Colors.blue)),
            errorBorder: OutlineInputBorder(
                borderSide: BorderSide(width: 3, color: Colors.red)),
          ),
        ),
        SizedBox(height: 20),

        TextField(
          controller: dateinput, //editing controller of this TextField
          decoration: InputDecoration(
              enabledBorder: OutlineInputBorder(
                  borderSide: BorderSide(width: 3, color: Colors.grey)),
              focusedBorder: OutlineInputBorder(
                  borderSide: BorderSide(width: 3, color: Colors.blue)),
              errorBorder: OutlineInputBorder(
                  borderSide: BorderSide(width: 3, color: Colors.red)),
              suffixIcon: Icon(Icons.calendar_today),
              labelText: "Enter Date" //label text of field
              ),
          readOnly: true, //set it true, so that user will not able to edit text
          onTap: () async {
            DateTime? pickedDate = await showDatePicker(
                context: context,
                initialDate: DateTime.now(),
                firstDate: DateTime(2000),
                lastDate: DateTime(2101));

            if (pickedDate != null) {
              print(pickedDate);
              String formattedDate =
                  DateFormat('dd/MM/yyyy').format(pickedDate);
              print(formattedDate);

              setState(() {
                dateinput.text = formattedDate;
              });
            } else {
              print("Date is not selected");
            }
          },
        ),
        // ),
        SizedBox(height: 20),
        Container(
          decoration: BoxDecoration(
            border: Border.all(color: Colors.black54, width: 3.0),
          ),
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 8.0),
            child: DropdownButton(
              isExpanded: true,
              value: genderSelectedValue,
              items: dropdownItems,
              onChanged: (String? value) {
                if (value == null) {
                  return;
                }
                this.setState(() {
                  genderSelectedValue = value;
                });
              },
            ),
          ),
        ),

        SizedBox(height: 10),

        FitStyleButton(
          'Change password',
          handleChangePasswordButtonPressed,
          padding: 0,
        ),
        FitStyleButton(
          'Change membership type',
          handleChangeMembershipTypeButtonPressed,
          padding: 0,
        ),

        ElevatedButton(
          onPressed: () {},
          child: Icon(
            Icons.done,
            color: Colors.black,
            size: 40,
          ),
          style: ElevatedButton.styleFrom(
            shape: CircleBorder(),

            padding: EdgeInsets.all(20),
            backgroundColor: Colors.green, // <-- Button color
            foregroundColor: Colors.red, // <-- Splash color
          ),
        )
      ],
    );
  }
}
