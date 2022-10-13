import 'dart:convert';
import 'dart:io';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class APIService {
  static String username = '';
  static String password = '';
  String route;

  APIService({required this.route});

  void setParameter(String username, String password) {
    APIService.username = username;
    APIService.password = password;
  }

  static Future<String> get(String route) async {
    String baseUrl =
        'http://10.0.2.2:2137/api/airports'; // + route; // TODO: Szef base url
    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.get(
      Uri.parse(baseUrl),
      //headers: {HttpHeaders.authorizationHeader: basicAuth}
    );

    if (response.statusCode == 200) {
      print('WOOOHOOOO');
      return JsonDecoder().convert(response.body);
    } else {
      print('DUPA DUPA');
      print(response.statusCode);
      print(response.body);
      return ''; // TODO: JR
    }
  }
}