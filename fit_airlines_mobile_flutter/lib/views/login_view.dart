import 'dart:convert';

import 'package:fit_airlines_mobile_flutter/services/api/airport_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/city_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/country_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/flight_service.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:flutter/material.dart';
import 'dart:developer';

class LoginView extends StatefulWidget {
  const LoginView({Key? key}) : super(key: key);

  @override
  State<LoginView> createState() => _LoginViewState();
}

class _LoginViewState extends State<LoginView> {
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Padding(
          padding: const EdgeInsets.all(30.0),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Image(
                image: AssetImage('assets/images/logo.png'),
                height: 100,
                width: 100,
              ),
              SizedBox(height: 20),
              TextField(
                controller: usernameController,
                decoration: InputDecoration(
                  hintText: 'Username',
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(10),
                  ),
                ),
              ),
              SizedBox(height: 20),
              TextField(
                controller: passwordController,
                decoration: InputDecoration(
                  hintText: 'Password',
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(10),
                  ),
                ),
              ),
              SizedBox(height: 20),
              FitStyleButton('Login', () async {
                print(usernameController.text + ' ' + passwordController.text);

                APIService.username =
                    'member@fit.ba'; //usernameController.text;
                APIService.password = 'password'; //passwordController.text;va
                var service = FlightService();

                var objects = await service.getAllObjects();
                print(objects.first.toString());
                var jsonn = json.encode(objects.first);

                var spaces = ' ' * 4;
                var encoder = JsonEncoder.withIndent(spaces);
                print(encoder.convert(jsonn));
                //print(objects.first.picture);

                // var cos = await api.getObjectList();
                // print(cos.first);

                //await APIService.get('/airports');
              }),
            ],
          ),
        ),
      ),
    );
  }
}
