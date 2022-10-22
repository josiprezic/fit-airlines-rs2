import 'dart:convert';

import 'package:fit_airlines_mobile_flutter/services/api/airport_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/api_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/city_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/country_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/flight_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/offer_service.dart';
import 'package:fit_airlines_mobile_flutter/services/api/user_service.dart';
import 'package:fit_airlines_mobile_flutter/services/app_user_service.dart';
import 'package:fit_airlines_mobile_flutter/services/snackbar_manager.dart';
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
                obscureText: true,
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

                try {
                  var isSuccessfulLogin = await AppUserService.login(usernameController.text, passwordController.text);
                  if (isSuccessfulLogin) {
                    Navigator.of(context).pushNamed('/home');
                  } else {
                    SnackbarManager.showSnackbar('Ups! Wrong credentials.', context);
                    passwordController.text = '';
                  }
                } on Exception {
                  SnackbarManager.showSnackbar('Ups! Wrong credentials.', context);
                }
              }),
            ],
          ),
        ),
      ),
    );
  }
}
